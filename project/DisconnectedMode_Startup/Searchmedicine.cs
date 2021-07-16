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
    public partial class Searchmedicine : Form
    {

        OracleConnection con;
        string ordb = "Data source=orcl; User Id =scott;Password=tiger;";

        public Searchmedicine()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {

            if (Med_name.Text == "")
                MessageBox.Show("Please enter medicien name");
            else
            {
                string medicine_name, med_exp_date, price, id;

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "GET_MED_INFO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("med", Med_name.Text);
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);

                cmd.Parameters.Add("PRICE", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                id = cmd.Parameters["id"].Value.ToString();
                price = cmd.Parameters["PRICE"].Value.ToString();
                medicine_name = Med_name.Text;
                this.med_info.Rows.Clear();
                med_info.ColumnCount = 3;
                med_info.Columns[0].Name = "Medicine ID";
                med_info.Columns[1].Name = "Medicine Name";
                med_info.Columns[2].Name = "Medicine Price";
                this.med_info.Rows.Add(id, medicine_name, price);
            }
        }

        private void SearchFilms_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void med_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchback_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform obj = new Mainform();
            obj.Show();
        }
    }
}
