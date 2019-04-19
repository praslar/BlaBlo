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

        }


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
            if(client.Connected)
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

            if (webBrowser1.Document != null)
            {
                HtmlElement element = webBrowser1.Document.CreateElement("p");
                element.InnerText = textBoxName.Text + ": " + textBoxMessage.Text;
                webBrowser1.Document.Body.AppendChild(element);
            }
            else
                webBrowser1.DocumentText = textBoxName.Text + ": " + textBoxMessage.Text;



            textBoxMessage.Text = "";
        }
        private void Chat_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            NgatKetNoi();
        }
    }
}
