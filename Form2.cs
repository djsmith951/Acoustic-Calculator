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
    public partial class Form2 : Form
    {
        int materialId;
        string MaterialName;
        double txt125;
        double txt250;
        double txt500;
        double txt1k;
        double txt2k;
        double txt4k;

        

        public Form2()
        {
            InitializeComponent();
            FillBox();
        }

        void FillBox()
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
                    MaterialEditList.Items.Add(sName);
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "insert into materials.materialinfo (idMaterialNumber,Name,125Hz,250Hz,500Hz,1kHz,2kHz,4kHz) values('" + this.txt_idMaterialNumber.Text + "','" + this.txt_MaterialName.Text + "','" + this.txt_125.Text + "','" + this.txt_250.Text + "','" + this.txt_500.Text + "','" + this.txt_1k.Text + "','" + this.txt_2k.Text + "','" + this.txt_4k.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Refresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "delete from materials.materialinfo where idMaterialNumber ='" + this.txt_idMaterialNumber.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
        }

        private void MaterialEditList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "select * from materials.materialinfo where name= '" + MaterialEditList.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    materialId = myReader.GetInt32("idMaterialNumber");
                    txt_idMaterialNumber.Text = Convert.ToString(materialId);

                    MaterialName = myReader.GetString("Name");
                    txt_MaterialName.Text = MaterialName;


                    txt125 = myReader.GetDouble("125Hz");
                    txt_125.Text = Convert.ToString(txt125);

                    txt250 = myReader.GetDouble("250Hz");
                    txt_250.Text = Convert.ToString(txt250);

                    txt500 = myReader.GetDouble("500Hz");
                    txt_500.Text = Convert.ToString(txt500);

                    txt1k = myReader.GetDouble("1kHz");
                    txt_1k.Text = Convert.ToString(txt1k);

                    txt2k = myReader.GetDouble("2kHz");
                    txt_2k.Text = Convert.ToString(txt2k);

                    txt4k = myReader.GetDouble("4kHz");
                    txt_4k.Text = Convert.ToString(txt4k);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            {
                
                this.chart1.Series["AbsCoef"].Points.AddXY("125", txt125);
                this.chart1.Series["AbsCoef"].Points.AddXY("250", txt250);
                this.chart1.Series["AbsCoef"].Points.AddXY("500", txt500);
                this.chart1.Series["AbsCoef"].Points.AddXY("1kHz", txt1k);
                this.chart1.Series["AbsCoef"].Points.AddXY("2kHz", txt2k);
                this.chart1.Series["AbsCoef"].Points.AddXY("4kHz", txt4k);
            }
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=blackstone951";
            string Query = "update materials.materialinfo set idMaterialNumber='" + this.txt_idMaterialNumber.Text + "',Name='" + this.txt_MaterialName.Text + "',125Hz='" + this.txt_125.Text + "',250Hz='" + this.txt_250.Text + "',500Hz='" + this.txt_500.Text + "',1kHz='" + this.txt_1k.Text + "',2kHz='" + this.txt_2k.Text + "',4kHz='" + this.txt_4k.Text + "' where idMaterialNumber='" + this.txt_idMaterialNumber.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

       

    }
}
 

