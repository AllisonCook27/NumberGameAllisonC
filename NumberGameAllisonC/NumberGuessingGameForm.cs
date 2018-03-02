/*
     * Created by: Allison Cook
     * Created on: 2 March, 2018
     * Created for: ICS3U Programming
     * Daily Assignment – Day #15 - Number Guessing Game
     * This program asks the user to guess a number form 1-10 and see if the guessed the right number
    */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGameAllisonC
{
    public partial class frmNumberGuessingGame : Form
    {
        //variable
        int userNumber;
        public frmNumberGuessingGame()
        {
            InitializeComponent();
            //hide text before it starts
            lblright.Hide();
            lblWrong.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program when "Exit" is clicked
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //hide text if using agian without starting up
            lblright.Hide();
            lblWrong.Hide(); 

            //local constant
            const int NUMBER = 9;

            try
            {
                //Try to set it as a number
                userNumber = Convert.ToInt16(txtInput.Text);
            }
            catch
            {
                //tell the user they need to input a number
                MessageBox.Show("Please input a number");
            }

            if (userNumber == NUMBER)
            {
                //show the user they got it right
                lblright.Show();
                this.picCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                //show the user they got it wrong
                lblWrong.Show();
                this.picCheck.Image = Properties.Resources.red_x;

            }
        }
    }
}
