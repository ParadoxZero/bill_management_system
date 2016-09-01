using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_management_system
{
    class Printer
    {
        public string output_file_path ;
        string header_file_path ;
        string footer_file_path ;

        string headertext ;
        string footertext ;
        StreamWriter Output ;
        string filename_with_path;

        public Printer(string output)
        {
            output_file_path = output;
            headertext = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Header.txt");
            footertext = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Footer.txt");;
        }
        public void initialize(string path_filename)
        {
            filename_with_path = output_file_path + path_filename;
            Output = new StreamWriter(filename_with_path, true);
        }
        // function header
        public void  header(string yourTin , string customerTin , string date, string invoice)
        {
            Output.WriteLine("                     Mariya Agencies " + "\n");
            Output.WriteLine("Invoice No: " + invoice);
            string format = "{0,-25}{1,-25}{2,-12}";
            Output.WriteLine(string.Format(format, "Agency Tin:" + yourTin, "Customer Tin:" + customerTin, "Dt:" + date));
            Output.WriteLine(headertext);
            
        }
        
        //function item list
        public void content(DataTable YourDataTable)
        {
            foreach (DataRow row in YourDataTable.Rows)
            {
                Boolean breakline = false;
                string temp = "";
                string result = "";
                string pipeline = "|";
                string Sno = pipeline + row["Sno"].ToString();
                string Name = pipeline + row["Name"].ToString();
                if (Name.Length <= 30)
                {
                    temp = Name;
                }
                else
                {
                    temp = Name.Substring(0, 30);
                    breakline = true;
                }
                string Qty = pipeline + row["Qty"].ToString();
                string price = pipeline + row["Price"].ToString();
                string G_price = pipeline + row["GrossPrice"].ToString();
                string vat = pipeline + row["Tax"].ToString();
                string subTotal = pipeline + ((Decimal)row["Sub Total"]).ToString("F");
                string Format = "{0,-3}{1,-30}{2,-5}{3,-8}{4,-9}{5,-5}{6,-9}";
                result = string.Format(Format, Sno, temp, Qty, price, G_price, vat, subTotal);
                Output.WriteLine(result);
                if (breakline)
                {
                    Sno = pipeline;
                    temp = pipeline + Name.Substring(30);
                    Qty = pipeline;
                    price = pipeline;
                    G_price = pipeline;
                    vat = pipeline;
                    subTotal = pipeline;
                    result = string.Format(Format, Sno, temp, Qty, price, G_price, vat, subTotal);
                    breakline = false;
                    Output.WriteLine(result);
                }

            }
        } 

        //function footer
        public void footer(Decimal TotalAmt)
        {
            Output.WriteLine("----------------------------------------------------------------------");
            Output.WriteLine("				              Total Amount :" + String.Format("{0:F2}",TotalAmt));
            
                Output.WriteLine(footertext);
            
            
        }
        
        //print function
        public void print()
        {
            Output.Close();
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                ProcessStartInfo info = new ProcessStartInfo(filename_with_path);
                info.Arguments = "\"" + printDialog.PrinterSettings.PrinterName + "\"";
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                info.UseShellExecute = true;
                info.Verb = "PrintTo";
                Process.Start(info);
            }

        }
    }
}
