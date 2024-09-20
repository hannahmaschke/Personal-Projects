namespace MatchTheCountry
{
    partial class MatchTheFlagWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchTheFlagWindow));
            this.flagPictureBox = new System.Windows.Forms.PictureBox();
            this.flagFormTextbox = new System.Windows.Forms.TextBox();
            this.flagLabel = new System.Windows.Forms.Label();
            this.submitButtonFlagForm = new System.Windows.Forms.Button();
            this.cancelButtonFlagForm = new System.Windows.Forms.Button();
            this.currentScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.skipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flagPictureBox
            // 
            this.flagPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.flagPictureBox.Location = new System.Drawing.Point(263, 139);
            this.flagPictureBox.Name = "flagPictureBox";
            this.flagPictureBox.Size = new System.Drawing.Size(246, 202);
            this.flagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flagPictureBox.TabIndex = 0;
            this.flagPictureBox.TabStop = false;
            this.flagPictureBox.Click += new System.EventHandler(this.flagPictureBox_Click);
            // 
            // flagFormTextbox
            // 
            this.flagFormTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flagFormTextbox.Location = new System.Drawing.Point(226, 376);
            this.flagFormTextbox.Name = "flagFormTextbox";
            this.flagFormTextbox.Size = new System.Drawing.Size(326, 32);
            this.flagFormTextbox.TabIndex = 1;
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.BackColor = System.Drawing.Color.Transparent;
            this.flagLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flagLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.flagLabel.Location = new System.Drawing.Point(105, 38);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(757, 78);
            this.flagLabel.TabIndex = 2;
            this.flagLabel.Text = "Type the name of the country and click submit        \r\n        or press enter- Yo" +
    "u have 90 seconds!";
            // 
            // submitButtonFlagForm
            // 
            this.submitButtonFlagForm.BackColor = System.Drawing.Color.Lime;
            this.submitButtonFlagForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submitButtonFlagForm.Location = new System.Drawing.Point(656, 429);
            this.submitButtonFlagForm.Name = "submitButtonFlagForm";
            this.submitButtonFlagForm.Size = new System.Drawing.Size(132, 32);
            this.submitButtonFlagForm.TabIndex = 3;
            this.submitButtonFlagForm.Text = "Submit";
            this.submitButtonFlagForm.UseVisualStyleBackColor = false;
            this.submitButtonFlagForm.Click += new System.EventHandler(this.submitButtonFlagForm_Click);
            // 
            // cancelButtonFlagForm
            // 
            this.cancelButtonFlagForm.BackColor = System.Drawing.Color.Red;
            this.cancelButtonFlagForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButtonFlagForm.Location = new System.Drawing.Point(12, 429);
            this.cancelButtonFlagForm.Name = "cancelButtonFlagForm";
            this.cancelButtonFlagForm.Size = new System.Drawing.Size(132, 32);
            this.cancelButtonFlagForm.TabIndex = 4;
            this.cancelButtonFlagForm.Text = "Cancel";
            this.cancelButtonFlagForm.UseVisualStyleBackColor = false;
            this.cancelButtonFlagForm.Click += new System.EventHandler(this.cancelButtonFlagForm_Click);
            // 
            // currentScoreLabel
            // 
            this.currentScoreLabel.AutoSize = true;
            this.currentScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreLabel.ForeColor = System.Drawing.Color.White;
            this.currentScoreLabel.Location = new System.Drawing.Point(559, 179);
            this.currentScoreLabel.Name = "currentScoreLabel";
            this.currentScoreLabel.Size = new System.Drawing.Size(140, 25);
            this.currentScoreLabel.TabIndex = 5;
            this.currentScoreLabel.Text = "Current Score:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(564, 222);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(66, 26);
            this.timerLabel.TabIndex = 6;
            this.timerLabel.Text = "Time:";
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.Color.Yellow;
            this.skipButton.Location = new System.Drawing.Point(470, 429);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(145, 32);
            this.skipButton.TabIndex = 7;
            this.skipButton.Text = "Skip Question";
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // MatchTheFlagWindow
            // 
            this.AcceptButton = this.submitButtonFlagForm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.cancelButtonFlagForm;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.currentScoreLabel);
            this.Controls.Add(this.cancelButtonFlagForm);
            this.Controls.Add(this.submitButtonFlagForm);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.flagFormTextbox);
            this.Controls.Add(this.flagPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MatchTheFlagWindow";
            this.Text = "Match the flag to its country!";
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flagPictureBox;
        private System.Windows.Forms.TextBox flagFormTextbox;
        private System.Windows.Forms.Label flagLabel;
        private System.Windows.Forms.Button submitButtonFlagForm;
        private System.Windows.Forms.Button cancelButtonFlagForm;
        private System.Windows.Forms.Label currentScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button skipButton;
    }
}