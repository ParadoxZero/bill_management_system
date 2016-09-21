using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        public string output_file_path;

        string headertext;
        string footertext;
        //StreamWriter Output;
        string filename_with_path;
        Double total_tax;
        Double total_gross;

        public Printer(string output)
        {
            output_file_path = output;
            headertext = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Header.txt");
            footertext = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Footer.txt"); ;
        }
        public void initialize(string path_filename, MainForm form)
        {
            filename_with_path = output_file_path + path_filename;

        }/*
        // function header
        public void header(string yourTin, string customerTin, string date, string invoice, string name)
        {

            Output.WriteLine("                            Mariya Agencies" + "\n");
            Output.WriteLine("                                Form 8\n\n");
            Output.WriteLine("Invoice No: " + invoice);
            Output.WriteLine("Customer name:" + name);
            string format = "{0,-25}{1,-25}{2,-12}";
            Output.WriteLine(string.Format(format, "Agency Tin:" + yourTin, "Customer Tin:" + customerTin, "Dt:" + date));
            Output.WriteLine(headertext);

        }

        //function item list
        public void content(System.Data.DataTable YourDataTable)
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
            Output.WriteLine("				              Total Amount :" + String.Format("{0:F2}", TotalAmt));

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

        }*/

        //New Function 
        public void doc_creation(string invoice, string yourTin, string customerTin, string partyname, string date, System.Data.DataTable YourDataTable, Double TotalAmt, string filename_with_path)
        {

            object oMissing = System.Reflection.Missing.Value;

            ////education purpose only----------------
            //YourDataTable.Columns.Add("Sno", typeof(int));
            //YourDataTable.Columns.Add("Commodity", typeof(string));
            //YourDataTable.Columns.Add("Quantity", typeof(int));
            //YourDataTable.Columns.Add("Tax", typeof(float));
            //YourDataTable.Columns.Add("Unit Price", typeof(float));
            //YourDataTable.Columns.Add("GrossPrice", typeof(float));
            //YourDataTable.Columns.Add("Rate of tax", typeof(float));
            //YourDataTable.Columns.Add("Total", typeof(float));

            //YourDataTable.Rows.Add(1, "Helsado", 5, 34, 450, 5, 490, 45);
            //YourDataTable.Rows.Add(2, "sadHelo", 5, 45, 450, 5, 490);
            //YourDataTable.Rows.Add(3, "Helosad grgr grg rgra re rgirgijfjiorejgero", 5, 345, 450, 5, 490);
            //YourDataTable.Rows.Add(4, "Hsdselo", 5, 4345, 446, 5, 575);
            //YourDataTable.Rows.Add(5, "Helossd", 5, 454, 446, 5, 880);
            //YourDataTable.Rows.Add(7, "Bonvita 3kg", 5, 3, 575, 5, 7557);
            //YourDataTable.Rows.Add(8, "ewrwer", 5, 46, 450, 575, 24);
            //YourDataTable.Rows.Add(9, "Hefcoij ahdi", 5, 46, 686, 5, 346);
            //YourDataTable.Rows.Add(10, "Rnidfiof ikvjif", 5, 46, 24, 5, 123);
            //YourDataTable.Rows.Add(11, "Qufgnnfn ifnvi", 5, 46, 242, 5, 5464);
            //YourDataTable.Rows.Add(12, "Wgirg fidf", 5, 46, 450, 14, 123);
            //YourDataTable.Rows.Add(13, "Qforgjfob", 5, 46, 450, 4, 776);
            //YourDataTable.Rows.Add(14, "Pfbijdf vif", 5, 46, 450, 35, 443);

            ////----------------------------------
            //----------------DOC creation--------------//
            //Create an instance for word app

            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

            //Set animation status for word application
            winword.ShowAnimation = false;

            //Set status for word application is to be visible or not.
            winword.Visible = false;
            //Create a missing variable for missing value
            object missing = System.Reflection.Missing.Value;
            //Create a new document
            Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            winword.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
            winword.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 0.0F;
            document.PageSetup.LeftMargin = 35f;
            document.PageSetup.RightMargin = 35f;
            document.PageSetup.TopMargin = -15f;
            document.PageSetup.BottomMargin = 30f;

            //Addind invoice and date
            Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
            para1.Range.Font.Size = 10;
            para1.Range.Text = "Invoice No : " + invoice + "                                                                                                                                                          " + "Date: " + date + "\vCompany's TIN Number  :" + yourTin;
            para1.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            para1.Range.InsertParagraphAfter();

            //Adding MARIYA AGENCIES heading

            Paragraph Mariya = document.Content.Paragraphs.Add(ref missing);
            object start = Mariya.Range.Start;
            object end = Mariya.Range.End;
            Range rng = document.Range(ref start, ref end);
            rng.Text = "MARIYA AGENCIES";
            rng.Font.Name = "Arial Regular";
            rng.Font.Size = 14;
            rng.Font.Bold = 1;
            rng.Font.Italic = 1;
            Mariya.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            rng.InsertParagraphAfter();

            //Adding rest of data to subheading
            Paragraph subheading = document.Content.Paragraphs.Add(ref missing);
            subheading.Range.Text = "R.I.T. JUNCTION, PAMPADY \v Contact : 0481 2507112 , 9400806612\v Email : mariyabakeryicecream@gmail.com  ";
            object start1 = subheading.Range.Start;
            object end1 = subheading.Range.End;
            Range rng1 = document.Range(ref start1, ref end1);
            rng1.Font.Size = 8;
            rng1.Font.Bold = 1;
            subheading.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            rng1.InsertParagraphAfter();

            Paragraph subheading2 = document.Content.Paragraphs.Add(ref missing);
            subheading2.Range.Text = "\v THE KERALA VALUE ADDED TAX RULES 2005";
            object start9 = subheading.Range.Start;
            object end9 = subheading.Range.End;
            Range rng9 = document.Range(ref start9, ref end9);
            rng9.Font.Bold = 0;
            rng9.Font.Size = 9;
            rng9.InsertParagraphAfter();

            Paragraph form8a = document.Content.Paragraphs.Add(ref missing);
            form8a.Range.Text = "\nForm No.8";
            object start2 = form8a.Range.Start;
            object end2 = form8a.Range.End;
            Range rng2 = document.Range(ref start2, ref end2);
            rng2.Font.Size = 14;
            rng2.Font.Bold = 1;
            rng2.InsertParagraphAfter();

            Paragraph form8asubheading2 = document.Content.Paragraphs.Add(ref missing);
            form8asubheading2.Range.Text = "[See rule 58(10)]";
            object start10 = form8asubheading2.Range.Start;
            object end10 = form8asubheading2.Range.End;
            Range rng10 = document.Range(ref start10, ref end10);
            rng10.Font.Italic = 1;
            rng10.Font.Size = 8;
            rng10.Font.Bold = 0;
            rng10.InsertParagraphAfter();

            Paragraph form8aSubheading = document.Content.Paragraphs.Add(ref missing);
            form8aSubheading.Range.Text = " \vTAX INVOICE\v";
            object start3 = form8aSubheading.Range.Start;
            object end3 = form8aSubheading.Range.End;
            Range rng3 = document.Range(ref start3, ref end3);
            rng3.Font.Size = 10;
            rng3.Font.Bold = 1;
            rng3.Font.Italic = 0;
            rng3.InsertParagraphAfter();


            //Party's  name..
            Paragraph party = document.Content.Paragraphs.Add(ref missing);
            party.Range.Text = "Party : " + partyname + "\vBuyer's TIN Number : " + customerTin + "\v\v";
            party.Range.Font.Size = 10;
            party.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            object start4 = party.Range.Start + 8;
            object end4 = party.Range.End;
            Range rng4 = document.Range(ref start4, ref end4);
            rng4.Font.Bold = 1;
            rng4.InsertParagraphAfter();

            //Create a dynamic table and entering data using datatable declared above table and insert some dummy record
            Table newTable;
            object oEndOfDoc = "\\endofdoc";
            Range wrdRng = document.Bookmarks.get_Item(ref oEndOfDoc).Range;
            newTable = document.Tables.Add(wrdRng, 1, 8, ref oMissing, ref oMissing);
            newTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            newTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
            newTable.AllowAutoFit = true;
            //for (int i = 0, j = 0; j < 8; j++)
            //{
            //    var cell = YourDataTable.Columns;
            //    newTable.Cell(newTable.Rows.Count, j + 1).Range.Text = YourDataTable.Columns[j].ToString();
            //}
            newTable.Cell(1, 1).Range.Text = "Sno";
            newTable.Cell(1, 2).Range.Text = "Commodity";
            newTable.Cell(1, 3).Range.Text = "Quantity";
            newTable.Cell(1, 4).Range.Text = "Tax Rate";
            newTable.Cell(1, 5).Range.Text = "Unit Price";
            newTable.Cell(1, 6).Range.Text = "Gross Price";
            newTable.Cell(1, 7).Range.Text = "Tax";
            newTable.Cell(1, 8).Range.Text = "Total";

            newTable.Rows.Add();

            //for (int i = 0; i < YourDataTable.Rows.Count; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        var cell = YourDataTable.Rows[i][j];
            //        newTable.Cell(newTable.Rows.Count, j + 1).Range.Text = YourDataTable.Rows[i][j].ToString();

            //    }
            //    newTable.Rows.Add();
            //}

            for (int i = 0; i < YourDataTable.Rows.Count; i++)
            {
                //for(int j=0; j<8; j++)
                //{
                //    newTable.Cell(newTable.Rows.Count, j + 1).Range.Text = YourDataTable.Rows[i][j].ToString();
                //}
                newTable.Cell(newTable.Rows.Count, 1).Range.Text = YourDataTable.Rows[i][0].ToString();
                newTable.Cell(newTable.Rows.Count, 2).Range.Text = YourDataTable.Rows[i][1].ToString();
                newTable.Cell(newTable.Rows.Count, 3).Range.Text = YourDataTable.Rows[i][2].ToString();
                newTable.Cell(newTable.Rows.Count, 4).Range.Text = YourDataTable.Rows[i][5].ToString();
                newTable.Cell(newTable.Rows.Count, 5).Range.Text = Math.Round(Convert.ToDouble(YourDataTable.Rows[i][3]), 2, MidpointRounding.AwayFromZero).ToString("F");
                newTable.Cell(newTable.Rows.Count, 6).Range.Text = Math.Round(Convert.ToDouble(YourDataTable.Rows[i][4]), 2, MidpointRounding.AwayFromZero).ToString("F");
                total_gross = total_gross + Math.Round(Convert.ToDouble(YourDataTable.Rows[i][4]), 2, MidpointRounding.AwayFromZero);
                newTable.Cell(newTable.Rows.Count, 7).Range.Text = Math.Round(Convert.ToDouble(YourDataTable.Rows[i][4]) * (Convert.ToDouble(YourDataTable.Rows[i][5]) / 100f), 2, MidpointRounding.AwayFromZero).ToString("F");
                total_tax = total_tax + Math.Round(Convert.ToDouble(YourDataTable.Rows[i][4]) * (Convert.ToDouble(YourDataTable.Rows[i][5]) / 100f), 2, MidpointRounding.AwayFromZero);
                newTable.Cell(newTable.Rows.Count, 8).Range.Text = Math.Round(Convert.ToDouble(YourDataTable.Rows[i][6]), 2, MidpointRounding.AwayFromZero).ToString("F");

                newTable.Rows.Add();
            }

            newTable.Columns[1].PreferredWidth = 30;
            newTable.Columns[2].PreferredWidth = 600;
            newTable.Columns[3].PreferredWidth = 30;
            newTable.Columns[4].PreferredWidth = 90;
            newTable.Columns[5].PreferredWidth = 120;
            newTable.Columns[6].PreferredWidth = 30;
            newTable.Columns[7].PreferredWidth = 120;


            foreach (Row row in newTable.Rows)
            {

                foreach (Cell cell in row.Cells)
                {
                    //Header row
                    if (cell.RowIndex == 1)
                    {
                        cell.Range.Font.Bold = 1;
                        //other format properties goes here
                        cell.Range.Font.Name = "Times";
                        cell.Range.Font.Size = 10;
                        //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
                        cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                        //Center alignment for the Header cells
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    }

                    //Data row
                    else
                    {
                        row.Alignment = WdRowAlignment.wdAlignRowLeft;
                        object start5 = cell.Range.Start;
                        object end5 = cell.Range.End;
                        Range cellformat = document.Range(ref start5, ref end5);
                        cellformat.Font.Name = "Times";
                        cellformat.Font.Size = 9;
                        cellformat.Font.Bold = 0;
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    }
                }
            }

            //Total amounts and other discount related things..
            Paragraph totalamt = document.Content.Paragraphs.Add(ref missing);
            totalamt.Range.Text = "\v\v Total Gross Amount : "+ Math.Round(total_gross, 2, MidpointRounding.AwayFromZero).ToString("F") + "\vTotal Tax Amount : " + Math.Round(total_tax,2,MidpointRounding.AwayFromZero).ToString("F")+"\v\vGrand Total : " + Math.Round(TotalAmt, 2, MidpointRounding.AwayFromZero).ToString("F");
            totalamt.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            object start6 = totalamt.Range.Start;
            object end6 = totalamt.Range.End;
            Range rng6 = document.Range(ref start6, ref end6);
            rng6.Font.Name = "Agency FB";
            rng6.Font.Bold = 0;
            rng6.Font.Size = 9;
            rng6.InsertParagraphAfter();




            //Declaration
            Paragraph declaration = document.Content.Paragraphs.Add(ref missing);
            declaration.Range.Text = "\v\v\vDECLARATION \vCertified that all the particulars shown in the above Tax invioce are true and correct in all respects and the goods on which the tax charged and collected are in accordance with the provisions of the KVAT ACT 2003 and the rules made thereunder. It is also certified that my/our Registration under KVAT Act 2003 is not subject to any suspension/cancellation and it is valid as on date of this bill.";
            object start11 = declaration.Range.Start;
            object end11 = declaration.Range.End;
            Range rng11 = document.Range(ref start11, ref end11);
            rng11.Font.Name = "Agency FB";
            rng11.Font.Size = 10;
            rng11.Font.Bold = 0;
            declaration.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            declaration.Range.InsertParagraphAfter();


            Paragraph MariyaSign = document.Content.Paragraphs.Add(ref missing);
            MariyaSign.Range.Text = "\v\v For MARIYA AGENCIES\v\v\vAuthorised Signatory";
            MariyaSign.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            document.PrintOut(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing);
            //Save the document
            object fileFormat = WdSaveFormat.wdFormatPDF;
            //object filename = System.Windows.Forms.Application.StartupPath + "/" + invoice + ".pdf";
            object filename = ConfigurationManager.AppSettings["output"] + invoice + ".pdf";
            document.SaveAs(ref filename, ref fileFormat);
            object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
            ((_Document)document).Close(ref saveChanges, ref oMissing, ref oMissing);
            document = null;
            winword.Quit(ref missing, ref missing, ref missing);
            winword = null;
            //----------------DOC creation ends---------------------//



        }
    }
}