namespace CourseSystem.View
{
    partial class ReviewSelectedCourse
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
            this._userNameLabel = new System.Windows.Forms.Label();
            this._courseListLabel = new System.Windows.Forms.Label();
            this._courseListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this._courseListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "教授姓名：";
            // 
            // _userNameLabel
            // 
            this._userNameLabel.AutoSize = true;
            this._userNameLabel.Location = new System.Drawing.Point(84, 28);
            this._userNameLabel.Name = "_userNameLabel";
            this._userNameLabel.Size = new System.Drawing.Size(0, 12);
            this._userNameLabel.TabIndex = 1;
            // 
            // _courseListLabel
            // 
            this._courseListLabel.AutoSize = true;
            this._courseListLabel.Location = new System.Drawing.Point(13, 52);
            this._courseListLabel.Name = "_courseListLabel";
            this._courseListLabel.Size = new System.Drawing.Size(77, 12);
            this._courseListLabel.TabIndex = 2;
            this._courseListLabel.Text = "已開設課程：";
            // 
            // _courseListDataGridView
            // 
            this._courseListDataGridView.AllowUserToAddRows = false;
            this._courseListDataGridView.AllowUserToDeleteRows = false;
            this._courseListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this._courseListDataGridView.Location = new System.Drawing.Point(15, 67);
            this._courseListDataGridView.Name = "_courseListDataGridView";
            this._courseListDataGridView.ReadOnly = true;
            this._courseListDataGridView.RowTemplate.Height = 24;
            this._courseListDataGridView.Size = new System.Drawing.Size(370, 150);
            this._courseListDataGridView.TabIndex = 3;
            this._courseListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickCourseListDataGridView);
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
            this.Column4.HeaderText = "查看學生名單";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = "清單";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // ReviewSelectedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 264);
            this.Controls.Add(this._courseListDataGridView);
            this.Controls.Add(this._courseListLabel);
            this.Controls.Add(this._userNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "ReviewSelectedCourse";
            this.Text = "ReviewSelectedCourse";
            ((System.ComponentModel.ISupportInitialize)(this._courseListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _userNameLabel;
        private System.Windows.Forms.Label _courseListLabel;
        private System.Windows.Forms.DataGridView _courseListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}