using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bill_management_system
{
    class DbHelper
    {
        public MySqlConnection connection;

        private MySqlCommand cmd;
        private string com = ",";
        private string qte = "'";
        public DbHelper(MySqlConnection c)
        {
            connection = c;
            cmd = connection.CreateCommand();
        }

        public int insertItem(String name, Decimal price)
        {
            cmd.CommandText = "INSERT INTO item(Name,Price) VALUES(" + qte + name + qte + com + price + ");";
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
        }
        public bool updateItem(string name,Decimal price,string id)
        {
            cmd.CommandText = "UPDATE item SET Name='" + name + "',Price=" + price + " Where " +
                "id=" + id + ";";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            return true;
        }
        public void deleteItem(string id)
        {
            cmd.CommandText = "DELETE FROM item where id=" + id;
            cmd.ExecuteNonQuery();
            return;
        }
        public DataSet getAllItem()
        {
            cmd.CommandText = "Select * from item ;";
            DataSet set = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(set);
            return set;
        }
    }
}
