namespace ATM
{
    partial class addAtm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.addAtmBTN = new System.Windows.Forms.Button();
            this.banksCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Банк";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(23, 38);
            this.addressTB.MaxLength = 150;
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(260, 20);
            this.addressTB.TabIndex = 3;
            // 
            // addAtmBTN
            // 
            this.addAtmBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.addAtmBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAtmBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAtmBTN.Location = new System.Drawing.Point(90, 148);
            this.addAtmBTN.Name = "addAtmBTN";
            this.addAtmBTN.Size = new System.Drawing.Size(125, 25);
            this.addAtmBTN.TabIndex = 5;
            this.addAtmBTN.Text = "Добавить банкомат";
            this.addAtmBTN.UseVisualStyleBackColor = false;
            this.addAtmBTN.Click += new System.EventHandler(this.addAtmBTN_Click);
            // 
            // banksCB
            // 
            this.banksCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banksCB.FormattingEnabled = true;
            this.banksCB.Location = new System.Drawing.Point(23, 92);
            this.banksCB.Name = "banksCB";
            this.banksCB.Size = new System.Drawing.Size(260, 21);
            this.banksCB.TabIndex = 6;
            // 
            // addAtm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 212);
            this.Controls.Add(this.banksCB);
            this.Controls.Add(this.addAtmBTN);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addAtm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление банкомата";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addAtm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Button addAtmBTN;
        private System.Windows.Forms.ComboBox banksCB;
    }
}