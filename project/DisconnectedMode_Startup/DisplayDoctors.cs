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
    public partial class DisplayDoctors : Form
    {
        OracleConnection conn;
        string ordb = "Data source=orcl; User Id =scott;Password=tiger;";
        //To Make Default Value of RadioButton checked -> 
        //Form Design, Select RadioButton,RightClick,Properties, Checked = True

        public DisplayDoctors()
        {
            InitializeComponent();
        }

      

        private void Manage_Data_DataAdapter_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Manage_Data_DataAdapter_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void Dis_Click(object sender, EventArgs e)
        {
            if (spec.Text == "")
                MessageBox.Show("Please Enter Your Specialization");
            else
            {

                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Display_Doctor_Info";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("spec", spec.Text);
                cmd.Parameters.Add("info", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader dr = cmd.ExecuteReader();
                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "Doctor ID";
                dataGridView1.Columns[1].Name = "First Name";
                dataGridView1.Columns[2].Name = "Last Name";
                dataGridView1.Columns[3].Name = "Dep ID";
                this.dataGridView1.Rows.Clear();

                while (dr.Read())
                {
                    this.dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
                dr.Close();
            }
        }

        

       

        private void disback_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform obj = new Mainform();
            obj.Show();
        }
    }
}

