namespace CourseSystem.View
{
    partial class PersonalClassSchedule
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
            this._idLabel = new System.Windows.Forms.Label();
            this._idTextBox = new System.Windows.Forms.TextBox();
            this._checkScheduleButton = new System.Windows.Forms.Button();
            this._classScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._classScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _idLabel
            // 
            this._idLabel.AutoSize = true;
            this._idLabel.Location = new System.Drawing.Point(380, 43);
            this._idLabel.Name = "_idLabel";
            this._idLabel.Size = new System.Drawing.Size(77, 12);
            this._idLabel.TabIndex = 0;
            this._idLabel.Text = "請輸入學號：";
            // 
            // _idTextBox
            // 
            this._idTextBox.Location = new System.Drawing.Point(472, 40);
            this._idTextBox.Name = "_idTextBox";
            this._idTextBox.Size = new System.Drawing.Size(100, 22);
            this._idTextBox.TabIndex = 1;
            // 
            // _checkScheduleButton
            // 
            this._checkScheduleButton.Location = new System.Drawing.Point(617, 40);
            this._checkScheduleButton.Name = "_checkScheduleButton";
            this._checkScheduleButton.Size = new System.Drawing.Size(75, 23);
            this._checkScheduleButton.TabIndex = 2;
            this._checkScheduleButton.Text = "查詢";
            this._checkScheduleButton.UseVisualStyleBackColor = true;
            this._checkScheduleButton.Click += new System.EventHandler(this.ClickCheckScheduleButton);
            // 
            // _classScheduleDataGridView
            // 
            this._classScheduleDataGridView.AllowUserToAddRows = false;
            this._classScheduleDataGridView.AllowUserToDeleteRows = false;
            this._classScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._classScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            this._classScheduleDataGridView.Location = new System.Drawing.Point(12, 83);
            this._classScheduleDataGridView.Name = "_classScheduleDataGridView";
            this._classScheduleDataGridView.ReadOnly = true;
            this._classScheduleDataGridView.RowTemplate.Height = 24;
            this._classScheduleDataGridView.Size = new System.Drawing.Size(703, 436);
            this._classScheduleDataGridView.TabIndex = 3;
            // 
            // Time
            // 
            this.Time.HeaderText = "";
            this.Time.Name = "Time";
            // 
            // Monday
            // 
            this.Monday.HeaderText = "星期一";
            this.Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "星期二";
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "星期三";
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "星期四";
            this.Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            this.Friday.HeaderText = "星期五";
            this.Friday.Name = "Friday";
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "星期六";
            this.Saturday.Name = "Saturday";
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "星期日";
            this.Sunday.Name = "Sunday";
            // 
            // PersonalClassSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 531);
            this.Controls.Add(this._classScheduleDataGridView);
            this.Controls.Add(this._checkScheduleButton);
            this.Controls.Add(this._idTextBox);
            this.Controls.Add(this._idLabel);
            this.Name = "PersonalClassSchedule";
            this.Text = "PersonalClassSchedule";
            ((System.ComponentModel.ISupportInitialize)(this._classScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _idLabel;
        private System.Windows.Forms.TextBox _idTextBox;
        private System.Windows.Forms.Button _checkScheduleButton;
        private System.Windows.Forms.DataGridView _classScheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
    }
}