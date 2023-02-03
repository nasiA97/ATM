namespace ATM
{
    partial class login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.errorLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(100, 78);
            this.passwordTB.MaxLength = 50;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(260, 20);
            this.passwordTB.TabIndex = 2;
            this.passwordTB.MouseEnter += new System.EventHandler(this.passwordTB_change_visibility);
            this.passwordTB.MouseLeave += new System.EventHandler(this.passwordTB_change_visibility);
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.loginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBTN.Location = new System.Drawing.Point(150, 114);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(100, 35);
            this.loginBTN.TabIndex = 3;
            this.loginBTN.Text = "Войти";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(100, 38);
            this.loginTB.MaxLength = 50;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(260, 20);
            this.loginTB.TabIndex = 1;
            // 
            // errorLB
            // 
            this.errorLB.ForeColor = System.Drawing.Color.Red;
            this.errorLB.Location = new System.Drawing.Point(12, 162);
            this.errorLB.Name = "errorLB";
            this.errorLB.Size = new System.Drawing.Size(360, 21);
            this.errorLB.TabIndex = 6;
            this.errorLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 198);
            this.Controls.Add(this.errorLB);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label errorLB;
    }
}

