namespace CourseSystem.View
{
    partial class LogIn
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
            this._pwdLabel = new System.Windows.Forms.Label();
            this._userIdTextBox = new System.Windows.Forms.TextBox();
            this._userPwdTextBox = new System.Windows.Forms.TextBox();
            this._logInOKButton = new System.Windows.Forms.Button();
            this._logInCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _idLabel
            // 
            this._idLabel.AutoSize = true;
            this._idLabel.Location = new System.Drawing.Point(49, 59);
            this._idLabel.Name = "_idLabel";
            this._idLabel.Size = new System.Drawing.Size(63, 12);
            this._idLabel.TabIndex = 0;
            this._idLabel.Text = "使用者Id：";
            // 
            // _pwdLabel
            // 
            this._pwdLabel.AutoSize = true;
            this._pwdLabel.Location = new System.Drawing.Point(49, 124);
            this._pwdLabel.Name = "_pwdLabel";
            this._pwdLabel.Size = new System.Drawing.Size(41, 12);
            this._pwdLabel.TabIndex = 1;
            this._pwdLabel.Text = "密碼：";
            // 
            // _userIdTextBox
            // 
            this._userIdTextBox.Location = new System.Drawing.Point(129, 56);
            this._userIdTextBox.Name = "_userIdTextBox";
            this._userIdTextBox.Size = new System.Drawing.Size(100, 22);
            this._userIdTextBox.TabIndex = 2;
            // 
            // _userPwdTextBox
            // 
            this._userPwdTextBox.Location = new System.Drawing.Point(129, 121);
            this._userPwdTextBox.Name = "_userPwdTextBox";
            this._userPwdTextBox.Size = new System.Drawing.Size(100, 22);
            this._userPwdTextBox.TabIndex = 3;
            this._userPwdTextBox.TextChanged += new System.EventHandler(this.TextChangeduserPwdTextBox);
            // 
            // _logInOKButton
            // 
            this._logInOKButton.Location = new System.Drawing.Point(51, 167);
            this._logInOKButton.Name = "_logInOKButton";
            this._logInOKButton.Size = new System.Drawing.Size(75, 23);
            this._logInOKButton.TabIndex = 4;
            this._logInOKButton.Text = "確定";
            this._logInOKButton.UseVisualStyleBackColor = true;
            this._logInOKButton.Click += new System.EventHandler(this.ClickLogInOKButton);
            // 
            // _logInCancelButton
            // 
            this._logInCancelButton.Location = new System.Drawing.Point(154, 167);
            this._logInCancelButton.Name = "_logInCancelButton";
            this._logInCancelButton.Size = new System.Drawing.Size(75, 23);
            this._logInCancelButton.TabIndex = 5;
            this._logInCancelButton.Text = "取消";
            this._logInCancelButton.UseVisualStyleBackColor = true;
            this._logInCancelButton.Click += new System.EventHandler(this.ClickLogInCancelButton);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 264);
            this.Controls.Add(this._logInCancelButton);
            this.Controls.Add(this._logInOKButton);
            this.Controls.Add(this._userPwdTextBox);
            this.Controls.Add(this._userIdTextBox);
            this.Controls.Add(this._pwdLabel);
            this.Controls.Add(this._idLabel);
            this.Name = "LogIn";
            this.Text = "登入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _idLabel;
        private System.Windows.Forms.Label _pwdLabel;
        private System.Windows.Forms.TextBox _userIdTextBox;
        private System.Windows.Forms.TextBox _userPwdTextBox;
        private System.Windows.Forms.Button _logInOKButton;
        private System.Windows.Forms.Button _logInCancelButton;
    }
}