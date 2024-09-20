using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchTheCountry
{
    public partial class Result : Form
    {
        public Result(int currentScore, int turnsTaken, int wrongAnswers, float correctPercentage)
        {
            InitializeComponent();

            resultLabel.Text = ($"Game Over! Your score is {currentScore}. You answered {turnsTaken} questions. \n " +
                   $"You got {currentScore} questions correct, and answered {wrongAnswers} questions incorrectly. " +
                   (correctPercentage == 100 ?
                   "100%! Hannah did it again!" :
                   $"You got {correctPercentage} percent of the questions right!"));
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.OK;
        }
    }
}
