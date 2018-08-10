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
    public partial class PopUp_Animal : Form
    {
        private void PopUp_Animal_Load(object sender, EventArgs e)
        {
            // Form Configuration
            this.Text = Variables.GameName;
            this.ShowIcon = false;
            this.ActiveControl = txbTextInsert;
            this.CenterToScreen();
        }

        public PopUp_Animal()
        {
            InitializeComponent();

            // Form Text Definition
            string tempStringA = "What was the animal that you thought about?";
            string tempStringB = "";
            string lableText; //Variable for a temporary text for the Form text.
            Game.SetLabelForm(tempStringA, tempStringB, Variables.ListAnimals, false, out lableText);
            lblText.Text = lableText;
        }

        private void acceptAndClose()
        {
            Game.tempVarCase90 = txbTextInsert.Text;
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            acceptAndClose();
        }

        private void txbTextInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk_Click(this, new EventArgs());
            }
        }

        private void PopUp_Animal_FormClosing(object sender, EventArgs e)
        {
            Game.dueExitForm = true;
            Game.flagState = false;
        }

        private void PopUp_Animal_FormClosing(object sender, FormClosingEventArgs e)
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
