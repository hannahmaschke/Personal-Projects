namespace MatchTheCountry
{
    partial class capitalResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(capitalResultForm));
            this.capitalResultLabel = new System.Windows.Forms.Label();
            this.cancelButtonResult = new System.Windows.Forms.Button();
            this.playAgainButtonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // capitalResultLabel
            // 
            this.capitalResultLabel.AutoSize = true;
            this.capitalResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.capitalResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitalResultLabel.Location = new System.Drawing.Point(278, 51);
            this.capitalResultLabel.Name = "capitalResultLabel";
            this.capitalResultLabel.Size = new System.Drawing.Size(162, 32);
            this.capitalResultLabel.TabIndex = 0;
            this.capitalResultLabel.Text = "Your Result";
            // 
            // cancelButtonResult
            // 
            this.cancelButtonResult.BackColor = System.Drawing.Color.PeachPuff;
            this.cancelButtonResult.Location = new System.Drawing.Point(12, 400);
            this.cancelButtonResult.Name = "cancelButtonResult";
            this.cancelButtonResult.Size = new System.Drawing.Size(165, 38);
            this.cancelButtonResult.TabIndex = 1;
            this.cancelButtonResult.Text = "Cancel";
            this.cancelButtonResult.UseVisualStyleBackColor = false;
            this.cancelButtonResult.Click += new System.EventHandler(this.cancelButtonResult_Click);
            // 
            // playAgainButtonResult
            // 
            this.playAgainButtonResult.BackColor = System.Drawing.Color.PeachPuff;
            this.playAgainButtonResult.Location = new System.Drawing.Point(623, 400);
            this.playAgainButtonResult.Name = "playAgainButtonResult";
            this.playAgainButtonResult.Size = new System.Drawing.Size(165, 38);
            this.playAgainButtonResult.TabIndex = 2;
            this.playAgainButtonResult.Text = "Play again";
            this.playAgainButtonResult.UseVisualStyleBackColor = false;
            this.playAgainButtonResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // capitalResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playAgainButtonResult);
            this.Controls.Add(this.cancelButtonResult);
            this.Controls.Add(this.capitalResultLabel);
            this.Name = "capitalResultForm";
            this.Text = "Your Results!";
            this.Load += new System.EventHandler(this.capitalResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label capitalResultLabel;
        private System.Windows.Forms.Button cancelButtonResult;
        private System.Windows.Forms.Button playAgainButtonResult;
    }
}