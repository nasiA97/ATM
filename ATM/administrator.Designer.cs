namespace ATM
{
    partial class administrator
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
            this.banksBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.atmsBTN = new System.Windows.Forms.Button();
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
            // banksBTN
            // 
            this.banksBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.banksBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.banksBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.banksBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.banksBTN.Location = new System.Drawing.Point(235, 200);
            this.banksBTN.Name = "banksBTN";
            this.banksBTN.Size = new System.Drawing.Size(250, 30);
            this.banksBTN.TabIndex = 1;
            this.banksBTN.Text = "Банки";
            this.banksBTN.UseVisualStyleBackColor = false;
            this.banksBTN.Click += new System.EventHandler(this.banksBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.atmsBTN);
            this.panel1.Controls.Add(this.banksBTN);
            this.panel1.Controls.Add(this.Information);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 441);
            this.panel1.TabIndex = 2;
            // 
            // atmsBTN
            // 
            this.atmsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.atmsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atmsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atmsBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.atmsBTN.Location = new System.Drawing.Point(235, 250);
            this.atmsBTN.Name = "atmsBTN";
            this.atmsBTN.Size = new System.Drawing.Size(250, 30);
            this.atmsBTN.TabIndex = 2;
            this.atmsBTN.Text = "Банкоматы";
            this.atmsBTN.UseVisualStyleBackColor = false;
            this.atmsBTN.Click += new System.EventHandler(this.atmsBTN_Click);
            // 
            // administrator
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
            this.Name = "administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.administrator_FormClosed);
            this.Information.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Information;
        private System.Windows.Forms.Label userNameLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userRoleLB;
        private System.Windows.Forms.Button banksBTN;
        private System.Windows.Forms.Button atmsBTN;
    }
}

