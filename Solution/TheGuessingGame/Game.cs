using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGuessingGame
{
    public class Game
    {
        public static bool flagState; // Flag to help the case control.
        public static bool dueExitForm; // Exit intend bit.
        public static string tempVarCase90; // Temporary input variable.
        public static string tempVarCase91; // Temporary input variable.
        static int caseValue = 10; // Case value control.

        public static void MainGame() // Main Game State Control
        {
            string tempText; // temporary usage text variable.
            string animalNameTemp; // temporary usage text variable.
            string placeNameTemp; // temporary usage text variable.

            switch (caseValue)
            {
                case 10: // Start Game - Think about an Animal {OK => Continue, CANCEL = Close Game}
                    Console.WriteLine(caseValue.ToString());
                    tempText = "Think about an animal...";
                    Game.MsgBox_OKCancel(tempText, Variables.GameName, out flagState);

                    //Yes
                    if (flagState == true)
                    {
                        caseValue = 20;
                        flagState = false;
                    }
                    //Calcel
                    else
                    {
                        caseValue = 99;
                        
                    }

                    break;

                case 20: // Does the animal that you tought about lives in water?
                    Console.WriteLine(caseValue.ToString());
                    placeNameTemp = "Water";
                    tempText = "Does the animal that you tought about lives in " + placeNameTemp + " ?";
                    Game.MsgBox_YesNo(tempText, Variables.GameName, out flagState);

                    //Yes
                    if (flagState == true)
                    {
                        caseValue = 30;
                        flagState = false;
                    }
                    //No
                    else if (flagState == false)
                    {
                        if (Variables.ListPlaces.Count < 1)
                        {
                            caseValue = 40;
                            flagState = false;
                        }
                        else
                        {
                            caseValue = 21;
                            flagState = false;
                        }
                    }

                    break;

                case 21: // Check other places.
                    Console.WriteLine(caseValue.ToString());
                    int i = 0;

                    foreach (var item in Variables.ListPlaces)
                    {
                        tempText = "Does the animal that you tought about " + item.ToString() + " ?";
                        Game.MsgBox_YesNo(tempText, Variables.GameName, out flagState);

                        if (flagState == true)
                        {
                            caseValue = 31;
                            flagState = false;
                            break;
                        }

                        else if (flagState == false)
                        {
                            i++;
                        }
                    }

                    if (i >= Variables.ListPlaces.Count)
                    {
                        caseValue = 40;
                        flagState = false;
                    }

                    break;

                case 30: // Is the animal you thought about a Shark?
                    Console.WriteLine(caseValue.ToString());
                    animalNameTemp = "Shark";
                    tempText = "Is the animal you thought about a " + animalNameTemp + " ?";
                    Game.MsgBox_YesNo(tempText, Variables.GameName, out flagState);

                    //Yes
                    if (flagState == true)
                    {
                        caseValue = 98;
                        flagState = false;
                    }
                    //No
                    else
                    {
                        caseValue = 90;
                        flagState = false;
                    }

                    break;

                case 31: // Check other animals, 
                    Console.WriteLine(caseValue.ToString());

                    int j = 0;

                    foreach (var item in Variables.ListAnimals)
                    {
                        tempText = "Is the animal you thought about a " + item.ToString() + " ?";
                        Game.MsgBox_YesNo(tempText, Variables.GameName, out flagState);

                        if (flagState == true)
                        {
                            caseValue = 98;
                            flagState = false;
                            break;
                        }
                        else if (flagState == false)
                        {
                            j++;
                        }
                    }

                    if (j >= Variables.ListPlaces.Count)
                    {
                        caseValue = 90;
                        flagState = false;
                    }

                    break;

                case 40: // Is the animal you thought about a Monkey?
                    Console.WriteLine(caseValue.ToString());
                    animalNameTemp = "Monkey";
                    tempText = "Is the animal you thought about a " + animalNameTemp + " ?";
                    Game.MsgBox_YesNo(tempText, Variables.GameName, out flagState);

                    if (flagState == true)
                    {
                        caseValue = 98;
                        flagState = false;
                    }
                    else
                    {
                        caseValue = 90;
                        flagState = false;
                    }

                    break;

                case 90: // Insert Animal Name
                    Console.WriteLine(caseValue.ToString());

                    LoadForm_PopUpAnimal();

                    if (dueExitForm == true)
                    {
                        caseValue = 10;
                        flagState = false;
                    }

                    if (dueExitForm == false)
                    {
                        caseValue = 91;
                        flagState = false;
                    }
                    
                    break;

                case 91: // Insert Place Name, and list writing.
                    Console.WriteLine(caseValue.ToString());

                    LoadForm_PopUpPlace();

                    if (dueExitForm == true)
                    {
                        caseValue = 10;
                        flagState = false;
                    }

                    if (dueExitForm == false)
                    {
                        GetData(tempVarCase90, Variables.ListAnimals, out Game.flagState);
                        if(flagState == true)
                        { 
                            GetData(tempVarCase91, Variables.ListPlaces, out Game.flagState);
                            if (flagState == true)
                            {
                                caseValue = 10;
                                flagState = false;
                            }
                        }
                    }
                    
                    break;

                case 98: // Win Game State
                    Console.WriteLine(caseValue.ToString());
                    string tempTxt1 = "I win again!";
                    Game.MsgBox_Ok(tempTxt1, Variables.GameName, out flagState);

                    if (flagState == true)
                    {
                        caseValue = 10;
                        flagState = false;
                    }

                    break;

                case 99: // Close Game State
                    Console.WriteLine(caseValue.ToString());
                    Variables.GameRun = false;
                    break;
            } // Switch Case control for the game steps
        }

        public static void GetData(string txtInput, ArrayList OutputList, out bool FlagState)
        {
            bool tempBool = false;

            if (txtInput != null && txtInput != "")
            {
                OutputList.Add(txtInput);
                tempBool = true;
            }
            else
            {
                MessageBox.Show("Please, insert a value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FlagState = tempBool;
        } // Get String and Insert into arraylist.

        public static void SetLabelForm (string Text1, string Text2, ArrayList OutputList, bool UsageOfList, out string OutputText)
        {
            string lastText = "";

            if (UsageOfList == true)
            {
                lastText = Game.tempVarCase90; //OutputList[OutputList.Count].ToString();
            }

            OutputText = Text1 + " " + lastText + " " + Text2;
        } // Set the label text into the form.

        public static void MsgBox_OKCancel(string TxtText, string TxtTitle, out bool YesNo)
        {
            var result = MessageBox.Show(TxtText, TxtTitle, MessageBoxButtons.OKCancel);
            bool temp = false;

            if (result == DialogResult.OK)
            {
                temp = true;
            }
            else if (result == DialogResult.Cancel)
            {
                temp = false;
            }

            YesNo = temp;
        } // Custom MessageBox with OK and Cancel Button.

        public static void MsgBox_YesNo(string TxtText, string TxtTitle, out bool YesNo)
        {
            var result = MessageBox.Show(TxtText, TxtTitle, MessageBoxButtons.YesNo);
            bool temp = false;

            if (result == DialogResult.Yes)
            {
                temp = true;
            }
            else if (result == DialogResult.No)
            {
                temp = false;
            }

            YesNo = temp;
        }  // Custom MessageBox with YES and No Button.

        public static void MsgBox_Ok(string TxtText, string TxtTitle, out bool YesNo)
        {
            var result = MessageBox.Show(TxtText, TxtTitle, MessageBoxButtons.OK);
            bool temp = false;

            if (result == DialogResult.OK)
            {
                temp = true;
            }
            
            YesNo = temp;
        } // Custom MessageBox with only OK Button.

        public static void LoadForm_PopUpAnimal() // Show the form to input the Animals.
        {          
            var form = new PopUp_Animal();
            form.ShowDialog();
        }

        public static void LoadForm_PopUpPlace() // Show the form to input the Places.
        {
            var form = new PopUp_Place();
            form.ShowDialog();
        }

    }

}
