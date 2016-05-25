namespace CourseSystem.View
{
    partial class AddCourse
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
            this._courseNameLabel = new System.Windows.Forms.Label();
            this._OKButton = new System.Windows.Forms.Button();
            this._CancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._courseIdLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this._weekLabel = new System.Windows.Forms.Label();
            this._dateComboBox = new System.Windows.Forms.ComboBox();
            this._ClassCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this._timeDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.節數 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._addClassButton = new System.Windows.Forms.Button();
            this._clearClassButton = new System.Windows.Forms.Button();
            this._timesliceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._timeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _courseNameLabel
            // 
            this._courseNameLabel.AutoSize = true;
            this._courseNameLabel.Location = new System.Drawing.Point(40, 32);
            this._courseNameLabel.Name = "_courseNameLabel";
            this._courseNameLabel.Size = new System.Drawing.Size(65, 12);
            this._courseNameLabel.TabIndex = 0;
            this._courseNameLabel.Text = "課程名稱：";
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(203, 377);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 1;
            this._OKButton.Text = "OK";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this.ClickOKButton);
            // 
            // _CancelButton
            // 
            this._CancelButton.Location = new System.Drawing.Point(306, 377);
            this._CancelButton.Name = "_CancelButton";
            this._CancelButton.Size = new System.Drawing.Size(75, 23);
            this._CancelButton.TabIndex = 2;
            this._CancelButton.Text = "Cancel";
            this._CancelButton.UseVisualStyleBackColor = true;
            this._CancelButton.Click += new System.EventHandler(this.ClickCancelButton);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // _courseIdLabel
            // 
            this._courseIdLabel.AutoSize = true;
            this._courseIdLabel.Location = new System.Drawing.Point(40, 71);
            this._courseIdLabel.Name = "_courseIdLabel";
            this._courseIdLabel.Size = new System.Drawing.Size(41, 12);
            this._courseIdLabel.TabIndex = 4;
            this._courseIdLabel.Text = "課號：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // _weekLabel
            // 
            this._weekLabel.AutoSize = true;
            this._weekLabel.Location = new System.Drawing.Point(40, 113);
            this._weekLabel.Name = "_weekLabel";
            this._weekLabel.Size = new System.Drawing.Size(41, 12);
            this._weekLabel.TabIndex = 6;
            this._weekLabel.Text = "日期：";
            // 
            // _dateComboBox
            // 
            this._dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dateComboBox.FormattingEnabled = true;
            this._dateComboBox.Items.AddRange(new object[] {
            "星期一",
            "星期二",
            "星期三",
            "星期四",
            "星期五"});
            this._dateComboBox.Location = new System.Drawing.Point(126, 113);
            this._dateComboBox.Name = "_dateComboBox";
            this._dateComboBox.Size = new System.Drawing.Size(121, 20);
            this._dateComboBox.TabIndex = 7;
            // 
            // _ClassCheckedListBox
            // 
            this._ClassCheckedListBox.CheckOnClick = true;
            this._ClassCheckedListBox.FormattingEnabled = true;
            this._ClassCheckedListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D"});
            this._ClassCheckedListBox.Location = new System.Drawing.Point(271, 57);
            this._ClassCheckedListBox.Name = "_ClassCheckedListBox";
            this._ClassCheckedListBox.Size = new System.Drawing.Size(241, 89);
            this._ClassCheckedListBox.TabIndex = 8;
            // 
            // _timeDataGridView
            // 
            this._timeDataGridView.AllowUserToAddRows = false;
            this._timeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._timeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.日期,
            this.節數});
            this._timeDataGridView.Location = new System.Drawing.Point(271, 163);
            this._timeDataGridView.Name = "_timeDataGridView";
            this._timeDataGridView.ReadOnly = true;
            this._timeDataGridView.RowTemplate.Height = 24;
            this._timeDataGridView.Size = new System.Drawing.Size(284, 148);
            this._timeDataGridView.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // 日期
            // 
            this.日期.HeaderText = "date";
            this.日期.Name = "日期";
            this.日期.ReadOnly = true;
            // 
            // 節數
            // 
            this.節數.HeaderText = "time";
            this.節數.Name = "節數";
            this.節數.ReadOnly = true;
            // 
            // _addClassButton
            // 
            this._addClassButton.Location = new System.Drawing.Point(42, 191);
            this._addClassButton.Name = "_addClassButton";
            this._addClassButton.Size = new System.Drawing.Size(75, 23);
            this._addClassButton.TabIndex = 10;
            this._addClassButton.Text = "加入";
            this._addClassButton.UseVisualStyleBackColor = true;
            this._addClassButton.Click += new System.EventHandler(this.ClickAddClassButton);
            // 
            // _clearClassButton
            // 
            this._clearClassButton.Location = new System.Drawing.Point(151, 191);
            this._clearClassButton.Name = "_clearClassButton";
            this._clearClassButton.Size = new System.Drawing.Size(75, 23);
            this._clearClassButton.TabIndex = 11;
            this._clearClassButton.Text = "取消";
            this._clearClassButton.UseVisualStyleBackColor = true;
            // 
            // _timesliceLabel
            // 
            this._timesliceLabel.AutoSize = true;
            this._timesliceLabel.Location = new System.Drawing.Point(269, 32);
            this._timesliceLabel.Name = "_timesliceLabel";
            this._timesliceLabel.Size = new System.Drawing.Size(41, 12);
            this._timesliceLabel.TabIndex = 12;
            this._timesliceLabel.Text = "節數：";
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 412);
            this.Controls.Add(this._timesliceLabel);
            this.Controls.Add(this._clearClassButton);
            this.Controls.Add(this._addClassButton);
            this.Controls.Add(this._timeDataGridView);
            this.Controls.Add(this._ClassCheckedListBox);
            this.Controls.Add(this._dateComboBox);
            this.Controls.Add(this._weekLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this._courseIdLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._CancelButton);
            this.Controls.Add(this._OKButton);
            this.Controls.Add(this._courseNameLabel);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            ((System.ComponentModel.ISupportInitialize)(this._timeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _courseNameLabel;
        private System.Windows.Forms.Button _OKButton;
        private System.Windows.Forms.Button _CancelButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label _courseIdLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label _weekLabel;
        private System.Windows.Forms.ComboBox _dateComboBox;
        private System.Windows.Forms.CheckedListBox _ClassCheckedListBox;
        private System.Windows.Forms.DataGridView _timeDataGridView;
        private System.Windows.Forms.Button _addClassButton;
        private System.Windows.Forms.Button _clearClassButton;
        private System.Windows.Forms.Label _timesliceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 節數;
    }
}