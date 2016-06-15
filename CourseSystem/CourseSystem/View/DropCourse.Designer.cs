namespace CourseSystem.View
{
    partial class DropCourse
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
            this._userLabel = new System.Windows.Forms.Label();
            this._showUserLabel = new System.Windows.Forms.Label();
            this._courseDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this._studentSelectedCourseLabel = new System.Windows.Forms.Label();
            this._DropCourseLabel = new System.Windows.Forms.Label();
            this._dropCouresDataGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this._OKButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dropCouresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _userLabel
            // 
            this._userLabel.AutoSize = true;
            this._userLabel.Location = new System.Drawing.Point(29, 26);
            this._userLabel.Name = "_userLabel";
            this._userLabel.Size = new System.Drawing.Size(65, 12);
            this._userLabel.TabIndex = 0;
            this._userLabel.Text = "學生姓名：";
            // 
            // _showUserLabel
            // 
            this._showUserLabel.AutoSize = true;
            this._showUserLabel.Location = new System.Drawing.Point(101, 26);
            this._showUserLabel.Name = "_showUserLabel";
            this._showUserLabel.Size = new System.Drawing.Size(0, 12);
            this._showUserLabel.TabIndex = 1;
            // 
            // _courseDataGridView
            // 
            this._courseDataGridView.AllowUserToAddRows = false;
            this._courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this._courseDataGridView.Location = new System.Drawing.Point(31, 88);
            this._courseDataGridView.Name = "_courseDataGridView";
            this._courseDataGridView.ReadOnly = true;
            this._courseDataGridView.RowTemplate.Height = 24;
            this._courseDataGridView.Size = new System.Drawing.Size(377, 150);
            this._courseDataGridView.TabIndex = 2;
            this._courseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCourseDataGridViewCell);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "課程名稱";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "課號";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "確認退選";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Text = "退選課程";
            this.Column4.UseColumnTextForButtonValue = true;
            this.Column4.Visible = false;
            // 
            // _studentSelectedCourseLabel
            // 
            this._studentSelectedCourseLabel.AutoSize = true;
            this._studentSelectedCourseLabel.Location = new System.Drawing.Point(29, 64);
            this._studentSelectedCourseLabel.Name = "_studentSelectedCourseLabel";
            this._studentSelectedCourseLabel.Size = new System.Drawing.Size(65, 12);
            this._studentSelectedCourseLabel.TabIndex = 3;
            this._studentSelectedCourseLabel.Text = "已選課程：";
            // 
            // _DropCourseLabel
            // 
            this._DropCourseLabel.AutoSize = true;
            this._DropCourseLabel.Location = new System.Drawing.Point(31, 269);
            this._DropCourseLabel.Name = "_DropCourseLabel";
            this._DropCourseLabel.Size = new System.Drawing.Size(65, 12);
            this._DropCourseLabel.TabIndex = 4;
            this._DropCourseLabel.Text = "待退課程：";
            // 
            // _dropCouresDataGridView
            // 
            this._dropCouresDataGridView.AllowUserToAddRows = false;
            this._dropCouresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dropCouresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this._dropCouresDataGridView.Location = new System.Drawing.Point(31, 294);
            this._dropCouresDataGridView.Name = "_dropCouresDataGridView";
            this._dropCouresDataGridView.ReadOnly = true;
            this._dropCouresDataGridView.RowTemplate.Height = 24;
            this._dropCouresDataGridView.Size = new System.Drawing.Size(375, 150);
            this._dropCouresDataGridView.TabIndex = 5;
            this._dropCouresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDropCouresDataGridViewCell);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 30;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "課程名稱";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "課號";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "取消退選";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Text = "取消退選";
            this.Column8.UseColumnTextForButtonValue = true;
            this.Column8.Visible = false;
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(131, 480);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 6;
            this._OKButton.Text = "退選";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this._OKButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(252, 480);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 7;
            this._cancelButton.Text = "取消";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.ClickCancelButton);
            // 
            // DropCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 524);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._OKButton);
            this.Controls.Add(this._dropCouresDataGridView);
            this.Controls.Add(this._DropCourseLabel);
            this.Controls.Add(this._studentSelectedCourseLabel);
            this.Controls.Add(this._courseDataGridView);
            this.Controls.Add(this._showUserLabel);
            this.Controls.Add(this._userLabel);
            this.Name = "DropCourse";
            this.Text = "DropCourse";
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dropCouresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _userLabel;
        private System.Windows.Forms.Label _showUserLabel;
        private System.Windows.Forms.DataGridView _courseDataGridView;
        private System.Windows.Forms.Label _studentSelectedCourseLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Label _DropCourseLabel;
        private System.Windows.Forms.DataGridView _dropCouresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.Button _OKButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}