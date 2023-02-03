namespace ATM
{
    partial class addClient
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.addClientBTN = new System.Windows.Forms.Button();
            this.banksCB = new System.Windows.Forms.ComboBox();
            this.cardNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(23, 38);
            this.nameTB.MaxLength = 50;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(260, 20);
            this.nameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адрес";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(23, 146);
            this.addressTB.MaxLength = 150;
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(260, 20);
            this.addressTB.TabIndex = 3;
            // 
            // addClientBTN
            // 
            this.addClientBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.addClientBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClientBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientBTN.Location = new System.Drawing.Point(90, 256);
            this.addClientBTN.Name = "addClientBTN";
            this.addClientBTN.Size = new System.Drawing.Size(125, 25);
            this.addClientBTN.TabIndex = 5;
            this.addClientBTN.Text = "Добавить клиента";
            this.addClientBTN.UseVisualStyleBackColor = false;
            this.addClientBTN.Click += new System.EventHandler(this.addClientBTN_Click);
            // 
            // banksCB
            // 
            this.banksCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banksCB.FormattingEnabled = true;
            this.banksCB.Location = new System.Drawing.Point(23, 200);
            this.banksCB.Name = "banksCB";
            this.banksCB.Size = new System.Drawing.Size(260, 21);
            this.banksCB.TabIndex = 4;
            // 
            // cardNUD
            // 
            this.cardNUD.Location = new System.Drawing.Point(23, 92);
            this.cardNUD.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.cardNUD.Minimum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.cardNUD.Name = "cardNUD";
            this.cardNUD.Size = new System.Drawing.Size(260, 20);
            this.cardNUD.TabIndex = 2;
            this.cardNUD.Value = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер карты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Банк";
            // 
            // addClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 320);
            this.Controls.Add(this.addClientBTN);
            this.Controls.Add(this.banksCB);
            this.Controls.Add(this.cardNUD);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление клиента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addClient_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.cardNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Button addClientBTN;
        private System.Windows.Forms.ComboBox banksCB;
        private System.Windows.Forms.NumericUpDown cardNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}