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
    public partial class EasyOrHardModeForm : Form
    {
        public EasyOrHardModeForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            const int Easy = 0, Hard = 1;
            // check which one is selected
            if (hardModeButton.Checked)
            { DialogResult = (DialogResult)Hard; }

            else {
            DialogResult = (DialogResult)Easy;
            }


            Close();
        }
    }
}
