using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ChatApp_Client
{
    public partial class Login : MaterialForm
    {
        
        public Login()
        {
            InitializeComponent();
            //Dùng theme khác cho giao diện người dùng:  MaterialSkin
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
          
        }
        ConnectToSQL connectsql = new ConnectToSQL();

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = connectsql.GetData("select * from Accounts where username = '" + textBoxlogin.Text + "' and password = '" + textBoxpass.Text + "'");
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Chat_Client frm = new Chat_Client(textBoxlogin.Text);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên năng nhập hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
