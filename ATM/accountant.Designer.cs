namespace ATM
{
    partial class accountant
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
            this.Information = new System.Windows.Forms.Panel();
            this.userRoleLB = new System.Windows.Forms.Label();
            this.userNameLB = new System.Windows.Forms.Label();
            this.transactionsBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportAtmsBTN = new System.Windows.Forms.Button();
            this.reportFeesBTN = new System.Windows.Forms.Button();
            this.Information.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Information.Controls.Add(this.userRoleLB);
            this.Information.Controls.Add(this.userNameLB);
            this.Information.Location = new System.Drawing.Point(-1, -1);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(704, 41);
            this.Information.TabIndex = 1;
            // 
            // userRoleLB
            // 
            this.userRoleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userRoleLB.Location = new System.Drawing.Point(372, 10);
            this.userRoleLB.Name = "userRoleLB";
            this.userRoleLB.Size = new System.Drawing.Size(327, 21);
            this.userRoleLB.TabIndex = 0;
            this.userRoleLB.Text = "testRole";
            this.userRoleLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userNameLB
            // 
            this.userNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLB.Location = new System.Drawing.Point(3, 10);
            this.userNameLB.Name = "userNameLB";
            this.userNameLB.Size = new System.Drawing.Size(327, 21);
            this.userNameLB.TabIndex = 0;
            this.userNameLB.Text = "testName";
            this.userNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionsBTN
            // 
            this.transactionsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.transactionsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactionsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionsBTN.Location = new System.Drawing.Point(235, 170);
            this.transactionsBTN.Name = "transactionsBTN";
            this.transactionsBTN.Size = new System.Drawing.Size(250, 30);
            this.transactionsBTN.TabIndex = 1;
            this.transactionsBTN.Text = "Просмотреть операции";
            this.transactionsBTN.UseVisualStyleBackColor = false;
            this.transactionsBTN.Click += new System.EventHandler(this.transactionsBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reportFeesBTN);
            this.panel1.Controls.Add(this.reportAtmsBTN);
            this.panel1.Controls.Add(this.transactionsBTN);
            this.panel1.Controls.Add(this.Information);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 441);
            this.panel1.TabIndex = 2;
            // 
            // reportAtmsBTN
            // 
            this.reportAtmsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.reportAtmsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportAtmsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportAtmsBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportAtmsBTN.Location = new System.Drawing.Point(235, 220);
            this.reportAtmsBTN.Name = "reportAtmsBTN";
            this.reportAtmsBTN.Size = new System.Drawing.Size(250, 30);
            this.reportAtmsBTN.TabIndex = 2;
            this.reportAtmsBTN.Text = "Статистика по банкоматам";
            this.reportAtmsBTN.UseVisualStyleBackColor = false;
            this.reportAtmsBTN.Click += new System.EventHandler(this.reportAtmsBTN_Click);
            // 
            // reportFeesBTN
            // 
            this.reportFeesBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.reportFeesBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportFeesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportFeesBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportFeesBTN.Location = new System.Drawing.Point(235, 270);
            this.reportFeesBTN.Name = "reportFeesBTN";
            this.reportFeesBTN.Size = new System.Drawing.Size(250, 30);
            this.reportFeesBTN.TabIndex = 3;
            this.reportFeesBTN.Text = "Отчет по комиссиям";
            this.reportFeesBTN.UseVisualStyleBackColor = false;
            this.reportFeesBTN.Click += new System.EventHandler(this.reportFeesBTN_Click);
            // 
            // accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "accountant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бухгалтер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.accountant_FormClosed);
            this.Information.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Information;
        private System.Windows.Forms.Label userNameLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userRoleLB;
        private System.Windows.Forms.Button transactionsBTN;
        private System.Windows.Forms.Button reportAtmsBTN;
        private System.Windows.Forms.Button reportFeesBTN;
    }
}

