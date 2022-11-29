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
    public partial class FormPlayerTurn : Form
    {   
        int player1Turn;    //declaration of variables
        int player2Turn;
        int iCount;
        Boolean boolPlayer1Turn;
        Boolean boolPlayer2Turn;
        Boolean boolPlayer1Block;
        Boolean boolPlayer2Block;
        Boolean boolRest1;
        Boolean boolRest2;

        public string[] arrPlayer1 { get; set; }    //getting arrays from Form1
        public string[] arrPlayer2 { get; set; }
        public int[] arrDragonStats1 { get; set; }
        public int[] arrDragonStats2 { get; set; }

        public FormPlayerTurn()
        {
            InitializeComponent();
        }

        public void FormPlayerTurn_Load(object sender, EventArgs e)
        {
            btnRest.Hide();
            takeInitiative();   //calling the take initiative method
            customizeForm();    //calling customize form method
            boolPlayer1Block = false;
            boolPlayer2Block = false;
            boolRest1 = false;
            boolRest2 = false;
            iCount = 0;
    }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (boolPlayer1Turn == true)    //Player 1's turn
            {
                arrDragonStats2[0] = Attack();      //calling the attack method                  
                richBattleLog.AppendText("\r\n" + arrPlayer1[1] + " attacks " + arrPlayer2[1] + "! " + arrPlayer2[1] + " takes " + arrDragonStats1[1] + " damage and is now on " + arrDragonStats2[0] + " HP" + "\r\n" +
                                         "--------------------------------------------------");
                DeathCheck();       //calling the death check method
                boolPlayer1Turn = false;
                boolPlayer2Turn = true;
                iCount += 1;    //adding 1 to iCount integer 
                SwitchTurns();      //calling switch turn method
                            
            }
            else if (boolPlayer2Turn == true)   //Player 2's turn
            {
                arrDragonStats1[0] = Attack();      //calling the attack method  
                richBattleLog.AppendText("\r\n" + arrPlayer2[1] + " attacks " + arrPlayer1[1] + "! " + arrPlayer1[1] + " takes " + arrDragonStats2[1] + " damage and is now on " + arrDragonStats1[0] + " HP" + "\r\n" +
                                         "--------------------------------------------------");
                DeathCheck();       //calling the death check method
                boolPlayer2Turn = false;
                boolPlayer1Turn = true;
                iCount += 1;    //adding 1 to iCount integer 
                SwitchTurns();      //calling switch turn method
                             
            }
        }

        public static string[] calledArrPlayer1()
        {
            Form1 FormDragonBattle = new Form1();
            return FormDragonBattle.callArrPlayer1();  //calling Player1 array from Form1
        }

        public static string[] calledArrPlayer2()
        {
            Form1 FormDragonBattle = new Form1();
            return FormDragonBattle.callArrPlayer2();  //calling Player2 array from Form1
        }

        public static int[] calledArrDragonStats1()
        {
            Form1 FormDragonBattle = new Form1();
            return FormDragonBattle.callArrDragonStats1(); //calling DragonStats1 array from Form1
        }

        public static int[] calledArrDragonStats2()
        {
            Form1 FormDragonBattle = new Form1();
            return FormDragonBattle.callArrDragonStats2(); //calling DragonStats2 array from Form1
        }

        public static int randomRoll()    //method to roll dice to generate a random number from 1-6
        {
            int dice;
            Random diceRoll = new Random();
            dice = diceRoll.Next(1, 7);
            return dice;
        }

        public void takeInitiative()
        {
            player1Turn = 0;    //initializing variables
            player2Turn = 0;

            while (player1Turn == player2Turn)      //while loop to keep randomizing the players' dice values until they are different
            {
                player1Turn = randomRoll();
                player2Turn = randomRoll();
            }

            if (player1Turn > player2Turn)      //if statements to check which player goes first
            {
                boolPlayer1Turn = true;
                boolPlayer2Turn = false;
            }
            else if (player2Turn > player1Turn)
            {
                boolPlayer2Turn = true;
                boolPlayer1Turn = false;
            }
        }

        public void customizeForm()
        {
            if (boolPlayer1Turn == true)    //Player 1's turn: all Player 1's information and dragon stats
            {
                FormPlayerTurn FormPlayerTurn = new FormPlayerTurn();
                FormPlayerTurn.Text = arrPlayer1[0] + "'s Turn";
                groupBlaster.Text = arrPlayer1[1] + ", the " + arrPlayer1[2] + "'s Turn";
                lblHP.Text = "HP: " + arrDragonStats1[0];
                groupOpponent.Text = "Opponent: " + arrPlayer2[0];
                lblDragon.Text = arrPlayer2[1] + ", the " + arrPlayer2[2];
                lblOpponentHP.Text = "HP: " + arrDragonStats2[0];
                richBattleLog.Text = "**************************************************" + "\r\n" + 
                                     arrPlayer1[0] + "'s dragon " + arrPlayer1[1] + " takes initiative!" + "\r\n" +
                                     "**************************************************" + "\r\n" +
                                     arrPlayer1[0] + "'s Turn: ";
            }
            else if (boolPlayer2Turn == true)   //Player 2's turn: all Player 2's information and dragon stats
            {
                FormPlayerTurn FormPlayerTurn = new FormPlayerTurn();
                FormPlayerTurn.Text = arrPlayer2[0] + "'s Turn";
                groupBlaster.Text = arrPlayer2[1] + ", the " + arrPlayer2[2] + "'s Turn";
                lblHP.Text = "HP: " + arrDragonStats2[0];
                groupOpponent.Text = "Opponent: " + arrPlayer1[0];
                lblDragon.Text = arrPlayer1[1] + ", the " + arrPlayer1[2];
                lblOpponentHP.Text = "HP: " + arrDragonStats1[0];
                richBattleLog.Text = "**************************************************" + "\r\n" +
                                     arrPlayer2[0] + "'s dragon " + arrPlayer2[1] + " takes initiative!" + "\r\n" +
                                     "**************************************************" + "\r\n" +
                                     arrPlayer2[0] + "'s Turn: ";
            }
        }

        public void Block()     //action for blocking damage
        {
            if (boolPlayer1Turn == true)
            {
                boolPlayer1Block = true;
            }
            if (boolPlayer2Turn == true)
            {
                boolPlayer2Block = true;
            }
        }

        public int Attack()     //attack action and remaining HP
        {
            int hp1Remaining;
            int hp2Remaining;

            hp1Remaining = arrDragonStats1[0];
            hp2Remaining = arrDragonStats2[0];

            if (boolPlayer1Turn == true)    //Player 1's turn
            {
                if (boolPlayer2Block == true)
                {
                    hp2Remaining = hp2Remaining - (arrDragonStats1[1] - arrDragonStats2[3]);     //HP is equal to it's original value minus (attack damage minus block damage)
                    return hp2Remaining;
                }
                else
                {
                    hp2Remaining = hp2Remaining - arrDragonStats1[1];   //HP is equal to it's original value minus attack damage
                    return hp2Remaining;
                }               
            }

            if (boolPlayer2Turn == true)    //Player 2's turn
            {
                if (boolPlayer1Block == true)
                {
                    hp1Remaining = hp1Remaining - (arrDragonStats2[1] - arrDragonStats1[3]);     //HP is equal to it's original value minus (attack damage minus block damage)
                    return hp1Remaining;
                }
                else
                {
                    hp1Remaining = hp1Remaining - arrDragonStats2[1];   //HP is equal to it's original value minus attack damage
                    return hp1Remaining;
                }
            }
            return 0;
        }

        public int SpecialAttack()      //special attack action and remaining HP
        {
            int hp1Remaining;
            int hp2Remaining;

            hp1Remaining = arrDragonStats1[0];
            hp2Remaining = arrDragonStats2[0];

            if (boolPlayer1Turn == true)    //Player 1's turn
            {
                if (boolPlayer2Block == true)
                {
                    hp2Remaining = hp2Remaining - (arrDragonStats1[2] - arrDragonStats2[3]);     //HP is equal to it's original value minus (special attack damage minus block damage)
                    return hp2Remaining;
                }
                else
                {
                    hp2Remaining = hp2Remaining - arrDragonStats1[2];   //HP is equal to it's original value minus special attack damage
                    return hp2Remaining;
                }
            }

            if (boolPlayer2Turn == true)    //Player 2's turn
            {
                if (boolPlayer1Block == true)
                {
                    hp1Remaining = hp1Remaining - (arrDragonStats2[2] - arrDragonStats1[3]);     //HP is equal to it's original value minus (special attack damage minus block damage)
                    return hp1Remaining;
                }
                else
                {
                    hp1Remaining = hp1Remaining - arrDragonStats2[2];   //HP is equal to it's original value minus special attack damage
                    return hp1Remaining;
                }
            }
            return 0;
        }

        private void btnSpecialAttack_Click(object sender, EventArgs e)
        {
            if (boolPlayer1Turn == true)    //Player 1's turn
            {
                arrDragonStats2[0] = SpecialAttack();       //calling the special attack method
                richBattleLog.AppendText("\r\n" + arrPlayer1[1] + " special attacks " + arrPlayer2[1] + "! " + arrPlayer2[1] + " takes " + arrDragonStats1[2] + " damage and is now on " + arrDragonStats2[0] + " HP" + "\r\n" +
                                         "--------------------------------------------------");
                DeathCheck();       //calling the death check method
                boolRest1 = true;
                boolPlayer1Turn = false;
                boolPlayer2Turn = true;
                iCount += 1;    //adding 1 to iCount integer
                SwitchTurns();      //calling switch turns method               
            }
            else if (boolPlayer2Turn == true)   //Player 2's turn
            {
                arrDragonStats1[0] = SpecialAttack();       //calling the special attack method
                richBattleLog.AppendText("\r\n" + arrPlayer2[1] + " special attacks " + arrPlayer1[1] + "! " + arrPlayer1[1] + " takes " + arrDragonStats2[2] + " damage and is now on " + arrDragonStats1[0] + " HP" + "\r\n" +
                                         "--------------------------------------------------");
                DeathCheck();       //calling the death check method
                boolRest2 = true;
                boolPlayer2Turn = false;
                boolPlayer1Turn = true;
                iCount += 1;    //adding 1 to iCount integer
                SwitchTurns();      //calling switch turns method              
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)     //block action button
        {
            Block();    //calling block method

            if (boolPlayer1Block == true)       //Player 1's turn
            {
                richBattleLog.AppendText("\r\n" + arrPlayer1[1] + " blocks " + arrPlayer2[1] + "! " + arrPlayer1[1] + " blocks " + arrDragonStats1[3] + " damage and is now on " + arrDragonStats1[0] + " HP" + "\r\n" +
                                         "--------------------------------------------------");
                DeathCheck();       //calling the death check method
                boolPlayer1Block = false;
                boolPlayer2Block = false;
                boolPlayer1Turn = false;
                boolPlayer2Turn = true;
                iCount += 1;    //adding 1 to iCount integer 
                SwitchTurns();      //calling switch turn method
                              
            }

            if (boolPlayer2Block == true)       //Player 2's turn
            {
                richBattleLog.AppendText("\r\n" + arrPlayer2[1] + " blocks " + arrPlayer1[1] + "! " + arrPlayer2[1] + " blocks " + arrDragonStats2[3] + " damage and is now on " + arrDragonStats2[0] + " HP" + "\r\n" +
                                         "--------------------------------------------------");
                DeathCheck();       //calling the death check method
                boolPlayer1Block = false;
                boolPlayer2Block = false;
                boolPlayer2Turn = false;
                boolPlayer1Turn = true;
                iCount += 1;    //adding 1 to iCount integer 
                SwitchTurns();      //calling switch turn method
                             
            }
        }

        public void SwitchTurns()   //method to assist players switching turns and changing the form to suit the switch
        {
            TakeSecondInitiative();     //calling take initiative method to randomize which player goes first in the next round

            if (boolPlayer1Turn == true)    //Player 1's turn (form display)
            {              
                FormPlayerTurn FormPlayerTurn = new FormPlayerTurn();
                FormPlayerTurn.Text = arrPlayer1[0] + "'s Turn";
                groupBlaster.Text = arrPlayer1[1] + ", the " + arrPlayer1[2] + "'s Turn";
                lblHP.Text = "HP: " + arrDragonStats1[0];
                groupOpponent.Text = "Opponent: " + arrPlayer2[0];
                lblDragon.Text = arrPlayer2[1] + ", the " + arrPlayer2[2];
                lblOpponentHP.Text = "HP: " + arrDragonStats2[0];
                richBattleLog.AppendText("\r\n" + arrPlayer1[0] + "'s Turn: ");

                if (boolRest1 == true)
                {
                    btnRest.Show();
                }
                else if (boolRest1 == false)
                {
                    btnRest.Hide();
                }
            }

            if (boolPlayer2Turn == true)    //Player 2's turn (form display)
            {              
                FormPlayerTurn FormPlayerTurn = new FormPlayerTurn();
                FormPlayerTurn.Text = arrPlayer2[0] + "'s Turn";
                groupBlaster.Text = arrPlayer2[1] + ", the " + arrPlayer2[2] + "'s Turn";
                lblHP.Text = "HP: " + arrDragonStats2[0];
                groupOpponent.Text = "Opponent: " + arrPlayer1[0];
                lblDragon.Text = arrPlayer1[1] + ", the " + arrPlayer1[2];
                lblOpponentHP.Text = "HP: " + arrDragonStats1[0];
                richBattleLog.AppendText("\r\n" + arrPlayer2[0] + "'s Turn: ");

                if (boolRest2 == true)
                {
                    btnRest.Show();
                }
                else if (boolRest2 == false)
                {
                    btnRest.Hide();
                }
            }           
        }

        public void TakeSecondInitiative()      //method to call takeInitiative() and reroll the "dice" every round so a new player starts each round
        {
            if (iCount%2 == 0)
            {
                takeInitiative();
            }
        }

        public void DeathCheck()    //method to check if a dragon is dead aka if their HP is 0 or less
        {
            if (arrDragonStats1[0] <= 0)    //if Player 1 loses
            {
                btnAttack.Enabled = false;
                btnSpecialAttack.Enabled = false;
                btnBlock.Enabled = false;
                richBattleLog.AppendText("\r\n" + arrPlayer1[1] + " is unable to continue. " + arrPlayer2[1] + " is the victor!");
            }

            if (arrDragonStats2[0] <= 0)    //if Player 2 loses
            {
                btnAttack.Enabled = false;
                btnSpecialAttack.Enabled = false;
                btnBlock.Enabled = false;
                richBattleLog.AppendText("\r\n" + arrPlayer2[1] + " is unable to continue. " + arrPlayer1[1] + " is the victor!");
            }
        }

        public void Rest(string dragonsName)
        {
            if (boolRest1 == true)
            {
                richBattleLog.AppendText("\r\n" + dragonsName + " is too tired to fight, and rests a while." + "\r\n" +
                                        "--------------------------------------------------");
                boolRest1 = false;
            }

            if (boolRest2 == true)
            {
                richBattleLog.AppendText("\r\n" + dragonsName + " is too tired to fight, and rests a while." + "\r\n" +
                                        "--------------------------------------------------");
                boolRest2 = false;
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (boolPlayer1Turn == true)
            {
                DeathCheck();       //calling the death check method
                Rest(arrPlayer1[1]);    //calling the rest method
                boolPlayer1Turn = false;
                boolPlayer2Turn = true;
                iCount += 1;    //adding 1 to iCount integer
                SwitchTurns();      //calling switch turns method               
            }
            else if (boolPlayer2Turn == true)
            {
                DeathCheck();       //calling the death check method
                Rest(arrPlayer2[1]);    //calling the rest method
                boolPlayer1Turn = true;
                boolPlayer2Turn = false;
                iCount += 1;    //adding 1 to iCount integer
                SwitchTurns();      //calling switch turns method                               
            }
        }
    }
}
