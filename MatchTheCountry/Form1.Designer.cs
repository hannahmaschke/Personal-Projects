namespace MatchTheCountry
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.matchLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cancelButton = new System.Windows.Forms.Button();
            this.matchFlagPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.appLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchFlagPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // matchLabel
            // 
            this.matchLabel.AutoSize = true;
            this.matchLabel.BackColor = System.Drawing.Color.Transparent;
            this.matchLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchLabel.Location = new System.Drawing.Point(219, 19);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(349, 48);
            this.matchLabel.TabIndex = 0;
            this.matchLabel.Text = "Match the Country!";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Salmon;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 454);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 36);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // matchFlagPicBox
            // 
            this.matchFlagPicBox.Image = global::MatchTheCountry.Properties.Resources.matchtoitsflag;
            this.matchFlagPicBox.Location = new System.Drawing.Point(48, 195);
            this.matchFlagPicBox.Name = "matchFlagPicBox";
            this.matchFlagPicBox.Size = new System.Drawing.Size(275, 209);
            this.matchFlagPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.matchFlagPicBox.TabIndex = 4;
            this.matchFlagPicBox.TabStop = false;
            this.matchFlagPicBox.Click += new System.EventHandler(this.matchFlagPicBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(481, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.matchCapitals_Click);
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.BackColor = System.Drawing.Color.Transparent;
            this.appLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.Location = new System.Drawing.Point(63, 102);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(658, 66);
            this.appLabel.TabIndex = 6;
            this.appLabel.Text = "Choose an option to match a flag to the country, or match \r\n                 the " +
    "capital city to the country!";
            this.appLabel.Click += new System.EventHandler(this.appLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.matchFlagPicBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.matchLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Match the Country";
            ((System.ComponentModel.ISupportInitialize)(this.matchFlagPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox matchFlagPicBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label appLabel;
    }
}

