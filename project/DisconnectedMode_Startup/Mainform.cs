using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisconnectedMode_Startup
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searchmedicine obj = new Searchmedicine();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           Formconn obj = new Formconn();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayDoctors obj = new DisplayDoctors();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formcrystal1 obj = new Formcrystal1();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formcrystal2 obj = new Formcrystal2();
            obj.Show();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        
        }
    }
}
