using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_Client
{

    public partial class Chat_Client : MaterialForm
    {
        string filename;
        int index;
    
        public Chat_Client(string s)
        {
            InitializeComponent();

            //Thầy hay hỏi vê cái này!! không có dòng này là bị lỗi nhe
            CheckForIllegalCrossThreadCalls = false;

            //Cài đặt theme giao diện người dùng: materialFrom
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            //Hiển thị tên người dùng trên form
            textBoxName.Text = s;

            //Thiết lập kết nối
            KetNoi();

            this.groupBox1.Visible = false;

        }

        //Thêm data nhận được vào khung chat
        delegate void UpdateTextMessenger(WebBrowser web, string value);
        void UpdateTextData(WebBrowser web, string value)
        {
            if (web.Document != null)
            {
                HtmlElement element = web.Document.CreateElement("p");
                element.InnerText = value;
                web.Document.Body.AppendChild(element);
            }
            else
                web.DocumentText = value;
        }

        //Khởi tạo giao thức TCP/IP, thiết lập Socket
        IPEndPoint Ip;
        Socket client;
        void KetNoi()
        {

            Ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(Ip);
                toolStripStatusLabel1.Text = "Connected to Server (IP: " + Ip.Address.ToString() + " Port: " + Ip.Port.ToString() + ")";
                client.Send(PhanManh(textBoxName.Text + "    is connected@@ "));

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Không thể kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Sau khi kết nối -> Luôn lắng nghe
            Thread listen = new Thread(NhanData);
            listen.IsBackground = true;
            listen.Start();

        }
        void NgatKetNoi()
        {
            if (client.Connected)
                client.Send(PhanManh(textBoxName.Text + "   is disconnected$$ "));
            Application.Exit();



        }
        void GuiData()
        {
            if (client.Connected)
            {
                if (textBoxMessage.Text != string.Empty)
                {
                    client.Send(PhanManh(textBoxName.Text + ": " + textBoxMessage.Text));
                }
            }
            else
            {
                MessageBox.Show("Chưa kết nối server!");
                return;
            }
        }
        void NhanData()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)GomManh(data);

                    toolStripStatusLabel1.Text = "Text received form " + message;

                    if (message.Contains("&&"))
                    {
                        checkedListBox1.Items.Add((message.Substring(0, 5)));
                        toolStripStatusLabel1.Text = "Số client đang kết nối: " + checkedListBox1.Items.Count;                       
                    }
                    if (message.Contains("$$"))
                    {
                        
                        foreach (string name in checkedListBox1.Items)
                            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                            {
                                if (message.Substring(0, 5).CompareTo(name) == 0)
                                {
                                    checkedListBox1.Items.RemoveAt(i);
                                }
                            }
                        toolStripStatusLabel1.Text = "Số client đang kết nối: " + checkedListBox1.Items.Count;
                    }
                    //  Thêm tin nhắn vào khung chat
                    UpdateTextMessenger text = UpdateTextData;
                    if (webBrowser1.InvokeRequired)
                        Invoke(text, webBrowser1, message);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ngắt kết nối!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NgatKetNoi();
            }
        }
        //Serialize and Deserialize
        byte[] PhanManh(object data)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, data);

            return stream.ToArray();
        }
        object GomManh(byte[] data)
        {
            MemoryStream steam = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(steam);
        }

        //=======================================================================Control Events

        private void textBoxMessage_Enter(object sender, EventArgs e)
        {
            textBoxMessage.Text = "";
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {

            GuiData();

            toolStripStatusLabel2.Text = "Sent Data: " + textBoxMessage.Text;

            //Thêm data vào khung chat sau khi gửi đi

            if (webBrowser1.Document != null)
            {
                HtmlElement element = webBrowser1.Document.CreateElement("p");
                element.InnerText = textBoxName.Text + ": " + textBoxMessage.Text;
                webBrowser1.Document.Body.AppendChild(element);
            }
            else
                webBrowser1.DocumentText = textBoxName.Text + ": " + textBoxMessage.Text;


            //Xóa chữ trong textbox tin nhắn sau khi gửi đi
            textBoxMessage.Text = "";
        }
        private void Chat_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            NgatKetNoi();
        }

        private void buttonImg_Click(object sender, EventArgs e)
        {
            if (openFileDialogImg.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialogImg.FileName;
                index = openFileDialogImg.FilterIndex;
                toolStripStatusLabel1.Text = "Img path: " + openFileDialogImg.FileName;

                //Thêm hình vào khung chat sau khi chọn hình
                if (webBrowser1.Document != null)
                {
                    HtmlElement element = webBrowser1.Document.CreateElement("p");
                    element.InnerText = string.Empty;
                    webBrowser1.Document.Body.AppendChild(element);

                    HtmlElement imgElement = webBrowser1.Document.CreateElement("img");
                    imgElement.SetAttribute("src", filename);
                    webBrowser1.Document.Body.AppendChild(imgElement);

                }
                else
                    webBrowser1.DocumentText = "<img src='" + filename + "'/>";
                filename = null;
                MessageBox.Show("Comming soon", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonfile_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel1.Text = "File path: " + openFileDialogFile.FileName;
                MessageBox.Show("Comming soon", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            //lấy danh sách client
            //Còn lỗi
            client.Send(PhanManh("get_client"));
        }
        private void Chat_Client_MouseEnter(object sender, EventArgs e)
        {
            this.checkedListBox1.Items.Clear();
            this.groupBox1.Visible = false;
            toolStripStatusLabel1.Text = "Welcome to BlaBlo ChatApp";
        }
    }
}
