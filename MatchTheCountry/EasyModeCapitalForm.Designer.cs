﻿namespace MatchTheCountry
{
    partial class EasyModeCapitalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyModeCapitalForm));
            this.capitalWindowLabel = new System.Windows.Forms.Label();
            this.flagPictureBoxCapital = new System.Windows.Forms.PictureBox();
            this.capitalTextbox = new System.Windows.Forms.TextBox();
            this.capitalCurrentScoreLabel = new System.Windows.Forms.Label();
            this.capitalTimerLabel = new System.Windows.Forms.Label();
            this.cancelButtonFlagForm = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.submitButtonFlagForm = new System.Windows.Forms.Button();
            this.countryNameLabel = new System.Windows.Forms.Label();
            this.capitalTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBoxCapital)).BeginInit();
            this.SuspendLayout();
            // 
            // capitalWindowLabel
            // 
            this.capitalWindowLabel.AutoSize = true;
            this.capitalWindowLabel.BackColor = System.Drawing.Color.Transparent;
            this.capitalWindowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitalWindowLabel.Location = new System.Drawing.Point(68, 45);
            this.capitalWindowLabel.Name = "capitalWindowLabel";
            this.capitalWindowLabel.Size = new System.Drawing.Size(624, 64);
            this.capitalWindowLabel.TabIndex = 1;
            this.capitalWindowLabel.Text = "Write the name of the capital city of each country\r\n before the timer runs out!";
            // 
            // flagPictureBoxCapital
            // 
            this.flagPictureBoxCapital.BackColor = System.Drawing.Color.Transparent;
            this.flagPictureBoxCapital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flagPictureBoxCapital.Location = new System.Drawing.Point(298, 166);
            this.flagPictureBoxCapital.Name = "flagPictureBoxCapital";
            this.flagPictureBoxCapital.Size = new System.Drawing.Size(210, 151);
            this.flagPictureBoxCapital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flagPictureBoxCapital.TabIndex = 3;
            this.flagPictureBoxCapital.TabStop = false;
            // 
            // capitalTextbox
            // 
            this.capitalTextbox.Location = new System.Drawing.Point(281, 329);
            this.capitalTextbox.Name = "capitalTextbox";
            this.capitalTextbox.Size = new System.Drawing.Size(245, 26);
            this.capitalTextbox.TabIndex = 4;
            // 
            // capitalCurrentScoreLabel
            // 
            this.capitalCurrentScoreLabel.AutoSize = true;
            this.capitalCurrentScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.capitalCurrentScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitalCurrentScoreLabel.Location = new System.Drawing.Point(552, 166);
            this.capitalCurrentScoreLabel.Name = "capitalCurrentScoreLabel";
            this.capitalCurrentScoreLabel.Size = new System.Drawing.Size(153, 26);
            this.capitalCurrentScoreLabel.TabIndex = 12;
            this.capitalCurrentScoreLabel.Text = "Current Score:";
            // 
            // capitalTimerLabel
            // 
            this.capitalTimerLabel.AutoSize = true;
            this.capitalTimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.capitalTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitalTimerLabel.Location = new System.Drawing.Point(552, 212);
            this.capitalTimerLabel.Name = "capitalTimerLabel";
            this.capitalTimerLabel.Size = new System.Drawing.Size(66, 26);
            this.capitalTimerLabel.TabIndex = 13;
            this.capitalTimerLabel.Text = "Time:";
            // 
            // cancelButtonFlagForm
            // 
            this.cancelButtonFlagForm.BackColor = System.Drawing.Color.Red;
            this.cancelButtonFlagForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButtonFlagForm.Location = new System.Drawing.Point(12, 406);
            this.cancelButtonFlagForm.Name = "cancelButtonFlagForm";
            this.cancelButtonFlagForm.Size = new System.Drawing.Size(132, 32);
            this.cancelButtonFlagForm.TabIndex = 14;
            this.cancelButtonFlagForm.Text = "Cancel";
            this.cancelButtonFlagForm.UseVisualStyleBackColor = false;
            this.cancelButtonFlagForm.Click += new System.EventHandler(this.cancelButtonFlagForm_Click);
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.Color.Yellow;
            this.skipButton.Location = new System.Drawing.Point(315, 406);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(145, 32);
            this.skipButton.TabIndex = 15;
            this.skipButton.Text = "Skip Question";
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // submitButtonFlagForm
            // 
            this.submitButtonFlagForm.BackColor = System.Drawing.Color.Lime;
            this.submitButtonFlagForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submitButtonFlagForm.Location = new System.Drawing.Point(656, 406);
            this.submitButtonFlagForm.Name = "submitButtonFlagForm";
            this.submitButtonFlagForm.Size = new System.Drawing.Size(132, 32);
            this.submitButtonFlagForm.TabIndex = 16;
            this.submitButtonFlagForm.Text = "Submit";
            this.submitButtonFlagForm.UseVisualStyleBackColor = false;
            this.submitButtonFlagForm.Click += new System.EventHandler(this.submitButtonFlagForm_Click);
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.AutoSize = true;
            this.countryNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryNameLabel.Location = new System.Drawing.Point(372, 130);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(0, 20);
            this.countryNameLabel.TabIndex = 17;
            // 
            // capitalTimer
            // 
            this.capitalTimer.Enabled = true;
            this.capitalTimer.Interval = 1000;
            this.capitalTimer.Tick += new System.EventHandler(this.capitalTimer_Tick);
            // 
            // EasyModeCapitalForm
            // 
            this.AcceptButton = this.submitButtonFlagForm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.cancelButtonFlagForm;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryNameLabel);
            this.Controls.Add(this.submitButtonFlagForm);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.cancelButtonFlagForm);
            this.Controls.Add(this.capitalTimerLabel);
            this.Controls.Add(this.capitalCurrentScoreLabel);
            this.Controls.Add(this.capitalTextbox);
            this.Controls.Add(this.flagPictureBoxCapital);
            this.Controls.Add(this.capitalWindowLabel);
            this.Name = "EasyModeCapitalForm";
            this.Text = "Easy Mode- Match the capital ";
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBoxCapital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label capitalWindowLabel;
        private System.Windows.Forms.PictureBox flagPictureBoxCapital;
        private System.Windows.Forms.TextBox capitalTextbox;
        private System.Windows.Forms.Label capitalCurrentScoreLabel;
        private System.Windows.Forms.Label capitalTimerLabel;
        private System.Windows.Forms.Button cancelButtonFlagForm;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button submitButtonFlagForm;
        private System.Windows.Forms.Label countryNameLabel;
        private System.Windows.Forms.Timer capitalTimer;
    }
}