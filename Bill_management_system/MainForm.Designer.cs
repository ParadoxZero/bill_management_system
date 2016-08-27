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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.select_bill_item = new System.Windows.Forms.Button();
            this.qty = new System.Windows.Forms.TextBox();
            this.bill_item_list = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.data_items = new System.Windows.Forms.DataGridView();
            this.item_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.Item_name = new System.Windows.Forms.TextBox();
            this.item_price = new System.Windows.Forms.TextBox();
            this.update_db = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_view.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_view
            // 
            this.tab_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_view.Controls.Add(this.tabPage1);
            this.tab_view.Controls.Add(this.tabPage2);
            this.tab_view.Location = new System.Drawing.Point(0, 45);
            this.tab_view.Margin = new System.Windows.Forms.Padding(0);
            this.tab_view.Name = "tab_view";
            this.tab_view.Padding = new System.Drawing.Point(10, 10);
            this.tab_view.SelectedIndex = 0;
            this.tab_view.Size = new System.Drawing.Size(752, 459);
            this.tab_view.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.data_items);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.select_bill_item);
            this.tabPage1.Controls.Add(this.qty);
            this.tabPage1.Controls.Add(this.bill_item_list);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Bill";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.select_bill_item.Location = new System.Drawing.Point(482, 5);
            this.select_bill_item.Name = "select_bill_item";
            this.select_bill_item.Size = new System.Drawing.Size(75, 27);
            this.select_bill_item.TabIndex = 2;
            this.select_bill_item.Text = "Add";
            this.select_bill_item.UseVisualStyleBackColor = true;
            this.select_bill_item.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(376, 6);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(100, 22);
            this.qty.TabIndex = 1;
            // 
            // bill_item_list
            // 
            this.bill_item_list.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bill_item_list.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bill_item_list.FormattingEnabled = true;
            this.bill_item_list.Location = new System.Drawing.Point(49, 5);
            this.bill_item_list.Name = "bill_item_list";
            this.bill_item_list.Size = new System.Drawing.Size(284, 24);
            this.bill_item_list.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.update_db);
            this.tabPage2.Controls.Add(this.item_price);
            this.tabPage2.Controls.Add(this.Item_name);
            this.tabPage2.Controls.Add(this.select);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.item_box);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.IndianRed;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(702, 0);
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
            this.panel1.Size = new System.Drawing.Size(752, 45);
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
            // data_items
            // 
            this.data_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_items.Location = new System.Drawing.Point(7, 35);
            this.data_items.Name = "data_items";
            this.data_items.RowTemplate.Height = 24;
            this.data_items.Size = new System.Drawing.Size(729, 373);
            this.data_items.TabIndex = 5;
            // 
            // item_box
            // 
            this.item_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.item_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.item_box.FormattingEnabled = true;
            this.item_box.Location = new System.Drawing.Point(94, 4);
            this.item_box.Name = "item_box";
            this.item_box.Size = new System.Drawing.Size(249, 24);
            this.item_box.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Item";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(350, 7);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 2;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // Item_name
            // 
            this.Item_name.Location = new System.Drawing.Point(94, 49);
            this.Item_name.Name = "Item_name";
            this.Item_name.Size = new System.Drawing.Size(331, 22);
            this.Item_name.TabIndex = 3;
            // 
            // item_price
            // 
            this.item_price.Location = new System.Drawing.Point(432, 48);
            this.item_price.Name = "item_price";
            this.item_price.Size = new System.Drawing.Size(100, 22);
            this.item_price.TabIndex = 4;
            // 
            // update_db
            // 
            this.update_db.Location = new System.Drawing.Point(94, 89);
            this.update_db.Name = "update_db";
            this.update_db.Size = new System.Drawing.Size(113, 23);
            this.update_db.TabIndex = 5;
            this.update_db.Text = "Add/Update";
            this.update_db.UseVisualStyleBackColor = true;
            this.update_db.Click += new System.EventHandler(this.update_db_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tab_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tab_view.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_view;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button select_bill_item;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.ComboBox bill_item_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_items;
        private System.Windows.Forms.Button update_db;
        private System.Windows.Forms.TextBox item_price;
        private System.Windows.Forms.TextBox Item_name;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox item_box;
        private System.Windows.Forms.Button button1;
    }
}