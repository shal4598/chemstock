namespace pro1
{
    partial class userlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userlogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.t2ul = new System.Windows.Forms.TextBox();
            this.adminloginl1 = new System.Windows.Forms.Label();
            this.t1ul = new System.Windows.Forms.TextBox();
            this.labeladminloginl2 = new System.Windows.Forms.Label();
            this.loginb2ul = new System.Windows.Forms.Button();
            this.resetb1ul = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.t2ul);
            this.groupBox1.Controls.Add(this.adminloginl1);
            this.groupBox1.Controls.Add(this.t1ul);
            this.groupBox1.Controls.Add(this.labeladminloginl2);
            this.groupBox1.Location = new System.Drawing.Point(40, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 214);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(222, 187);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // t2ul
            // 
            this.t2ul.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2ul.Location = new System.Drawing.Point(222, 141);
            this.t2ul.Name = "t2ul";
            this.t2ul.PasswordChar = '*';
            this.t2ul.Size = new System.Drawing.Size(226, 34);
            this.t2ul.TabIndex = 5;
            this.t2ul.TextChanged += new System.EventHandler(this.t2ul_TextChanged);
            this.t2ul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t2ul_KeyDown);
            // 
            // adminloginl1
            // 
            this.adminloginl1.AutoSize = true;
            this.adminloginl1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminloginl1.Location = new System.Drawing.Point(222, 28);
            this.adminloginl1.Name = "adminloginl1";
            this.adminloginl1.Size = new System.Drawing.Size(110, 27);
            this.adminloginl1.TabIndex = 2;
            this.adminloginl1.Text = "Username:";
            this.adminloginl1.Click += new System.EventHandler(this.adminloginl1_Click);
            // 
            // t1ul
            // 
            this.t1ul.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1ul.Location = new System.Drawing.Point(222, 58);
            this.t1ul.Name = "t1ul";
            this.t1ul.Size = new System.Drawing.Size(226, 34);
            this.t1ul.TabIndex = 4;
            this.t1ul.TextChanged += new System.EventHandler(this.t1ul_TextChanged);
            this.t1ul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t1ul_KeyDown);
            // 
            // labeladminloginl2
            // 
            this.labeladminloginl2.AutoSize = true;
            this.labeladminloginl2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladminloginl2.Location = new System.Drawing.Point(222, 111);
            this.labeladminloginl2.Name = "labeladminloginl2";
            this.labeladminloginl2.Size = new System.Drawing.Size(102, 27);
            this.labeladminloginl2.TabIndex = 3;
            this.labeladminloginl2.Text = "Password:";
            this.labeladminloginl2.Click += new System.EventHandler(this.labeladminloginl2_Click);
            // 
            // loginb2ul
            // 
            this.loginb2ul.BackColor = System.Drawing.Color.Blue;
            this.loginb2ul.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginb2ul.ForeColor = System.Drawing.Color.White;
            this.loginb2ul.Location = new System.Drawing.Point(405, 272);
            this.loginb2ul.Name = "loginb2ul";
            this.loginb2ul.Size = new System.Drawing.Size(123, 45);
            this.loginb2ul.TabIndex = 8;
            this.loginb2ul.Text = "Log In";
            this.loginb2ul.UseVisualStyleBackColor = false;
            this.loginb2ul.Click += new System.EventHandler(this.loginb2ul_Click);
            // 
            // resetb1ul
            // 
            this.resetb1ul.BackColor = System.Drawing.Color.Blue;
            this.resetb1ul.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetb1ul.ForeColor = System.Drawing.Color.White;
            this.resetb1ul.Location = new System.Drawing.Point(42, 272);
            this.resetb1ul.Name = "resetb1ul";
            this.resetb1ul.Size = new System.Drawing.Size(123, 45);
            this.resetb1ul.TabIndex = 7;
            this.resetb1ul.Text = "Reset";
            this.resetb1ul.UseVisualStyleBackColor = false;
            this.resetb1ul.Click += new System.EventHandler(this.adminloginb1_Click);
            // 
            // userlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(573, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginb2ul);
            this.Controls.Add(this.resetb1ul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userlogin_FormClosing);
            this.Load += new System.EventHandler(this.userlogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox t2ul;
        private System.Windows.Forms.Label adminloginl1;
        private System.Windows.Forms.TextBox t1ul;
        private System.Windows.Forms.Label labeladminloginl2;
        private System.Windows.Forms.Button loginb2ul;
        private System.Windows.Forms.Button resetb1ul;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}