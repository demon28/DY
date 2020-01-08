using DY注册机.XieYi.MashangModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DY注册机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            XieYi.MaShang maShang = new XieYi.MaShang();

            LoginModel login = new LoginModel();
            if (maShang.Login(this.tb_user.Text, this.tb_pwd.Text, ref login))
            {
                this.tb_token.Text = login.token;
            }

            SetTextBox(maShang.Msg, tb_loger);
        }


        public void SetTextBox(string text, TextBox textBox)
        {
            if (textBox.InvokeRequired)
            {
                Action<string, TextBox> action = new Action<string, TextBox>(SetTextBox);
                Invoke(action, new object[] { text });
            }
            else
            {
                textBox.Text += "\r\n";
                textBox.AppendText(text);
                //定位到最后一行
            }
        }
    }
}
