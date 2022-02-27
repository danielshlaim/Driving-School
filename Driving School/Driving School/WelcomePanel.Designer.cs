namespace Driving_School
{
    partial class WelcomePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePanel));
            this.LetsStartBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LetsStartBTN
            // 
            this.LetsStartBTN.BackColor = System.Drawing.Color.Gold;
            this.LetsStartBTN.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LetsStartBTN.ForeColor = System.Drawing.Color.Black;
            this.LetsStartBTN.Location = new System.Drawing.Point(281, 321);
            this.LetsStartBTN.Name = "LetsStartBTN";
            this.LetsStartBTN.Size = new System.Drawing.Size(140, 31);
            this.LetsStartBTN.TabIndex = 0;
            this.LetsStartBTN.Text = "Lets Get Started";
            this.LetsStartBTN.UseVisualStyleBackColor = false;
            this.LetsStartBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LetsStartBTN);
            this.Name = "WelcomePanel";
            this.Size = new System.Drawing.Size(837, 541);
            this.Load += new System.EventHandler(this.WelcomePanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LetsStartBTN;
    }
}
