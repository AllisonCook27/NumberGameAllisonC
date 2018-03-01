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
            lblright.Hide();
            lblWrong.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //local constant
            const int NUMBER = 9;

            try
            {
                userNumber = Convert.ToInt16(txtInput.Text);
            }
            catch
            {
                MessageBox.Show("Please input a number");
            }

            if (userNumber == NUMBER)
            {
                lblright.Show();
                this.picCheck.Image = Properties.Resources.checkmark;
            }
            else
            {

            }
        }
    }
}
