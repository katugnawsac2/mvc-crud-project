namespace SysArchPrelim
{
    partial class Form2
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
            this.CollegeDataGridView = new System.Windows.Forms.DataGridView();
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.collegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SysArchPrelim.DatabaseDataSet();
            this.CollegeIsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.collegeTableAdapter = new SysArchPrelim.DatabaseDataSetTableAdapters.CollegeTableAdapter();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CollegeIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CollegeNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CollegeCodeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CollegeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CollegeDataGridView
            // 
            this.CollegeDataGridView.AutoGenerateColumns = false;
            this.CollegeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CollegeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collegeIDDataGridViewTextBoxColumn,
            this.collegeNameDataGridViewTextBoxColumn,
            this.collegeCodeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.CollegeDataGridView.DataSource = this.collegeBindingSource;
            this.CollegeDataGridView.Location = new System.Drawing.Point(600, 90);
            this.CollegeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CollegeDataGridView.Name = "CollegeDataGridView";
            this.CollegeDataGridView.RowHeadersWidth = 62;
            this.CollegeDataGridView.Size = new System.Drawing.Size(673, 487);
            this.CollegeDataGridView.TabIndex = 29;
            this.CollegeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CollegeDataGridView_CellContentClick);
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            this.collegeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // collegeNameDataGridViewTextBoxColumn
            // 
            this.collegeNameDataGridViewTextBoxColumn.DataPropertyName = "CollegeName";
            this.collegeNameDataGridViewTextBoxColumn.HeaderText = "CollegeName";
            this.collegeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collegeNameDataGridViewTextBoxColumn.Name = "collegeNameDataGridViewTextBoxColumn";
            this.collegeNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // collegeCodeDataGridViewTextBoxColumn
            // 
            this.collegeCodeDataGridViewTextBoxColumn.DataPropertyName = "CollegeCode";
            this.collegeCodeDataGridViewTextBoxColumn.HeaderText = "CollegeCode";
            this.collegeCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.collegeCodeDataGridViewTextBoxColumn.Name = "collegeCodeDataGridViewTextBoxColumn";
            this.collegeCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Width = 150;
            // 
            // collegeBindingSource
            // 
            this.collegeBindingSource.DataMember = "College";
            this.collegeBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CollegeIsActiveCheckBox
            // 
            this.CollegeIsActiveCheckBox.AutoSize = true;
            this.CollegeIsActiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollegeIsActiveCheckBox.Location = new System.Drawing.Point(345, 374);
            this.CollegeIsActiveCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CollegeIsActiveCheckBox.Name = "CollegeIsActiveCheckBox";
            this.CollegeIsActiveCheckBox.Size = new System.Drawing.Size(87, 26);
            this.CollegeIsActiveCheckBox.TabIndex = 24;
            this.CollegeIsActiveCheckBox.Text = "Active";
            this.CollegeIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // collegeTableAdapter
            // 
            this.collegeTableAdapter.ClearBeforeFill = true;
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
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(120, 448);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(160, 36);
            this.guna2Button1.TabIndex = 31;
            this.guna2Button1.Text = "ADD";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(120, 516);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(160, 36);
            this.guna2Button2.TabIndex = 32;
            this.guna2Button2.Text = "UPDATE";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(318, 448);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(160, 36);
            this.guna2Button3.TabIndex = 33;
            this.guna2Button3.Text = "DELETE";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
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
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(318, 516);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(160, 36);
            this.guna2Button4.TabIndex = 34;
            this.guna2Button4.Text = "RETRIEVE";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1140, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(197, 20);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Department Form";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(751, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(0, 0);
            this.guna2HtmlLabel1.TabIndex = 39;
            this.guna2HtmlLabel1.Text = null;
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
            this.CollegeIDTextBox.Location = new System.Drawing.Point(151, 115);
            this.CollegeIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CollegeIDTextBox.Name = "CollegeIDTextBox";
            this.CollegeIDTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CollegeIDTextBox.PlaceholderText = "College ID";
            this.CollegeIDTextBox.SelectedText = "";
            this.CollegeIDTextBox.Size = new System.Drawing.Size(281, 56);
            this.CollegeIDTextBox.TabIndex = 41;
            // 
            // CollegeNameTextBox
            // 
            this.CollegeNameTextBox.BorderColor = System.Drawing.Color.Black;
            this.CollegeNameTextBox.BorderRadius = 10;
            this.CollegeNameTextBox.BorderThickness = 2;
            this.CollegeNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CollegeNameTextBox.DefaultText = "";
            this.CollegeNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CollegeNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CollegeNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CollegeNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CollegeNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CollegeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CollegeNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.CollegeNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CollegeNameTextBox.IconLeft = global::SysArchPrelim.Properties.Resources.user__1_;
            this.CollegeNameTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.CollegeNameTextBox.Location = new System.Drawing.Point(151, 206);
            this.CollegeNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CollegeNameTextBox.Name = "CollegeNameTextBox";
            this.CollegeNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CollegeNameTextBox.PlaceholderText = "College Name";
            this.CollegeNameTextBox.SelectedText = "";
            this.CollegeNameTextBox.Size = new System.Drawing.Size(281, 56);
            this.CollegeNameTextBox.TabIndex = 42;
            // 
            // CollegeCodeTextBox
            // 
            this.CollegeCodeTextBox.BorderColor = System.Drawing.Color.Black;
            this.CollegeCodeTextBox.BorderRadius = 10;
            this.CollegeCodeTextBox.BorderThickness = 2;
            this.CollegeCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CollegeCodeTextBox.DefaultText = "";
            this.CollegeCodeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CollegeCodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CollegeCodeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CollegeCodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CollegeCodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CollegeCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CollegeCodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.CollegeCodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CollegeCodeTextBox.IconLeft = global::SysArchPrelim.Properties.Resources.promo;
            this.CollegeCodeTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.CollegeCodeTextBox.Location = new System.Drawing.Point(151, 301);
            this.CollegeCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CollegeCodeTextBox.Name = "CollegeCodeTextBox";
            this.CollegeCodeTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.CollegeCodeTextBox.PlaceholderText = "College Code";
            this.CollegeCodeTextBox.SelectedText = "";
            this.CollegeCodeTextBox.Size = new System.Drawing.Size(281, 56);
            this.CollegeCodeTextBox.TabIndex = 43;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1349, 622);
            this.Controls.Add(this.CollegeCodeTextBox);
            this.Controls.Add(this.CollegeNameTextBox);
            this.Controls.Add(this.CollegeIDTextBox);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.CollegeDataGridView);
            this.Controls.Add(this.CollegeIsActiveCheckBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CollegeForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CollegeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CollegeDataGridView;
        private System.Windows.Forms.CheckBox CollegeIsActiveCheckBox;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource collegeBindingSource;
        private DatabaseDataSetTableAdapters.CollegeTableAdapter collegeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox CollegeIDTextBox;
        private Guna.UI2.WinForms.Guna2TextBox CollegeNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox CollegeCodeTextBox;
    }
}