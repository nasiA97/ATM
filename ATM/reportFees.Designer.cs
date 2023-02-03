namespace ATM
{
    partial class reportFees
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
            this.feeCB = new System.Windows.Forms.CheckBox();
            this.banksCB = new System.Windows.Forms.ComboBox();
            this.toDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveReportCSV = new System.Windows.Forms.Button();
            this.saveReportPDF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveReportCSV);
            this.panel1.Controls.Add(this.saveReportPDF);
            this.panel1.Controls.Add(this.feeCB);
            this.panel1.Controls.Add(this.banksCB);
            this.panel1.Controls.Add(this.toDTP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fromDTP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 451);
            this.panel1.TabIndex = 2;
            // 
            // feeCB
            // 
            this.feeCB.AutoSize = true;
            this.feeCB.Location = new System.Drawing.Point(506, 50);
            this.feeCB.Name = "feeCB";
            this.feeCB.Size = new System.Drawing.Size(80, 19);
            this.feeCB.TabIndex = 15;
            this.feeCB.Text = "Комиссия";
            this.feeCB.UseVisualStyleBackColor = true;
            this.feeCB.CheckedChanged += new System.EventHandler(this.updateDGVs);
            // 
            // banksCB
            // 
            this.banksCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banksCB.FormattingEnabled = true;
            this.banksCB.Location = new System.Drawing.Point(506, 20);
            this.banksCB.Name = "banksCB";
            this.banksCB.Size = new System.Drawing.Size(174, 23);
            this.banksCB.TabIndex = 3;
            this.banksCB.SelectedIndexChanged += new System.EventHandler(this.updateDGVs);
            // 
            // toDTP
            // 
            this.toDTP.Location = new System.Drawing.Point(238, 20);
            this.toDTP.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.toDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.toDTP.Name = "toDTP";
            this.toDTP.Size = new System.Drawing.Size(130, 23);
            this.toDTP.TabIndex = 2;
            this.toDTP.Value = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.toDTP.ValueChanged += new System.EventHandler(this.updateDGVs);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(402, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Банкоматы банка";
            // 
            // fromDTP
            // 
            this.fromDTP.Location = new System.Drawing.Point(47, 20);
            this.fromDTP.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.fromDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fromDTP.Name = "fromDTP";
            this.fromDTP.Size = new System.Drawing.Size(130, 23);
            this.fromDTP.TabIndex = 1;
            this.fromDTP.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fromDTP.ValueChanged += new System.EventHandler(this.updateDGVs);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(211, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "До";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "От";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(660, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // saveReportCSV
            // 
            this.saveReportCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.saveReportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveReportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveReportCSV.Location = new System.Drawing.Point(158, 400);
            this.saveReportCSV.Name = "saveReportCSV";
            this.saveReportCSV.Size = new System.Drawing.Size(125, 25);
            this.saveReportCSV.TabIndex = 19;
            this.saveReportCSV.Text = "Сохранить CSV";
            this.saveReportCSV.UseVisualStyleBackColor = false;
            this.saveReportCSV.Click += new System.EventHandler(this.saveReportCSV_Click);
            // 
            // saveReportPDF
            // 
            this.saveReportPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.saveReportPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveReportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveReportPDF.Location = new System.Drawing.Point(420, 400);
            this.saveReportPDF.Name = "saveReportPDF";
            this.saveReportPDF.Size = new System.Drawing.Size(125, 25);
            this.saveReportPDF.TabIndex = 20;
            this.saveReportPDF.Text = "Сохранить PDF";
            this.saveReportPDF.UseVisualStyleBackColor = false;
            this.saveReportPDF.Click += new System.EventHandler(this.saveReportPDF_Click);
            // 
            // reportFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 451);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reportFees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по комиссиям";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker toDTP;
        private System.Windows.Forms.DateTimePicker fromDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox banksCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox feeCB;
        private System.Windows.Forms.Button saveReportCSV;
        private System.Windows.Forms.Button saveReportPDF;
    }
}

