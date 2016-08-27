using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bill_management_system
{
    public partial class MainForm : Form
    {
        public MySqlConnection db_connection;
        public DataSet item_data;

        private DataTable dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
            dt.Columns.Add("Sno", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Qty", typeof(int));
            dt.Columns.Add("Price", typeof(Decimal));
            dt.Columns.Add("Tax", typeof(Decimal));
            dt.Columns.Add("Sub Total", typeof(Decimal));
            data_items.DataSource = dt;
        }
        public void initialize()
        {
            comboBox1.DataSource = item_data.Tables[0];
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "Name";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            db_connection.Close();
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void data_table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int value = (int)comboBox1.SelectedValue;
            foreach(DataRow row in item_data.Tables[0].Rows)
            {
                if (((int)row["id"]) == value)
                {
                    MessageBox.Show("found " + row["name"]);
                }
            }
        }
    }
}
