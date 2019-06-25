namespace pro1
{
    partial class history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            this.todate = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new pro1.stockDataSet();
            this.stockdbTableAdapter = new pro1.stockDataSetTableAdapters.stockdbTableAdapter();
            this.b1cart = new System.Windows.Forms.Button();
            this.b2status = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.l2 = new System.Windows.Forms.Label();
            this.l1cd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // todate
            // 
            this.todate.AutoSize = true;
            this.todate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todate.Location = new System.Drawing.Point(693, 55);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(89, 26);
            this.todate.TabIndex = 0;
            this.todate.Text = "To Date:";
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "yyyy-MM-dd";
            this.dt1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(266, 49);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(220, 34);
            this.dt1.TabIndex = 1;
            this.dt1.Value = new System.DateTime(2019, 4, 19, 13, 12, 9, 0);
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "yyyy-MM-dd";
            this.dt2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(798, 49);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(196, 34);
            this.dt2.TabIndex = 3;
            this.dt2.Value = new System.DateTime(2019, 4, 19, 13, 12, 28, 0);
            // 
            // fromdate
            // 
            this.fromdate.AutoSize = true;
            this.fromdate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromdate.Location = new System.Drawing.Point(117, 57);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(112, 26);
            this.fromdate.TabIndex = 2;
            this.fromdate.Text = "From Date:";
            this.fromdate.Click += new System.EventHandler(this.fromdate_Click);
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Blue;
            this.find.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.ForeColor = System.Drawing.Color.White;
            this.find.Location = new System.Drawing.Point(1068, 20);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(244, 76);
            this.find.TabIndex = 4;
            this.find.Text = "Search Record";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockdbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(888, 473);
            this.dataGridView1.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Chemical Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockdbBindingSource
            // 
            this.stockdbBindingSource.DataMember = "stockdb";
            this.stockdbBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "stockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockdbTableAdapter
            // 
            this.stockdbTableAdapter.ClearBeforeFill = true;
            // 
            // b1cart
            // 
            this.b1cart.BackColor = System.Drawing.Color.Blue;
            this.b1cart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1cart.ForeColor = System.Drawing.Color.White;
            this.b1cart.Location = new System.Drawing.Point(1068, 210);
            this.b1cart.Name = "b1cart";
            this.b1cart.Size = new System.Drawing.Size(244, 75);
            this.b1cart.TabIndex = 8;
            this.b1cart.Text = "Print";
            this.b1cart.UseVisualStyleBackColor = false;
            this.b1cart.Click += new System.EventHandler(this.b1cart_Click);
            // 
            // b2status
            // 
            this.b2status.BackColor = System.Drawing.Color.Blue;
            this.b2status.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2status.ForeColor = System.Drawing.Color.White;
            this.b2status.Location = new System.Drawing.Point(1068, 114);
            this.b2status.Name = "b2status";
            this.b2status.Size = new System.Drawing.Size(244, 79);
            this.b2status.TabIndex = 7;
            this.b2status.Text = "Export to excel";
            this.b2status.UseVisualStyleBackColor = false;
            this.b2status.Click += new System.EventHandler(this.b2status_Click);
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
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(283, 616);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 29);
            this.l2.TabIndex = 21;
            // 
            // l1cd
            // 
            this.l1cd.AutoSize = true;
            this.l1cd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1cd.Location = new System.Drawing.Point(114, 616);
            this.l1cd.Name = "l1cd";
            this.l1cd.Size = new System.Drawing.Size(153, 29);
            this.l1cd.TabIndex = 20;
            this.l1cd.Text = "Record Found:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::pro1.Properties.Resources.i2;
            this.pictureBox1.Location = new System.Drawing.Point(1014, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 279);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(1362, 685);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1cd);
            this.Controls.Add(this.b1cart);
            this.Controls.Add(this.b2status);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.find);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.fromdate);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.todate);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todate;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Label fromdate;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private stockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource stockdbBindingSource;
        private stockDataSetTableAdapters.stockdbTableAdapter stockdbTableAdapter;
        private System.Windows.Forms.Button b1cart;
        private System.Windows.Forms.Button b2status;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1cd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}