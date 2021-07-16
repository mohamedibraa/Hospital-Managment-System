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
    public partial class Formcrystal2 : Form
    {
        CrystalReport2 CR2;
        public Formcrystal2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR2;
        }

        private void Formcrystal2_Load(object sender, EventArgs e)
        {
            CR2 = new CrystalReport2();
        }

        private void crys2back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform obj = new Mainform();
            obj.Show();
        }
    }
}
