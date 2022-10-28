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
using System.Security.Cryptography;

namespace OOP_PreLab
{
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }
        private void kayıtolbutton_Click(object sender, EventArgs e)
        {
           
            XDocument xdosya = XDocument.Load(@"veri.xml");
            XElement root = xdosya.Root;
            XElement element = new XElement("user");
            XElement username = new XElement("Username", usernametext.Text);
            XElement password = new XElement("Password", ComputeSha256Hash(passwordtext.Text));
            XElement nameSurname = new XElement("Name-Surname", namesurnametext.Text);
            XElement phoneNumber = new XElement("PhoneNumber", phonenumbertext.Text);
            XElement adress = new XElement("Adress", adrtesstext.Text);
            XElement city = new XElement("City", citytext.Text);
            XElement country = new XElement("Country", countrytext.Text);
            XElement mail = new XElement("E-Mail", mailtext.Text);
            element.Add(username, password, nameSurname, phoneNumber, adress, city, country, mail);
            root.Add(element);
            xdosya.Save(@"veri.xml");
            MessageBox.Show("Kayıt Eklendi");
            FormLogin gecis = new FormLogin();
            gecis.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormLogin gecıs = new FormLogin();
            gecıs.Show();
            this.Hide();
        }

        static public string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
