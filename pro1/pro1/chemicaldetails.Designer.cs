namespace pro1
{
    partial class chemicaldetails
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
            this.deletebtncd = new System.Windows.Forms.Button();
            this.gcd = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new pro1.stockDataSet();
            this.clearbtncd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpadd = new System.Windows.Forms.DateTimePicker();
            this.cbadd = new System.Windows.Forms.ComboBox();
            this.lbl1add = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t1add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t2add = new System.Windows.Forms.TextBox();
            this.addbtncd = new System.Windows.Forms.Button();
            this.removeb1cd = new System.Windows.Forms.Button();
            this.searchtbcd = new System.Windows.Forms.TextBox();
            this.updatebtncd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.l1cd = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.stockdbTableAdapter = new pro1.stockDataSetTableAdapters.stockdbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletebtncd
            // 
            this.deletebtncd.BackColor = System.Drawing.Color.Aqua;
            this.deletebtncd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deletebtncd.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtncd.ForeColor = System.Drawing.Color.Black;
            this.deletebtncd.Location = new System.Drawing.Point(38, 519);
            this.deletebtncd.Name = "deletebtncd";
            this.deletebtncd.Size = new System.Drawing.Size(525, 52);
            this.deletebtncd.TabIndex = 3;
            this.deletebtncd.Text = "Delete";
            this.deletebtncd.UseVisualStyleBackColor = false;
            this.deletebtncd.Click += new System.EventHandler(this.button4_Click);
            // 
            // gcd
            // 
            this.gcd.AllowUserToAddRows = false;
            this.gcd.AllowUserToDeleteRows = false;
            this.gcd.AllowUserToResizeColumns = false;
            this.gcd.AllowUserToResizeRows = false;
            this.gcd.AutoGenerateColumns = false;
            this.gcd.BackgroundColor = System.Drawing.Color.White;
            this.gcd.ColumnHeadersHeight = 28;
            this.gcd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gcd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.gcd.DataSource = this.stockdbBindingSource;
            this.gcd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gcd.Location = new System.Drawing.Point(649, 89);
            this.gcd.Name = "gcd";
            this.gcd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gcd.Size = new System.Drawing.Size(680, 510);
            this.gcd.TabIndex = 6;
            this.gcd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gcd_CellContentClick);
            this.gcd.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gcd_CellFormatting);
            this.gcd.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gcd_MouseDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Chemical Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
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
            // clearbtncd
            // 
            this.clearbtncd.BackColor = System.Drawing.Color.Aqua;
            this.clearbtncd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearbtncd.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtncd.ForeColor = System.Drawing.Color.Black;
            this.clearbtncd.Location = new System.Drawing.Point(38, 582);
            this.clearbtncd.Name = "clearbtncd";
            this.clearbtncd.Size = new System.Drawing.Size(525, 52);
            this.clearbtncd.TabIndex = 13;
            this.clearbtncd.Text = "Reset";
            this.clearbtncd.UseVisualStyleBackColor = false;
            this.clearbtncd.Click += new System.EventHandler(this.clearadd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.dtpadd);
            this.groupBox1.Controls.Add(this.cbadd);
            this.groupBox1.Controls.Add(this.lbl1add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.t1add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.t2add);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 273);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter details:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpadd
            // 
            this.dtpadd.CustomFormat = "yyyy-MM-dd";
            this.dtpadd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpadd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpadd.Location = new System.Drawing.Point(277, 207);
            this.dtpadd.MaxDate = new System.DateTime(7866, 8, 18, 0, 0, 0, 0);
            this.dtpadd.MinDate = new System.DateTime(2017, 12, 30, 0, 0, 0, 0);
            this.dtpadd.Name = "dtpadd";
            this.dtpadd.Size = new System.Drawing.Size(215, 34);
            this.dtpadd.TabIndex = 10;
            this.dtpadd.Value = new System.DateTime(2019, 3, 26, 0, 0, 0, 0);
            // 
            // cbadd
            // 
            this.cbadd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbadd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbadd.FormattingEnabled = true;
            this.cbadd.Items.AddRange(new object[] {
            "Organic",
            "Inorganic"});
            this.cbadd.Location = new System.Drawing.Point(277, 143);
            this.cbadd.Name = "cbadd";
            this.cbadd.Size = new System.Drawing.Size(215, 34);
            this.cbadd.TabIndex = 9;
            this.cbadd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbadd_KeyDown);
            // 
            // lbl1add
            // 
            this.lbl1add.AutoSize = true;
            this.lbl1add.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1add.Location = new System.Drawing.Point(57, 40);
            this.lbl1add.Name = "lbl1add";
            this.lbl1add.Size = new System.Drawing.Size(74, 26);
            this.lbl1add.TabIndex = 0;
            this.lbl1add.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date :";
            // 
            // t1add
            // 
            this.t1add.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1add.Location = new System.Drawing.Point(277, 32);
            this.t1add.MaxLength = 30;
            this.t1add.Name = "t1add";
            this.t1add.Size = new System.Drawing.Size(215, 34);
            this.t1add.TabIndex = 1;
            this.t1add.TextChanged += new System.EventHandler(this.t1add_TextChanged);
            this.t1add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t1add_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "No. of bottle/Packet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type :";
            // 
            // t2add
            // 
            this.t2add.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2add.Location = new System.Drawing.Point(277, 89);
            this.t2add.MaxLength = 4;
            this.t2add.Name = "t2add";
            this.t2add.Size = new System.Drawing.Size(215, 34);
            this.t2add.TabIndex = 4;
            this.t2add.TextChanged += new System.EventHandler(this.t2add_TextChanged);
            this.t2add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t2add_KeyDown);
            this.t2add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t2add_KeyPress);
            // 
            // addbtncd
            // 
            this.addbtncd.BackColor = System.Drawing.Color.Aqua;
            this.addbtncd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addbtncd.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtncd.ForeColor = System.Drawing.Color.Black;
            this.addbtncd.Location = new System.Drawing.Point(38, 330);
            this.addbtncd.Name = "addbtncd";
            this.addbtncd.Size = new System.Drawing.Size(525, 52);
            this.addbtncd.TabIndex = 11;
            this.addbtncd.Text = "Add";
            this.addbtncd.UseVisualStyleBackColor = false;
            this.addbtncd.Click += new System.EventHandler(this.b1addadd_Click);
            // 
            // removeb1cd
            // 
            this.removeb1cd.BackColor = System.Drawing.Color.Aqua;
            this.removeb1cd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.removeb1cd.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeb1cd.ForeColor = System.Drawing.Color.Black;
            this.removeb1cd.Location = new System.Drawing.Point(38, 389);
            this.removeb1cd.Name = "removeb1cd";
            this.removeb1cd.Size = new System.Drawing.Size(525, 52);
            this.removeb1cd.TabIndex = 14;
            this.removeb1cd.Text = "Remove";
            this.removeb1cd.UseVisualStyleBackColor = false;
            this.removeb1cd.Click += new System.EventHandler(this.removeb1cd_Click);
            // 
            // searchtbcd
            // 
            this.searchtbcd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtbcd.Location = new System.Drawing.Point(745, 43);
            this.searchtbcd.Name = "searchtbcd";
            this.searchtbcd.Size = new System.Drawing.Size(584, 30);
            this.searchtbcd.TabIndex = 15;
            this.searchtbcd.TextChanged += new System.EventHandler(this.searchtbcd_TextChanged);
            this.searchtbcd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchtbcd_KeyPress);
            // 
            // updatebtncd
            // 
            this.updatebtncd.BackColor = System.Drawing.Color.Aqua;
            this.updatebtncd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.updatebtncd.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtncd.ForeColor = System.Drawing.Color.Black;
            this.updatebtncd.Location = new System.Drawing.Point(38, 454);
            this.updatebtncd.Name = "updatebtncd";
            this.updatebtncd.Size = new System.Drawing.Size(525, 52);
            this.updatebtncd.TabIndex = 16;
            this.updatebtncd.Text = "Update";
            this.updatebtncd.UseVisualStyleBackColor = false;
            this.updatebtncd.Click += new System.EventHandler(this.updatebtncd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(645, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search :";
            // 
            // l1cd
            // 
            this.l1cd.AutoSize = true;
            this.l1cd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1cd.Location = new System.Drawing.Point(646, 633);
            this.l1cd.Name = "l1cd";
            this.l1cd.Size = new System.Drawing.Size(230, 29);
            this.l1cd.TabIndex = 18;
            this.l1cd.Text = "Total no. of chemicals:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(868, 633);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 29);
            this.l2.TabIndex = 19;
            this.l2.Click += new System.EventHandler(this.l2_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(919, 633);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(141, 29);
            this.l3.TabIndex = 20;
            this.l3.Text = "Total stocks:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(1072, 633);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(0, 29);
            this.l4.TabIndex = 21;
            // 
            // stockdbTableAdapter
            // 
            this.stockdbTableAdapter.ClearBeforeFill = true;
            // 
            // chemicaldetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(1362, 685);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1cd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updatebtncd);
            this.Controls.Add(this.searchtbcd);
            this.Controls.Add(this.removeb1cd);
            this.Controls.Add(this.clearbtncd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addbtncd);
            this.Controls.Add(this.gcd);
            this.Controls.Add(this.deletebtncd);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chemicaldetails";
            this.ShowIcon = false;
            this.Text = "   Chemical Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.chemicaldetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebtncd;
        private System.Windows.Forms.DataGridView gcd;
        private stockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource stockdbBindingSource;
        private stockDataSetTableAdapters.stockdbTableAdapter stockdbTableAdapter;
        private System.Windows.Forms.Button clearbtncd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpadd;
        private System.Windows.Forms.ComboBox cbadd;
        private System.Windows.Forms.Label lbl1add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t1add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t2add;
        private System.Windows.Forms.Button addbtncd;
        private System.Windows.Forms.Button removeb1cd;
        private System.Windows.Forms.TextBox searchtbcd;
        private System.Windows.Forms.Button updatebtncd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l1cd;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}