namespace ATM
{
    partial class banks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteBankBTN = new System.Windows.Forms.Button();
            this.updateBankBTN = new System.Windows.Forms.Button();
            this.addBankBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.deleteBankBTN);
            this.panel1.Controls.Add(this.updateBankBTN);
            this.panel1.Controls.Add(this.addBankBTN);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 401);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(660, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // deleteBankBTN
            // 
            this.deleteBankBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.deleteBankBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBankBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBankBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBankBTN.Location = new System.Drawing.Point(555, 350);
            this.deleteBankBTN.Name = "deleteBankBTN";
            this.deleteBankBTN.Size = new System.Drawing.Size(125, 30);
            this.deleteBankBTN.TabIndex = 3;
            this.deleteBankBTN.Text = "Удалить";
            this.deleteBankBTN.UseVisualStyleBackColor = false;
            this.deleteBankBTN.Click += new System.EventHandler(this.deleteBankBTN_Click);
            // 
            // updateBankBTN
            // 
            this.updateBankBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.updateBankBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBankBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBankBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBankBTN.Location = new System.Drawing.Point(410, 350);
            this.updateBankBTN.Name = "updateBankBTN";
            this.updateBankBTN.Size = new System.Drawing.Size(125, 30);
            this.updateBankBTN.TabIndex = 2;
            this.updateBankBTN.Text = "Изменить";
            this.updateBankBTN.UseVisualStyleBackColor = false;
            this.updateBankBTN.Click += new System.EventHandler(this.updateBankBTN_Click);
            // 
            // addBankBTN
            // 
            this.addBankBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.addBankBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBankBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBankBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBankBTN.Location = new System.Drawing.Point(20, 350);
            this.addBankBTN.Name = "addBankBTN";
            this.addBankBTN.Size = new System.Drawing.Size(250, 30);
            this.addBankBTN.TabIndex = 1;
            this.addBankBTN.Text = "Добавить банк";
            this.addBankBTN.UseVisualStyleBackColor = false;
            this.addBankBTN.Click += new System.EventHandler(this.addBankBTN_Click);
            // 
            // banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 401);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "banks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.banks_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBankBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteBankBTN;
        private System.Windows.Forms.Button updateBankBTN;
    }
}

