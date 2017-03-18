using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AcousticModeling2
{
    public partial class Form1 : Form
    {
        double sWall01at125;
        double sWall01at250;
        double sWall01at500;
        double sWall01at1k; 
        double sWall01at2k;
        double sWall01at4k;

        double sWall02at125;
        double sWall02at250;
        double sWall02at500;
        double sWall02at1k;
        double sWall02at2k;
        double sWall02at4k;

        double sWall03at125;
        double sWall03at250;
        double sWall03at500;
        double sWall03at1k;
        double sWall03at2k;
        double sWall03at4k;

        double sWall04at125;
        double sWall04at250;
        double sWall04at500;
        double sWall04at1k;
        double sWall04at2k;
        double sWall04at4k;

        double sWall05at125;
        double sWall05at250;
        double sWall05at500;
        double sWall05at1k;
        double sWall05at2k;
        double sWall05at4k;

        double sWall06at125;
        double sWall06at250;
        double sWall06at500;
        double sWall06at1k;
        double sWall06at2k;
        double sWall06at4k;

        double RT125;
        double RT250;
        double RT500;
        double RT1k;
        double RT2k;
        double RT4k;

        double Lmode1;
        double Lmode2;
        double Lmode3;
        double Lmode4;
        double Lmode5;

        double Wmode1;
        double Wmode2;
        double Wmode3;
        double Wmode4;
        double Wmode5;

        double Hmode1;
        double Hmode2;
        double Hmode3;
        double Hmode4;
        double Hmode5;

        double c;

        double x;

        


        public Form1()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "select * from materials.materialinfo ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("name");
                    Wall01Material.Items.Add(sName);
                    Wall2Material.Items.Add(sName);
                    Wall3Material.Items.Add(sName);
                    Wall4Material.Items.Add(sName);
                    Wall5Material.Items.Add(sName);
                    Wall6Material.Items.Add(sName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Wall01Material_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "select * from materials.materialinfo where name= '" + Wall01Material.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    sWall01at125 = myReader.GetDouble("125Hz");
                    sWall01at250 = myReader.GetDouble("250Hz");
                    sWall01at500 = myReader.GetDouble("500Hz");
                    sWall01at1k = myReader.GetDouble("1kHz");
                    sWall01at2k = myReader.GetDouble("2kHz");
                    sWall01at4k = myReader.GetDouble("4kHz");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Wall2Material_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "select * from materials.materialinfo where name= '" + Wall2Material.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    sWall02at125 = myReader.GetDouble("125Hz");
                    sWall02at250 = myReader.GetDouble("250Hz");
                    sWall02at500 = myReader.GetDouble("500Hz");
                    sWall02at1k = myReader.GetDouble("1kHz");
                    sWall02at2k = myReader.GetDouble("2kHz");
                    sWall02at4k = myReader.GetDouble("4kHz");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Wall3Material_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "select * from materials.materialinfo where name= '" + Wall3Material.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    sWall03at125 = myReader.GetDouble("125Hz");
                    sWall03at250 = myReader.GetDouble("250Hz");
                    sWall03at500 = myReader.GetDouble("500Hz");
                    sWall03at1k = myReader.GetDouble("1kHz");
                    sWall03at2k = myReader.GetDouble("2kHz");
                    sWall03at4k = myReader.GetDouble("4kHz");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Wall4Material_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "select * from materials.materialinfo where name= '" + Wall4Material.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    sWall04at125 = myReader.GetDouble("125Hz");
                    sWall04at250 = myReader.GetDouble("250Hz");
                    sWall04at500 = myReader.GetDouble("500Hz");
                    sWall04at1k = myReader.GetDouble("1kHz");
                    sWall04at2k = myReader.GetDouble("2kHz");
                    sWall04at4k = myReader.GetDouble("4kHz");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Wall5Material_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "select * from materials.materialinfo where name= '" + Wall5Material.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    sWall05at125 = myReader.GetDouble("125Hz");
                    sWall05at250 = myReader.GetDouble("250Hz");
                    sWall05at500 = myReader.GetDouble("500Hz");
                    sWall05at1k = myReader.GetDouble("1kHz");
                    sWall05at2k = myReader.GetDouble("2kHz");
                    sWall05at4k = myReader.GetDouble("4kHz");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Wall6Material_SelectedIndexChanged(object sender, EventArgs e)
        {


            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "select * from materials.materialinfo where name= '" + Wall6Material.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    sWall06at125 = myReader.GetDouble("125Hz");
                    sWall06at250 = myReader.GetDouble("250Hz");
                    sWall06at500 = myReader.GetDouble("500Hz");
                    sWall06at1k = myReader.GetDouble("1kHz");
                    sWall06at2k = myReader.GetDouble("2kHz");
                    sWall06at4k = myReader.GetDouble("4kHz");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                private void button1_Click_1(object sender, EventArgs e)
                {
                    double height = Convert.ToDouble(HeightBox.Text);
                    double width = Convert.ToDouble(WidthBox.Text);
                    double length = Convert.ToDouble(LengthBox.Text);
                    c = Convert.ToDouble(SpeedofSound.Text);

                    double volume = height * width * length;
                    double surfacearea = (2 * (height * width)) + (2 * (height * length)) + (2 * (width * length));

                    VolumeBox.Text = Convert.ToString(volume);
                    SurfaceAreaBox.Text = Convert.ToString(surfacearea);

                    double s1 = length * height;
                    double s2 = length * height;
                    double s3 = width * height;
                    double s4 = width * height;
                    double s5 = length * width;
                    double s6 = length * width;

                    double atot125 = (s1*sWall01at125 + s2*sWall02at125 + s3*sWall03at125 + s4*sWall04at125 + s5*sWall05at125 + s6*sWall06at125)+(volume*.00615);
                    double atot250 = (s1 * sWall01at250 + s2 * sWall02at250 + s3 * sWall03at250 + s4 * sWall04at250 + s5 * sWall05at250 + s6 * sWall06at250)+(volume*.0142);
                    double atot500 = (s1 * sWall01at500 + s2 * sWall02at500 + s3 * sWall03at500 + s4 * sWall04at500 + s5 * sWall05at500 + s6 * sWall06at500)+(volume * .0252);
                    double atot1k =  (s1 * sWall01at1k + s2 * sWall02at1k + s3 * sWall03at1k + s4 * sWall04at1k + s5 * sWall05at1k + s6 * sWall06at1k)+(volume * .0501);
                    double atot2k = (s1 * sWall01at2k + s2 * sWall02at2k + s3 * sWall03at2k + s4 * sWall04at2k + s5 * sWall05at2k + s6 * sWall06at2k)+(volume * .141);
                    double atot4k = (s1 * sWall01at4k + s2 * sWall02at4k + s3 * sWall03at4k + s4 * sWall04at4k + s5 * sWall05at4k + s6 * sWall06at4k)+(volume*.485);

                    RT125 = (x * volume) / atot125 ;
                    RT250 = (x * volume) / atot250;
                    RT500 = (x * volume) / atot500;
                    RT1k = (x * volume) / atot1k;
                    RT2k = (x * volume) / atot2k;
                    RT4k = (x * volume) / atot4k;



                    RT125Box.Text = RT125.ToString("0.00");
                    //RT125Box.Text = Convert.ToString(RT125);
                    RT250Box.Text = RT250.ToString("0.00");
                   // RT250Box.Text = Convert.ToString(RT250);
                    RT500Box.Text = RT500.ToString("0.00");
                    //RT500Box.Text = Convert.ToString(RT500);
                    RT1kBox.Text = RT1k.ToString("0.00");
                    //RT1kBox.Text = Convert.ToString(RT1k);
                    RT2kBox.Text = RT2k.ToString("0.00");
                    //RT2kBox.Text = Convert.ToString(RT2k);
                    RT4kBox.Text = RT4k.ToString("0.00");
                    //RT4kBox.Text = Convert.ToString(RT4k);
                    double AverageRT60 = (RT125 + RT250 + RT500 + RT1k + RT2k + RT4k)/6;

                    AverageRT60Box.Text = AverageRT60.ToString("0.00");
                    //AverageRT60Box.Text = Convert.ToString(AverageRT60);


                    Lmode1 = c / (2 * length);
                    Lmode2 = Lmode1 * 2;
                    Lmode3 = Lmode1 * 3;
                    Lmode4 = Lmode1 * 4;
                    Lmode5 = Lmode1 * 5;

                    Wmode1 = c / (2 * width);
                    Wmode2 = Wmode1 * 2;
                    Wmode3 = Wmode1 * 3;
                    Wmode4 = Wmode1 * 4;
                    Wmode5 = Wmode1 * 5;

                    Hmode1 = c / (2 * height);
                    Hmode2 = Hmode1 * 2;
                    Hmode3 = Hmode1 * 3;
                    Hmode4 = Hmode1 * 4;
                    Hmode5 = Hmode1 * 5;

                    Lmode1Box.Text = Convert.ToString(Lmode1);
                    Lmode2Box.Text = Convert.ToString(Lmode2);
                    Lmode3Box.Text = Convert.ToString(Lmode3);

                    Wmode1Box.Text = Convert.ToString(Wmode1);
                    Wmode2Box.Text = Convert.ToString(Wmode2);
                    Wmode3Box.Text = Convert.ToString(Wmode3);

                    Hmode1Box.Text = Convert.ToString(Hmode1);
                    Hmode2Box.Text = Convert.ToString(Hmode2);
                    Hmode3Box.Text = Convert.ToString(Hmode3);

                    double MeanFreePath = (4*volume)/(surfacearea);
                    MeanFreePathBox.Text = MeanFreePath.ToString("0.00");
                    //MeanFreePathBox.Text = Convert.ToString(MeanFreePath);

                    double SchroederFrequency = Math.Pow((AverageRT60 / volume), (.5))*2000;
                    SchroederFrequencyBox.Text = SchroederFrequency.ToString("0.00");
                    //SchroederFrequencyBox.Text = Convert.ToString(SchroederFrequency);

                    double BassRatio = ((RT125+RT250)/(RT500+RT1k));
                    BassRatioBox.Text = BassRatio.ToString("0.00");
                    //BassRatioBox.Text = Convert.ToString(BassRatio);



                    //this.chart1.Series["RT"].Points.AddXY("125", RT125);
                    //this.chart1.Series["RT"].Points.AddXY("250", RT250);
                    //this.chart1.Series["RT"].Points.AddXY("500", RT500);
                    //this.chart1.Series["RT"].Points.AddXY("1kHz", RT1k);
                    //this.chart1.Series["RT"].Points.AddXY("2kHz", RT2k);
                    //this.chart1.Series["RT"].Points.AddXY("4kHz", RT4k);




                }
                private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
                {

                    if (comboBox1.Text == "Feet")
                    {
                        x = .049;
                    }
                    else if (comboBox1.Text == "Meters")
                    {
                        x = .161;
                    }
                }

                private void button2_Click(object sender, EventArgs e)
                {
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }

                private void RefreshButton_Click(object sender, EventArgs e)
                {
                   this.Refresh(); 
                }

               


          
            

               
            }
        }
    






        
      
      

        




    

