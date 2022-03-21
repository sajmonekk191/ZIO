using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using ZIO.containers;
using Newtonsoft.Json;
using System.Text;

namespace etcs
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CreateAccbtn_Click(object sender, EventArgs e)
        {
            if (CreateAccbtn.Text == "Create new Account")
            {
                Loginlbl.Text = "Register";
                CreateAccbtn.Text = "Login to Account";
                Connectbtn.Text = "Create Acc";
                checkBox1.Visible = false;
                label4.Visible = true;
                textBox3.Visible = true;
                Connectbtn.Location = new Point(184, 256);
                CreateAccbtn.Location = new Point(163, 285);
            }
            else
            {
                Loginlbl.Text = "Login";
                CreateAccbtn.Text = "Create new Account";
                Connectbtn.Text = "Connect";
                checkBox1.Visible = true;
                label4.Visible = false;
                textBox3.Visible = false;
                Connectbtn.Location = new Point(184, 223);
                CreateAccbtn.Location = new Point(163, 252);
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && Connectbtn.Text == "Connect")
            {
                if (textBox1.Text == hodnoty.Username && textBox2.Text == hodnoty.Password)
                {
                    errorlabel.Visible = true;
                    errorlabel.ForeColor = Color.LimeGreen;
                    errorlabel.Text = "Logged in successfully !";
                    hodnoty.Connected = true;
                    ClearAllText();
                }
                else
                {
                    errorlabel.Visible = true;
                    errorlabel.ForeColor = Color.Red;
                    errorlabel.Text = "Invalid Password !";
                    ClearAllText();
                }
            }
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && Connectbtn.Text == "Create Acc")
            {
                if (textBox2.Text == textBox3.Text)
                {
                    errorlabel.Visible = true;
                    errorlabel.ForeColor = Color.LimeGreen;
                    errorlabel.Text = "Account successfully created !";
                    hodnoty.Username = textBox1.Text;
                    hodnoty.Password = textBox2.Text;
                    ClearAllText();
                }
                else
                {
                    errorlabel.Visible = true;
                    errorlabel.ForeColor = Color.Red;
                    errorlabel.Text = "Passwords doesn´t match !";
                    ClearAllText();
                }
            }
        }
        private void ClearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
    }
}
