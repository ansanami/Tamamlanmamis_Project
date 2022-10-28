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
    public partial class listusersform : Form
    {
        public listusersform()
        {
            InitializeComponent();
        }

        private void listusersform_Load(object sender, EventArgs e)
        {
            kayıtgetır();
        }

        public void kayıtgetır()
        {
            DataSet dset = new DataSet();
            XmlReader reader = XmlReader.Create(@"veri.xml");
            dset.ReadXml(reader);
            dataGridView1.DataSource = dset.Tables[0];
            reader.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form4 gecıs = new Form4();
            gecıs.Show();
            this.Hide();
        }
    }
}
