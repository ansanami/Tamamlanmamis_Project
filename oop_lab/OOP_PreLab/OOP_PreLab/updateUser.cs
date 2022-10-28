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
    public partial class updateUser : Form
    {
        public updateUser()
        {
            InitializeComponent();
        }

        private void updateusersınformatıonforadmın_Load(object sender, EventArgs e)
        {

            kayıtlists();
        }

        private void kayıtlists()
        {
          
            DataSet dset = new DataSet();
            XmlReader reader = XmlReader.Create(@"veri.xml");
            dset.ReadXml(reader);
            dataGridView1.DataSource = dset.Tables[0];
            reader.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            XDocument xdosya = XDocument.Load(@"veri.xml");
            XElement element = xdosya.Element("users").Elements("user").FirstOrDefault(x=> x.Element("Username").Value == x.Element("Username").Value);
            if (element!=null)
            {
                element.SetElementValue("Password", form3.ComputeSha256Hash(passwordtext.Text));
                element.SetElementValue("Name-Surname", namesurnametext.Text);
                element.SetElementValue("PhoneNumber", phonenumbertext.Text);
                element.SetElementValue("Adress", adrtesstext.Text);
                element.SetElementValue("City", citytext.Text);
                element.SetElementValue("Country", countrytext.Text);
                element.SetElementValue("E-Mail", mailtext.Text);
                xdosya.Save(@"veri.xml");
                MessageBox.Show("veriler guncellendı");
                kayıtlists();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            passwordtext.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            namesurnametext.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            phonenumbertext.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            adrtesstext.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            citytext.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            countrytext.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mailtext.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form4 gecis = new Form4();
            gecis.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load(@"veri.xml");
            xdoc.Root.Elements().Where(x => x.Element("Username").Value == dataGridView1.CurrentRow.Cells[0].Value.ToString()).Remove();
            xdoc.Save(@"veri.xml");
            MessageBox.Show("Kayıt Silindi");
            kayıtlists();
        }
    }
}
