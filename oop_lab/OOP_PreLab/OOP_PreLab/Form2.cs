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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_ayarlar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            buttonSettings.Visible = false;
            playButton.Visible = false;
            exitButton.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            buttonSettings.Visible = true;
            exitButton.Visible = true ;
            playButton.Visible = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Settings1.Default.diffculty_level = comboBox1.Text;
            Settings1.Default.Save();

            if (comboBox1.Text == "Custom")
            {
                textBoxWidth.Visible = true; 
                textBoxHeight.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                Settings1.Default.visible = true;
                Settings1.Default.Save();

            }
            else
            {
                textBoxWidth.Visible = false;
                textBoxHeight.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                Settings1.Default.visible = false;
                Settings1.Default.Save();
            }
        }

        private void checkBoxSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSquare.Checked)
            {
                Settings1.Default.square = true;
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.square = false;
                Settings1.Default.Save();
            }
        }

        private void checkBoxTriangle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTriangle.Checked)
            {
                Settings1.Default.triangle = true;
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.triangle = false;
                Settings1.Default.Save();
            }
        }

        private void checkBoxRound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRound.Checked)
            {
                Settings1.Default.round = true;
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.round = false;
                Settings1.Default.Save();
            }
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            Settings1.Default.width = textBoxWidth.Text;
            Settings1.Default.Save();
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            Settings1.Default.height = textBoxHeight.Text;
            Settings1.Default.Save();
        }


        private void kırmızı_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxRed.Checked)
            {
                Settings1.Default.kırmızı = true;
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.kırmızı = false;
                Settings1.Default.Save();
            }
        }

        private void yeşil_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxGreen.Checked)
            {
                Settings1.Default.yeşil = true;
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.yeşil = false;
                Settings1.Default.Save();
            }
        }

        private void mavi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlue.Checked)
            {
                Settings1.Default.mavi = true;
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.mavi = false;
                Settings1.Default.Save();
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            FormLogin donus = new FormLogin();
            donus.Show();
            this.Hide();
        }

        private void bilgiButton_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();

        }
    }
}
