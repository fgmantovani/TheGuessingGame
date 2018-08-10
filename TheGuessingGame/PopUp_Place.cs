using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGuessingGame
{
    public partial class PopUp_Place : Form
    {
        private void PopUp_Place_Load(object sender, EventArgs e)
        {
            // Form Configuration
            this.Text = Variables.GameName;
            this.ShowIcon = false;
            this.ActiveControl = txbTextInsert;
            this.CenterToScreen();
        }

        public PopUp_Place()
        {
            InitializeComponent();

            // Form Text Definition
            string tempStringA = "A"; // String Temporary B
            string tempStringB = " ________ but a monkey does not (Fill it with an animal trait, like 'lives in water'."; // String Temporary B
            string lableText; //Variable for a temporary text for the Form text.
            Game.SetLabelForm(tempStringA, tempStringB, Variables.ListAnimals, true, out lableText); // Set Label Text in Form Method <Game.cs>
            lblText.Text = lableText;
        }

        private void acceptAndClose()
        {
            Game.tempVarCase91 = txbTextInsert.Text;
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            acceptAndClose();
        }

        private void txbTextInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnOk_Click(this, new EventArgs());
            }
        }

        private void PopUp_Place_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", Variables.GameName, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Game.dueExitForm = true;
                    Game.flagState = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
            
        }
    }
}
