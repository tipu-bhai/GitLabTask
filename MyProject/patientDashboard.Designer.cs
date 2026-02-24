
namespace MyProject
{
    partial class patientDashboard
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
            this.buttonMyProfile = new System.Windows.Forms.Button();
            this.labelMyProfile = new System.Windows.Forms.Label();
            this.buttonSeeDoctorList = new System.Windows.Forms.Button();
            this.labelSeeAllDoctorList = new System.Windows.Forms.Label();
            this.buttonTakeAppoinment = new System.Windows.Forms.Button();
            this.labelTakeAppoinment = new System.Windows.Forms.Label();
            this.panelTakeAppoinment = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxPatientComplain = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.labelCancle = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTakeAppoinment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMyProfile
            // 
            this.buttonMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyProfile.Location = new System.Drawing.Point(258, 187);
            this.buttonMyProfile.Name = "buttonMyProfile";
            this.buttonMyProfile.Size = new System.Drawing.Size(144, 37);
            this.buttonMyProfile.TabIndex = 9;
            this.buttonMyProfile.Text = "Click";
            this.buttonMyProfile.UseVisualStyleBackColor = true;
            this.buttonMyProfile.Click += new System.EventHandler(this.buttonMyProfile_Click);
            // 
            // labelMyProfile
            // 
            this.labelMyProfile.AutoSize = true;
            this.labelMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyProfile.Location = new System.Drawing.Point(43, 187);
            this.labelMyProfile.Name = "labelMyProfile";
            this.labelMyProfile.Size = new System.Drawing.Size(127, 25);
            this.labelMyProfile.TabIndex = 10;
            this.labelMyProfile.Text = "My Profile : ";
            // 
            // buttonSeeDoctorList
            // 
            this.buttonSeeDoctorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeDoctorList.Location = new System.Drawing.Point(258, 246);
            this.buttonSeeDoctorList.Name = "buttonSeeDoctorList";
            this.buttonSeeDoctorList.Size = new System.Drawing.Size(144, 37);
            this.buttonSeeDoctorList.TabIndex = 11;
            this.buttonSeeDoctorList.Text = "Click";
            this.buttonSeeDoctorList.UseVisualStyleBackColor = true;
            this.buttonSeeDoctorList.Click += new System.EventHandler(this.buttonSeeDoctorList_Click);
            // 
            // labelSeeAllDoctorList
            // 
            this.labelSeeAllDoctorList.AutoSize = true;
            this.labelSeeAllDoctorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeeAllDoctorList.Location = new System.Drawing.Point(40, 246);
            this.labelSeeAllDoctorList.Name = "labelSeeAllDoctorList";
            this.labelSeeAllDoctorList.Size = new System.Drawing.Size(194, 25);
            this.labelSeeAllDoctorList.TabIndex = 12;
            this.labelSeeAllDoctorList.Text = "See all Doctor list :";
            // 
            // buttonTakeAppoinment
            // 
            this.buttonTakeAppoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeAppoinment.Location = new System.Drawing.Point(258, 307);
            this.buttonTakeAppoinment.Name = "buttonTakeAppoinment";
            this.buttonTakeAppoinment.Size = new System.Drawing.Size(144, 37);
            this.buttonTakeAppoinment.TabIndex = 13;
            this.buttonTakeAppoinment.Text = "Click";
            this.buttonTakeAppoinment.UseVisualStyleBackColor = true;
            this.buttonTakeAppoinment.Click += new System.EventHandler(this.buttonTakeAppoinment_Click);
            // 
            // labelTakeAppoinment
            // 
            this.labelTakeAppoinment.AutoSize = true;
            this.labelTakeAppoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTakeAppoinment.Location = new System.Drawing.Point(40, 313);
            this.labelTakeAppoinment.Name = "labelTakeAppoinment";
            this.labelTakeAppoinment.Size = new System.Drawing.Size(201, 25);
            this.labelTakeAppoinment.TabIndex = 14;
            this.labelTakeAppoinment.Text = "Take Appoinment : ";
            // 
            // panelTakeAppoinment
            // 
            this.panelTakeAppoinment.BackColor = System.Drawing.Color.Cyan;
            this.panelTakeAppoinment.Controls.Add(this.label6);
            this.panelTakeAppoinment.Controls.Add(this.label5);
            this.panelTakeAppoinment.Controls.Add(this.label4);
            this.panelTakeAppoinment.Controls.Add(this.dataGridView);
            this.panelTakeAppoinment.Controls.Add(this.textBoxPatientComplain);
            this.panelTakeAppoinment.Controls.Add(this.buttonConfirm);
            this.panelTakeAppoinment.Controls.Add(this.label3);
            this.panelTakeAppoinment.Controls.Add(this.buttonCancle);
            this.panelTakeAppoinment.Controls.Add(this.labelCancle);
            this.panelTakeAppoinment.Controls.Add(this.dateTimePicker);
            this.panelTakeAppoinment.Location = new System.Drawing.Point(472, 12);
            this.panelTakeAppoinment.Name = "panelTakeAppoinment";
            this.panelTakeAppoinment.Size = new System.Drawing.Size(758, 501);
            this.panelTakeAppoinment.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Select A Appoinment DATE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Select Your Doctor From Hear :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Write Your Medical Problem Here :";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(24, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(397, 248);
            this.dataGridView.TabIndex = 20;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Speciality";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SELECT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // textBoxPatientComplain
            // 
            this.textBoxPatientComplain.Location = new System.Drawing.Point(24, 357);
            this.textBoxPatientComplain.Multiline = true;
            this.textBoxPatientComplain.Name = "textBoxPatientComplain";
            this.textBoxPatientComplain.Size = new System.Drawing.Size(711, 72);
            this.textBoxPatientComplain.TabIndex = 19;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(611, 446);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(122, 37);
            this.buttonConfirm.TabIndex = 17;
            this.buttonConfirm.Text = "Click";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirm Appoinment :";
            // 
            // buttonCancle
            // 
            this.buttonCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancle.Location = new System.Drawing.Point(239, 446);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(122, 37);
            this.buttonCancle.TabIndex = 15;
            this.buttonCancle.Text = "Click";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click_1);
            // 
            // labelCancle
            // 
            this.labelCancle.AutoSize = true;
            this.labelCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCancle.Location = new System.Drawing.Point(19, 452);
            this.labelCancle.Name = "labelCancle";
            this.labelCancle.Size = new System.Drawing.Size(214, 25);
            this.labelCancle.TabIndex = 16;
            this.labelCancle.Text = "Cancle Appoinment :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(439, 54);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(296, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.textBoxPatientName);
            this.panel1.Controls.Add(this.labelPatientName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelMyProfile);
            this.panel1.Controls.Add(this.buttonMyProfile);
            this.panel1.Controls.Add(this.labelSeeAllDoctorList);
            this.panel1.Controls.Add(this.buttonSeeDoctorList);
            this.panel1.Controls.Add(this.labelTakeAppoinment);
            this.panel1.Controls.Add(this.buttonTakeAppoinment);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 501);
            this.panel1.TabIndex = 17;
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientName.Location = new System.Drawing.Point(214, 77);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(188, 30);
            this.textBoxPatientName.TabIndex = 22;
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientName.Location = new System.Drawing.Point(43, 82);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(154, 25);
            this.labelPatientName.TabIndex = 21;
            this.labelPatientName.Text = "Patient Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Patient Dashboard";
            // 
            // patientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(1242, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTakeAppoinment);
            this.Name = "patientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientDashboard";
            this.Load += new System.EventHandler(this.patientDashboard_Load);
            this.panelTakeAppoinment.ResumeLayout(false);
            this.panelTakeAppoinment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMyProfile;
        private System.Windows.Forms.Label labelMyProfile;
        private System.Windows.Forms.Button buttonSeeDoctorList;
        private System.Windows.Forms.Label labelSeeAllDoctorList;
        private System.Windows.Forms.Button buttonTakeAppoinment;
        private System.Windows.Forms.Label labelTakeAppoinment;
        private System.Windows.Forms.Panel panelTakeAppoinment;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.TextBox textBoxPatientComplain;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Label labelCancle;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.Label labelPatientName;
    }
}