namespace DentalCare
{
    partial class ListOfExperiencedDoctors
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dentalCareDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            this.experienceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.experienceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
           
            this.experienceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            
            this.experienceBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.experienceBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorNicNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expereinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentalCareDBDataSetBindingSource)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource1)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "EXPERIENCED DOCTORS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 65);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DentalCare.Properties.Resources.AllBackgroundnew;
            this.pictureBox1.Location = new System.Drawing.Point(753, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 225);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // dentalCareDBDataSetBindingSource
            // 
         
            this.dentalCareDBDataSetBindingSource.Position = 0;
            // 
            // dentalCareDBDataSet
            // 
            
            // dentalCareDBDataSet1
            // 
            
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";

            // 
            // doctorsTableAdapter
            // 
       
            // 
            // dentalCareDBDataSet2
            // 
           
            // 
            // experienceBindingSource
            // 
            this.experienceBindingSource.DataMember = "experience";
           
            // 
            // experienceTableAdapter
            // 
           
            // 
            // experienceBindingSource1
            // 
            this.experienceBindingSource1.DataMember = "experience";
 
            // 
            // dentalCareDBDataSet3
            // 
           
            // 
            // experienceBindingSource2
            // 
            this.experienceBindingSource2.DataMember = "experience";
        
            // 
            // experienceTableAdapter1
            // 
           
            // 
            // experienceBindingSource3
            // 
            this.experienceBindingSource3.DataMember = "experience";
        
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorNicNoDataGridViewTextBoxColumn,
            this.doctorFirstNameDataGridViewTextBoxColumn,
            this.doctorLastNameDataGridViewTextBoxColumn,
            this.expereinceDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.experienceBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(96, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 232);
            this.dataGridView1.TabIndex = 43;
            // 
            // experienceBindingSource4
            // 
            this.experienceBindingSource4.DataMember = "experience";
        
            // 
            // doctorNicNoDataGridViewTextBoxColumn
            // 
            this.doctorNicNoDataGridViewTextBoxColumn.DataPropertyName = "DoctorNicNo";
            this.doctorNicNoDataGridViewTextBoxColumn.HeaderText = "DoctorNicNo";
            this.doctorNicNoDataGridViewTextBoxColumn.Name = "doctorNicNoDataGridViewTextBoxColumn";
            this.doctorNicNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // doctorFirstNameDataGridViewTextBoxColumn
            // 
            this.doctorFirstNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorFirstName";
            this.doctorFirstNameDataGridViewTextBoxColumn.HeaderText = "DoctorFirstName";
            this.doctorFirstNameDataGridViewTextBoxColumn.Name = "doctorFirstNameDataGridViewTextBoxColumn";
            this.doctorFirstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // doctorLastNameDataGridViewTextBoxColumn
            // 
            this.doctorLastNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorLastName";
            this.doctorLastNameDataGridViewTextBoxColumn.HeaderText = "DoctorLastName";
            this.doctorLastNameDataGridViewTextBoxColumn.Name = "doctorLastNameDataGridViewTextBoxColumn";
            this.doctorLastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // expereinceDataGridViewTextBoxColumn
            // 
            this.expereinceDataGridViewTextBoxColumn.DataPropertyName = "Expereince";
            this.expereinceDataGridViewTextBoxColumn.HeaderText = "Expereince";
            this.expereinceDataGridViewTextBoxColumn.Name = "expereinceDataGridViewTextBoxColumn";
            this.expereinceDataGridViewTextBoxColumn.Width = 150;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.Width = 150;
            // 
            // ListOfExperiencedDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ListOfExperiencedDoctors";
            this.Text = "ListOfExperiencedDoctors";
            this.Load += new System.EventHandler(this.ListOfExperiencedDoctors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentalCareDBDataSetBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource1)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource dentalCareDBDataSetBindingSource;


        private System.Windows.Forms.BindingSource doctorsBindingSource;


        private System.Windows.Forms.BindingSource experienceBindingSource;

        private System.Windows.Forms.BindingSource experienceBindingSource1;
  
        private System.Windows.Forms.BindingSource experienceBindingSource2;

        private System.Windows.Forms.BindingSource experienceBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNicNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expereinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource experienceBindingSource4;
    }
}