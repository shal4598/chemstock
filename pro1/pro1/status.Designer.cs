namespace pro1
{
    partial class status
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(status));
            this.l1status = new System.Windows.Forms.Label();
            this.b1status = new System.Windows.Forms.Button();
            this.gvstatus = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcart = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1cart = new System.Windows.Forms.Button();
            this.b2status = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l1status
            // 
            this.l1status.AutoSize = true;
            this.l1status.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1status.Location = new System.Drawing.Point(33, 616);
            this.l1status.Name = "l1status";
            this.l1status.Size = new System.Drawing.Size(205, 26);
            this.l1status.TabIndex = 1;
            this.l1status.Text = "Total no of chemicals:";
            // 
            // b1status
            // 
            this.b1status.BackColor = System.Drawing.Color.Blue;
            this.b1status.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1status.ForeColor = System.Drawing.Color.White;
            this.b1status.Location = new System.Drawing.Point(664, 35);
            this.b1status.Name = "b1status";
            this.b1status.Size = new System.Drawing.Size(209, 64);
            this.b1status.TabIndex = 2;
            this.b1status.Text = "Add to cart";
            this.b1status.UseVisualStyleBackColor = false;
            this.b1status.Click += new System.EventHandler(this.b1status_Click);
            // 
            // gvstatus
            // 
            this.gvstatus.AllowUserToAddRows = false;
            this.gvstatus.AllowUserToDeleteRows = false;
            this.gvstatus.BackgroundColor = System.Drawing.Color.White;
            this.gvstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvstatus.ColumnHeadersHeight = 28;
            this.gvstatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvstatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name,
            this.stock,
            this.type});
            this.gvstatus.Location = new System.Drawing.Point(38, 35);
            this.gvstatus.Name = "gvstatus";
            this.gvstatus.ReadOnly = true;
            this.gvstatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvstatus.Size = new System.Drawing.Size(596, 553);
            this.gvstatus.TabIndex = 3;
            this.gvstatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvstatus_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Chemical Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // gvcart
            // 
            this.gvcart.AllowUserToAddRows = false;
            this.gvcart.AllowUserToDeleteRows = false;
            this.gvcart.AllowUserToResizeColumns = false;
            this.gvcart.AllowUserToResizeRows = false;
            this.gvcart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvcart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvcart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gvcart.ColumnHeadersHeight = 28;
            this.gvcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvcart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c3});
            this.gvcart.Location = new System.Drawing.Point(919, 35);
            this.gvcart.Name = "gvcart";
            this.gvcart.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvcart.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvcart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gvcart.ShowEditingIcon = false;
            this.gvcart.Size = new System.Drawing.Size(406, 568);
            this.gvcart.TabIndex = 4;
            this.gvcart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvcart_CellContentClick);
            // 
            // c1
            // 
            this.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c1.HeaderText = "Chemical Name";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            // 
            // c3
            // 
            this.c3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c3.HeaderText = "Type";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            // 
            // b1cart
            // 
            this.b1cart.BackColor = System.Drawing.Color.Blue;
            this.b1cart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1cart.ForeColor = System.Drawing.Color.White;
            this.b1cart.Location = new System.Drawing.Point(664, 218);
            this.b1cart.Name = "b1cart";
            this.b1cart.Size = new System.Drawing.Size(209, 68);
            this.b1cart.TabIndex = 6;
            this.b1cart.Text = "Print";
            this.b1cart.UseVisualStyleBackColor = false;
            this.b1cart.Click += new System.EventHandler(this.b1cart_Click);
            // 
            // b2status
            // 
            this.b2status.BackColor = System.Drawing.Color.Blue;
            this.b2status.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2status.ForeColor = System.Drawing.Color.White;
            this.b2status.Location = new System.Drawing.Point(664, 123);
            this.b2status.Name = "b2status";
            this.b2status.Size = new System.Drawing.Size(209, 68);
            this.b2status.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label1.Location = new System.Drawing.Point(232, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pro1.Properties.Resources.desktopicon;
            this.pictureBox1.Location = new System.Drawing.Point(640, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(1362, 685);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b1cart);
            this.Controls.Add(this.b2status);
            this.Controls.Add(this.gvcart);
            this.Controls.Add(this.gvstatus);
            this.Controls.Add(this.b1status);
            this.Controls.Add(this.l1status);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "status";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Status";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1status;
        private System.Windows.Forms.Button b1status;
        private System.Windows.Forms.DataGridView gvstatus;
        private System.Windows.Forms.DataGridView gvcart;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Button b1cart;
        private System.Windows.Forms.Button b2status;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}