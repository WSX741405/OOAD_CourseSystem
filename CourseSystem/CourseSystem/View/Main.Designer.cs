﻿namespace CourseSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._checkClassScheduleButton = new System.Windows.Forms.Button();
            this._selectCourseButton = new System.Windows.Forms.Button();
            this._registerButton = new System.Windows.Forms.Button();
            this._loginButton = new System.Windows.Forms.Button();
            this._logoutButton = new System.Windows.Forms.Button();
            this._helloLabel = new System.Windows.Forms.Label();
            this._addCourseButton = new System.Windows.Forms.Button();
            this._dropCourseButton = new System.Windows.Forms.Button();
            this._reviewSelectCourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _checkClassScheduleButton
            // 
            this._checkClassScheduleButton.Location = new System.Drawing.Point(33, 59);
            this._checkClassScheduleButton.Name = "_checkClassScheduleButton";
            this._checkClassScheduleButton.Size = new System.Drawing.Size(75, 23);
            this._checkClassScheduleButton.TabIndex = 0;
            this._checkClassScheduleButton.Text = "查詢課表";
            this._checkClassScheduleButton.UseVisualStyleBackColor = true;
            this._checkClassScheduleButton.Visible = false;
            this._checkClassScheduleButton.Click += new System.EventHandler(this.ClickCheckClassScheduleButton);
            // 
            // _selectCourseButton
            // 
            this._selectCourseButton.Location = new System.Drawing.Point(33, 88);
            this._selectCourseButton.Name = "_selectCourseButton";
            this._selectCourseButton.Size = new System.Drawing.Size(75, 23);
            this._selectCourseButton.TabIndex = 1;
            this._selectCourseButton.Text = "學生選課";
            this._selectCourseButton.UseVisualStyleBackColor = true;
            this._selectCourseButton.Visible = false;
            this._selectCourseButton.Click += new System.EventHandler(this.ClickSelectCourseButton);
            // 
            // _registerButton
            // 
            this._registerButton.Location = new System.Drawing.Point(202, 42);
            this._registerButton.Name = "_registerButton";
            this._registerButton.Size = new System.Drawing.Size(75, 23);
            this._registerButton.TabIndex = 2;
            this._registerButton.Text = "註冊";
            this._registerButton.UseVisualStyleBackColor = true;
            this._registerButton.Click += new System.EventHandler(this.ClickRegisterButton);
            // 
            // _loginButton
            // 
            this._loginButton.Location = new System.Drawing.Point(202, 13);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(75, 23);
            this._loginButton.TabIndex = 3;
            this._loginButton.Text = "登入";
            this._loginButton.UseVisualStyleBackColor = true;
            this._loginButton.Click += new System.EventHandler(this.ClickLogInButton);
            // 
            // _logoutButton
            // 
            this._logoutButton.Location = new System.Drawing.Point(202, 13);
            this._logoutButton.Name = "_logoutButton";
            this._logoutButton.Size = new System.Drawing.Size(75, 23);
            this._logoutButton.TabIndex = 4;
            this._logoutButton.Text = "登出";
            this._logoutButton.UseVisualStyleBackColor = true;
            this._logoutButton.Visible = false;
            this._logoutButton.Click += new System.EventHandler(this.ClickLogOutButton);
            // 
            // _helloLabel
            // 
            this._helloLabel.AutoSize = true;
            this._helloLabel.Location = new System.Drawing.Point(31, 13);
            this._helloLabel.Name = "_helloLabel";
            this._helloLabel.Size = new System.Drawing.Size(0, 12);
            this._helloLabel.TabIndex = 5;
            // 
            // _addCourseButton
            // 
            this._addCourseButton.Location = new System.Drawing.Point(33, 88);
            this._addCourseButton.Name = "_addCourseButton";
            this._addCourseButton.Size = new System.Drawing.Size(75, 23);
            this._addCourseButton.TabIndex = 6;
            this._addCourseButton.Text = "新增課程";
            this._addCourseButton.UseVisualStyleBackColor = true;
            this._addCourseButton.Visible = false;
            this._addCourseButton.Click += new System.EventHandler(this.ClickAddCourseButton);
            // 
            // _dropCourseButton
            // 
            this._dropCourseButton.Location = new System.Drawing.Point(114, 88);
            this._dropCourseButton.Name = "_dropCourseButton";
            this._dropCourseButton.Size = new System.Drawing.Size(75, 23);
            this._dropCourseButton.TabIndex = 7;
            this._dropCourseButton.Text = "學生退課";
            this._dropCourseButton.UseVisualStyleBackColor = true;
            this._dropCourseButton.Visible = false;
            this._dropCourseButton.Click += new System.EventHandler(this.ClickDropCourseButton);
            // 
            // _reviewSelectCourseButton
            // 
            this._reviewSelectCourseButton.Location = new System.Drawing.Point(114, 88);
            this._reviewSelectCourseButton.Name = "_reviewSelectCourseButton";
            this._reviewSelectCourseButton.Size = new System.Drawing.Size(88, 23);
            this._reviewSelectCourseButton.TabIndex = 8;
            this._reviewSelectCourseButton.Text = "查詢學生修課";
            this._reviewSelectCourseButton.UseVisualStyleBackColor = true;
            this._reviewSelectCourseButton.Visible = false;
            this._reviewSelectCourseButton.Click += new System.EventHandler(this.ClickReviewSelectCourseButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 121);
            this.Controls.Add(this._reviewSelectCourseButton);
            this.Controls.Add(this._dropCourseButton);
            this.Controls.Add(this._addCourseButton);
            this.Controls.Add(this._helloLabel);
            this.Controls.Add(this._logoutButton);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this._registerButton);
            this.Controls.Add(this._selectCourseButton);
            this.Controls.Add(this._checkClassScheduleButton);
            this.Name = "Form1";
            this.Text = "課程系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _checkClassScheduleButton;
        private System.Windows.Forms.Button _selectCourseButton;
        private System.Windows.Forms.Button _registerButton;
        private System.Windows.Forms.Button _loginButton;
        private System.Windows.Forms.Button _logoutButton;
        private System.Windows.Forms.Label _helloLabel;
        private System.Windows.Forms.Button _addCourseButton;
        private System.Windows.Forms.Button _dropCourseButton;
        private System.Windows.Forms.Button _reviewSelectCourseButton;
    }
}

