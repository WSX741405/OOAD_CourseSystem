namespace CourseSystem.View
{
    partial class SelectedCourse
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
            this._courseDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this._studentNameLabel = new System.Windows.Forms.Label();
            this._showStudentNameLabel = new System.Windows.Forms.Label();
            this._selectedCourseLabel = new System.Windows.Forms.Label();
            this._alreadySelectLabel = new System.Windows.Forms.Label();
            this._studentSelectCourseDataGridView = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this._OKButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._studentSelectCourseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _courseDataGridView
            // 
            this._courseDataGridView.AllowUserToAddRows = false;
            this._courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this._courseDataGridView.Location = new System.Drawing.Point(35, 65);
            this._courseDataGridView.Name = "_courseDataGridView";
            this._courseDataGridView.ReadOnly = true;
            this._courseDataGridView.RowTemplate.Height = 24;
            this._courseDataGridView.Size = new System.Drawing.Size(490, 157);
            this._courseDataGridView.TabIndex = 0;
            this._courseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCourseDataGridViewCell);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "課號";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "課程名稱";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "開課教授";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "加入選課";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "加選課程";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Visible = false;
            // 
            // _studentNameLabel
            // 
            this._studentNameLabel.AutoSize = true;
            this._studentNameLabel.Location = new System.Drawing.Point(33, 13);
            this._studentNameLabel.Name = "_studentNameLabel";
            this._studentNameLabel.Size = new System.Drawing.Size(65, 12);
            this._studentNameLabel.TabIndex = 1;
            this._studentNameLabel.Text = "學生姓名：";
            // 
            // _showStudentNameLabel
            // 
            this._showStudentNameLabel.AutoSize = true;
            this._showStudentNameLabel.Location = new System.Drawing.Point(105, 13);
            this._showStudentNameLabel.Name = "_showStudentNameLabel";
            this._showStudentNameLabel.Size = new System.Drawing.Size(0, 12);
            this._showStudentNameLabel.TabIndex = 2;
            // 
            // _selectedCourseLabel
            // 
            this._selectedCourseLabel.AutoSize = true;
            this._selectedCourseLabel.Location = new System.Drawing.Point(33, 50);
            this._selectedCourseLabel.Name = "_selectedCourseLabel";
            this._selectedCourseLabel.Size = new System.Drawing.Size(65, 12);
            this._selectedCourseLabel.TabIndex = 3;
            this._selectedCourseLabel.Text = "加選課程：";
            // 
            // _alreadySelectLabel
            // 
            this._alreadySelectLabel.AutoSize = true;
            this._alreadySelectLabel.Location = new System.Drawing.Point(33, 237);
            this._alreadySelectLabel.Name = "_alreadySelectLabel";
            this._alreadySelectLabel.Size = new System.Drawing.Size(65, 12);
            this._alreadySelectLabel.TabIndex = 4;
            this._alreadySelectLabel.Text = "已選課程：";
            // 
            // _studentSelectCourseDataGridView
            // 
            this._studentSelectCourseDataGridView.AllowUserToAddRows = false;
            this._studentSelectCourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._studentSelectCourseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column8,
            this.Column7,
            this.Column9,
            this.Column10});
            this._studentSelectCourseDataGridView.Location = new System.Drawing.Point(35, 252);
            this._studentSelectCourseDataGridView.Name = "_studentSelectCourseDataGridView";
            this._studentSelectCourseDataGridView.ReadOnly = true;
            this._studentSelectCourseDataGridView.RowTemplate.Height = 24;
            this._studentSelectCourseDataGridView.Size = new System.Drawing.Size(490, 150);
            this._studentSelectCourseDataGridView.TabIndex = 5;
            this._studentSelectCourseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickStudentSelectCourseDataGridViewCell);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 30;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "課號";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "課程名稱";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "開課教授";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "取消加選";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Text = "取消選課";
            this.Column10.UseColumnTextForButtonValue = true;
            this.Column10.Visible = false;
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(185, 435);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 6;
            this._OKButton.Text = "加選";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this.ClickOKButton);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(294, 435);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 7;
            this._cancelButton.Text = "取消";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.ClickCancelButton);
            // 
            // SelectedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 472);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._OKButton);
            this.Controls.Add(this._studentSelectCourseDataGridView);
            this.Controls.Add(this._alreadySelectLabel);
            this.Controls.Add(this._selectedCourseLabel);
            this.Controls.Add(this._showStudentNameLabel);
            this.Controls.Add(this._studentNameLabel);
            this.Controls.Add(this._courseDataGridView);
            this.Name = "SelectedCourse";
            this.Text = "SelectedCourse";
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._studentSelectCourseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _courseDataGridView;
        private System.Windows.Forms.Label _studentNameLabel;
        private System.Windows.Forms.Label _showStudentNameLabel;
        private System.Windows.Forms.Label _selectedCourseLabel;
        private System.Windows.Forms.Label _alreadySelectLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridView _studentSelectCourseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.Button _OKButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}