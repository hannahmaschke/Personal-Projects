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
    public partial class capitalResultForm : Form
    {
        public capitalResultForm(int currentScoreCapital, int turnsTakenCapital, int wrongAnswersCapital, float correctPercentageCapital)
        {
            InitializeComponent();

            capitalResultLabel.Text = ($"Game Over! Your score is {currentScoreCapital}. You answered {turnsTakenCapital} questions. \n " +
                   $"You got {currentScoreCapital} questions correct, and answered {wrongAnswersCapital} questions incorrectly. " +
                   (correctPercentageCapital == 100 ?
                   "100%! Hannah did it again!" :
                   $"You got {correctPercentageCapital} percent of the questions right!"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButtonResult_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capitalResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
