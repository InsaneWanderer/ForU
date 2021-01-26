using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
 
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            Hide();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Start form3 = new Start();
            form3.Show();
            Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}

