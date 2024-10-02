using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ageButton_Click(object sender, EventArgs e)
        {
            /* Create a variable to hold a person's age. Then use that variable
               to determine if the person is old enough to play a game
               that requires the user to be 18 or older. Display an
               appropriate message based on the age            
             */
            double age = Convert.ToDouble(ageInput.Text);

            if(age >= 18)
            {
                ageOutput.Text = "You can play the lottery";
            }
            else
            {
                ageOutput.Text = "You are too young";
            }

        }

        private void xpButton_Click(object sender, EventArgs e)
        {
            /*  Create a variable to hold the xp gained in a level. If the 
             *  player gained over 100 xp then they get double the xp for 
             *  each xp gained over 100.
             *  
             *  Sample output for input 80
             *  You gained 80 xp
             *  
             *  Sample output for input 120
             *  You gained 140 xp
             */
            int xp = Convert.ToInt32(xpInput.Text);

            if (xp > 100)
            {
                xp = (xp - 100) * 2 + 100;
            }

            xpOutput.Text = $"You gained {xp} xp";
             
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            /* Create a program that determines the max value between 2 values 
               inputted by the user. The output should match the following:

               Sample output for inputs 34, 12
               The max value is: 34

               Sample output for inputs 22, 77
               The max value is: 77
            */
            int num1 = Convert.ToInt16(num1Input.Text);
            int num2 = Convert.ToInt16(num2Input.Text);

            if(num1 > num2)
            {
                maxOutput.Text = $"The max value is {num1}";
            }
            else
            {
                maxOutput.Text = $"The max value is {num2}";
            }
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines if an entered year
            /// is a leap year. The output should match the following:
            /// 
            /// Sample output for inputs 2002
            /// 2002 is not a leap year
            /// 
            /// Sample output for inputs 2016
            /// 2016 is a leap year
            int year = Convert.ToInt32(yearInput.Text);

            if (year % 4 == 0)
            {
                yearOutput.Text = $"{year} is a leap year";
            }
            else
            {
                yearOutput.Text = $"{year} is NOT a leap year";
            }

        }


    }
}
