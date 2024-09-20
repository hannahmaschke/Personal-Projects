namespace MatchTheCountry
{
    partial class EasyOrHardModeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyOrHardModeForm));
            this.modeFormLabel = new System.Windows.Forms.Label();
            this.easyModeButton = new System.Windows.Forms.RadioButton();
            this.hardModeButton = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modeFormLabel
            // 
            this.modeFormLabel.AutoSize = true;
            this.modeFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.modeFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeFormLabel.Location = new System.Drawing.Point(71, 39);
            this.modeFormLabel.Name = "modeFormLabel";
            this.modeFormLabel.Size = new System.Drawing.Size(591, 37);
            this.modeFormLabel.TabIndex = 0;
            this.modeFormLabel.Text = "Do you want to play easy or hard mode?";
            // 
            // easyModeButton
            // 
            this.easyModeButton.AutoSize = true;
            this.easyModeButton.BackColor = System.Drawing.Color.Transparent;
            this.easyModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyModeButton.Location = new System.Drawing.Point(208, 140);
            this.easyModeButton.Name = "easyModeButton";
            this.easyModeButton.Size = new System.Drawing.Size(336, 33);
            this.easyModeButton.TabIndex = 1;
            this.easyModeButton.TabStop = true;
            this.easyModeButton.Text = "Easy breezy lemon squeezy";
            this.easyModeButton.UseVisualStyleBackColor = false;
            // 
            // hardModeButton
            // 
            this.hardModeButton.AutoSize = true;
            this.hardModeButton.BackColor = System.Drawing.Color.Transparent;
            this.hardModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardModeButton.Location = new System.Drawing.Point(208, 207);
            this.hardModeButton.Name = "hardModeButton";
            this.hardModeButton.Size = new System.Drawing.Size(166, 33);
            this.hardModeButton.TabIndex = 2;
            this.hardModeButton.TabStop = true;
            this.hardModeButton.Text = "I like it hard!";
            this.hardModeButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.Location = new System.Drawing.Point(12, 319);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playButton.Location = new System.Drawing.Point(590, 319);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(115, 39);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Let\'s play!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // EasyOrHardModeForm
            // 
            this.AcceptButton = this.playButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(717, 370);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.hardModeButton);
            this.Controls.Add(this.easyModeButton);
            this.Controls.Add(this.modeFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EasyOrHardModeForm";
            this.Text = "Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modeFormLabel;
        private System.Windows.Forms.RadioButton easyModeButton;
        private System.Windows.Forms.RadioButton hardModeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button playButton;
    }
}