//Sasha Heyburgh 19336832

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SashaHeyburgh_19336832_GADE5111_Assignment1
{
    public partial class Form1 : Form
    {
        string[] arrPlayer1 = new string[3];    //declaration of arrays to store player and dragon stats
        string[] arrPlayer2 = new string[3];
        int[] arrDragonStats1 = new int[4];
        int[] arrDragonStats2 = new int[4];
        Boolean boolStats1 = false;
        Boolean boolStats2 = false;

        public const string fireDrag = "Fire Dragon";   //constant declarations for Fire Dragon stats
        public const int fireDragHP = 20;
        public const int fireDragAttack = 5;
        public const int fireDragSpecial = 12;
        public const int fireDragBlock = 4;

        public const string iceDrag = "Ice Dragon";     //constant declarations for Ice Dragon stats
        public const int iceDragHP = 30;
        public const int iceDragAttack = 4;
        public const int iceDragSpecial = 9;
        public const int iceDragBlock = 5;

        public const string windDrag = "Wind Dragon";   //constant declarations for Wind Dragon stats
        public const int windDragHP = 40;
        public const int windDragAttack = 3;
        public const int windDragSpecial = 7;
        public const int windDragBlock = 5;

        public const string earthDrag = "Earth Dragon"; //constant declarations for Earth Dragon stats
        public const int earthDragHP = 50;
        public const int earthDragAttack = 2;
        public const int earthDragSpecial = 5;
        public const int earthDragBlock = 6;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            btnStartGame.Enabled = false;   //Disabling the Start Game button when the form loads
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            string playerName1 = txtPlayer1Name.Text;   //declaration of variables for Player 1 Name, Dragon Name and Dragon Type
            string dragName1 = txtDragon1Name.Text;
            string dragType1 = "";   

            if (radFireDragon1.Checked)     //if statements to check which radio button is selected
            {
                dragType1 = radFireDragon1.Text;
            }
            else if (radIceDragon1.Checked)
            {
                dragType1 = radIceDragon1.Text;
            }
            else if (radWindDragon1.Checked)
            {
                dragType1 = radWindDragon1.Text;
            }
            else if (radEarthDragon1.Checked)
            {
                dragType1 = radEarthDragon1.Text;
            }
            else
            {
                MessageBox.Show("Please Select a Dragon Type");     //Message shown if user has not selected a Dragon Type
            }

            if (playerName1 == "" || dragName1 == "")   //checking for user input
            {
                MessageBox.Show("Please Enter your Information");
            }
            else
            {
                arrPlayer1[0] = playerName1;    //adding user input to array
                arrPlayer1[1] = dragName1;
                arrPlayer1[2] = dragType1;
            }

            boolStats1 = true;
            saveValues(playerName1, dragName1, dragType1);  //calling SaveValues method
            btnSave1.Enabled = false;   //disabling Player 1 Save button
            enableStart();  //calling method to enable Start Game button
        }

        public void saveValues(string playerName, string dragName, string dragType)
        {
            if (boolStats1 == true)     //if statement to take the Dragon Type that player 1 has chosen and add it's stats to the Dragon Stats array
            {
                if (dragType == fireDrag)   //fire dragon stats
                {
                    arrPlayer1[2] = "Fire Dragon";
                    arrDragonStats1[0] = fireDragHP;
                    arrDragonStats1[1] = fireDragAttack;
                    arrDragonStats1[2] = fireDragSpecial;
                    arrDragonStats1[3] = fireDragBlock;
                }
                else if (dragType == iceDrag)   //ice dragon stats
                {
                    arrPlayer1[2] = "Ice Dragon";
                    arrDragonStats1[0] = iceDragHP;
                    arrDragonStats1[1] = iceDragAttack;
                    arrDragonStats1[2] = iceDragSpecial;
                    arrDragonStats1[3] = iceDragBlock;
                }
                else if (dragType == windDrag)  //wind dragon stats
                {
                    arrPlayer1[2] = "Wind Dragon";
                    arrDragonStats1[0] = windDragHP;
                    arrDragonStats1[1] = windDragAttack;
                    arrDragonStats1[2] = windDragSpecial;
                    arrDragonStats1[3] = windDragBlock;
                }
                else if (dragType == earthDrag)     //earth dragon stats
                {
                    arrPlayer1[2] = "Earth Dragon";
                    arrDragonStats1[0] = earthDragHP;
                    arrDragonStats1[1] = earthDragAttack;
                    arrDragonStats1[2] = earthDragSpecial;
                    arrDragonStats1[3] = earthDragBlock;
                }

                boolStats1 = false;
            }

            if (boolStats2 == true)     //if statement to take the Dragon Type that player 1 has chosen and add it's stats to the Dragon Stats array
            {
                if (dragType == fireDrag)   //fire dragon stats
                {
                    arrPlayer2[2] = "Fire Dragon";
                    arrDragonStats2[0] = fireDragHP;
                    arrDragonStats2[1] = fireDragAttack;
                    arrDragonStats2[2] = fireDragSpecial;
                    arrDragonStats2[3] = fireDragBlock;
                }
                else if (dragType == iceDrag)   //ice dragon stats
                {
                    arrPlayer2[2] = "Ice Dragon";
                    arrDragonStats2[0] = iceDragHP;
                    arrDragonStats2[1] = iceDragAttack;
                    arrDragonStats2[2] = iceDragSpecial;
                    arrDragonStats2[3] = iceDragBlock;
                }
                else if (dragType == windDrag)      //wind dragon stats
                {
                    arrPlayer2[2] = "Wind Dragon";
                    arrDragonStats2[0] = windDragHP;
                    arrDragonStats2[1] = windDragAttack;
                    arrDragonStats2[2] = windDragSpecial;
                    arrDragonStats2[3] = windDragBlock;
                }
                else if (dragType == earthDrag)     //earth dragon stats
                {
                    arrPlayer2[2] = "Earth Dragon";
                    arrDragonStats2[0] = earthDragHP;
                    arrDragonStats2[1] = earthDragAttack;
                    arrDragonStats2[2] = earthDragSpecial;
                    arrDragonStats2[3] = earthDragBlock;
                }

                boolStats2 = false;
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            string playerName2 = txtPlayer2Name.Text;   //declaration of variables for Player 2 Name, Dragon Name and Dragon Type
            string dragName2 = txtDragon2Name.Text;
            string dragType2 = "0";

            if (radFireDragon2.Checked)     //if statements to check which radio button is selected
            {
                dragType2 = radFireDragon2.Text;
            }
            else if (radIceDragon2.Checked)
            {
                dragType2 = radIceDragon2.Text;
            }
            else if (radWindDragon2.Checked)
            {
                dragType2 = radWindDragon2.Text;
            }
            else if (radEarthDragon2.Checked)
            {
                dragType2 = radEarthDragon2.Text;
            }
            else
            {
                MessageBox.Show("Please Select a Dragon Type");     //Message shown if user has not selected a Dragon Type
            }

            if (playerName2 == "" || dragName2 == "")   //checking for user input
            {
                MessageBox.Show("Please Enter your Information");
            }
            else
            {
                arrPlayer2[0] = playerName2;    //adding user input to array
                arrPlayer2[1] = dragName2;
                arrPlayer2[2] = dragType2;
            }

            boolStats2 = true;
            saveValues(playerName2, dragName2, dragType2);  //calling SaveValues method
            btnSave2.Enabled = false;   //disabling Player 2 Save button
            enableStart();  //calling method to enable Start Game button
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();    //hiding Form1 and showing the Player Turn form
            FormPlayerTurn FormPlayerTurn = new FormPlayerTurn();
            FormPlayerTurn.arrPlayer1 = arrPlayer1;
            FormPlayerTurn.arrPlayer2 = arrPlayer2;
            FormPlayerTurn.arrDragonStats1 = arrDragonStats1;
            FormPlayerTurn.arrDragonStats2 = arrDragonStats2;
            FormPlayerTurn.ShowDialog();
            FormPlayerTurn.Show();
        }
        public void enableStart()
        {
            if (btnSave1.Enabled == false && btnSave2.Enabled == false)     //if statement to enable the Start Game button IF both Save buttons are disabled
            {
                btnStartGame.Enabled = true;
            }
            else
            {
                //nothing
            }
        }

        public string[] callArrPlayer1()    //returning Player1 array inside a method to access from Form2 (aka FormPlayerTurn)
        {
            return arrPlayer1;
        }

        public string[] callArrPlayer2()    //returning Player2 array inside a method to access from Form2 (aka FormPlayerTurn)
        {
            return arrPlayer2;
        }

        public int[] callArrDragonStats1()  //returning Dragon Stats1 array inside a method to access from Form2 (aka FormPlayerTurn)
        {
            return arrDragonStats1;
        }

        public int[] callArrDragonStats2()  //returning Dragon Stats2 array inside a method to access from Form2 (aka FormPlayerTurn)
        {
            return arrDragonStats2;
        }
    }
}
