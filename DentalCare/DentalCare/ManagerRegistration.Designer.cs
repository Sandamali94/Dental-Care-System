namespace DentalCare
{
    partial class ManagerRegistration
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
            this.managersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnreset = new System.Windows.Forms.Button();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcontactmob = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.txtaddli1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmanfname = new System.Windows.Forms.TextBox();
            this.txtmanlname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcontacthome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.managersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // managersBindingSource
            // 
            this.managersBindingSource.DataMember = "Managers";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Yellow;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(792, 358);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(100, 48);
            this.btnreset.TabIndex = 83;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(678, 131);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(256, 26);
            this.dtpdate.TabIndex = 80;
            this.dtpdate.Value = new System.DateTime(2019, 8, 29, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 65);
            this.panel1.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANAGER REGISTRATION";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(556, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 48);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(314, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 48);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(88, 358);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 48);
            this.btnSubmit.TabIndex = 76;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(678, 177);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(256, 26);
            this.txtage.TabIndex = 73;
            this.txtage.Enter += new System.EventHandler(this.txtage_ValueChanged);
            this.txtage.MouseEnter += new System.EventHandler(this.txtage_MouseEnter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(571, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 22);
            this.label11.TabIndex = 72;
            this.label11.Text = "Age";
            // 
            // txtcontactmob
            // 
            this.txtcontactmob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactmob.Location = new System.Drawing.Point(708, 256);
            this.txtcontactmob.Name = "txtcontactmob";
            this.txtcontactmob.Size = new System.Drawing.Size(226, 26);
            this.txtcontactmob.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(571, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 22);
            this.label15.TabIndex = 74;
            this.label15.Text = "Contact No ";
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.Location = new System.Drawing.Point(858, 94);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(76, 23);
            this.rdbfemale.TabIndex = 70;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmale.Location = new System.Drawing.Point(678, 94);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(63, 23);
            this.rdbmale.TabIndex = 69;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 22);
            this.label10.TabIndex = 68;
            this.label10.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 66;
            this.label8.Text = "DOB";
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(224, 301);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(256, 26);
            this.txtcity.TabIndex = 65;
            // 
            // txtstreet
            // 
            this.txtstreet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstreet.Location = new System.Drawing.Point(224, 259);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(256, 26);
            this.txtstreet.TabIndex = 64;
            // 
            // txtaddli1
            // 
            this.txtaddli1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddli1.Location = new System.Drawing.Point(224, 217);
            this.txtaddli1.Name = "txtaddli1";
            this.txtaddli1.Size = new System.Drawing.Size(256, 26);
            this.txtaddli1.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 62;
            this.label7.Text = "Street ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 61;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 60;
            this.label5.Text = "Address Line1";
            // 
            // txtmanfname
            // 
            this.txtmanfname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanfname.Location = new System.Drawing.Point(224, 129);
            this.txtmanfname.Name = "txtmanfname";
            this.txtmanfname.Size = new System.Drawing.Size(256, 26);
            this.txtmanfname.TabIndex = 59;
            // 
            // txtmanlname
            // 
            this.txtmanlname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanlname.Location = new System.Drawing.Point(224, 173);
            this.txtmanlname.Name = "txtmanlname";
            this.txtmanlname.Size = new System.Drawing.Size(256, 26);
            this.txtmanlname.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 57;
            this.label4.Text = "Manager Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Manger First Name";
            // 
            // txtemid
            // 
            this.txtemid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemid.Location = new System.Drawing.Point(224, 90);
            this.txtemid.Name = "txtemid";
            this.txtemid.Size = new System.Drawing.Size(256, 26);
            this.txtemid.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Manager ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(613, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 22);
            this.label12.TabIndex = 85;
            this.label12.Text = "Mobile";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(613, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 22);
            this.label13.TabIndex = 87;
            this.label13.Text = "Home";
            // 
            // txtcontacthome
            // 
            this.txtcontacthome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontacthome.Location = new System.Drawing.Point(708, 301);
            this.txtcontacthome.Name = "txtcontacthome";
            this.txtcontacthome.Size = new System.Drawing.Size(226, 26);
            this.txtcontacthome.TabIndex = 86;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DentalCare.Properties.Resources.AllBackgroundnew;
            this.pictureBox1.Location = new System.Drawing.Point(751, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 224);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtcontacthome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcontactmob);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rdbfemale);
            this.Controls.Add(this.rdbmale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtstreet);
            this.Controls.Add(this.txtaddli1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmanfname);
            this.Controls.Add(this.txtmanlname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManagerRegistration";
            this.Text = "ManagerRegistration";
            this.Load += new System.EventHandler(this.ManagerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcontactmob;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.TextBox txtaddli1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmanfname;
        private System.Windows.Forms.TextBox txtmanlname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcontacthome;

        private System.Windows.Forms.BindingSource managersBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addline1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}