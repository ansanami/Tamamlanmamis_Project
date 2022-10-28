using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PreLab
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void adminSettings_Click(object sender, EventArgs e)
        {
            Form4 gecis4 = new Form4();
            gecis4.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            FormLogin donus = new FormLogin();
            donus.Show();
            this.Hide();
        }

        private void button_ayarlar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            playButton.Visible = false;
            adminSettings.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            playButton.Visible = true;
            adminSettings.Visible = true;
        }
    }
}
