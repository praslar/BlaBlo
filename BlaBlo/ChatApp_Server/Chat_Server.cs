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

namespace ChatApp_Server
{
    public partial class Chat_Server : MaterialForm
    {
        string filename;
        int index;

        
        public Chat_Server()
        {
            InitializeComponent();

            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            CheckForIllegalCrossThreadCalls = false;
            toolStripStatusLabel1.Text = "Setting up server...";
            KetNoi();
        }

        //Thêm data vào khung chat sau khi nhận đc
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

        //Thiết lập server, lập trình Socket
        IPEndPoint Ip;
        Socket Server;
        //Danh sách kết nối
        List<Socket> clients;
        int clientcount;
        //======================================================================================
        void KetNoi()
        {
            clients = new List<Socket>();

            //Kết nối hia máy khác nhau thì chỉnh IP với Port ở đây nhe
            Ip = new IPEndPoint(IPAddress.Any, 9999);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            Server.Bind(Ip);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Server.Listen(10);
                        Socket client = Server.Accept();

                        clients.Add(client);


                        Thread receive = new Thread(NhanData);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch (Exception)
                {
                    Ip = new IPEndPoint(IPAddress.Any, 8080);
                    Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });
            Listen.IsBackground = true;
            Listen.Start();
        }
        void NgatKetNoi()
        {
            Server.Close();
        }
        void GuiData(Socket client)
        {
            if (client != null && textBoxMessage.Text != string.Empty)
                client.Send(PhanManh("Server: " + textBoxMessage.Text));
        }
        void NhanData(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 9999];
                    client.Receive(data);
                    string message = (string)GomManh(data);
                    //Client yêu cầu lấy danh sách cách client đang online
                    if (message.Contains("get_client"))
                    {
                            foreach (object name in this.checkedListBoxClientList.Items)
                            {
                                foreach (Socket item in clients)
                                {
                                    if (item != null)
                                        item.Send(PhanManh(name + " is online&&"));
                                }

                            }                                         
                    }
                    //Client kết nối thành công
                    if (message.Contains("@@"))
                    {
                        clientcount = clients.Count;
                        checkedListBoxClientList.Items.Add(message.Substring(0, 5));
                        toolStripStatusLabel1.Text = "Số client đang kết nối: " + clientcount;
                        toolStripStatusLabel2.Text = "Client connected!";
                    }
                    //Client disconnect
                    if (message.Contains("$$"))
                    {
                        foreach (Socket item in clients)
                        {
                            if (item != null && item != client)
                                item.Send(PhanManh((string)GomManh(data)));
                        }                       
                        UpdateTextMessenger text1 = UpdateTextData;
                        if (webBrowser1.InvokeRequired)
                            Invoke(text1, webBrowser1, message);
                        string user = message.Substring(0, 5);
                        foreach (string name in checkedListBoxClientList.Items)
                        {
                            if (user.CompareTo(name) == 0)
                            {
                                checkedListBoxClientList.Items.Remove(name);
                            }
                        }

                    }

                    //Thêm data vào khung chát đồng thời gửi tin nhắn của client này đến tất cả các client khác trong server
                    foreach (Socket item in clients)
                    {
                        if (item != null && item != client)
                            item.Send(PhanManh((string)GomManh(data)));
                    }

                    UpdateTextMessenger text = UpdateTextData;
                    if (webBrowser1.InvokeRequired)
                        Invoke(text, webBrowser1, message);

                }
            }
            catch (Exception)
            {
                clients.Remove(client);
                toolStripStatusLabel1.Text = "Số client đang kết nối: " + checkedListBoxClientList.Items.Count;
                toolStripStatusLabel2.Text = "Client disconnected!";
                client.Close();
            }
        }
        //Phân mảnh và gom mảnh data để gửi và nhận thông tin
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



        //===================================

        private void buttonSend_Click(object sender, EventArgs e)
        {

            foreach (Socket client in clients)
            {
                GuiData(client);
            }
            if (webBrowser1.Document != null)
            {
                HtmlElement element = webBrowser1.Document.CreateElement("p");
                element.InnerText = "Server: " + textBoxMessage.Text;
                webBrowser1.Document.Body.AppendChild(element);
            }
            else
                webBrowser1.DocumentText = "Server: " + textBoxMessage.Text;
            textBoxMessage.Text = "";
        }
        private void Chat_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            NgatKetNoi();
        }
        private void textBoxMessage_Enter(object sender, EventArgs e)
        {
            textBoxMessage.Text = "";
        }
        private void buttonImg_Click(object sender, EventArgs e)
        {
            if (openFileDialogImg.ShowDialog() == DialogResult.OK)
            {
                //Thêm ảnh vào khung chat sau khi chọn ảnh
                filename = openFileDialogImg.FileName;
                index = openFileDialogImg.FilterIndex;
                toolStripStatusLabel1.Text = "Img path: " + openFileDialogImg.FileName;

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
        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel1.Text = "File path: " + openFileDialogFile.FileName;
                MessageBox.Show("Comming soon", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
