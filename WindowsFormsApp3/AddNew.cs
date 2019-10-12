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
    public partial class AddNew : Form
    {
        public AddNew()
        {
            InitializeComponent();
        }

        public StartWindow form1_ref; // = new Form1;

        /// <summary>
        /// Funkcja towrzy nowy przycisk dla nowego pracownika po kilknięciu guzika OK na panelu AddNew.
        /// Zablokować możliwość wprowadznie pustego guzika!!!
        /// </summary>
        public void OKbutton_Click(object sender, EventArgs e)
        {
            form1_ref.DynamicButton(name_surname_TB.Text);
            form1_ref.Show();
            //Form1 form1 = new Form1();
            //form1.Show();
            this.Hide();    
        }

        private void name_surname_TB_Enter(object sender, EventArgs e)
        {
            if(name_surname_TB.Text == "np. Jacek Kowalski")
            {
                name_surname_TB.Text = "";

                name_surname_TB.ForeColor = Color.Black;
                //form1_ref.shadowtext_TB("np. Jacek Kowalski", "", Color.Black);
            }
        }

        private void name_surname_TB_Leave(object sender, EventArgs e)
        {

            if (name_surname_TB.Text == "")
            {
                name_surname_TB.Text = "np. Jacek Kowalski";

                name_surname_TB.ForeColor = Color.Silver;
            }
        }

        /// <summary>
        /// Funkcja towrzy nowy przycisk dla nowego pracownika po wciśnięciu guzika ENTER.
        /// </summary>
        private void name_surname_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                OKbutton_Click(sender, e);
            }
        }
    }
}
