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
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _courseDataGridView
            // 
            this._courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseDataGridView.Location = new System.Drawing.Point(33, 184);
            this._courseDataGridView.Name = "_courseDataGridView";
            this._courseDataGridView.RowTemplate.Height = 24;
            this._courseDataGridView.Size = new System.Drawing.Size(347, 167);
            this._courseDataGridView.TabIndex = 0;
            // 
            // SelectedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 409);
            this.Controls.Add(this._courseDataGridView);
            this.Name = "SelectedCourse";
            this.Text = "SelectedCourse";
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _courseDataGridView;
    }
}