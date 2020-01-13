namespace DentalCare
{
    partial class CreateUserAccounts
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comacctype = new System.Windows.Forms.ComboBox();
            this.btncancle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "CREATE USER ACCOUNTS";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(274, 335);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 45);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DentalCare.Properties.Resources.AllBackgroundnew;
            this.pictureBox1.Location = new System.Drawing.Point(527, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 242);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // comacctype
            // 
            this.comacctype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comacctype.FormattingEnabled = true;
            this.comacctype.Items.AddRange(new object[] {
            "Manager",
            "Front Office",
            "Doctor"});
            this.comacctype.Location = new System.Drawing.Point(262, 237);
            this.comacctype.Name = "comacctype";
            this.comacctype.Size = new System.Drawing.Size(211, 27);
            this.comacctype.TabIndex = 63;
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Red;
            this.btncancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.Location = new System.Drawing.Point(396, 335);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(101, 45);
            this.btncancle.TabIndex = 60;
            this.btncancle.Text = "CANCLE";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 65);
            this.panel1.TabIndex = 61;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(41, 335);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(211, 45);
            this.btnlogin.TabIndex = 59;
            this.btnlogin.Text = "CREATE ACCOUNT";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(262, 167);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(211, 26);
            this.txtpass.TabIndex = 58;
            // 
            // txtuname
            // 
            this.txtuname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Location = new System.Drawing.Point(262, 94);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(211, 26);
            this.txtuname.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "Account Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Username";
            // 
            // CreateUserAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 467);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comacctype);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CreateUserAccounts";
            this.Text = "CreateUserAccounts";
            this.Load += new System.EventHandler(this.CreateUserAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comacctype;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}