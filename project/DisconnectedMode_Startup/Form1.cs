using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace DisconnectedMode_Startup
{
    public partial class Form1 : Form
    {

        OracleDataAdapter DataAdapter;
        OracleCommandBuilder CommandBuilder;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Btn_Click(object sender, EventArgs e)
        {
            if (SalaryTxtBox.Text == "")
            {
                MessageBox.Show("please enter the salary");
            }
            else
            {
                dataGridView1.DataSource = null;

                string connString = "Data Source=orcl; User Id=scott; Password=tiger;";
                int salary = int.Parse(SalaryTxtBox.Text.ToString());
                string commString = "select * from Doctors where Salary >= '" + salary + "'";

                DataAdapter = new OracleDataAdapter(commString, connString);
                ds = new DataSet();
                DataAdapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            CommandBuilder = new OracleCommandBuilder(DataAdapter);
            DataAdapter.Update(ds.Tables[0]);
            MessageBox.Show("Saved");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform obj = new Mainform();
            obj.Show();
        }
    }
}
