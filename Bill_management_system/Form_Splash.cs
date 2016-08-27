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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_timer_Tick(object sender, EventArgs e)
        {
            Splash_timer.Enabled = false;
            progressBar1.Value = 70;
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; userId=ma; password=pswd; database=bill_items";
            try
            {
                cn.Open();
                progressBar1.Value += 20;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Unable to connect to database!");
                System.Environment.Exit(1);
            }
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * from item";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet set = new DataSet();
            adp.Fill(set);
            adp.Dispose();
            var main_form = new MainForm();
            main_form.db_connection = cn;
            main_form.item_data = set;
            main_form.FormClosed += (s,args) => this.Close();
            main_form.initialize();
            progressBar1.Value = 100;
            this.Hide();
            main_form.Show();
        }
    }
}
