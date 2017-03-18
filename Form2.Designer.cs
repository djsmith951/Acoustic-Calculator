namespace AcousticModeling2
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_125 = new System.Windows.Forms.TextBox();
            this.txt_250 = new System.Windows.Forms.TextBox();
            this.txt_500 = new System.Windows.Forms.TextBox();
            this.txt_1k = new System.Windows.Forms.TextBox();
            this.txt_2k = new System.Windows.Forms.TextBox();
            this.txt_4k = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.txt_idMaterialNumber = new System.Windows.Forms.TextBox();
            this.txt_MaterialName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MaterialEditList = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_125
            // 
            this.txt_125.Location = new System.Drawing.Point(40, 130);
            this.txt_125.Name = "txt_125";
            this.txt_125.Size = new System.Drawing.Size(100, 20);
            this.txt_125.TabIndex = 0;
            this.txt_125.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_250
            // 
            this.txt_250.Location = new System.Drawing.Point(147, 129);
            this.txt_250.Name = "txt_250";
            this.txt_250.Size = new System.Drawing.Size(100, 20);
            this.txt_250.TabIndex = 1;
            this.txt_250.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_500
            // 
            this.txt_500.Location = new System.Drawing.Point(254, 129);
            this.txt_500.Name = "txt_500";
            this.txt_500.Size = new System.Drawing.Size(100, 20);
            this.txt_500.TabIndex = 2;
            this.txt_500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_1k
            // 
            this.txt_1k.Location = new System.Drawing.Point(361, 129);
            this.txt_1k.Name = "txt_1k";
            this.txt_1k.Size = new System.Drawing.Size(100, 20);
            this.txt_1k.TabIndex = 3;
            this.txt_1k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_2k
            // 
            this.txt_2k.Location = new System.Drawing.Point(467, 129);
            this.txt_2k.Name = "txt_2k";
            this.txt_2k.Size = new System.Drawing.Size(100, 20);
            this.txt_2k.TabIndex = 4;
            this.txt_2k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_4k
            // 
            this.txt_4k.Location = new System.Drawing.Point(574, 129);
            this.txt_4k.Name = "txt_4k";
            this.txt_4k.Size = new System.Drawing.Size(100, 20);
            this.txt_4k.TabIndex = 5;
            this.txt_4k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(606, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "4kHz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "2kHz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "500Hz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "1kHz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "250Hz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "125Hz";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(160, 172);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // txt_idMaterialNumber
            // 
            this.txt_idMaterialNumber.Location = new System.Drawing.Point(40, 39);
            this.txt_idMaterialNumber.Name = "txt_idMaterialNumber";
            this.txt_idMaterialNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_idMaterialNumber.TabIndex = 30;
            // 
            // txt_MaterialName
            // 
            this.txt_MaterialName.Location = new System.Drawing.Point(40, 86);
            this.txt_MaterialName.Name = "txt_MaterialName";
            this.txt_MaterialName.Size = new System.Drawing.Size(100, 20);
            this.txt_MaterialName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Material Id Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Material Name";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(481, 172);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 33;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MaterialEditList
            // 
            this.MaterialEditList.FormattingEnabled = true;
            this.MaterialEditList.Location = new System.Drawing.Point(553, 39);
            this.MaterialEditList.Name = "MaterialEditList";
            this.MaterialEditList.Size = new System.Drawing.Size(121, 21);
            this.MaterialEditList.TabIndex = 34;
            this.MaterialEditList.SelectedIndexChanged += new System.EventHandler(this.MaterialEditList_SelectedIndexChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(319, 172);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 35;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(27, 223);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "AbsCoef";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(647, 217);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 479);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.MaterialEditList);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaterialName);
            this.Controls.Add(this.txt_idMaterialNumber);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_4k);
            this.Controls.Add(this.txt_2k);
            this.Controls.Add(this.txt_1k);
            this.Controls.Add(this.txt_500);
            this.Controls.Add(this.txt_250);
            this.Controls.Add(this.txt_125);
            this.Name = "Form2";
            this.Text = "Material Editor";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_125;
        private System.Windows.Forms.TextBox txt_250;
        private System.Windows.Forms.TextBox txt_500;
        private System.Windows.Forms.TextBox txt_1k;
        private System.Windows.Forms.TextBox txt_2k;
        private System.Windows.Forms.TextBox txt_4k;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox txt_idMaterialNumber;
        private System.Windows.Forms.TextBox txt_MaterialName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox MaterialEditList;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}