namespace CourseSystem.View
{
    partial class StudentList
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
            this._studentListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._studentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _studentListDataGridView
            // 
            this._studentListDataGridView.AllowUserToAddRows = false;
            this._studentListDataGridView.AllowUserToDeleteRows = false;
            this._studentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._studentListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this._studentListDataGridView.Location = new System.Drawing.Point(12, 12);
            this._studentListDataGridView.Name = "_studentListDataGridView";
            this._studentListDataGridView.ReadOnly = true;
            this._studentListDataGridView.RowTemplate.Height = 24;
            this._studentListDataGridView.Size = new System.Drawing.Size(174, 169);
            this._studentListDataGridView.TabIndex = 0;
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
            this.Column2.HeaderText = "學生姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // _OKButton
            // 
            this._OKButton.Location = new System.Drawing.Point(59, 196);
            this._OKButton.Name = "_OKButton";
            this._OKButton.Size = new System.Drawing.Size(75, 23);
            this._OKButton.TabIndex = 1;
            this._OKButton.Text = "確認";
            this._OKButton.UseVisualStyleBackColor = true;
            this._OKButton.Click += new System.EventHandler(this.ClickOKButton);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 231);
            this.Controls.Add(this._OKButton);
            this.Controls.Add(this._studentListDataGridView);
            this.Name = "StudentList";
            this.Text = "StudentList";
            ((System.ComponentModel.ISupportInitialize)(this._studentListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _studentListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button _OKButton;
    }
}