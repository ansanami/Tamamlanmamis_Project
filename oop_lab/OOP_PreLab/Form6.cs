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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 gecıs = new Form2();
            gecıs.Show();
            this.Hide();
        }

        private void buttonUpdate6_Click(object sender, EventArgs e)
        {
            XDocument xdosya = XDocument.Load(@"veri.xml");
            XElement element = xdosya.Element("users").Elements("user").FirstOrDefault(x => x.Element("Username").Value == Settings1.Default.username.ToString());
            if (element != null )
            {
               
                
                    element.SetElementValue("Password", form3.ComputeSha256Hash(passwordtext.Text));
                    element.SetElementValue("Name-Surname", namesurnametext.Text);
                    element.SetElementValue("PhoneNumber", phonenumbertext.Text);
                    element.SetElementValue("Adress", adrtesstext.Text);
                    element.SetElementValue("City", citytext.Text);
                    element.SetElementValue("Country", countrytext.Text);
                    element.SetElementValue("E-Mail", mailtext.Text);
                    xdosya.Save(@"veri.xml");
                    MessageBox.Show("veriler guncellendı yenıden gırıs yapınız");

                    FormLogin gecis = new FormLogin();
                    gecis.Show();
                    this.Hide();
 
            }
        }
    }
}
