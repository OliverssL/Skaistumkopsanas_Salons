﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PrecuDatubaze_OL_ZV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn = null;
            sqlite_conn = new SQLiteConnection("Data Source=Precu_Datubaze.db; Version=3; New=True; Compress=True;");

            try
            {

                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return sqlite_conn;
        }

        private void Pierakstīties_Click(object sender, EventArgs e)
        {
            {
                if (Vards.Text != "")
                {
                    SQLiteConnection sqlite_conn;
                    sqlite_conn = CreateConnection();
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "INSERT INTO Klients (Vards, Uzvards, Tel_numurs, Pers_kods, Pers_ID) VALUES (@Vards, @Uzvards, @Tel_numurs, @Pers_kods, Pers_ID)";
         
                   
                }
                else
                {
                    MessageBox.Show("Lūdzu ievadien jūsu Vārdu");
                }
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();

            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Vards_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uzvards_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tel_numurs_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pers_kods_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vards_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Pers_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
