using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace DisconnectedMode_Startup
{
    public partial class Formcrystal1 : Form
    {
        CrystalReport1 CR1;
        public Formcrystal1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR1.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = CR1;
        }

        private void Formcrystal1_Load(object sender, EventArgs e)
        {
            CR1 = new CrystalReport1();
            foreach (ParameterDiscreteValue v in CR1.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);

        }

        private void crys1back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform obj = new Mainform();
            obj.Show();
        }
    }
}
