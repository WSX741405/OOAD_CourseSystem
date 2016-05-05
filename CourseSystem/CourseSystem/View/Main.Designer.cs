namespace CourseSystem
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
            this._computeGradeButton = new System.Windows.Forms.Button();
            this._registerButton = new System.Windows.Forms.Button();
            this._loginButton = new System.Windows.Forms.Button();
            this._logoutButton = new System.Windows.Forms.Button();
            this._helloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _checkClassScheduleButton
            // 
            this._checkClassScheduleButton.Location = new System.Drawing.Point(33, 70);
            this._checkClassScheduleButton.Name = "_checkClassScheduleButton";
            this._checkClassScheduleButton.Size = new System.Drawing.Size(75, 23);
            this._checkClassScheduleButton.TabIndex = 0;
            this._checkClassScheduleButton.Text = "查詢課表";
            this._checkClassScheduleButton.UseVisualStyleBackColor = true;
            this._checkClassScheduleButton.Visible = false;
            this._checkClassScheduleButton.Click += new System.EventHandler(this.ClickCheckClassScheduleButton);
            // 
            // _computeGradeButton
            // 
            this._computeGradeButton.Location = new System.Drawing.Point(126, 70);
            this._computeGradeButton.Name = "_computeGradeButton";
            this._computeGradeButton.Size = new System.Drawing.Size(75, 23);
            this._computeGradeButton.TabIndex = 1;
            this._computeGradeButton.Text = "成績計算";
            this._computeGradeButton.UseVisualStyleBackColor = true;
            this._computeGradeButton.Visible = false;
            this._computeGradeButton.Click += new System.EventHandler(this.ClickComputeGradeButton);
            // 
            // _registerButton
            // 
            this._registerButton.Location = new System.Drawing.Point(462, 35);
            this._registerButton.Name = "_registerButton";
            this._registerButton.Size = new System.Drawing.Size(75, 23);
            this._registerButton.TabIndex = 2;
            this._registerButton.Text = "註冊";
            this._registerButton.UseVisualStyleBackColor = true;
            this._registerButton.Click += new System.EventHandler(this.ClickRegisterButton);
            // 
            // _loginButton
            // 
            this._loginButton.Location = new System.Drawing.Point(557, 35);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(75, 23);
            this._loginButton.TabIndex = 3;
            this._loginButton.Text = "登入";
            this._loginButton.UseVisualStyleBackColor = true;
            this._loginButton.Click += new System.EventHandler(this.ClickLogInButton);
            // 
            // _logoutButton
            // 
            this._logoutButton.Location = new System.Drawing.Point(557, 35);
            this._logoutButton.Name = "_logoutButton";
            this._logoutButton.Size = new System.Drawing.Size(75, 23);
            this._logoutButton.TabIndex = 4;
            this._logoutButton.Text = "登出";
            this._logoutButton.UseVisualStyleBackColor = true;
            this._logoutButton.Visible = false;
            // 
            // _helloLabel
            // 
            this._helloLabel.AutoSize = true;
            this._helloLabel.Location = new System.Drawing.Point(31, 13);
            this._helloLabel.Name = "_helloLabel";
            this._helloLabel.Size = new System.Drawing.Size(0, 12);
            this._helloLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 320);
            this.Controls.Add(this._helloLabel);
            this.Controls.Add(this._logoutButton);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this._registerButton);
            this.Controls.Add(this._computeGradeButton);
            this.Controls.Add(this._checkClassScheduleButton);
            this.Name = "Form1";
            this.Text = "課程系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _checkClassScheduleButton;
        private System.Windows.Forms.Button _computeGradeButton;
        private System.Windows.Forms.Button _registerButton;
        private System.Windows.Forms.Button _loginButton;
        private System.Windows.Forms.Button _logoutButton;
        private System.Windows.Forms.Label _helloLabel;
    }
}

