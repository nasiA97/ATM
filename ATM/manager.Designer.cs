namespace ATM
{
    partial class manager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteClientBTN = new System.Windows.Forms.Button();
            this.updateClientBTN = new System.Windows.Forms.Button();
            this.addClientBTN = new System.Windows.Forms.Button();
            this.Information.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.userRoleLB.Location = new System.Drawing.Point(353, 10);
            this.userRoleLB.Name = "userRoleLB";
            this.userRoleLB.Size = new System.Drawing.Size(327, 21);
            this.userRoleLB.TabIndex = 0;
            this.userRoleLB.Text = "testRole";
            this.userRoleLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userNameLB
            // 
            this.userNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLB.Location = new System.Drawing.Point(17, 10);
            this.userNameLB.Name = "userNameLB";
            this.userNameLB.Size = new System.Drawing.Size(327, 21);
            this.userNameLB.TabIndex = 0;
            this.userNameLB.Text = "testName";
            this.userNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.deleteClientBTN);
            this.panel1.Controls.Add(this.updateClientBTN);
            this.panel1.Controls.Add(this.addClientBTN);
            this.panel1.Controls.Add(this.Information);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 441);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(660, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // deleteClientBTN
            // 
            this.deleteClientBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.deleteClientBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteClientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClientBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteClientBTN.Location = new System.Drawing.Point(555, 390);
            this.deleteClientBTN.Name = "deleteClientBTN";
            this.deleteClientBTN.Size = new System.Drawing.Size(125, 30);
            this.deleteClientBTN.TabIndex = 2;
            this.deleteClientBTN.Text = "Удалить";
            this.deleteClientBTN.UseVisualStyleBackColor = false;
            this.deleteClientBTN.Click += new System.EventHandler(this.deleteClientBTN_Click);
            // 
            // updateClientBTN
            // 
            this.updateClientBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.updateClientBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateClientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateClientBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateClientBTN.Location = new System.Drawing.Point(410, 390);
            this.updateClientBTN.Name = "updateClientBTN";
            this.updateClientBTN.Size = new System.Drawing.Size(125, 30);
            this.updateClientBTN.TabIndex = 2;
            this.updateClientBTN.Text = "Изменить";
            this.updateClientBTN.UseVisualStyleBackColor = false;
            this.updateClientBTN.Click += new System.EventHandler(this.updateClientBTN_Click);
            // 
            // addClientBTN
            // 
            this.addClientBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.addClientBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClientBTN.Location = new System.Drawing.Point(20, 390);
            this.addClientBTN.Name = "addClientBTN";
            this.addClientBTN.Size = new System.Drawing.Size(250, 30);
            this.addClientBTN.TabIndex = 2;
            this.addClientBTN.Text = "Добавить клиента";
            this.addClientBTN.UseVisualStyleBackColor = false;
            this.addClientBTN.Click += new System.EventHandler(this.addClientBTN_Click);
            // 
            // manager
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
            this.Name = "manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.manager_FormClosed);
            this.Information.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Information;
        private System.Windows.Forms.Label userNameLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userRoleLB;
        private System.Windows.Forms.Button addClientBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteClientBTN;
        private System.Windows.Forms.Button updateClientBTN;
    }
}

