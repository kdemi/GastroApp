using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class StartWindow : Form
    {
        private int nrOFemployee = 0;

        /// <summary>
        /// Function InitializeSW() cleans StartWindow.Panel1 and creates on it new Buttons basing on the data base.
        /// 
        /// przeszukiwanie po tablicach przykład poniżej:
        /// foreach(DataTable tablica in dataset_obj.Tables){   }
        ///     
        /// przeszukiwanie po rerkordach przykład poniżej:
        /// foreach (DataRow rekord in dataset_obj.Tables["Employees"].Rows) {  }
        /// 
        /// </summary>
        public void InitializeSW()
        {
            panel1.Controls.Clear();
        }
        /*
            try
            {
                dataset_obj.ReadXml("Baza.xml");

                foreach (DataRow rekord in dataset_obj.Tables["Employees"].Rows)
                {
                    if ((bool)rekord["active_inactive"] == true)
                        NewButton((string)rekord["name"]);
                }
            }
            catch (System.IO.FileNotFoundException)
            { nrOFemployee = 0; }
        }
         */


        public StartWindow() //<== KONSTRUKTOR!!!!
        {
            InitializeComponent();


            try
            {
                dataset_obj.ReadXml("Baza.xml");

                /*po tablicach
                foreach(DataTable tablica in dataset_obj.Tables)
                {} */

                // po rekordach
                foreach (DataRow rekord in dataset_obj.Tables["Employees"].Rows)
                {
                    if ((bool)rekord["active_inactive"] == true)
                        NewButton((string)rekord["name"]);
                }
            }
            catch (System.IO.FileNotFoundException)
            { nrOFemployee = 0; }

        }


        /// <summary>
        /// dodanie nowego przycisku z nazwą pracownika, poniżej istniejącego już przycisku.
        /// </summary>
        /// <param name="x"> string wyświetlany w nowo utworzonym przycisku</param>
        public void NewButton(string x)
        {
            const int hight = 10;

            Button newEmployee = new Button();
            newEmployee.Height = 62;
            newEmployee.Width = 204;
            if (nrOFemployee == 0)
            {
                newEmployee.Location = new Point(70, hight);
            }
            else
            {
                newEmployee.Location = new Point(70, (hight + (72 * nrOFemployee)));
            }
            newEmployee.Text = x;

            newEmployee.Click += newEmployeeClick;
            panel1.Controls.Add(newEmployee);

            nrOFemployee++;
        }

        /// <summary>
        /// Tworzy nowy przycisk i dodaje nowego pracownika oraz dodaje informacje do bazy danych.
        /// </summary>
        /// <param name="nametext">nazwa nowego pracownika wyświetlana na przycisku i dodawana do bazy danych</param>
        public void DynamicButton(string nametext)
        {

            NewButton(nametext);                               //newEmployee.Name = ($"{Form2.temp}");
                                                               //newEmployee.Click += new EventHandler(newEmployeeClick);
                                                               //addedbutton = newEmployee;
                                                               //dodaj nowy element do tablicy
            DataRow row = dataset_obj.Tables["Employees"].NewRow();
            row["Name"] = nametext;
            dataset_obj.Tables["Employees"].Rows.Add(row);



        }

        public void newEmployeeClick(object sender, EventArgs e)
        {
            PersonalWindow personW = new PersonalWindow(((Button)sender).Text, dataset_obj);
            personW.Show();                                           
        }



        private void /*form1.*/dodajPracownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddNew form2 = new AddNew();
            form2.form1_ref = this;//wskazuje na obiekt form1 klasy Form1
            form2.Show();

            // Form2 form2 = new Form2();
            // form2.Show();                //(new Form2()).Show();
        }



        private void searcher_TextChanged(object sender, EventArgs e)
        {
            string ToConfront = searcher.Text;

            if (searcher.Text != "")
            {
                foreach (Control a in panel1.Controls)
                {
                    if (a.Text.ToUpper().StartsWith(searcher.Text.ToUpper()))
                    {   // wykrzacza się przy wyszukiwaniu !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        panel1.VerticalScroll.Value = panel1.VerticalScroll.Value + a.Location.Y;
                        a.ForeColor = System.Drawing.Color.Green;
                        panel1.PerformLayout();
                    }
                    else
                    {
                        a.ForeColor = System.Drawing.Color.Black;
                    }

                }
            }
            else
            {
                foreach (Control a in panel1.Controls)
                {
                    a.ForeColor = System.Drawing.Color.Black;
                    //System.Drawing.FontStyle.Regular
                }
            }
        }

        
        private void searcher_Enter(object sender, EventArgs e)
        {
            if (searcher.Text == "Wyszukaj pracownika")
            {
                searcher.Text = "";

                searcher.ForeColor = Color.Black;
            }
        }

        private void searcher_Leave(object sender, EventArgs e)
        {

            if (searcher.Text == "")
            {
                searcher.Text = "Wyszukaj pracownika";

                searcher.ForeColor = Color.Silver;
            }
        }

        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataset_obj.WriteXml("Baza.xml");
        }
    }
}
