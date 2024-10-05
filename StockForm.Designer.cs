namespace projectAntonioBrown
{
    partial class StockSelection
    {
        // Necessary designer variable

        private System.ComponentModel.IContainer components = null;

        // Cleans up any resources being used

        // true if managed resources should be disposed; otherwise, false
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.startdatepicker = new System.Windows.Forms.DateTimePicker();
            this.Daily = new System.Windows.Forms.RadioButton();
            this.Weekly = new System.Windows.Forms.RadioButton();
            this.Monthly = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.enddatepicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Ticker = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 208);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(442, 486);
            this.dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Start Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startdatepicker
            // 
            this.startdatepicker.Location = new System.Drawing.Point(316, 61);
            this.startdatepicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startdatepicker.Name = "startdatepicker";
            this.startdatepicker.Size = new System.Drawing.Size(284, 26);
            this.startdatepicker.TabIndex = 13;
            this.startdatepicker.Value = new System.DateTime(2022, 1, 4, 0, 0, 0, 0);
            // 
            // Daily
            // 
            this.Daily.AutoSize = true;
            this.Daily.Location = new System.Drawing.Point(673, 35);
            this.Daily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(68, 24);
            this.Daily.TabIndex = 14;
            this.Daily.Text = "Daily";
            this.Daily.UseVisualStyleBackColor = true;
            this.Daily.CheckedChanged += new System.EventHandler(this.Daily_CheckedChanged);
            // 
            // Weekly
            // 
            this.Weekly.AutoSize = true;
            this.Weekly.Location = new System.Drawing.Point(673, 90);
            this.Weekly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Weekly.Name = "Weekly";
            this.Weekly.Size = new System.Drawing.Size(85, 24);
            this.Weekly.TabIndex = 15;
            this.Weekly.Text = "Weekly";
            this.Weekly.UseVisualStyleBackColor = true;
            this.Weekly.CheckedChanged += new System.EventHandler(this.Weekly_CheckedChanged);
            // 
            // Monthly
            // 
            this.Monthly.AutoSize = true;
            this.Monthly.Location = new System.Drawing.Point(673, 152);
            this.Monthly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Monthly.Name = "Monthly";
            this.Monthly.Size = new System.Drawing.Size(89, 24);
            this.Monthly.TabIndex = 16;
            this.Monthly.Text = "Monthly";
            this.Monthly.UseVisualStyleBackColor = true;
            this.Monthly.CheckedChanged += new System.EventHandler(this.Monthly_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "End Date";
            // 
            // enddatepicker
            // 
            this.enddatepicker.Location = new System.Drawing.Point(316, 118);
            this.enddatepicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enddatepicker.Name = "enddatepicker";
            this.enddatepicker.Size = new System.Drawing.Size(284, 26);
            this.enddatepicker.TabIndex = 18;
            this.enddatepicker.Value = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 101);
            this.button1.TabIndex = 19;
            this.button1.Text = "load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ticker
            // 
            this.Ticker.AutoSize = true;
            this.Ticker.Location = new System.Drawing.Point(69, 35);
            this.Ticker.Name = "Ticker";
            this.Ticker.Size = new System.Drawing.Size(51, 20);
            this.Ticker.TabIndex = 20;
            this.Ticker.Text = "Ticker";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StockSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 859);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Ticker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enddatepicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Monthly);
            this.Controls.Add(this.Weekly);
            this.Controls.Add(this.Daily);
            this.Controls.Add(this.startdatepicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockSelection";
            this.Text = "StockSeletion";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startdatepicker;
        private System.Windows.Forms.RadioButton Daily;
        private System.Windows.Forms.RadioButton Weekly;
        private System.Windows.Forms.RadioButton Monthly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker enddatepicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Ticker;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

