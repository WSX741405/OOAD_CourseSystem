﻿namespace CourseSystem.View
{
    partial class Register
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
            this._userIdTextBox = new System.Windows.Forms.TextBox();
            this._userPwdTextBox = new System.Windows.Forms.TextBox();
            this._idLabel = new System.Windows.Forms.Label();
            this._pwdLabel = new System.Windows.Forms.Label();
            this._registerOKButton = new System.Windows.Forms.Button();
            this._registerCancelButton = new System.Windows.Forms.Button();
            this._userIdentityLabel = new System.Windows.Forms.Label();
            this._userComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _userIdTextBox
            // 
            this._userIdTextBox.Location = new System.Drawing.Point(127, 66);
            this._userIdTextBox.Name = "_userIdTextBox";
            this._userIdTextBox.Size = new System.Drawing.Size(100, 22);
            this._userIdTextBox.TabIndex = 0;
            // 
            // _userPwdTextBox
            // 
            this._userPwdTextBox.Location = new System.Drawing.Point(127, 111);
            this._userPwdTextBox.Name = "_userPwdTextBox";
            this._userPwdTextBox.Size = new System.Drawing.Size(100, 22);
            this._userPwdTextBox.TabIndex = 1;
            this._userPwdTextBox.TextChanged += new System.EventHandler(this.TextChangeduserPwdTextBox);
            // 
            // _idLabel
            // 
            this._idLabel.AutoSize = true;
            this._idLabel.Location = new System.Drawing.Point(46, 69);
            this._idLabel.Name = "_idLabel";
            this._idLabel.Size = new System.Drawing.Size(63, 12);
            this._idLabel.TabIndex = 2;
            this._idLabel.Text = "使用者Id：";
            // 
            // _pwdLabel
            // 
            this._pwdLabel.AutoSize = true;
            this._pwdLabel.Location = new System.Drawing.Point(46, 114);
            this._pwdLabel.Name = "_pwdLabel";
            this._pwdLabel.Size = new System.Drawing.Size(41, 12);
            this._pwdLabel.TabIndex = 3;
            this._pwdLabel.Text = "密碼：";
            // 
            // _registerOKButton
            // 
            this._registerOKButton.Location = new System.Drawing.Point(48, 187);
            this._registerOKButton.Name = "_registerOKButton";
            this._registerOKButton.Size = new System.Drawing.Size(75, 23);
            this._registerOKButton.TabIndex = 4;
            this._registerOKButton.Text = "確定";
            this._registerOKButton.UseVisualStyleBackColor = true;
            this._registerOKButton.Click += new System.EventHandler(this.ClickRegisterOKButton);
            // 
            // _registerCancelButton
            // 
            this._registerCancelButton.Location = new System.Drawing.Point(152, 187);
            this._registerCancelButton.Name = "_registerCancelButton";
            this._registerCancelButton.Size = new System.Drawing.Size(75, 23);
            this._registerCancelButton.TabIndex = 5;
            this._registerCancelButton.Text = "取消";
            this._registerCancelButton.UseVisualStyleBackColor = true;
            this._registerCancelButton.Click += new System.EventHandler(this.ClickRegisterCancelButton);
            // 
            // _userIdentityLabel
            // 
            this._userIdentityLabel.AutoSize = true;
            this._userIdentityLabel.Location = new System.Drawing.Point(46, 151);
            this._userIdentityLabel.Name = "_userIdentityLabel";
            this._userIdentityLabel.Size = new System.Drawing.Size(77, 12);
            this._userIdentityLabel.TabIndex = 6;
            this._userIdentityLabel.Text = "使用者身分：";
            // 
            // _userComboBox
            // 
            this._userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._userComboBox.FormattingEnabled = true;
            this._userComboBox.Items.AddRange(new object[] {
            "Student",
            "Professor"});
            this._userComboBox.Location = new System.Drawing.Point(127, 148);
            this._userComboBox.Name = "_userComboBox";
            this._userComboBox.Size = new System.Drawing.Size(121, 20);
            this._userComboBox.TabIndex = 7;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 263);
            this.Controls.Add(this._userComboBox);
            this.Controls.Add(this._userIdentityLabel);
            this.Controls.Add(this._registerCancelButton);
            this.Controls.Add(this._registerOKButton);
            this.Controls.Add(this._pwdLabel);
            this.Controls.Add(this._idLabel);
            this.Controls.Add(this._userPwdTextBox);
            this.Controls.Add(this._userIdTextBox);
            this.Name = "Register";
            this.Text = "註冊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _userIdTextBox;
        private System.Windows.Forms.TextBox _userPwdTextBox;
        private System.Windows.Forms.Label _idLabel;
        private System.Windows.Forms.Label _pwdLabel;
        private System.Windows.Forms.Button _registerOKButton;
        private System.Windows.Forms.Button _registerCancelButton;
        private System.Windows.Forms.Label _userIdentityLabel;
        private System.Windows.Forms.ComboBox _userComboBox;
    }
}