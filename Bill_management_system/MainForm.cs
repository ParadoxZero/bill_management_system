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

        private bool updateFlag = false;
        private DataTable dt = new DataTable();
        private DbHelper db;
        public MainForm()
        {
            InitializeComponent();
            
            dt.Columns.Add("Sno", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Qty", typeof(int));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Tax", typeof(decimal));
            dt.Columns.Add("Sub Total", typeof(Decimal));
            dt.Columns["Sno"].AutoIncrement = true;
            data_items.DataSource = dt;
            data_items.Columns["Sno"].ReadOnly = true;
            data_items.Columns["Name"].ReadOnly = true;
            data_items.Columns["Price"].ReadOnly = true;
            data_items.Columns["Sub Total"].ReadOnly = true;
            data_items.AllowUserToAddRows = false;
            data_items.CellValueChanged += (data_changed);
        }
        public void initialize()
        {
            item_box.DataSource = bill_item_list.DataSource = item_data.Tables[0];
            item_box.ValueMember = bill_item_list.ValueMember = "id";
            item_box.DisplayMember = bill_item_list.DisplayMember = "Name";
            db = new DbHelper(db_connection);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            db_connection.Close();
            this.Close();
        }

        private void data_changed(Object s, EventArgs e)
        {
            int row = data_items.CurrentCell.RowIndex;
            int col = data_items.CurrentCell.ColumnIndex;
            DataRow r = dt.Rows[row];
            Decimal price = Convert.ToDecimal(r["Price"]);
            Decimal tax = Convert.ToDecimal(r["Tax"]);
            int qty;
            try {
                qty = Convert.ToInt32(r["Qty"]);
            }
            catch
            {
                r["Qty"] = 1;
                qty = 1;
            }
            r["Sub Total"] = price * qty * (1 + tax/100);
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void data_table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int value = (int)bill_item_list.SelectedValue;
            int qty;
            try {
                qty = Convert.ToInt32(this.qty.Text == null ? "1" : this.qty.Text);
            }
            catch
            {
                return;
            }
            DataRow r = dt.NewRow();
            foreach (DataRow row in item_data.Tables[0].Rows)
            {
                if (((int)row["id"]) == value)
                {
                    Decimal price =Convert.ToDecimal( row["Price"]);
                    r["Name"] = row["Name"];
                    r["Qty"] = qty;
                    r["Price"] = price;
                    r["Tax"] = 14.5;
                    r["Sub Total"] = price*qty*(1+ (Decimal)0.145);
                }
            }
            dt.Rows.Add(r);
        }

        private void select_Click(object sender, EventArgs e)
        {
            int value = (int)bill_item_list.SelectedValue;
            foreach(DataRow row in item_data.Tables[0].Rows)
            {
                if (((int)row["id"]) == value)
                {
                    Item_name.Text = row["Name"].ToString();
                    item_price.Text = row["Price"].ToString();
                    updateFlag = true;
                }
            }
        }

        private void update_db_Click(object sender, EventArgs e)
        {
            if(Item_name.Text=="" || item_price.Text == "")
            {
                MessageBox.Show("Input values!");
                return;
            }
            Decimal price = Convert.ToDecimal(item_price.Text);
            string id = null;
            string name = Item_name.Text, pr = "" + price;
            foreach(DataRow row in item_data.Tables[0].Rows)
            {
                if(name.Equals((string)row["Name"]))
                {
                    id = row["id"].ToString();
                }
            }
            if (updateFlag)
            {
                db.updateItem(Item_name.Text, price, id);
                updateFlag = false;
            }
            else
                db.insertItem(Item_name.Text, price);
            item_data = db.getAllItem();
            initialize();
            Item_name.Text = "";
            item_price.Text = "";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (!updateFlag)
                return;
            Decimal price = Convert.ToDecimal(item_price.Text);
            string id = null;
            string name = Item_name.Text, pr = "" + price;
            foreach (DataRow row in item_data.Tables[0].Rows)
            {
                if (name.Equals((string)row["Name"]))
                {
                    id = row["id"].ToString();
                }
            }
            if (id != null)
            {
                db.deleteItem(id);
                updateFlag = false;
                item_data = db.getAllItem();
                initialize();
            }
            Item_name.Text = "";
            item_price.Text = "";
        }
    }
}
