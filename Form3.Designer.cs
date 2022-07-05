namespace MilestoneProject
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ITEM_NAME = new System.Windows.Forms.TextBox();
            this.dSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMilestoneDataSet = new MilestoneProject.InventoryMilestoneDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.ITEM_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EACH_QUANTITY_IN_STOCK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.COST_CASE = new System.Windows.Forms.TextBox();
            this.CASE_QUANTITY_IN_STOCK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EACH_CASE_QUANTITY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BASE_UNIT_OF_MEASURE = new System.Windows.Forms.TextBox();
            this.VENDOR = new System.Windows.Forms.TextBox();
            this.STORAGE_LOCATION = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.addNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dSTableAdapter = new MilestoneProject.InventoryMilestoneDataSetTableAdapters.DSTableAdapter();
            this.tableAdapterManager = new MilestoneProject.InventoryMilestoneDataSetTableAdapters.TableAdapterManager();
            this.previousPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMilestoneDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 61;
            this.label2.Text = "Item Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Item ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Item Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 64;
            this.label4.Text = "Storage Location:";
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSBindingSource, "ITEM_NAME", true));
            this.ITEM_NAME.Location = new System.Drawing.Point(169, 113);
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.Size = new System.Drawing.Size(186, 20);
            this.ITEM_NAME.TabIndex = 65;
            // 
            // dSBindingSource
            // 
            this.dSBindingSource.DataMember = "DS";
            this.dSBindingSource.DataSource = this.inventoryMilestoneDataSet;
            // 
            // inventoryMilestoneDataSet
            // 
            this.inventoryMilestoneDataSet.DataSetName = "InventoryMilestoneDataSet";
            this.inventoryMilestoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(361, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 22);
            this.label10.TabIndex = 78;
            this.label10.Text = "Base Unit:";
            // 
            // ITEM_ID
            // 
            this.ITEM_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSBindingSource, "ITEM_ID", true));
            this.ITEM_ID.Location = new System.Drawing.Point(169, 69);
            this.ITEM_ID.Name = "ITEM_ID";
            this.ITEM_ID.Size = new System.Drawing.Size(186, 20);
            this.ITEM_ID.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(361, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 76;
            this.label9.Text = "Vendor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 68;
            this.label6.Text = "Cost (case):";
            // 
            // EACH_QUANTITY_IN_STOCK
            // 
            this.EACH_QUANTITY_IN_STOCK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSBindingSource, "EACH_QUANTITY_IN_STOCK", true));
            this.EACH_QUANTITY_IN_STOCK.Location = new System.Drawing.Point(574, 71);
            this.EACH_QUANTITY_IN_STOCK.Name = "EACH_QUANTITY_IN_STOCK";
            this.EACH_QUANTITY_IN_STOCK.Size = new System.Drawing.Size(181, 20);
            this.EACH_QUANTITY_IN_STOCK.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(361, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 22);
            this.label11.TabIndex = 74;
            this.label11.Text = "Case Quantity (each):";
            // 
            // COST_CASE
            // 
            this.COST_CASE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSBindingSource, "COST_CASE", true));
            this.COST_CASE.Location = new System.Drawing.Point(169, 194);
            this.COST_CASE.Name = "COST_CASE";
            this.COST_CASE.Size = new System.Drawing.Size(186, 20);
            this.COST_CASE.TabIndex = 69;
            // 
            // CASE_QUANTITY_IN_STOCK
            // 
            this.CASE_QUANTITY_IN_STOCK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSBindingSource, "CASE_QUANTITY_IN_STOCK", true));
            this.CASE_QUANTITY_IN_STOCK.Location = new System.Drawing.Point(573, 35);
            this.CASE_QUANTITY_IN_STOCK.Name = "CASE_QUANTITY_IN_STOCK";
            this.CASE_QUANTITY_IN_STOCK.Size = new System.Drawing.Size(181, 20);
            this.CASE_QUANTITY_IN_STOCK.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(361, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 22);
            this.label8.TabIndex = 70;
            this.label8.Text = "Quantity in Stock (case):";
            // 
            // EACH_CASE_QUANTITY
            // 
            this.EACH_CASE_QUANTITY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSBindingSource, "EACH_CASE_QUANTITY", true));
            this.EACH_CASE_QUANTITY.Location = new System.Drawing.Point(574, 113);
            this.EACH_CASE_QUANTITY.Name = "EACH_CASE_QUANTITY";
            this.EACH_CASE_QUANTITY.Size = new System.Drawing.Size(181, 20);
            this.EACH_CASE_QUANTITY.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(361, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 22);
            this.label7.TabIndex = 71;
            this.label7.Text = "Broken Case (each):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.BASE_UNIT_OF_MEASURE);
            this.panel1.Controls.Add(this.VENDOR);
            this.panel1.Controls.Add(this.STORAGE_LOCATION);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EACH_CASE_QUANTITY);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CASE_QUANTITY_IN_STOCK);
            this.panel1.Controls.Add(this.COST_CASE);
            this.panel1.Controls.Add(this.ITEM_NAME);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.EACH_QUANTITY_IN_STOCK);
            this.panel1.Controls.Add(this.ITEM_ID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 276);
            this.panel1.TabIndex = 80;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BASE_UNIT_OF_MEASURE
            // 
            this.BASE_UNIT_OF_MEASURE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSBindingSource, "BASE_UNIT_OF_MEASURE", true));
            this.BASE_UNIT_OF_MEASURE.Location = new System.Drawing.Point(573, 196);
            this.BASE_UNIT_OF_MEASURE.Name = "BASE_UNIT_OF_MEASURE";
            this.BASE_UNIT_OF_MEASURE.Size = new System.Drawing.Size(180, 20);
            this.BASE_UNIT_OF_MEASURE.TabIndex = 83;
            // 
            // VENDOR
            // 
            this.VENDOR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSBindingSource, "VENDOR", true));
            this.VENDOR.Location = new System.Drawing.Point(574, 152);
            this.VENDOR.Name = "VENDOR";
            this.VENDOR.Size = new System.Drawing.Size(180, 20);
            this.VENDOR.TabIndex = 82;
            // 
            // STORAGE_LOCATION
            // 
            this.STORAGE_LOCATION.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSBindingSource, "STORAGE_LOCATION", true));
            this.STORAGE_LOCATION.Location = new System.Drawing.Point(169, 154);
            this.STORAGE_LOCATION.Name = "STORAGE_LOCATION";
            this.STORAGE_LOCATION.Size = new System.Drawing.Size(186, 20);
            this.STORAGE_LOCATION.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 84;
            this.label5.Text = "Search:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(90, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(166, 20);
            this.search.TabIndex = 80;
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            // 
            // addNew
            // 
            this.addNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.addNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.addNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.addNew.ForeColor = System.Drawing.SystemColors.Window;
            this.addNew.Location = new System.Drawing.Point(9, 7);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(178, 38);
            this.addNew.TabIndex = 80;
            this.addNew.Text = "Add New";
            this.addNew.UseVisualStyleBackColor = false;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.print);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.reset);
            this.panel2.Controls.Add(this.addNew);
            this.panel2.Location = new System.Drawing.Point(781, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 275);
            this.panel2.TabIndex = 81;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Location = new System.Drawing.Point(9, 228);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(178, 38);
            this.exit.TabIndex = 83;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.delete.ForeColor = System.Drawing.SystemColors.Window;
            this.delete.Location = new System.Drawing.Point(9, 184);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(178, 38);
            this.delete.TabIndex = 82;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.print.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.print.ForeColor = System.Drawing.SystemColors.Window;
            this.print.Location = new System.Drawing.Point(9, 140);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(178, 38);
            this.print.TabIndex = 83;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.update.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.update.ForeColor = System.Drawing.SystemColors.Window;
            this.update.Location = new System.Drawing.Point(9, 52);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(178, 38);
            this.update.TabIndex = 81;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.reset.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.reset.ForeColor = System.Drawing.SystemColors.Window;
            this.reset.Location = new System.Drawing.Point(9, 96);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(178, 38);
            this.reset.TabIndex = 82;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.search);
            this.panel3.Location = new System.Drawing.Point(12, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 290);
            this.panel3.TabIndex = 82;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 239);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Click);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dSTableAdapter
            // 
            this.dSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DSTableAdapter = this.dSTableAdapter;
            this.tableAdapterManager.UpdateOrder = MilestoneProject.InventoryMilestoneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // previousPage
            // 
            this.previousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.previousPage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.previousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.previousPage.ForeColor = System.Drawing.SystemColors.Window;
            this.previousPage.Location = new System.Drawing.Point(12, 590);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(178, 38);
            this.previousPage.TabIndex = 83;
            this.previousPage.Text = "Previous Page";
            this.previousPage.UseVisualStyleBackColor = false;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 637);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMilestoneDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ITEM_NAME;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ITEM_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EACH_QUANTITY_IN_STOCK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox COST_CASE;
        private System.Windows.Forms.TextBox CASE_QUANTITY_IN_STOCK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EACH_CASE_QUANTITY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox STORAGE_LOCATION;
        private System.Windows.Forms.TextBox VENDOR;
        private System.Windows.Forms.TextBox BASE_UNIT_OF_MEASURE;
        private InventoryMilestoneDataSet inventoryMilestoneDataSet;
        private System.Windows.Forms.BindingSource dSBindingSource;
        private InventoryMilestoneDataSetTableAdapters.DSTableAdapter dSTableAdapter;
        private InventoryMilestoneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button previousPage;
    }
}