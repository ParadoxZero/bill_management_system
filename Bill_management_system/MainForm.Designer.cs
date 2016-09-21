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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tab_view = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Progress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.stock_datagrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.db_change_history_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.item_box_combo = new System.Windows.Forms.ComboBox();
            this.stock_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.bill_save_folder_browser = new System.Windows.Forms.FolderBrowserDialog();
            this.backup_folder_browser = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.reset_update_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tax_tb = new System.Windows.Forms.TextBox();
            this.tab_view.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_datagrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_view
            // 
            this.tab_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_view.Controls.Add(this.tabPage1);
            this.tab_view.Controls.Add(this.tabPage5);
            this.tab_view.Controls.Add(this.tabPage2);
            this.tab_view.Controls.Add(this.tabPage3);
            this.tab_view.Controls.Add(this.tabPage4);
            this.tab_view.Location = new System.Drawing.Point(0, 2);
            this.tab_view.Margin = new System.Windows.Forms.Padding(0);
            this.tab_view.Name = "tab_view";
            this.tab_view.Padding = new System.Drawing.Point(10, 10);
            this.tab_view.SelectedIndex = 0;
            this.tab_view.Size = new System.Drawing.Size(1011, 583);
            this.tab_view.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Progress);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.customer_name);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1003, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Bill";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Location = new System.Drawing.Point(369, 42);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(0, 15);
            this.Progress.TabIndex = 15;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(348, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(416, 43);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Customer name";
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(515, 39);
            this.customer_name.Margin = new System.Windows.Forms.Padding(2);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(305, 20);
            this.customer_name.TabIndex = 12;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(868, 33);
            this.print_btn.Margin = new System.Windows.Forms.Padding(2);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(56, 29);
            this.print_btn.TabIndex = 11;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_click);
            // 
            // invoice_textbox
            // 
            this.invoice_textbox.Location = new System.Drawing.Point(868, 6);
            this.invoice_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.invoice_textbox.Name = "invoice_textbox";
            this.invoice_textbox.Size = new System.Drawing.Size(98, 20);
            this.invoice_textbox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(824, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Invoice";
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(636, 6);
            this.date_picker.Margin = new System.Windows.Forms.Padding(2);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(184, 20);
            this.date_picker.TabIndex = 8;
            // 
            // cust_tin_textbox
            // 
            this.cust_tin_textbox.Location = new System.Drawing.Point(515, 6);
            this.cust_tin_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.cust_tin_textbox.Name = "cust_tin_textbox";
            this.cust_tin_textbox.Size = new System.Drawing.Size(117, 20);
            this.cust_tin_textbox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
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
            this.data_items.Location = new System.Drawing.Point(5, 72);
            this.data_items.Margin = new System.Windows.Forms.Padding(2);
            this.data_items.Name = "data_items";
            this.data_items.RowTemplate.Height = 24;
            this.data_items.Size = new System.Drawing.Size(994, 470);
            this.data_items.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item";
            // 
            // select_bill_item
            // 
            this.select_bill_item.AutoSize = true;
            this.select_bill_item.Location = new System.Drawing.Point(369, 4);
            this.select_bill_item.Margin = new System.Windows.Forms.Padding(2);
            this.select_bill_item.Name = "select_bill_item";
            this.select_bill_item.Size = new System.Drawing.Size(58, 29);
            this.select_bill_item.TabIndex = 2;
            this.select_bill_item.Text = "Add";
            this.select_bill_item.UseVisualStyleBackColor = true;
            this.select_bill_item.Click += new System.EventHandler(this.add_bill_item_click);
            // 
            // qty_textbox
            // 
            this.qty_textbox.Location = new System.Drawing.Point(282, 5);
            this.qty_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.qty_textbox.Name = "qty_textbox";
            this.qty_textbox.Size = new System.Drawing.Size(76, 20);
            this.qty_textbox.TabIndex = 1;
            this.qty_textbox.Text = "1";
            // 
            // bill_items_combo
            // 
            this.bill_items_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bill_items_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bill_items_combo.FormattingEnabled = true;
            this.bill_items_combo.Location = new System.Drawing.Point(37, 4);
            this.bill_items_combo.Margin = new System.Windows.Forms.Padding(2);
            this.bill_items_combo.Name = "bill_items_combo";
            this.bill_items_combo.Size = new System.Drawing.Size(214, 21);
            this.bill_items_combo.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.stock_datagrid);
            this.tabPage5.Location = new System.Drawing.Point(4, 36);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1003, 543);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Stock";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // stock_datagrid
            // 
            this.stock_datagrid.AllowUserToAddRows = false;
            this.stock_datagrid.AllowUserToDeleteRows = false;
            this.stock_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stock_datagrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.stock_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock_datagrid.Location = new System.Drawing.Point(0, 0);
            this.stock_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.stock_datagrid.Name = "stock_datagrid";
            this.stock_datagrid.ReadOnly = true;
            this.stock_datagrid.RowTemplate.Height = 24;
            this.stock_datagrid.Size = new System.Drawing.Size(1003, 543);
            this.stock_datagrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1003, 543);
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
            this.panel2.Controls.Add(this.tax_tb);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.reset_update_btn);
            this.panel2.Controls.Add(this.db_change_history_label);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.item_box_combo);
            this.panel2.Controls.Add(this.stock_textbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.delete_btn);
            this.panel2.Controls.Add(this.select);
            this.panel2.Controls.Add(this.update_db);
            this.panel2.Controls.Add(this.item_name_textbox);
            this.panel2.Controls.Add(this.item_price_textbox);
            this.panel2.Location = new System.Drawing.Point(15, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 259);
            this.panel2.TabIndex = 8;
            // 
            // db_change_history_label
            // 
            this.db_change_history_label.AutoSize = true;
            this.db_change_history_label.Location = new System.Drawing.Point(99, 120);
            this.db_change_history_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.db_change_history_label.Name = "db_change_history_label";
            this.db_change_history_label.Size = new System.Drawing.Size(0, 15);
            this.db_change_history_label.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name";
            // 
            // item_box_combo
            // 
            this.item_box_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.item_box_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.item_box_combo.FormattingEnabled = true;
            this.item_box_combo.Location = new System.Drawing.Point(99, 52);
            this.item_box_combo.Margin = new System.Windows.Forms.Padding(2);
            this.item_box_combo.Name = "item_box_combo";
            this.item_box_combo.Size = new System.Drawing.Size(188, 21);
            this.item_box_combo.TabIndex = 0;
            // 
            // stock_textbox
            // 
            this.stock_textbox.Location = new System.Drawing.Point(502, 89);
            this.stock_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.stock_textbox.Name = "stock_textbox";
            this.stock_textbox.Size = new System.Drawing.Size(76, 20);
            this.stock_textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Item";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(200, 170);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(86, 50);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Delete Entry";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Visible = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(291, 44);
            this.select.Margin = new System.Windows.Forms.Padding(2);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(56, 29);
            this.select.TabIndex = 2;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // update_db
            // 
            this.update_db.Location = new System.Drawing.Point(100, 171);
            this.update_db.Margin = new System.Windows.Forms.Padding(2);
            this.update_db.Name = "update_db";
            this.update_db.Size = new System.Drawing.Size(94, 49);
            this.update_db.TabIndex = 5;
            this.update_db.Text = "Add";
            this.update_db.UseVisualStyleBackColor = true;
            this.update_db.Click += new System.EventHandler(this.update_db_Click);
            // 
            // item_name_textbox
            // 
            this.item_name_textbox.Location = new System.Drawing.Point(99, 89);
            this.item_name_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.item_name_textbox.Name = "item_name_textbox";
            this.item_name_textbox.Size = new System.Drawing.Size(249, 20);
            this.item_name_textbox.TabIndex = 3;
            // 
            // item_price_textbox
            // 
            this.item_price_textbox.Location = new System.Drawing.Point(386, 89);
            this.item_price_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.item_price_textbox.Name = "item_price_textbox";
            this.item_price_textbox.Size = new System.Drawing.Size(76, 20);
            this.item_price_textbox.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1003, 543);
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
            this.groupBox2.Location = new System.Drawing.Point(338, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(262, 232);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local Settings";
            // 
            // path_display_label
            // 
            this.path_display_label.AutoSize = true;
            this.path_display_label.Location = new System.Drawing.Point(20, 70);
            this.path_display_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.path_display_label.Name = "path_display_label";
            this.path_display_label.Size = new System.Drawing.Size(0, 15);
            this.path_display_label.TabIndex = 10;
            // 
            // local_settings_save_btn
            // 
            this.local_settings_save_btn.Location = new System.Drawing.Point(38, 133);
            this.local_settings_save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.local_settings_save_btn.Name = "local_settings_save_btn";
            this.local_settings_save_btn.Size = new System.Drawing.Size(75, 35);
            this.local_settings_save_btn.TabIndex = 9;
            this.local_settings_save_btn.Text = "Save";
            this.local_settings_save_btn.UseVisualStyleBackColor = true;
            this.local_settings_save_btn.Click += new System.EventHandler(this.local_settings_save_btn_Click);
            // 
            // select_folder_btn
            // 
            this.select_folder_btn.Location = new System.Drawing.Point(159, 25);
            this.select_folder_btn.Margin = new System.Windows.Forms.Padding(2);
            this.select_folder_btn.Name = "select_folder_btn";
            this.select_folder_btn.Size = new System.Drawing.Size(68, 37);
            this.select_folder_btn.TabIndex = 7;
            this.select_folder_btn.Text = "Browse";
            this.select_folder_btn.UseVisualStyleBackColor = true;
            this.select_folder_btn.Click += new System.EventHandler(this.select_folder_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 15);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(325, 232);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Default Tax";
            // 
            // default_tax_textbox
            // 
            this.default_tax_textbox.Location = new System.Drawing.Point(106, 25);
            this.default_tax_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.default_tax_textbox.Name = "default_tax_textbox";
            this.default_tax_textbox.Size = new System.Drawing.Size(127, 20);
            this.default_tax_textbox.TabIndex = 1;
            // 
            // default_tin_textbox
            // 
            this.default_tin_textbox.Location = new System.Drawing.Point(106, 66);
            this.default_tin_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.default_tin_textbox.Name = "default_tin_textbox";
            this.default_tin_textbox.Size = new System.Drawing.Size(127, 20);
            this.default_tin_textbox.TabIndex = 6;
            // 
            // db_backup_btn
            // 
            this.db_backup_btn.Location = new System.Drawing.Point(40, 173);
            this.db_backup_btn.Margin = new System.Windows.Forms.Padding(2);
            this.db_backup_btn.Name = "db_backup_btn";
            this.db_backup_btn.Size = new System.Drawing.Size(109, 35);
            this.db_backup_btn.TabIndex = 2;
            this.db_backup_btn.Text = "Back up databaase";
            this.db_backup_btn.UseVisualStyleBackColor = true;
            this.db_backup_btn.Click += new System.EventHandler(this.db_backup_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Your TIN";
            // 
            // save_config_btn
            // 
            this.save_config_btn.Location = new System.Drawing.Point(40, 133);
            this.save_config_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_config_btn.Name = "save_config_btn";
            this.save_config_btn.Size = new System.Drawing.Size(56, 35);
            this.save_config_btn.TabIndex = 4;
            this.save_config_btn.Text = "Save";
            this.save_config_btn.UseVisualStyleBackColor = true;
            this.save_config_btn.Click += new System.EventHandler(this.save_config_btn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1003, 543);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 231);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bill \'n Stock\r\nVersion 1.0.0.0\r\nShift2Cloud Software Solutions\r\n\r\ncopyright © 201" +
    "6 Shift2Cloud\r\n\r\nAll rights reserved\r\n";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // reset_update_btn
            // 
            this.reset_update_btn.Location = new System.Drawing.Point(292, 171);
            this.reset_update_btn.Name = "reset_update_btn";
            this.reset_update_btn.Size = new System.Drawing.Size(84, 49);
            this.reset_update_btn.TabIndex = 12;
            this.reset_update_btn.Text = "Reset";
            this.reset_update_btn.UseVisualStyleBackColor = true;
            this.reset_update_btn.Visible = false;
            this.reset_update_btn.Click += new System.EventHandler(this.reset_update_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(584, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Tax";
            // 
            // tax_tb
            // 
            this.tax_tb.Location = new System.Drawing.Point(618, 90);
            this.tax_tb.Name = "tax_tb";
            this.tax_tb.Size = new System.Drawing.Size(100, 20);
            this.tax_tb.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 586);
            this.Controls.Add(this.tab_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mariya Agencies";
            this.tab_view.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stock_datagrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_view;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button select_bill_item;
        private System.Windows.Forms.TextBox qty_textbox;
        private System.Windows.Forms.ComboBox bill_items_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_items;
        private System.Windows.Forms.Button update_db;
        private System.Windows.Forms.TextBox item_price_textbox;
        private System.Windows.Forms.TextBox item_name_textbox;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox item_box_combo;
        private System.Windows.Forms.Button delete_btn;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView stock_datagrid;
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button reset_update_btn;
        private System.Windows.Forms.TextBox tax_tb;
        private System.Windows.Forms.Label label14;
    }
}