namespace DentalCare
{
    partial class ManagerMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIncRep = new System.Windows.Forms.Button();
            this.btnExpeDoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDocReg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME MANAGER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 69);
            this.panel1.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DentalCare.Properties.Resources.manager;
            this.panel3.Location = new System.Drawing.Point(330, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(61, 64);
            this.panel3.TabIndex = 5;
            // 
            // btnIncRep
            // 
            this.btnIncRep.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIncRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncRep.Location = new System.Drawing.Point(12, 85);
            this.btnIncRep.Name = "btnIncRep";
            this.btnIncRep.Size = new System.Drawing.Size(247, 48);
            this.btnIncRep.TabIndex = 45;
            this.btnIncRep.Text = "Income Report";
            this.btnIncRep.UseVisualStyleBackColor = false;
            this.btnIncRep.Click += new System.EventHandler(this.btnIncRep_Click);
            // 
            // btnExpeDoc
            // 
            this.btnExpeDoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExpeDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpeDoc.Location = new System.Drawing.Point(293, 85);
            this.btnExpeDoc.Name = "btnExpeDoc";
            this.btnExpeDoc.Size = new System.Drawing.Size(235, 48);
            this.btnExpeDoc.TabIndex = 46;
            this.btnExpeDoc.Text = "Experienced Doctors";
            this.btnExpeDoc.UseVisualStyleBackColor = false;
            this.btnExpeDoc.Click += new System.EventHandler(this.btnExpeDoc_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DentalCare.Properties.Resources.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-1, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 520);
            this.panel2.TabIndex = 43;
            // 
            // btnDocReg
            // 
            this.btnDocReg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDocReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocReg.Location = new System.Drawing.Point(562, 85);
            this.btnDocReg.Name = "btnDocReg";
            this.btnDocReg.Size = new System.Drawing.Size(222, 48);
            this.btnDocReg.TabIndex = 45;
            this.btnDocReg.Text = "Doctor Registration";
            this.btnDocReg.UseVisualStyleBackColor = false;
            this.btnDocReg.Click += new System.EventHandler(this.btnDocReg_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(816, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 47;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDocReg);
            this.Controls.Add(this.btnExpeDoc);
            this.Controls.Add(this.btnIncRep);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerMenu";
            this.Text = "ManagerMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIncRep;
        private System.Windows.Forms.Button btnExpeDoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDocReg;
        private System.Windows.Forms.Button button1;
    }
}