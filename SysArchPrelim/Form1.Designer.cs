namespace SysArchPrelim
{
    partial class Form1
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
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SysArchPrelim.DatabaseDataSet();
            this.departmentTableAdapter = new SysArchPrelim.DatabaseDataSetTableAdapters.DepartmentTableAdapter();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DepartmentIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CollegeIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DepartmentCodeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DepartmentNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.IsActiveCheckBox.Location = new System.Drawing.Point(334, 427);
            this.IsActiveCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Size = new System.Drawing.Size(103, 26);
            this.IsActiveCheckBox.TabIndex = 9;
            this.IsActiveCheckBox.Text = "ACTIVE";
            this.IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // DepartmentDataGridView
            // 
            this.DepartmentDataGridView.AutoGenerateColumns = false;
            this.DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.collegeIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.departmentCodeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.DepartmentDataGridView.DataSource = this.departmentBindingSource;
            this.DepartmentDataGridView.Location = new System.Drawing.Point(653, 101);
            this.DepartmentDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DepartmentDataGridView.Name = "DepartmentDataGridView";
            this.DepartmentDataGridView.RowHeadersWidth = 62;
            this.DepartmentDataGridView.Size = new System.Drawing.Size(752, 508);
            this.DepartmentDataGridView.TabIndex = 14;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            this.collegeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // departmentCodeDataGridViewTextBoxColumn
            // 
            this.departmentCodeDataGridViewTextBoxColumn.DataPropertyName = "DepartmentCode";
            this.departmentCodeDataGridViewTextBoxColumn.HeaderText = "DepartmentCode";
            this.departmentCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmentCodeDataGridViewTextBoxColumn.Name = "departmentCodeDataGridViewTextBoxColumn";
            this.departmentCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Width = 150;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(315, 552);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(160, 36);
            this.guna2Button4.TabIndex = 38;
            this.guna2Button4.Text = "RETRIEVE";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(315, 477);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(160, 36);
            this.guna2Button3.TabIndex = 37;
            this.guna2Button3.Text = "DELETE";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(119, 552);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(160, 36);
            this.guna2Button2.TabIndex = 36;
            this.guna2Button2.Text = "UPDATE";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(119, 477);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(160, 36);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "ADD";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DepartmentIDTextBox
            // 
            this.DepartmentIDTextBox.BorderColor = System.Drawing.Color.Black;
            this.DepartmentIDTextBox.BorderRadius = 10;
            this.DepartmentIDTextBox.BorderThickness = 2;
            this.DepartmentIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepartmentIDTextBox.DefaultText = "";
            this.DepartmentIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DepartmentIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DepartmentIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentIDTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DepartmentIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.DepartmentIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentIDTextBox.IconLeft = global::SysArchPrelim.Properties.Resources.corporation;
            this.DepartmentIDTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.DepartmentIDTextBox.Location = new System.Drawing.Point(156, 189);
            this.DepartmentIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartmentIDTextBox.Name = "DepartmentIDTextBox";
            this.DepartmentIDTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DepartmentIDTextBox.PlaceholderText = "Department ID";
            this.DepartmentIDTextBox.SelectedText = "";
            this.DepartmentIDTextBox.Size = new System.Drawing.Size(281, 56);
            this.DepartmentIDTextBox.TabIndex = 42;
            // 
            // CollegeIDTextBox
            // 
            this.CollegeIDTextBox.BorderColor = System.Drawing.Color.Black;
            this.CollegeIDTextBox.BorderRadius = 10;
            this.CollegeIDTextBox.BorderThickness = 2;
            this.CollegeIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CollegeIDTextBox.DefaultText = "";
            this.CollegeIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CollegeIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CollegeIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CollegeIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CollegeIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CollegeIDTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CollegeIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.CollegeIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CollegeIDTextBox.IconLeft = global::SysArchPrelim.Properties.Resources.card;
            this.CollegeIDTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.CollegeIDTextBox.Location = new System.Drawing.Point(156, 97);
            this.CollegeIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CollegeIDTextBox.Name = "CollegeIDTextBox";
            this.CollegeIDTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CollegeIDTextBox.PlaceholderText = "College ID";
            this.CollegeIDTextBox.SelectedText = "";
            this.CollegeIDTextBox.Size = new System.Drawing.Size(281, 56);
            this.CollegeIDTextBox.TabIndex = 43;
            // 
            // DepartmentCodeTextBox
            // 
            this.DepartmentCodeTextBox.BorderColor = System.Drawing.Color.Black;
            this.DepartmentCodeTextBox.BorderRadius = 10;
            this.DepartmentCodeTextBox.BorderThickness = 2;
            this.DepartmentCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepartmentCodeTextBox.DefaultText = "";
            this.DepartmentCodeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DepartmentCodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DepartmentCodeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentCodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentCodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DepartmentCodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.DepartmentCodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentCodeTextBox.IconLeft = global::SysArchPrelim.Properties.Resources.promo;
            this.DepartmentCodeTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.DepartmentCodeTextBox.Location = new System.Drawing.Point(156, 363);
            this.DepartmentCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartmentCodeTextBox.Name = "DepartmentCodeTextBox";
            this.DepartmentCodeTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DepartmentCodeTextBox.PlaceholderText = "Department Code";
            this.DepartmentCodeTextBox.SelectedText = "";
            this.DepartmentCodeTextBox.Size = new System.Drawing.Size(281, 56);
            this.DepartmentCodeTextBox.TabIndex = 45;
            // 
            // DepartmentNameTextBox
            // 
            this.DepartmentNameTextBox.BorderColor = System.Drawing.Color.Black;
            this.DepartmentNameTextBox.BorderRadius = 10;
            this.DepartmentNameTextBox.BorderThickness = 2;
            this.DepartmentNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepartmentNameTextBox.DefaultText = "";
            this.DepartmentNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DepartmentNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DepartmentNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DepartmentNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.DepartmentNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentNameTextBox.IconLeft = global::SysArchPrelim.Properties.Resources.user__1_;
            this.DepartmentNameTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.DepartmentNameTextBox.Location = new System.Drawing.Point(156, 280);
            this.DepartmentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartmentNameTextBox.Name = "DepartmentNameTextBox";
            this.DepartmentNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DepartmentNameTextBox.PlaceholderText = "Department Name";
            this.DepartmentNameTextBox.SelectedText = "";
            this.DepartmentNameTextBox.Size = new System.Drawing.Size(281, 56);
            this.DepartmentNameTextBox.TabIndex = 46;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1244, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 20);
            this.linkLabel1.TabIndex = 47;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to College Form";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1418, 676);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DepartmentNameTextBox);
            this.Controls.Add(this.DepartmentCodeTextBox);
            this.Controls.Add(this.CollegeIDTextBox);
            this.Controls.Add(this.DepartmentIDTextBox);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DepartmentDataGridView);
            this.Controls.Add(this.IsActiveCheckBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private System.Windows.Forms.DataGridView DepartmentDataGridView;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DatabaseDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox DepartmentIDTextBox;
        private Guna.UI2.WinForms.Guna2TextBox CollegeIDTextBox;
        private Guna.UI2.WinForms.Guna2TextBox DepartmentCodeTextBox;
        private Guna.UI2.WinForms.Guna2TextBox DepartmentNameTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

