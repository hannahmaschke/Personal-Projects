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
    // this is hard mode
    public partial class CapitalsForm : Form
    {

        Random random = new Random();

        int randomIndexCapital;
        int currentScoreCapital = 0;
        int wrongAnswersCapital = 0;
        int secondsCapital = 90;
        int turnsTakenCapital = 0;
        float correctPercentageCapital;
        List<int> previouslyUsedIndicesCapital = new List<int>();


        public CapitalsForm()
        {
            InitializeComponent();
            updateFlagCapital();
        }

        void updateFlagCapital()
        {
            do
            {// if all of the indices have been used, clear the indices array to start over
                if (previouslyUsedIndicesCapital.Count == Country.capital.Length)
                    previouslyUsedIndicesCapital.Clear();

                // generate a random index between 0 and the number of names
                randomIndexCapital = random.Next(0, Country.capital.Length);
            }
            while (previouslyUsedIndicesCapital.Contains(randomIndexCapital));

            previouslyUsedIndicesCapital.Add(randomIndexCapital);


            // get the flag into the picture box
            flagPictureBoxCapital.Image = Country.flag[randomIndexCapital];

            // Put the name of the country into the country name label
            countryNameLabel.Text = Country.name[randomIndexCapital];


        }

        private void cancelButtonFlagForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void submitButtonFlagForm_Click(object sender, EventArgs e)
        {
            // Whenever the user submits an answer, increment the variable that stores the number of turns
            turnsTakenCapital++;

            // get the random capital city name
            string capitalCityName = Country.capital[randomIndexCapital];

            // get user input
            String userInput = capitalTextbox.Text;

            // Compare user input and the capital city name
            if (userInput.ToLower() == capitalCityName.ToLower())

            {

                // increase score 
                currentScoreCapital++;

                // show the score in the label
                capitalCurrentScoreLabel.Text = $"Current Score: {currentScoreCapital}";



                // Show a message telling the user they are correct
                capitalWindowLabel.Text = "Correct!";

            }
            else
            { // Show a message telling the user they are not correct
                capitalWindowLabel.Text = "Incorrect- Please try again!";

                // When the user gets a question wrong, incremement the wrong answer variable by 1
                wrongAnswersCapital++;
            }
            // when the user submits an answer, clear the textbox
            capitalTextbox.Text = "";
            updateFlagCapital();
        }

        private void timer1_capital(object sender, EventArgs e)
        {
            // incremement the seconds by 1 every interval (1000 ms/1 second).
            secondsCapital--;

            // update the timer label
            capitalTimerLabel.Text = $"Time: {secondsCapital}";

            // when the timer gets down to 0, call the finalScreen method
            if (secondsCapital == 0)
            {
                // stop the timer
                capitalTimer.Stop();

                // calculate the number of questions that the user answered correctly
                correctPercentageCapital = (float) currentScoreCapital / turnsTakenCapital * 100f;

                // open the stats form
                Result capitalResultForm = new Result(currentScoreCapital, turnsTakenCapital, wrongAnswersCapital, correctPercentageCapital);
                this.Hide();
                capitalResultForm.ShowDialog();
                if (capitalResultForm.DialogResult == DialogResult.OK)
                {

                    // clear textbox
                    capitalTextbox.Text = "";

                    // clear and replace label
                    capitalWindowLabel.Text = "Type the name of the capital city and click submit or \npress enter- You have 90 seconds!";

                    // new country flag image
                    updateFlagCapital();

                    // clear score
                    currentScoreCapital = 0;
                    capitalCurrentScoreLabel.Text = "Current Score: 0";

                    //restart timer
                    secondsCapital = 90;
                    capitalTimerLabel.Text = "Time: 90";
                    capitalTimer.Start();
                }

                this.Show();
            }
            return;
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            // generate a random index between 0 and the number of city names
            randomIndexCapital = random.Next(0, Country.capital.Length);

            // get the flag into the picture box
            flagPictureBoxCapital.Image = Country.flag[randomIndexCapital];

            // get the country name in the country name label
            countryNameLabel.Text = Country.name[randomIndexCapital];

            // update the window label to show that a question was skipped
            capitalWindowLabel.Text = "Country skipped";

            return;
        }
    }

}
