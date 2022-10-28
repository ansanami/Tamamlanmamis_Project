using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace OOP_PreLab
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void button_Login_Click_1(object sender, EventArgs e)
        {
            XDocument xdosya = XDocument.Load(@"veri.xml");
            XElement element = xdosya.Element("users").Elements("user").FirstOrDefault(x => x.Element("Username").Value == textBoxUsername.Text);
            XElement element2 = xdosya.Element("users").Elements("user").FirstOrDefault(x => x.Element("Password").Value == form3.ComputeSha256Hash(textBoxPassword.Text));
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {
                Settings1.Default.username = textBoxUsername.Text;
                Settings1.Default.Save();
                Form5 gecis5 = new Form5();
                gecis5.Show();
                this.Hide();
                
            }
            else if (textBoxUsername.Text == "user" && textBoxPassword.Text == "user")
            {
                Settings1.Default.password = textBoxPassword.Text;
                Settings1.Default.Save();
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }
            else if (element != null && element2 != null)
            {
                Settings1.Default.password = textBoxPassword.Text;
                Settings1.Default.Save();
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Hatalı\t", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
        }

        private void singinbutton_Click(object sender, EventArgs e)
        {
            form3 gecis2 = new form3();
            gecis2.Show();
            this.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != '\u0008')
                    e.Handled = true;
        }
    }
}
