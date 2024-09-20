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
    public partial class MatchTheFlagWindow : Form
    {
        Random random = new Random();

        int randomIndex;
        int currentScore = 0;
        int wrongAnswers = 0;
        int seconds = 20;
        int turnsTaken = 0;
        float correctPercentage;
        List <int> previouslyUsedIndices = new List<int> ();

       



        public MatchTheFlagWindow()
        {
            InitializeComponent();
            UpdateFlag();
        }

        void UpdateFlag()
        {
            do
            {
                // if all of the indices have been used, clear the indices array to start over
                if (previouslyUsedIndices.Count == Country.name.Length)
                        previouslyUsedIndices.Clear();
                
                // generate a random index between 0 and the number of names
                randomIndex = random.Next(0, Country.name.Length);
            } while (previouslyUsedIndices.Contains(randomIndex));

            previouslyUsedIndices.Add(randomIndex);


            // get the flag into the picture box
            flagPictureBox.Image = Country.flag[randomIndex];

        }

        private void cancelButtonFlagForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flagPictureBox_Click(object sender, EventArgs e)
        {

        }
            

        private void submitButtonFlagForm_Click(object sender, EventArgs e)
        {

            // Whenever the user submits an answer, increment the variable that stores the number of turns
            turnsTaken++;

            // get the random country name
            string countryName = Country.name[randomIndex];

            // get user input
            String userInput = flagFormTextbox.Text;

            // Compare user input and the country name
            if (userInput.ToLower() == countryName.ToLower())

            {

                // increase score 
                currentScore++;

                // show the score in the label
                currentScoreLabel.Text = $"Current Score: {currentScore}";
        
                    

                // Show a message telling the user they are correct
                flagLabel.Text = "Correct!";


            } else
            {   // Show a message telling the user they are not correct
                flagLabel.Text = $"Incorrect- The correct answer was {countryName}";

                // When the user gets a question wrong, incremement the wrong answer variable by 1
                wrongAnswers++;

                // 


            }

            // when the user submits an answer, clear the textbox
            flagFormTextbox.Text = "";
            UpdateFlag();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            // incremement the seconds by 1 every interval (1000 ms/1 second).
            seconds--;

            // update the timer label
            timerLabel.Text = $"Time: {seconds}";


            // when the timer gets down to 0, call the finalScreen method
            if (seconds == 0)
            {
                // stop the timer
                timer1.Stop();

                // calculate the number of questions that the user answered correctly
                correctPercentage =  (float) currentScore / turnsTaken * 100f;

                // open the stats form
                Result form3 = new Result(currentScore, turnsTaken, wrongAnswers, correctPercentage);
                this.Hide();
                form3.ShowDialog();
                if (form3.DialogResult == DialogResult.OK)
                {

                    // clear textbox
                    flagFormTextbox.Text = "";

                    // clear and replace label
                    flagLabel.Text = "Type the name of the country and click submit or \npress enter- You have 90 seconds!";

                    // new country flag image
                    UpdateFlag() ;

                    // clear score
                    currentScore = 0;
                    currentScoreLabel.Text = "Current Score: 0";

                    //restart timer
                    seconds = 90;
                    timerLabel.Text = "Time: 90";
                    timer1.Start();


                }

                this.Show();

               
            }

            return;
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            // generate a random index between 0 and the number of names
            randomIndex = random.Next(0, Country.name.Length);

            // get the flag into the picture box
            flagPictureBox.Image = Country.flag[randomIndex];

            return;
        }

        
           
    }
}
// bugs
// add an option to play again

