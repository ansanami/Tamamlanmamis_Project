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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form5 gecıs5 = new Form5();
            gecıs5.Show();
            this.Hide();
        }

        private void allUserbutton_Click(object sender, EventArgs e)
        {
            listusersform gecis = new listusersform();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateUser gecis = new updateUser();
            gecis.Show();
            this.Hide();
        }

        private void kayıtolbutton_Click(object sender, EventArgs e)
        {
            form3 form3 = new form3();
            form3.Show();
            this.Hide();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            updateUser gecis = new updateUser();
            gecis.Show();
            this.Hide();
        }
    }
}
