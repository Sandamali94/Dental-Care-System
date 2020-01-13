namespace DentalCare
{
    partial class ClearkMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPatiRegi = new System.Windows.Forms.Button();
            this.btnPaymen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 69);
            this.panel1.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::DentalCare.Properties.Resources.cleark;
            this.panel4.Location = new System.Drawing.Point(426, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 60);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME FRONT OFFICER";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DentalCare.Properties.Resources.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-2, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 514);
            this.panel2.TabIndex = 41;
            // 
            // btnPatiRegi
            // 
            this.btnPatiRegi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatiRegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatiRegi.Location = new System.Drawing.Point(39, 87);
            this.btnPatiRegi.Name = "btnPatiRegi";
            this.btnPatiRegi.Size = new System.Drawing.Size(422, 48);
            this.btnPatiRegi.TabIndex = 36;
            this.btnPatiRegi.Text = "Patient Registration and Appoinment Handling";
            this.btnPatiRegi.UseVisualStyleBackColor = false;
            this.btnPatiRegi.Click += new System.EventHandler(this.btnPatiRegi_Click);
            // 
            // btnPaymen
            // 
            this.btnPaymen.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPaymen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymen.Location = new System.Drawing.Point(501, 87);
            this.btnPaymen.Name = "btnPaymen";
            this.btnPaymen.Size = new System.Drawing.Size(252, 48);
            this.btnPaymen.TabIndex = 38;
            this.btnPaymen.Text = "Payment for Treatments";
            this.btnPaymen.UseVisualStyleBackColor = false;
            this.btnPaymen.Click += new System.EventHandler(this.btnPaymen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(790, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 42;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearkMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPaymen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPatiRegi);
            this.Controls.Add(this.panel1);
            this.Name = "ClearkMenu";
            this.Text = "Front Officer Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPatiRegi;
        private System.Windows.Forms.Button btnPaymen;
        private System.Windows.Forms.Button button1;
    }
}