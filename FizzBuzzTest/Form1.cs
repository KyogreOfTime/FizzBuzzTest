using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FizzButton_Click(object sender, EventArgs e)
        {
            //declaring arrays to be filled with values and an int to help do said filling
            int fzBzValue = 1;
            int[] fzBzArray = new int[100];
            string[] fzBzString = new string[100];
            
            //for loop to fill fzBzArray with numerical values
            for(int fzBzIndex = 0; fzBzIndex < 100; fzBzIndex++)
            {
                fzBzArray[fzBzIndex] = fzBzValue;

                fzBzValue++;
            }
            
            //declaring int to help with the following for loop
            int fzBzValue2 = 1;

            //for loop to fill array fzBzString with string values
            for(int fzBzIndex2 = 0; fzBzIndex2 < 100; fzBzIndex2++)
            {
                if (fzBzValue2 % 3 == 0 && fzBzValue2 % 5 == 0)
                {
                    fzBzString[fzBzIndex2] = "FizzBuzz";
                }
                else if (fzBzValue2 % 3 == 0)
                {
                    fzBzString[fzBzIndex2] = "Fizz";
                }
                else if (fzBzValue2 % 5 == 0)
                {
                    fzBzString[fzBzIndex2] = "Buzz";
                }
                else
                {
                    fzBzString[fzBzIndex2] = fzBzArray[fzBzIndex2].ToString();
                }

                fzBzValue2++;
            }
            //was inspired to use string.Join from
            //https://stackoverflow.com/questions/26434458/how-to-print-the-contents-of-an-array-to-a-label-in-c-sharp
            fzBzOutputLabel.Text = string.Join(", ", fzBzString);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
