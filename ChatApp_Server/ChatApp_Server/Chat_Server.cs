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
        Socket Server;
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
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)GomManh(data);
               
                    if (message.Contains("@@"))
                    {
                        clientcount = clients.Count;
                        checkedListBoxClientList.Items.Add(message.Substring(0, 5));
                        toolStripStatusLabel1.Text = "Số client đang kết nối: " + clientcount;
                        toolStripStatusLabel2.Text = "Client connected!";
                    }
                    if (message.Contains("$$"))
                    {
                        foreach (Socket item in clients)
                        {
                            if (item != null && item != client)
                                item.Send(PhanManh((string)GomManh(data)));
                        }
                        //AddMessage(message);
                        UpdateTextMessenger text1 = UpdateTextData;
                        if (webBrowser1.InvokeRequired)
                            Invoke(text1, webBrowser1, message);
                        string user = message.Substring(0,5);
                        foreach  (string name in checkedListBoxClientList.Items)
                        {
                            if (user.CompareTo(name) == 0)
                            {
                                checkedListBoxClientList.Items.Remove(name);
                            }
                        }   
                        
                    }
                    foreach (Socket item in clients)
                    {
                        if (item != null && item != client)
                            item.Send(PhanManh((string)GomManh(data)));
                    }
                    // AddMessage(message);
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
                element.InnerText =  "Server: " + textBoxMessage.Text;
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
    }
}
