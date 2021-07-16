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
    public partial class Formconn : Form
    {
        string ordb = "Data source=orcl; User Id =scott;Password=tiger;";
        OracleConnection conn;
        public Formconn()
        {
            InitializeComponent();
        }

        private void Formconn_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select doctorid from doctors";
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                ID_combo.Items.Add(dr[0]);
            }
            dr.Close();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (first_Name_text.Text == "" || Last_name_text.Text == "" || Salary_text.Text == "" || specialization_text.Text == "")
            {
                MessageBox.Show("Please Enter all data");

            }
            else
            {
                /*OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "select max(doctorid) from doctors";
                OracleDataReader dr = cmd1.ExecuteReader();
                ID_combo.Items.Add((Int32.Parse(dr[0].ToString()) + 1).ToString());
                dr.Close();*/
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into doctors values(:id,:depid,:f_name,:l_name,:salary,:specialization)";
                cmd.Parameters.Add("id", ID_combo.Text);
                cmd.Parameters.Add("depid", null);
                cmd.Parameters.Add("f_name", first_Name_text.Text);
                cmd.Parameters.Add("l_name", Last_name_text.Text);
                cmd.Parameters.Add("salary", Salary_text.Text);
                cmd.Parameters.Add("specialization", specialization_text.Text);
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("successfully added");
                        ID_combo.Items.Add(ID_combo.Text);
                    }


                    else
                        MessageBox.Show("not added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("id already exist ");

                }
            }
        }

        private void ID_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string id = ID_combo.SelectedItem.ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from doctors where doctors.doctorid=:id";
            cmd.Parameters.Add("id", id);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                first_Name_text.Text = dr[2].ToString();
                Last_name_text.Text = dr[3].ToString();
                Salary_text.Text = dr[4].ToString();
                specialization_text.Text = dr[5].ToString();
            }
            dr.Close();

        }

        private void connback_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Mainform obj = new Mainform();
            obj.Show();
        }
    }
}
