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
    public partial class Splash : Form
    {
        private string user, pass, db_name;
        public Splash()
        {
            InitializeComponent();
            user = ConfigurationManager.AppSettings["user"];
            pass = ConfigurationManager.AppSettings["pass"];
            db_name = ConfigurationManager.AppSettings["db"];          
                        
        }

        private void Splash_timer_Tick(object sender, EventArgs e)
        {
            Splash_timer.Enabled = false;
            progressBar1.Value = 70;
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; userId="+user +"; password="+pass+"; database="+db_name;
            try
            {
                cn.Open();
                progressBar1.Value += 20;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Unable to connect to database!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * from item";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet set = new DataSet();
            adp.Fill(set);
            var main_form = new MainForm();
            main_form.db_connection = cn;
            main_form.FormClosed += (s,args) => this.Close();
            progressBar1.Value = 100;
            this.Hide();
            main_form.Show();
            main_form.initialize();
        }
    }
}
