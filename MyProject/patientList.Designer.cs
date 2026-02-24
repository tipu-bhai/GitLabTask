
namespace MyProject
{
    partial class patientList
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
            this.labelAllPatientList = new System.Windows.Forms.Label();
            this.dataGridViewSeePatientList = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelSearchByIdOrName = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchByIdOrName = new System.Windows.Forms.Label();
            this.comboBoxSearchByIDOrName = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelLiveSearch = new System.Windows.Forms.Panel();
            this.textBoxLiveSearch = new System.Windows.Forms.TextBox();
            this.labelLiveSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSeeAllAppoinment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeePatientList)).BeginInit();
            this.panelSearchByIdOrName.SuspendLayout();
            this.panelLiveSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAllPatientList
            // 
            this.labelAllPatientList.AutoSize = true;
            this.labelAllPatientList.BackColor = System.Drawing.Color.Purple;
            this.labelAllPatientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllPatientList.Location = new System.Drawing.Point(485, 9);
            this.labelAllPatientList.Name = "labelAllPatientList";
            this.labelAllPatientList.Size = new System.Drawing.Size(302, 29);
            this.labelAllPatientList.TabIndex = 22;
            this.labelAllPatientList.Text = "All Patient List (Max - 10)";
            // 
            // dataGridViewSeePatientList
            // 
            this.dataGridViewSeePatientList.AllowUserToAddRows = false;
            this.dataGridViewSeePatientList.AllowUserToDeleteRows = false;
            this.dataGridViewSeePatientList.AllowUserToResizeColumns = false;
            this.dataGridViewSeePatientList.AllowUserToResizeRows = false;
            this.dataGridViewSeePatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewSeePatientList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSeePatientList.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewSeePatientList.ColumnHeadersHeight = 70;
            this.dataGridViewSeePatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSeePatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewSeePatientList.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewSeePatientList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSeePatientList.Name = "dataGridViewSeePatientList";
            this.dataGridViewSeePatientList.RowHeadersWidth = 70;
            this.dataGridViewSeePatientList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSeePatientList.RowTemplate.Height = 24;
            this.dataGridViewSeePatientList.Size = new System.Drawing.Size(1250, 338);
            this.dataGridViewSeePatientList.TabIndex = 23;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "Appoinment ID";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.Width = 118;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Doctor Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Appoinment Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 134;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Patient Complain";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 131;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Patient Name";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 112;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Patient Address";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 126;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Patient Phone";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 116;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Patient Age";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 101;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Patient Gender";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 122;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "Patient Blood Group";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 115;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(12, 480);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 37);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelSearchByIdOrName
            // 
            this.panelSearchByIdOrName.BackColor = System.Drawing.Color.LimeGreen;
            this.panelSearchByIdOrName.Controls.Add(this.buttonSearch);
            this.panelSearchByIdOrName.Controls.Add(this.labelSearchByIdOrName);
            this.panelSearchByIdOrName.Controls.Add(this.comboBoxSearchByIDOrName);
            this.panelSearchByIdOrName.Controls.Add(this.textBoxSearch);
            this.panelSearchByIdOrName.Controls.Add(this.labelSearch);
            this.panelSearchByIdOrName.Location = new System.Drawing.Point(12, 44);
            this.panelSearchByIdOrName.Name = "panelSearchByIdOrName";
            this.panelSearchByIdOrName.Size = new System.Drawing.Size(628, 89);
            this.panelSearchByIdOrName.TabIndex = 25;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(478, 29);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 46);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchByIdOrName
            // 
            this.labelSearchByIdOrName.AutoSize = true;
            this.labelSearchByIdOrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchByIdOrName.Location = new System.Drawing.Point(23, 7);
            this.labelSearchByIdOrName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchByIdOrName.Name = "labelSearchByIdOrName";
            this.labelSearchByIdOrName.Size = new System.Drawing.Size(200, 25);
            this.labelSearchByIdOrName.TabIndex = 21;
            this.labelSearchByIdOrName.Text = "Select ID or Name :";
            // 
            // comboBoxSearchByIDOrName
            // 
            this.comboBoxSearchByIDOrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchByIDOrName.FormattingEnabled = true;
            this.comboBoxSearchByIDOrName.Items.AddRange(new object[] {
            "Appoinment ID",
            "Patient Name"});
            this.comboBoxSearchByIDOrName.Location = new System.Drawing.Point(19, 37);
            this.comboBoxSearchByIDOrName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchByIDOrName.Name = "comboBoxSearchByIDOrName";
            this.comboBoxSearchByIDOrName.Size = new System.Drawing.Size(204, 33);
            this.comboBoxSearchByIDOrName.TabIndex = 20;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(244, 40);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(210, 30);
            this.textBoxSearch.TabIndex = 18;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(239, 7);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(188, 25);
            this.labelSearch.TabIndex = 19;
            this.labelSearch.Text = "Type ID or Name :";
            // 
            // panelLiveSearch
            // 
            this.panelLiveSearch.BackColor = System.Drawing.Color.Green;
            this.panelLiveSearch.Controls.Add(this.textBoxLiveSearch);
            this.panelLiveSearch.Controls.Add(this.labelLiveSearch);
            this.panelLiveSearch.Location = new System.Drawing.Point(893, 44);
            this.panelLiveSearch.Name = "panelLiveSearch";
            this.panelLiveSearch.Size = new System.Drawing.Size(369, 89);
            this.panelLiveSearch.TabIndex = 26;
            // 
            // textBoxLiveSearch
            // 
            this.textBoxLiveSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLiveSearch.Location = new System.Drawing.Point(151, 34);
            this.textBoxLiveSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLiveSearch.Name = "textBoxLiveSearch";
            this.textBoxLiveSearch.Size = new System.Drawing.Size(205, 30);
            this.textBoxLiveSearch.TabIndex = 23;
            this.textBoxLiveSearch.TextChanged += new System.EventHandler(this.textBoxLiveSearch_TextChanged);
            // 
            // labelLiveSearch
            // 
            this.labelLiveSearch.AutoSize = true;
            this.labelLiveSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLiveSearch.Location = new System.Drawing.Point(13, 37);
            this.labelLiveSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLiveSearch.Name = "labelLiveSearch";
            this.labelLiveSearch.Size = new System.Drawing.Size(140, 25);
            this.labelLiveSearch.TabIndex = 22;
            this.labelLiveSearch.Text = "Live Search :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.buttonSeeAllAppoinment);
            this.panel1.Location = new System.Drawing.Point(646, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 89);
            this.panel1.TabIndex = 27;
            // 
            // buttonSeeAllAppoinment
            // 
            this.buttonSeeAllAppoinment.BackColor = System.Drawing.Color.Crimson;
            this.buttonSeeAllAppoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeAllAppoinment.Location = new System.Drawing.Point(1, 0);
            this.buttonSeeAllAppoinment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeeAllAppoinment.Name = "buttonSeeAllAppoinment";
            this.buttonSeeAllAppoinment.Size = new System.Drawing.Size(240, 89);
            this.buttonSeeAllAppoinment.TabIndex = 23;
            this.buttonSeeAllAppoinment.Text = "Click Here for See All Appoinment(s)";
            this.buttonSeeAllAppoinment.UseVisualStyleBackColor = false;
            this.buttonSeeAllAppoinment.Click += new System.EventHandler(this.buttonSeeAllAppoinment_Click);
            // 
            // patientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1266, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLiveSearch);
            this.Controls.Add(this.panelSearchByIdOrName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewSeePatientList);
            this.Controls.Add(this.labelAllPatientList);
            this.Name = "patientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientList";
            this.Load += new System.EventHandler(this.patientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeePatientList)).EndInit();
            this.panelSearchByIdOrName.ResumeLayout(false);
            this.panelSearchByIdOrName.PerformLayout();
            this.panelLiveSearch.ResumeLayout(false);
            this.panelLiveSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAllPatientList;
        private System.Windows.Forms.DataGridView dataGridViewSeePatientList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelSearchByIdOrName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchByIdOrName;
        private System.Windows.Forms.ComboBox comboBoxSearchByIDOrName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelLiveSearch;
        private System.Windows.Forms.TextBox textBoxLiveSearch;
        private System.Windows.Forms.Label labelLiveSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSeeAllAppoinment;
    }
}