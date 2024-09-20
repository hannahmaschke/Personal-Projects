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
    public partial class Form1 : Form
    {
        const int Easy = 0, Hard = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void appLabel_Click(object sender, EventArgs e)
        {

        }

        private void matchFlagPicBox_Click(object sender, EventArgs e)
        {
           
            MatchTheFlagWindow matchTheFlagWindow = new MatchTheFlagWindow();
            this.Hide();
            matchTheFlagWindow.ShowDialog();
            this.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void matchCapitals_Click(object sender, EventArgs e)
        {
            EasyOrHardModeForm easyOrHardModeForm = new EasyOrHardModeForm();
            
            this.Hide();

            if (easyOrHardModeForm.ShowDialog() == (DialogResult)Hard)
            {
                
                CapitalsForm capitalsForm = new CapitalsForm();
                capitalsForm.ShowDialog();
            }

            else
            { 
               
                EasyModeCapitalForm easyModeCapitalForm = new EasyModeCapitalForm();
                easyModeCapitalForm.ShowDialog();
            }
            
            this.Show();
        }


    }
}
