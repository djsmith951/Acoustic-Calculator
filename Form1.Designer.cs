namespace AcousticModeling2
{
    partial class Form1
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
            this.Wall01Material = new System.Windows.Forms.ComboBox();
            this.Wall2Material = new System.Windows.Forms.ComboBox();
            this.Wall3Material = new System.Windows.Forms.ComboBox();
            this.Wall4Material = new System.Windows.Forms.ComboBox();
            this.Wall5Material = new System.Windows.Forms.ComboBox();
            this.Wall6Material = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LengthBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.VolumeBox = new System.Windows.Forms.TextBox();
            this.SurfaceAreaBox = new System.Windows.Forms.TextBox();
            this.SpeedofSound = new System.Windows.Forms.TextBox();
            this.RT250Box = new System.Windows.Forms.TextBox();
            this.RT125Box = new System.Windows.Forms.TextBox();
            this.RT500Box = new System.Windows.Forms.TextBox();
            this.RT2kBox = new System.Windows.Forms.TextBox();
            this.RT1kBox = new System.Windows.Forms.TextBox();
            this.RT4kBox = new System.Windows.Forms.TextBox();
            this.Lmode1Box = new System.Windows.Forms.TextBox();
            this.Wmode2Box = new System.Windows.Forms.TextBox();
            this.Hmode1Box = new System.Windows.Forms.TextBox();
            this.Lmode2Box = new System.Windows.Forms.TextBox();
            this.Hmode2Box = new System.Windows.Forms.TextBox();
            this.Lmode3Box = new System.Windows.Forms.TextBox();
            this.Hmode3Box = new System.Windows.Forms.TextBox();
            this.Wmode1Box = new System.Windows.Forms.TextBox();
            this.Wmode3Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AverageRT60Box = new System.Windows.Forms.TextBox();
            this.MeanFreePathBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SchroederFrequencyBox = new System.Windows.Forms.TextBox();
            this.BassRatioBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Wall01Material
            // 
            this.Wall01Material.FormattingEnabled = true;
            this.Wall01Material.Location = new System.Drawing.Point(139, 56);
            this.Wall01Material.Name = "Wall01Material";
            this.Wall01Material.Size = new System.Drawing.Size(121, 21);
            this.Wall01Material.TabIndex = 1;
            this.Wall01Material.Text = "Wall 1 (LxH)";
            this.Wall01Material.SelectedIndexChanged += new System.EventHandler(this.Wall01Material_SelectedIndexChanged_1);
            // 
            // Wall2Material
            // 
            this.Wall2Material.FormattingEnabled = true;
            this.Wall2Material.Location = new System.Drawing.Point(139, 84);
            this.Wall2Material.Name = "Wall2Material";
            this.Wall2Material.Size = new System.Drawing.Size(121, 21);
            this.Wall2Material.TabIndex = 2;
            this.Wall2Material.Text = "Wall 2 (L x H)";
            this.Wall2Material.SelectedIndexChanged += new System.EventHandler(this.Wall2Material_SelectedIndexChanged_1);
            // 
            // Wall3Material
            // 
            this.Wall3Material.FormattingEnabled = true;
            this.Wall3Material.Location = new System.Drawing.Point(139, 112);
            this.Wall3Material.Name = "Wall3Material";
            this.Wall3Material.Size = new System.Drawing.Size(121, 21);
            this.Wall3Material.TabIndex = 3;
            this.Wall3Material.Text = "Wall 3 (W x H)";
            this.Wall3Material.SelectedIndexChanged += new System.EventHandler(this.Wall3Material_SelectedIndexChanged_1);
            // 
            // Wall4Material
            // 
            this.Wall4Material.FormattingEnabled = true;
            this.Wall4Material.Location = new System.Drawing.Point(139, 140);
            this.Wall4Material.Name = "Wall4Material";
            this.Wall4Material.Size = new System.Drawing.Size(121, 21);
            this.Wall4Material.TabIndex = 4;
            this.Wall4Material.Text = "Wall 4 (W x H)";
            this.Wall4Material.SelectedIndexChanged += new System.EventHandler(this.Wall4Material_SelectedIndexChanged_1);
            // 
            // Wall5Material
            // 
            this.Wall5Material.FormattingEnabled = true;
            this.Wall5Material.Location = new System.Drawing.Point(139, 168);
            this.Wall5Material.Name = "Wall5Material";
            this.Wall5Material.Size = new System.Drawing.Size(121, 21);
            this.Wall5Material.TabIndex = 5;
            this.Wall5Material.Text = "Wall 5 (L x W)";
            this.Wall5Material.SelectedIndexChanged += new System.EventHandler(this.Wall5Material_SelectedIndexChanged_1);
            // 
            // Wall6Material
            // 
            this.Wall6Material.FormattingEnabled = true;
            this.Wall6Material.Location = new System.Drawing.Point(139, 196);
            this.Wall6Material.Name = "Wall6Material";
            this.Wall6Material.Size = new System.Drawing.Size(121, 21);
            this.Wall6Material.TabIndex = 6;
            this.Wall6Material.Text = "Wall 6 (L x W)";
            this.Wall6Material.SelectedIndexChanged += new System.EventHandler(this.Wall6Material_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LengthBox
            // 
            this.LengthBox.Location = new System.Drawing.Point(27, 72);
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(100, 20);
            this.LengthBox.TabIndex = 8;
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(27, 130);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 20);
            this.WidthBox.TabIndex = 9;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(27, 197);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 20);
            this.HeightBox.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Feet",
            "Meters"});
            this.comboBox1.Location = new System.Drawing.Point(309, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "(Feet, or Meters)";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // VolumeBox
            // 
            this.VolumeBox.Location = new System.Drawing.Point(690, 177);
            this.VolumeBox.Name = "VolumeBox";
            this.VolumeBox.Size = new System.Drawing.Size(100, 20);
            this.VolumeBox.TabIndex = 12;
            // 
            // SurfaceAreaBox
            // 
            this.SurfaceAreaBox.Location = new System.Drawing.Point(690, 216);
            this.SurfaceAreaBox.Name = "SurfaceAreaBox";
            this.SurfaceAreaBox.Size = new System.Drawing.Size(100, 20);
            this.SurfaceAreaBox.TabIndex = 13;
            // 
            // SpeedofSound
            // 
            this.SpeedofSound.Location = new System.Drawing.Point(309, 84);
            this.SpeedofSound.Name = "SpeedofSound";
            this.SpeedofSound.Size = new System.Drawing.Size(121, 20);
            this.SpeedofSound.TabIndex = 14;
            this.SpeedofSound.Text = "Speed of Sound (sec)";
            // 
            // RT250Box
            // 
            this.RT250Box.Location = new System.Drawing.Point(204, 328);
            this.RT250Box.Name = "RT250Box";
            this.RT250Box.Size = new System.Drawing.Size(100, 20);
            this.RT250Box.TabIndex = 15;
            // 
            // RT125Box
            // 
            this.RT125Box.Location = new System.Drawing.Point(98, 328);
            this.RT125Box.Name = "RT125Box";
            this.RT125Box.Size = new System.Drawing.Size(100, 20);
            this.RT125Box.TabIndex = 15;
            // 
            // RT500Box
            // 
            this.RT500Box.Location = new System.Drawing.Point(310, 328);
            this.RT500Box.Name = "RT500Box";
            this.RT500Box.Size = new System.Drawing.Size(100, 20);
            this.RT500Box.TabIndex = 15;
            // 
            // RT2kBox
            // 
            this.RT2kBox.Location = new System.Drawing.Point(522, 328);
            this.RT2kBox.Name = "RT2kBox";
            this.RT2kBox.Size = new System.Drawing.Size(100, 20);
            this.RT2kBox.TabIndex = 15;
            // 
            // RT1kBox
            // 
            this.RT1kBox.Location = new System.Drawing.Point(416, 328);
            this.RT1kBox.Name = "RT1kBox";
            this.RT1kBox.Size = new System.Drawing.Size(100, 20);
            this.RT1kBox.TabIndex = 15;
            // 
            // RT4kBox
            // 
            this.RT4kBox.Location = new System.Drawing.Point(628, 328);
            this.RT4kBox.Name = "RT4kBox";
            this.RT4kBox.Size = new System.Drawing.Size(100, 20);
            this.RT4kBox.TabIndex = 15;
            // 
            // Lmode1Box
            // 
            this.Lmode1Box.Location = new System.Drawing.Point(690, 58);
            this.Lmode1Box.Name = "Lmode1Box";
            this.Lmode1Box.Size = new System.Drawing.Size(100, 20);
            this.Lmode1Box.TabIndex = 16;
            // 
            // Wmode2Box
            // 
            this.Wmode2Box.Location = new System.Drawing.Point(796, 82);
            this.Wmode2Box.Name = "Wmode2Box";
            this.Wmode2Box.Size = new System.Drawing.Size(100, 20);
            this.Wmode2Box.TabIndex = 16;
            // 
            // Hmode1Box
            // 
            this.Hmode1Box.Location = new System.Drawing.Point(902, 58);
            this.Hmode1Box.Name = "Hmode1Box";
            this.Hmode1Box.Size = new System.Drawing.Size(100, 20);
            this.Hmode1Box.TabIndex = 16;
            // 
            // Lmode2Box
            // 
            this.Lmode2Box.Location = new System.Drawing.Point(690, 82);
            this.Lmode2Box.Name = "Lmode2Box";
            this.Lmode2Box.Size = new System.Drawing.Size(100, 20);
            this.Lmode2Box.TabIndex = 16;
            // 
            // Hmode2Box
            // 
            this.Hmode2Box.Location = new System.Drawing.Point(902, 82);
            this.Hmode2Box.Name = "Hmode2Box";
            this.Hmode2Box.Size = new System.Drawing.Size(100, 20);
            this.Hmode2Box.TabIndex = 16;
            // 
            // Lmode3Box
            // 
            this.Lmode3Box.Location = new System.Drawing.Point(690, 108);
            this.Lmode3Box.Name = "Lmode3Box";
            this.Lmode3Box.Size = new System.Drawing.Size(100, 20);
            this.Lmode3Box.TabIndex = 16;
            // 
            // Hmode3Box
            // 
            this.Hmode3Box.Location = new System.Drawing.Point(902, 108);
            this.Hmode3Box.Name = "Hmode3Box";
            this.Hmode3Box.Size = new System.Drawing.Size(100, 20);
            this.Hmode3Box.TabIndex = 16;
            // 
            // Wmode1Box
            // 
            this.Wmode1Box.Location = new System.Drawing.Point(796, 58);
            this.Wmode1Box.Name = "Wmode1Box";
            this.Wmode1Box.Size = new System.Drawing.Size(100, 20);
            this.Wmode1Box.TabIndex = 16;
            // 
            // Wmode3Box
            // 
            this.Wmode3Box.Location = new System.Drawing.Point(796, 108);
            this.Wmode3Box.Name = "Wmode3Box";
            this.Wmode3Box.Size = new System.Drawing.Size(100, 20);
            this.Wmode3Box.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Room Dimensions (only add values to this section)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Volume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Surface Area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "125Hz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "250Hz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "1kHz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "500Hz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(551, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "2kHz";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(656, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "4kHz";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(741, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Average RT60";
            // 
            // AverageRT60Box
            // 
            this.AverageRT60Box.Location = new System.Drawing.Point(734, 328);
            this.AverageRT60Box.Name = "AverageRT60Box";
            this.AverageRT60Box.Size = new System.Drawing.Size(100, 20);
            this.AverageRT60Box.TabIndex = 24;
            // 
            // MeanFreePathBox
            // 
            this.MeanFreePathBox.Location = new System.Drawing.Point(804, 177);
            this.MeanFreePathBox.Name = "MeanFreePathBox";
            this.MeanFreePathBox.Size = new System.Drawing.Size(100, 20);
            this.MeanFreePathBox.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(813, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Mean Free Path";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(801, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Schroeder Frequency";
            // 
            // SchroederFrequencyBox
            // 
            this.SchroederFrequencyBox.Location = new System.Drawing.Point(802, 215);
            this.SchroederFrequencyBox.Name = "SchroederFrequencyBox";
            this.SchroederFrequencyBox.Size = new System.Drawing.Size(100, 20);
            this.SchroederFrequencyBox.TabIndex = 28;
            // 
            // BassRatioBox
            // 
            this.BassRatioBox.Location = new System.Drawing.Point(917, 176);
            this.BassRatioBox.Name = "BassRatioBox";
            this.BassRatioBox.Size = new System.Drawing.Size(100, 20);
            this.BassRatioBox.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(936, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Bass Ratio";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Material Editor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(777, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 24);
            this.label17.TabIndex = 32;
            this.label17.Text = "Modal Analysis";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(305, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(265, 24);
            this.label18.TabIndex = 33;
            this.label18.Text = "Reverberation Time (seconds)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(731, 351);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(277, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "(Calculations include Air Absorption at 70F and 30% R.H.)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(722, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "L Axis";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(825, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "W Axis";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(936, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "H axis";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(671, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(671, 86);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 37;
            this.label24.Text = "2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(671, 111);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 13);
            this.label25.TabIndex = 37;
            this.label25.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 407);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BassRatioBox);
            this.Controls.Add(this.SchroederFrequencyBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.MeanFreePathBox);
            this.Controls.Add(this.AverageRT60Box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hmode3Box);
            this.Controls.Add(this.Hmode2Box);
            this.Controls.Add(this.Hmode1Box);
            this.Controls.Add(this.Lmode3Box);
            this.Controls.Add(this.Lmode2Box);
            this.Controls.Add(this.Wmode3Box);
            this.Controls.Add(this.Wmode1Box);
            this.Controls.Add(this.Wmode2Box);
            this.Controls.Add(this.Lmode1Box);
            this.Controls.Add(this.RT4kBox);
            this.Controls.Add(this.RT1kBox);
            this.Controls.Add(this.RT2kBox);
            this.Controls.Add(this.RT500Box);
            this.Controls.Add(this.RT125Box);
            this.Controls.Add(this.RT250Box);
            this.Controls.Add(this.SpeedofSound);
            this.Controls.Add(this.SurfaceAreaBox);
            this.Controls.Add(this.VolumeBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.LengthBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Wall6Material);
            this.Controls.Add(this.Wall5Material);
            this.Controls.Add(this.Wall4Material);
            this.Controls.Add(this.Wall3Material);
            this.Controls.Add(this.Wall2Material);
            this.Controls.Add(this.Wall01Material);
            this.Name = "Form1";
            this.Text = "Acoustic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Wall01Material;
        private System.Windows.Forms.ComboBox Wall2Material;
        private System.Windows.Forms.ComboBox Wall3Material;
        private System.Windows.Forms.ComboBox Wall4Material;
        private System.Windows.Forms.ComboBox Wall5Material;
        private System.Windows.Forms.ComboBox Wall6Material;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LengthBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox VolumeBox;
        private System.Windows.Forms.TextBox SurfaceAreaBox;
        private System.Windows.Forms.TextBox SpeedofSound;
        private System.Windows.Forms.TextBox RT250Box;
        private System.Windows.Forms.TextBox RT125Box;
        private System.Windows.Forms.TextBox RT500Box;
        private System.Windows.Forms.TextBox RT2kBox;
        private System.Windows.Forms.TextBox RT1kBox;
        private System.Windows.Forms.TextBox RT4kBox;
        private System.Windows.Forms.TextBox Lmode1Box;
        private System.Windows.Forms.TextBox Wmode2Box;
        private System.Windows.Forms.TextBox Hmode1Box;
        private System.Windows.Forms.TextBox Lmode2Box;
        private System.Windows.Forms.TextBox Hmode2Box;
        private System.Windows.Forms.TextBox Lmode3Box;
        private System.Windows.Forms.TextBox Hmode3Box;
        private System.Windows.Forms.TextBox Wmode1Box;
        private System.Windows.Forms.TextBox Wmode3Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AverageRT60Box;
        private System.Windows.Forms.TextBox MeanFreePathBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox SchroederFrequencyBox;
        private System.Windows.Forms.TextBox BassRatioBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}

