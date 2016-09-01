namespace Bill_management_system
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_view = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.print_btn = new System.Windows.Forms.Button();
            this.invoice_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.cust_tin_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.data_items = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.select_bill_item = new System.Windows.Forms.Button();
            this.qty_textbox = new System.Windows.Forms.TextBox();
            this.bill_items_combo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.db_change_history_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.item_box_combo = new System.Windows.Forms.ComboBox();
            this.stock_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.update_db = new System.Windows.Forms.Button();
            this.item_name_textbox = new System.Windows.Forms.TextBox();
            this.item_price_textbox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.path_display_label = new System.Windows.Forms.Label();
            this.local_settings_save_btn = new System.Windows.Forms.Button();
            this.select_folder_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.default_tax_textbox = new System.Windows.Forms.TextBox();
            this.default_tin_textbox = new System.Windows.Forms.TextBox();
            this.db_backup_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.save_config_btn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bill_save_folder_browser = new System.Windows.Forms.FolderBrowserDialog();
            this.backup_folder_browser = new System.Windows.Forms.FolderBrowserDialog();
            this.tab_view.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_view
            // 
            this.tab_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_view.Controls.Add(this.tabPage1);
            this.tab_view.Controls.Add(this.tabPage2);
            this.tab_view.Controls.Add(this.tabPage3);
            this.tab_view.Location = new System.Drawing.Point(0, 45);
            this.tab_view.Margin = new System.Windows.Forms.Padding(0);
            this.tab_view.Name = "tab_view";
            this.tab_view.Padding = new System.Drawing.Point(10, 10);
            this.tab_view.SelectedIndex = 0;
            this.tab_view.Size = new System.Drawing.Size(1488, 503);
            this.tab_view.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.print_btn);
            this.tabPage1.Controls.Add(this.invoice_textbox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.date_picker);
            this.tabPage1.Controls.Add(this.cust_tin_textbox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.data_items);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.select_bill_item);
            this.tabPage1.Controls.Add(this.qty_textbox);
            this.tabPage1.Controls.Add(this.bill_items_combo);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1480, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Bill";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(1292, 5);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(75, 36);
            this.print_btn.TabIndex = 11;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_click);
            // 
            // invoice_textbox
            // 
            this.invoice_textbox.Location = new System.Drawing.Point(1157, 7);
            this.invoice_textbox.Name = "invoice_textbox";
            this.invoice_textbox.Size = new System.Drawing.Size(129, 22);
            this.invoice_textbox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1098, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Invoice";
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(848, 8);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(244, 22);
            this.date_picker.TabIndex = 8;
            // 
            // cust_tin_textbox
            // 
            this.cust_tin_textbox.Location = new System.Drawing.Point(687, 8);
            this.cust_tin_textbox.Name = "cust_tin_textbox";
            this.cust_tin_textbox.Size = new System.Drawing.Size(155, 22);
            this.cust_tin_textbox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Customer Tin";
            // 
            // data_items
            // 
            this.data_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_items.BackgroundColor = System.Drawing.Color.White;
            this.data_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_items.Location = new System.Drawing.Point(7, 47);
            this.data_items.Name = "data_items";
            this.data_items.RowTemplate.Height = 24;
            this.data_items.Size = new System.Drawing.Size(1465, 405);
            this.data_items.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item";
            // 
            // select_bill_item
            // 
            this.select_bill_item.AutoSize = true;
            this.select_bill_item.Location = new System.Drawing.Point(492, 5);
            this.select_bill_item.Name = "select_bill_item";
            this.select_bill_item.Size = new System.Drawing.Size(90, 36);
            this.select_bill_item.TabIndex = 2;
            this.select_bill_item.Text = "Add";
            this.select_bill_item.UseVisualStyleBackColor = true;
            this.select_bill_item.Click += new System.EventHandler(this.add_bill_item_click);
            // 
            // qty_textbox
            // 
            this.qty_textbox.Location = new System.Drawing.Point(376, 6);
            this.qty_textbox.Name = "qty_textbox";
            this.qty_textbox.Size = new System.Drawing.Size(100, 22);
            this.qty_textbox.TabIndex = 1;
            this.qty_textbox.Text = "1";
            // 
            // bill_items_combo
            // 
            this.bill_items_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bill_items_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bill_items_combo.FormattingEnabled = true;
            this.bill_items_combo.Location = new System.Drawing.Point(49, 5);
            this.bill_items_combo.Name = "bill_items_combo";
            this.bill_items_combo.Size = new System.Drawing.Size(284, 24);
            this.bill_items_combo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1480, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.db_change_history_label);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.item_box_combo);
            this.panel2.Controls.Add(this.stock_textbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.select);
            this.panel2.Controls.Add(this.update_db);
            this.panel2.Controls.Add(this.item_name_textbox);
            this.panel2.Controls.Add(this.item_price_textbox);
            this.panel2.Location = new System.Drawing.Point(20, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 318);
            this.panel2.TabIndex = 8;
            // 
            // db_change_history_label
            // 
            this.db_change_history_label.AutoSize = true;
            this.db_change_history_label.Location = new System.Drawing.Point(132, 148);
            this.db_change_history_label.Name = "db_change_history_label";
            this.db_change_history_label.Size = new System.Drawing.Size(0, 17);
            this.db_change_history_label.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(621, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name";
            // 
            // item_box_combo
            // 
            this.item_box_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.item_box_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.item_box_combo.FormattingEnabled = true;
            this.item_box_combo.Location = new System.Drawing.Point(132, 64);
            this.item_box_combo.Name = "item_box_combo";
            this.item_box_combo.Size = new System.Drawing.Size(249, 24);
            this.item_box_combo.TabIndex = 0;
            // 
            // stock_textbox
            // 
            this.stock_textbox.Location = new System.Drawing.Point(670, 109);
            this.stock_textbox.Name = "stock_textbox";
            this.stock_textbox.Size = new System.Drawing.Size(100, 22);
            this.stock_textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Item";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(266, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.delete_btn_click);
            // 
            // select
            // 
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select.Location = new System.Drawing.Point(388, 54);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 36);
            this.select.TabIndex = 2;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // update_db
            // 
            this.update_db.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_db.Location = new System.Drawing.Point(134, 210);
            this.update_db.Name = "update_db";
            this.update_db.Size = new System.Drawing.Size(126, 60);
            this.update_db.TabIndex = 5;
            this.update_db.Text = "Add/Update";
            this.update_db.UseVisualStyleBackColor = true;
            this.update_db.Click += new System.EventHandler(this.update_db_Click);
            // 
            // item_name_textbox
            // 
            this.item_name_textbox.Location = new System.Drawing.Point(132, 109);
            this.item_name_textbox.Name = "item_name_textbox";
            this.item_name_textbox.Size = new System.Drawing.Size(331, 22);
            this.item_name_textbox.TabIndex = 3;
            // 
            // item_price_textbox
            // 
            this.item_price_textbox.Location = new System.Drawing.Point(514, 109);
            this.item_price_textbox.Name = "item_price_textbox";
            this.item_price_textbox.Size = new System.Drawing.Size(100, 22);
            this.item_price_textbox.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1480, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.path_display_label);
            this.groupBox2.Controls.Add(this.local_settings_save_btn);
            this.groupBox2.Controls.Add(this.select_folder_btn);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(450, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 286);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local Settings";
            // 
            // path_display_label
            // 
            this.path_display_label.AutoSize = true;
            this.path_display_label.Location = new System.Drawing.Point(27, 86);
            this.path_display_label.Name = "path_display_label";
            this.path_display_label.Size = new System.Drawing.Size(0, 17);
            this.path_display_label.TabIndex = 10;
            // 
            // local_settings_save_btn
            // 
            this.local_settings_save_btn.Location = new System.Drawing.Point(50, 164);
            this.local_settings_save_btn.Name = "local_settings_save_btn";
            this.local_settings_save_btn.Size = new System.Drawing.Size(100, 43);
            this.local_settings_save_btn.TabIndex = 9;
            this.local_settings_save_btn.Text = "Save";
            this.local_settings_save_btn.UseVisualStyleBackColor = true;
            this.local_settings_save_btn.Click += new System.EventHandler(this.local_settings_save_btn_Click);
            // 
            // select_folder_btn
            // 
            this.select_folder_btn.Location = new System.Drawing.Point(212, 31);
            this.select_folder_btn.Name = "select_folder_btn";
            this.select_folder_btn.Size = new System.Drawing.Size(91, 45);
            this.select_folder_btn.TabIndex = 7;
            this.select_folder_btn.Text = "Browse";
            this.select_folder_btn.UseVisualStyleBackColor = true;
            this.select_folder_btn.Click += new System.EventHandler(this.select_folder_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Select Bill save location";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.default_tax_textbox);
            this.groupBox1.Controls.Add(this.default_tin_textbox);
            this.groupBox1.Controls.Add(this.db_backup_btn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.save_config_btn);
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 286);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Default Tax";
            // 
            // default_tax_textbox
            // 
            this.default_tax_textbox.Location = new System.Drawing.Point(142, 31);
            this.default_tax_textbox.Name = "default_tax_textbox";
            this.default_tax_textbox.Size = new System.Drawing.Size(168, 22);
            this.default_tax_textbox.TabIndex = 1;
            // 
            // default_tin_textbox
            // 
            this.default_tin_textbox.Location = new System.Drawing.Point(142, 81);
            this.default_tin_textbox.Name = "default_tin_textbox";
            this.default_tin_textbox.Size = new System.Drawing.Size(168, 22);
            this.default_tin_textbox.TabIndex = 6;
            // 
            // db_backup_btn
            // 
            this.db_backup_btn.Location = new System.Drawing.Point(53, 213);
            this.db_backup_btn.Name = "db_backup_btn";
            this.db_backup_btn.Size = new System.Drawing.Size(145, 43);
            this.db_backup_btn.TabIndex = 2;
            this.db_backup_btn.Text = "Back up databaase";
            this.db_backup_btn.UseVisualStyleBackColor = true;
            this.db_backup_btn.Click += new System.EventHandler(this.db_backup_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Your TIN";
            // 
            // save_config_btn
            // 
            this.save_config_btn.Location = new System.Drawing.Point(53, 164);
            this.save_config_btn.Name = "save_config_btn";
            this.save_config_btn.Size = new System.Drawing.Size(75, 43);
            this.save_config_btn.TabIndex = 4;
            this.save_config_btn.Text = "Save";
            this.save_config_btn.UseVisualStyleBackColor = true;
            this.save_config_btn.Click += new System.EventHandler(this.save_config_btn_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.IndianRed;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(1438, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 45);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 45);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mariya Agencies";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tab_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tab_view.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_view;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button select_bill_item;
        private System.Windows.Forms.TextBox qty_textbox;
        private System.Windows.Forms.ComboBox bill_items_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_items;
        private System.Windows.Forms.Button update_db;
        private System.Windows.Forms.TextBox item_price_textbox;
        private System.Windows.Forms.TextBox item_name_textbox;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox item_box_combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox default_tin_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_config_btn;
        private System.Windows.Forms.Button db_backup_btn;
        private System.Windows.Forms.TextBox default_tax_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.TextBox invoice_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.TextBox cust_tin_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stock_textbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button select_folder_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog bill_save_folder_browser;
        private System.Windows.Forms.Button local_settings_save_btn;
        private System.Windows.Forms.Label path_display_label;
        private System.Windows.Forms.Label db_change_history_label;
        private System.Windows.Forms.FolderBrowserDialog backup_folder_browser;
    }
}