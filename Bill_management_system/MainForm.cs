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
using System.Configuration;

namespace Bill_management_system
{
    public partial class MainForm : Form
    {
        public MySqlConnection db_connection;
        public DataSet item_list_data;

        private int sno = 1;
        private bool updateFlag = false;
        private DataTable dt = new DataTable();
        private DbHelper db;
        private Decimal tax;
        private string tin;
        public MainForm()
        {
            InitializeComponent();
            dt.Columns.Add("Sno", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Qty", typeof(int));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Tax", typeof(decimal));
            dt.Columns.Add("Sub Total", typeof(Decimal));
            dt.Columns.Add("Stock", typeof(int));
            data_items.DataSource = dt;
            data_items.Columns["Sno"].ReadOnly = true;
            data_items.Columns["Name"].ReadOnly = true;
            data_items.Columns["Price"].ReadOnly = true;
            data_items.Columns["Sub Total"].ReadOnly = true;
            data_items.AllowUserToAddRows = false;
            data_items.CellValueChanged += (data_changed);
            dt.RowDeleted += (sno_updater);
        }
        public void initialize()
        {
            item_box_combo.DataSource = bill_items_combo.DataSource = item_list_data.Tables[0];
            item_box_combo.ValueMember = bill_items_combo.ValueMember = "id";
            item_box_combo.DisplayMember = bill_items_combo.DisplayMember = "Name";
            db = new DbHelper(db_connection);
            tax = Convert.ToDecimal(ConfigurationManager.AppSettings["tax"]);
            tin = ConfigurationManager.AppSettings["tin"];
            default_tax_textbox.Text = "" + tax;
            default_tin_textbox.Text = tin;
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
        private void sno_updater(object s, EventArgs e)
        {
            int i = 1;
            foreach (DataRow item in dt.Rows)
            {
                item["Sno"] = i++;
            }
            sno = i;

        }
        private void add_bill_item_click(object sender, EventArgs e)
        {
            int value;
            int qty;

            try
            {
                value = (int)bill_items_combo.SelectedValue;
                qty = Convert.ToInt32(this.qty_textbox.Text.Equals("") ? "1" : this.qty_textbox.Text);
            }
            catch
            {
                return;
            }
            DataRow r = dt.NewRow(), base_row;
            foreach (DataRow row in item_list_data.Tables[0].Rows)
            {
                if (((int)row["id"]) == value)
                {
                    base_row = row;
                    Decimal price =Convert.ToDecimal( row["Price"]);
                    // Sno is added later after verifying the row is unique.
                    r["Name"] = row["Name"];
                    r["Qty"] = qty;
                    r["Price"] = price;
                    r["Tax"] = tax;
                    r["Stock"] = row["Stock"];
                    r["Sub Total"] = price*qty*(1+ (Decimal)0.145);
                    int st = Convert.ToInt32(row["Stock"]) - qty;
                    if (st < 0)
                    {
                        MessageBox.Show("Not Enough stock!");
                        return;
                    }
                    r["Stock"] = "" + st;
                    row["Stock"] = r["Stock"];
                }
            }
            foreach(DataRow row in dt.Rows)
            {
                if (row["Name"].Equals(r["Name"]))
                {
                    int qt = Convert.ToInt32(row["Qty"]);
                    qt += Convert.ToInt32(r["Qty"]);
                    row["Stock"] = r["Stock"];
                    row["Qty"] = qt;
                    return;
                }
            }
            
            r["Sno"] = sno++; // Don't move this to above
            // this is here to make sure Sno increases only if item new
            dt.Rows.Add(r);
            bill_items_combo.Text = "";
            this.qty_textbox.Text = "";
        }

        private void select_Click(object sender, EventArgs e)
        {
            int value = (int)bill_items_combo.SelectedValue;
            foreach(DataRow row in item_list_data.Tables[0].Rows)
            {
                if (((int)row["id"]) == value)
                {
                    item_name_textbox.Text = row["Name"].ToString();
                    item_price_textbox.Text = row["Price"].ToString();
                    stock_textbox.Text = row["Stock"].ToString();
                    updateFlag = true;
                }
            }
        }

        private void update_db_Click(object sender, EventArgs e)
        {
            if(item_name_textbox.Text=="" || item_price_textbox.Text == "" || stock_textbox.Text=="")
            {
                MessageBox.Show("Input values!");
                return;
            }
            Decimal price = Convert.ToDecimal(item_price_textbox.Text);
            string id = null;
            int stock = Convert.ToInt32(stock_textbox.Text);
            string name = item_name_textbox.Text, pr = "" + price;
            foreach(DataRow row in item_list_data.Tables[0].Rows)
            {
                if(name.Equals((string)row["Name"]))
                {
                    id = row["id"].ToString();
                }
            }
            if (updateFlag)
            {
                db.updateItem(item_name_textbox.Text, price, id);
                db.updateItemStock(id, stock);
                updateFlag = false;
            }
            else {
                db.insertItem(item_name_textbox.Text, price, stock);
            }
            item_list_data = db.getAllItem();
            initialize();
            item_name_textbox.Text = "";
            item_price_textbox.Text = "";
            stock_textbox.Text = "";
        }

        private void delete_btn_click(object sender, EventArgs e)
        {
            if (!updateFlag)
                return;
            Decimal price;
            try
            {
                 price = Convert.ToDecimal(item_price_textbox.Text);
            }
            catch
            {
                return;
            }
            string id = null;
            string name = item_name_textbox.Text, pr = "" + price;
            foreach (DataRow row in item_list_data.Tables[0].Rows)
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
                item_list_data = db.getAllItem();
                initialize();
            }
            item_name_textbox.Text = "";
            item_price_textbox.Text = "";
            stock_textbox.Text = "";
        }

        private void print_btn_click(object sender, EventArgs e)
        {
            foreach(DataRow row in dt.Rows)
            {
                int stock = Convert.ToInt32(row["Stock"]);
                int qty = Convert.ToInt32(row["Qty"]);
                stock -= qty;
                if (stock < 0)
                {
                    MessageBox.Show("Not Enough Stock of " + row["Name"]);
                    return;
                }
                string id = getId((string)row["Name"]);
                db.updateItemStock(id, stock);
                item_list_data = db.getAllItem();
                initialize();
            }
        }

        private string getId(string name)
        {
            foreach(DataRow row in item_list_data.Tables[0].Rows)
            {
                if (name.Equals(row["Name"]))
                    return row["id"].ToString();
            }
            return "";
        }

        private void save_config_btn_Click(object sender, EventArgs e)
        {
            string tin = default_tin_textbox.Text;
            ConfigurationManager.AppSettings["tin"] = tin;
            string tax = default_tax_textbox.Text;
            ConfigurationManager.AppSettings["tax"] = tax;
            initialize();
        }
    }
}
