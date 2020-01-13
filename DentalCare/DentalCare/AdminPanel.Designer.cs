namespace DentalCare
{
    partial class AdminPanel
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmanreg = new System.Windows.Forms.Button();
            this.btnUseAcc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfrontoffice = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DentalCare.Properties.Resources.manager;
            this.panel3.Location = new System.Drawing.Point(307, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 60);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME ADMIN";
            // 
            // btnmanreg
            // 
            this.btnmanreg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnmanreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanreg.Location = new System.Drawing.Point(283, 84);
            this.btnmanreg.Name = "btnmanreg";
            this.btnmanreg.Size = new System.Drawing.Size(247, 48);
            this.btnmanreg.TabIndex = 49;
            this.btnmanreg.Text = "Manager Registration";
            this.btnmanreg.UseVisualStyleBackColor = false;
            this.btnmanreg.Click += new System.EventHandler(this.btnmanreg_Click);
            // 
            // btnUseAcc
            // 
            this.btnUseAcc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUseAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseAcc.Location = new System.Drawing.Point(12, 84);
            this.btnUseAcc.Name = "btnUseAcc";
            this.btnUseAcc.Size = new System.Drawing.Size(247, 48);
            this.btnUseAcc.TabIndex = 48;
            this.btnUseAcc.Text = "Create User Accounts";
            this.btnUseAcc.UseVisualStyleBackColor = false;
            this.btnUseAcc.Click += new System.EventHandler(this.btnUseAcc_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DentalCare.Properties.Resources.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-3, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 514);
            this.panel2.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 69);
            this.panel1.TabIndex = 46;
            // 
            // btnfrontoffice
            // 
            this.btnfrontoffice.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnfrontoffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrontoffice.Location = new System.Drawing.Point(556, 84);
            this.btnfrontoffice.Name = "btnfrontoffice";
            this.btnfrontoffice.Size = new System.Drawing.Size(247, 48);
            this.btnfrontoffice.TabIndex = 50;
            this.btnfrontoffice.Text = "Front Office Registration";
            this.btnfrontoffice.UseVisualStyleBackColor = false;
            this.btnfrontoffice.Click += new System.EventHandler(this.btnfrontoffice_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(827, 84);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(145, 48);
            this.btnlogout.TabIndex = 51;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnfrontoffice);
            this.Controls.Add(this.btnmanreg);
            this.Controls.Add(this.btnUseAcc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmanreg;
        private System.Windows.Forms.Button btnUseAcc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfrontoffice;
        private System.Windows.Forms.Button btnlogout;
    }
}