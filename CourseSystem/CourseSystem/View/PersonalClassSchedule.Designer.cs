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
            this._addidLabel = new System.Windows.Forms.Label();
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
            this._currentIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._classScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _addidLabel
            // 
            this._addidLabel.AutoSize = true;
            this._addidLabel.Location = new System.Drawing.Point(380, 43);
            this._addidLabel.Name = "_addidLabel";
            this._addidLabel.Size = new System.Drawing.Size(77, 12);
            this._addidLabel.TabIndex = 0;
            this._addidLabel.Text = "請輸入學號：";
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
            this._checkScheduleButton.Location = new System.Drawing.Point(581, 39);
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
            this._classScheduleDataGridView.Size = new System.Drawing.Size(644, 436);
            this._classScheduleDataGridView.TabIndex = 3;
            // 
            // Time
            // 
            this.Time.HeaderText = "";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 75;
            // 
            // Monday
            // 
            this.Monday.HeaderText = "星期一";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Width = 75;
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "星期二";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Width = 75;
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "星期三";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Width = 76;
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "星期四";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Width = 75;
            // 
            // Friday
            // 
            this.Friday.HeaderText = "星期五";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Width = 75;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "星期六";
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.Width = 75;
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "星期日";
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            this.Sunday.Width = 75;
            // 
            // _currentIdLabel
            // 
            this._currentIdLabel.AutoSize = true;
            this._currentIdLabel.Location = new System.Drawing.Point(55, 42);
            this._currentIdLabel.Name = "_currentIdLabel";
            this._currentIdLabel.Size = new System.Drawing.Size(0, 12);
            this._currentIdLabel.TabIndex = 4;
            // 
            // PersonalClassSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 531);
            this.Controls.Add(this._currentIdLabel);
            this.Controls.Add(this._classScheduleDataGridView);
            this.Controls.Add(this._checkScheduleButton);
            this.Controls.Add(this._idTextBox);
            this.Controls.Add(this._addidLabel);
            this.Name = "PersonalClassSchedule";
            this.Text = "PersonalClassSchedule";
            ((System.ComponentModel.ISupportInitialize)(this._classScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _addidLabel;
        private System.Windows.Forms.TextBox _idTextBox;
        private System.Windows.Forms.Button _checkScheduleButton;
        private System.Windows.Forms.DataGridView _classScheduleDataGridView;
        private System.Windows.Forms.Label _currentIdLabel;
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