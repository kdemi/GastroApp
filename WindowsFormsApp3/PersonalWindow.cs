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
    public partial class PersonalWindow : Form
    {
        dataset1 ref_db_obj;
        static DataRow thisPerson_row;
        static int thisPerson_id;
        bool data_existence = false;
        DataRow row_to_delete;
        
        public PersonalWindow(string empoyeeName, dataset1 db)
        {
            InitializeComponent();
            lbPWname.Text = empoyeeName;
            ref_db_obj = db;

            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);

            foreach (DataRow row in ref_db_obj.Employees.Rows)
            { 
                if (lbPWname.Text.CompareTo((string)row["name"]) == 0)
                {
                    thisPerson_row = row;
                    //----------------Ustawienia----------------
                    tb_percent.Text = row["percent"].ToString();
                    tb_rate.Text = row["rate"].ToString();
                    tb_target.Text = row["target"].ToString();
                    thisPerson_id = (int)row["id_user"];
                }
            }

            
            //-----------------Wprowadź dane----------------------
            day_earnings_TB.Text = (ref_db_obj.Tables["IncomeTab"].Columns["days_earnings"].DefaultValue).ToString();
            work_h_TB.Text = (ref_db_obj.Tables["IncomeTab"].Columns["nrOFhours"].DefaultValue).ToString();
            imprest_TB.Text = (ref_db_obj.Tables["IncomeTab"].Columns["imprest"].DefaultValue).ToString();

            foreach (DataRow row in ref_db_obj.Tables["IncomeTab"].Rows)
            {
                if ((row["id_user"].Equals(thisPerson_id) == true) && ((DateTime)row["date"]).Date == DateTime.Now.Date)
                {
                    data_existence = true;
                    row_to_delete = row;
                }
            }
                //------------------------Wypłata---------------------
                showSalary_TB.Text = Wypłata().ToString();
            
            /*
             Wyszukiwanie "id" dla danej osoby, równie dobrze można w ten sposób wyszukać "row" dla danej osoby.
             int id = (from DataRow row in ref_db_obj.Employees.Rows
                      where lbPWname.Text.CompareTo((string)row["name"]) == 0
                      select (int)row["id"]).FirstOrDefault();*/
        }


        //---------------------------------USTAWIENIA--------------------------------------------

        /// <summary>
        /// pole tekstowe ma pobierać nowy text i zmieniać go w bazie danych po kliknieciu enter 
        /// ew. po przejsciu do kolejnej komórki (wyłącznie dla danego pracownika), 
        /// można wprowadzić liczbę całkowitą i system sam zamieni ją na ułamek
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ENTERdataSettings(string column_name, TextBox tempTB, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
            {
                double value;
                double.TryParse(tempTB.Text, out value);

                try
                {
                    if (value > 0.00)
                    {
                        thisPerson_row[column_name] = tempTB.Text;
                        tabControl1.Focus();
                    }
                    else
                    { MessageBox.Show("Wartość pola musi być większa od 0.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                }
                catch (System.ArgumentException)
                { MessageBox.Show("Nie można zapisać. \nWypełnij puste pole.\nWprowadzona wartość musi być większa od 0.", "UWAGA!", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
        }

        private void tb_percent_KeyDown(object sender, KeyEventArgs e)
        {
            ENTERdataSettings("percent", sender as TextBox, e);
        }

        private void tb_rate_KeyDown(object sender, KeyEventArgs e)
        {
            ENTERdataSettings("rate", sender as TextBox, e);
        }

        private void tb_target_KeyDown(object sender, KeyEventArgs e)
        {
            ENTERdataSettings("target", sender as TextBox, e);
        }

        private void savechangesB_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(tb_percent.Text) <= 0 || double.Parse(tb_rate.Text) <= 0 || double.Parse(tb_target.Text) <= 0)
                {
                    MessageBox.Show("Nie można zapisać. \nWypełnij wszystkie puste pola.\nWprowadzona wartość musi być różna od 0.", "UWAGA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    thisPerson_row["percent"] = tb_percent.Text;
                    thisPerson_row["rate"] = tb_rate.Text;
                    thisPerson_row["target"] = tb_target.Text;
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Nie można zapisać. \nWypełnij wszystkie puste pola.\nWprowadzona wartość musi być różna od 0.", "UWAGA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Nie można zapisać. \nWypełnij wszystkie puste pola.\nWprowadzona wartość musi być różna od 0.", "UWAGA!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void RemoveE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Czy na pewno chcesz usunąć pracownika {lbPWname.Text}?", "Usuń pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                thisPerson_row["active_inactive"] = false;
                this.Close();
            }
        }

        //----------------------------------WPROWADŹ----------------------------------------------
        private void ENTERdataEnter(string column_name, TextBox tempTB, KeyEventArgs key)
        {
            
            double value = 0;
            double.TryParse(tempTB.Text, out value);

            if (key.KeyCode == Keys.Enter)
            {
                if (data_existence == true)
                {
                    if (MessageBox.Show("W dniu dzisiejszym wprowadzono już dane do bazy dla tego użytkownika.\nCzy chcesz zastąpić istniejące dane nowymi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    { return; }
                    else
                    { ref_db_obj.Tables["IncomeTab"].Rows.Remove(row_to_delete); }
                }

                if (value >= 0.00)
                {
                    DataRow row = ref_db_obj.Tables["IncomeTab"].NewRow();

                    row["date"] = DateTime.Now;
                    row["id_user"] = thisPerson_id;
                    row["paid"] = false;
                    row[column_name] = tempTB.Text;

                    ref_db_obj.Tables["IncomeTab"].Rows.Add(row);
                }
                else
                { MessageBox.Show("Nie można zapisać.\nWprowadzona wartość musi być większa lub równa 0.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            }
        }
     
        private void day_earnings_TB_KeyDown(object sender, KeyEventArgs e)
        {
            ENTERdataEnter("days_earnings", sender as TextBox, e);
        }

        private void work_h_TB_KeyDown(object sender, KeyEventArgs e)
        {
            ENTERdataEnter("nrOFhours", sender as TextBox, e);
        }

        private void imprest_TB_KeyDown(object sender, KeyEventArgs e)
        {
            ENTERdataEnter("imprest", sender as TextBox, e);
        }

        private void enter_Button_Click(object sender, EventArgs e)
        {
            if (data_existence == true)
            {
                if(MessageBox.Show("W dniu dzisiejszym wprowadzono już dane do bazy dla tego użytkownika.\nCzy chcesz zastąpić istniejące dane nowymi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                { return; }
                else
                { ref_db_obj.Tables["IncomeTab"].Rows.Remove(row_to_delete); }
                //w TYM momencie tracimy wszytskie poprzednie dane, jeżeli użytkownik nie wprowadzi ich ponownie!!
                //używtkownik musi mieć możliwość wprowadzenia nowych danych bez utraty np godzin pracy czy też
                //zaliczek dla danej daty.
                // TO CONSIDER AND DO!!!!!!!!!!!!!!!!!!!!
                }

            if (double.Parse(day_earnings_TB.Text) < 0.00 || double.Parse(work_h_TB.Text) < 0.00 || double.Parse(imprest_TB.Text) < 0.00)
            { MessageBox.Show("Nie można zapisać.\nWprowadzona wartość musi być większa lub równa 0.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            else
            {
                DataRow row = ref_db_obj.Tables["IncomeTab"].NewRow();

                row["id_user"] = thisPerson_id;
                row["date"] = DateTime.Now;
                row["days_earnings"] = day_earnings_TB.Text;
                row["nrOFhours"] = work_h_TB.Text;
                row["imprest"] = imprest_TB.Text;
                row["paid"] = false;

                ref_db_obj.Tables["IncomeTab"].Rows.Add(row);

                this.Close();
            }
        }
    

        //----------------------------------WYPŁATA-------------------------------------------------

        private float Wypłata()
        {
            float procent = (((float)thisPerson_row["percent"]) / 100);
            float pr_od_utarg = 0;
            float suma_h_paracy = 0;
            float zaliczka = 0;

            foreach (DataRow row in ref_db_obj.IncomeTab.Rows)
            {
                if((row["id_user"].Equals(thisPerson_id) == true) && ((DateTime)row["date"] >= dateTimePicker1.Value && ((DateTime)row["date"] <= dateTimePicker2.Value)))
                {
                    if ((float)row["days_earnings"] >= (float)thisPerson_row["target"])
                    {
                        pr_od_utarg += ((float)row["days_earnings"]) * procent;
                    }

                    suma_h_paracy += (float)row["nrOFhours"];
                    zaliczka += (float)row["imprest"];
                }
            }
             
            return (( pr_od_utarg + (suma_h_paracy * ((float)thisPerson_row["rate"]))) - zaliczka) ;
        }

        private void OK_B_salary_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ref_db_obj.IncomeTab.Rows)
            {
                if((row["id_user"].Equals(thisPerson_id) == true) && ((DateTime)row["date"] >= dateTimePicker1.Value && ((DateTime)row["date"] <= dateTimePicker2.Value)) && ((bool)row["paid"] == true))
                {
                    showSalary_TB.Text = Wypłata().ToString(); // w koloże zielonym bo wypłacono
                    showSalary_TB.ForeColor = Color.Green;
                }
                else
                {
                    showSalary_TB.Text = Wypłata().ToString();
                    showSalary_TB.ForeColor = Color.Red; // na czerwono bo nie wypłacono
                }
            }
        }

        //bool timeAndID_condition;

        private void paid_B_salary_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ref_db_obj.IncomeTab.Rows)
            {
               // timeAndID_condition = (row["id_user"].Equals(thisPerson_id) == true) && ((DateTime)row["date"] >= dateTimePicker1.Value && ((DateTime)row["date"] <= dateTimePicker2.Value));

                if ((row["id_user"].Equals(thisPerson_id) == true) && ((DateTime)row["date"] >= dateTimePicker1.Value && ((DateTime)row["date"] <= dateTimePicker2.Value)))
                {
                    row["paid"] = true;
                }
            }
        }

    }
}
