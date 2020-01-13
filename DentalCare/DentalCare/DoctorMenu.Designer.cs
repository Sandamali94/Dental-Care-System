namespace DentalCare
{
    partial class DoctorMenu
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
            this.btnPatientEnq = new System.Windows.Forms.Button();
            this.btnVieDaiAppo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME DOCTOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 69);
            this.panel1.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DentalCare.Properties.Resources.doctpr;
            this.panel3.Location = new System.Drawing.Point(313, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 60);
            this.panel3.TabIndex = 5;
            // 
            // btnPatientEnq
            // 
            this.btnPatientEnq.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientEnq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientEnq.Location = new System.Drawing.Point(73, 85);
            this.btnPatientEnq.Name = "btnPatientEnq";
            this.btnPatientEnq.Size = new System.Drawing.Size(247, 48);
            this.btnPatientEnq.TabIndex = 43;
            this.btnPatientEnq.Text = "Patient Enquiry";
            this.btnPatientEnq.UseVisualStyleBackColor = false;
            this.btnPatientEnq.Click += new System.EventHandler(this.btnPatientEnq_Click);
            // 
            // btnVieDaiAppo
            // 
            this.btnVieDaiAppo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVieDaiAppo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVieDaiAppo.Location = new System.Drawing.Point(396, 85);
            this.btnVieDaiAppo.Name = "btnVieDaiAppo";
            this.btnVieDaiAppo.Size = new System.Drawing.Size(247, 48);
            this.btnVieDaiAppo.TabIndex = 45;
            this.btnVieDaiAppo.Text = "View Daily Appoinments";
            this.btnVieDaiAppo.UseVisualStyleBackColor = false;
            this.btnVieDaiAppo.Click += new System.EventHandler(this.btnVieDaiAppo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DentalCare.Properties.Resources.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-3, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 514);
            this.panel2.TabIndex = 42;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(722, 85);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(172, 48);
            this.btnlogout.TabIndex = 46;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // DoctorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnVieDaiAppo);
            this.Controls.Add(this.btnPatientEnq);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorMenu";
            this.Text = "DoctorMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPatientEnq;
        private System.Windows.Forms.Button btnVieDaiAppo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnlogout;
    }
}