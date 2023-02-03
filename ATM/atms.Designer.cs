namespace ATM
{
    partial class atms
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
            this.deleteAtmBTN = new System.Windows.Forms.Button();
            this.updateAtmBTN = new System.Windows.Forms.Button();
            this.addAtmBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.deleteAtmBTN);
            this.panel1.Controls.Add(this.updateAtmBTN);
            this.panel1.Controls.Add(this.addAtmBTN);
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
            // deleteAtmBTN
            // 
            this.deleteAtmBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.deleteAtmBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAtmBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAtmBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAtmBTN.Location = new System.Drawing.Point(555, 350);
            this.deleteAtmBTN.Name = "deleteAtmBTN";
            this.deleteAtmBTN.Size = new System.Drawing.Size(125, 30);
            this.deleteAtmBTN.TabIndex = 3;
            this.deleteAtmBTN.Text = "Удалить";
            this.deleteAtmBTN.UseVisualStyleBackColor = false;
            this.deleteAtmBTN.Click += new System.EventHandler(this.deleteAtmBTN_Click);
            // 
            // updateAtmBTN
            // 
            this.updateAtmBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.updateAtmBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateAtmBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateAtmBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateAtmBTN.Location = new System.Drawing.Point(410, 350);
            this.updateAtmBTN.Name = "updateAtmBTN";
            this.updateAtmBTN.Size = new System.Drawing.Size(125, 30);
            this.updateAtmBTN.TabIndex = 2;
            this.updateAtmBTN.Text = "Изменить";
            this.updateAtmBTN.UseVisualStyleBackColor = false;
            this.updateAtmBTN.Click += new System.EventHandler(this.updateAtmBTN_Click);
            // 
            // addAtmBTN
            // 
            this.addAtmBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.addAtmBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAtmBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAtmBTN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAtmBTN.Location = new System.Drawing.Point(20, 350);
            this.addAtmBTN.Name = "addAtmBTN";
            this.addAtmBTN.Size = new System.Drawing.Size(250, 30);
            this.addAtmBTN.TabIndex = 1;
            this.addAtmBTN.Text = "Добавить банкомат";
            this.addAtmBTN.UseVisualStyleBackColor = false;
            this.addAtmBTN.Click += new System.EventHandler(this.addAtmBTN_Click);
            // 
            // atms
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
            this.Name = "atms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банкоматы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.atms_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addAtmBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteAtmBTN;
        private System.Windows.Forms.Button updateAtmBTN;
    }
}

