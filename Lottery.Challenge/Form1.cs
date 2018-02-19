using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery.Challenge
{

    /*
       - Time taken 57 Minutes
       - With more time:
            * Create a historical log of generated numbers to allow the user to see previous numbers generated
            * Connect to the lottery api to be able to view previous results
    */


    public partial class Form1 : Form
    {
       
        private List<int> _numbers = new List<int>();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            _numbers.Clear(); 
         
            for (int i = 1; i <= 6; i++)
            {
                _numbers.Add(RandomNumberGenerator());
            }

            _numbers.Sort();

            //with more time I would create a function to iterate over the available textboxes
            textBox1.Text = this._numbers[0].ToString();
            textBox2.Text = this._numbers[1].ToString();
            textBox3.Text = this._numbers[2].ToString();
            textBox4.Text = this._numbers[3].ToString();
            textBox5.Text = this._numbers[4].ToString();
            textBox6.Text = this._numbers[5].ToString();

            if (chkBonusBall.Checked)
            {
                textBoxBonus.Text = RandomNumberGenerator().ToString();

            }

        }

        private int RandomNumberGenerator()
        {
            int randomNumber = random.Next(1,50);

            if (_numbers.Contains(randomNumber))
            {
                return RandomNumberGenerator();
            }
            else
            {
                return randomNumber;
            }
        }

        private void chkBonusBall_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private Color getColour(int number)
        {
            try
            {
                if (number <= 9)
                {
                    return Color.Gray;
                }
                else if (number >= 10 && number <= 19)
                {
                    return Color.Blue;
                }
                else if (number >= 20 && number <= 29)
                {
                    return Color.Pink;
                }
                else if (number >= 30 && number <= 39)
                {
                    return Color.Green;
                }
                else
                {
                    return Color.Yellow;
                }

            }
            catch (Exception ex)
            {
                return Color.Gray;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.BackColor = getColour(int.Parse(textBox.Text));
        }
    }
}
