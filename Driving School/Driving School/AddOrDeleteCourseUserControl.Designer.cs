namespace Driving_School
{
    partial class AddOrDeleteCourseUserControl
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
            this.Course_NameLBL = new System.Windows.Forms.Label();
            this.Course_RankLbl = new System.Windows.Forms.Label();
            this.courseNameComboBox = new System.Windows.Forms.ComboBox();
            this.JoinBtn = new System.Windows.Forms.Button();
            this.B_RadioBtn = new System.Windows.Forms.RadioButton();
            this.A_RankRadioBtn = new System.Windows.Forms.RadioButton();
            this.Taxi_RadioBtn = new System.Windows.Forms.RadioButton();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Course_NameLBL
            // 
            this.Course_NameLBL.AutoSize = true;
            this.Course_NameLBL.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Course_NameLBL.Location = new System.Drawing.Point(15, 125);
            this.Course_NameLBL.Name = "Course_NameLBL";
            this.Course_NameLBL.Size = new System.Drawing.Size(115, 20);
            this.Course_NameLBL.TabIndex = 0;
            this.Course_NameLBL.Text = "Course_Name :";
            // 
            // Course_RankLbl
            // 
            this.Course_RankLbl.AutoSize = true;
            this.Course_RankLbl.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Course_RankLbl.Location = new System.Drawing.Point(15, 215);
            this.Course_RankLbl.Name = "Course_RankLbl";
            this.Course_RankLbl.Size = new System.Drawing.Size(109, 20);
            this.Course_RankLbl.TabIndex = 1;
            this.Course_RankLbl.Text = "Course_Rank :";
            this.Course_RankLbl.Click += new System.EventHandler(this.Course_RankLbl_Click);
            // 
            // courseNameComboBox
            // 
            this.courseNameComboBox.FormattingEnabled = true;
            this.courseNameComboBox.Location = new System.Drawing.Point(143, 122);
            this.courseNameComboBox.Name = "courseNameComboBox";
            this.courseNameComboBox.Size = new System.Drawing.Size(151, 28);
            this.courseNameComboBox.TabIndex = 3;
            this.courseNameComboBox.SelectedValueChanged += new System.EventHandler(this.courseNameComboBox_SelectedValueChanged);
            // 
            // JoinBtn
            // 
            this.JoinBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.JoinBtn.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.JoinBtn.Location = new System.Drawing.Point(28, 334);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.Size = new System.Drawing.Size(94, 29);
            this.JoinBtn.TabIndex = 5;
            this.JoinBtn.Text = "Join";
            this.JoinBtn.UseVisualStyleBackColor = true;
            this.JoinBtn.Click += new System.EventHandler(this.JoinBtn_Click);
            // 
            // B_RadioBtn
            // 
            this.B_RadioBtn.AutoSize = true;
            this.B_RadioBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.B_RadioBtn.ForeColor = System.Drawing.Color.Pink;
            this.B_RadioBtn.Location = new System.Drawing.Point(143, 185);
            this.B_RadioBtn.Name = "B_RadioBtn";
            this.B_RadioBtn.Size = new System.Drawing.Size(41, 24);
            this.B_RadioBtn.TabIndex = 6;
            this.B_RadioBtn.TabStop = true;
            this.B_RadioBtn.Text = "B";
            this.B_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // A_RankRadioBtn
            // 
            this.A_RankRadioBtn.AutoSize = true;
            this.A_RankRadioBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.A_RankRadioBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.A_RankRadioBtn.Location = new System.Drawing.Point(143, 215);
            this.A_RankRadioBtn.Name = "A_RankRadioBtn";
            this.A_RankRadioBtn.Size = new System.Drawing.Size(41, 24);
            this.A_RankRadioBtn.TabIndex = 7;
            this.A_RankRadioBtn.TabStop = true;
            this.A_RankRadioBtn.Text = "A";
            this.A_RankRadioBtn.UseVisualStyleBackColor = true;
            // 
            // Taxi_RadioBtn
            // 
            this.Taxi_RadioBtn.AutoSize = true;
            this.Taxi_RadioBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Taxi_RadioBtn.ForeColor = System.Drawing.Color.Gold;
            this.Taxi_RadioBtn.Location = new System.Drawing.Point(143, 245);
            this.Taxi_RadioBtn.Name = "Taxi_RadioBtn";
            this.Taxi_RadioBtn.Size = new System.Drawing.Size(40, 24);
            this.Taxi_RadioBtn.TabIndex = 8;
            this.Taxi_RadioBtn.TabStop = true;
            this.Taxi_RadioBtn.Text = "P";
            this.Taxi_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.DeleteBtn.Location = new System.Drawing.Point(153, 334);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddOrDeleteCourseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Taxi_RadioBtn);
            this.Controls.Add(this.A_RankRadioBtn);
            this.Controls.Add(this.B_RadioBtn);
            this.Controls.Add(this.JoinBtn);
            this.Controls.Add(this.courseNameComboBox);
            this.Controls.Add(this.Course_RankLbl);
            this.Controls.Add(this.Course_NameLBL);
            this.Name = "AddOrDeleteCourseUserControl";
            this.Size = new System.Drawing.Size(312, 456);
            this.Load += new System.EventHandler(this.AddOrDeleteCourseUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Course_NameLBL;
        private System.Windows.Forms.Label Course_RankLbl;
        private System.Windows.Forms.ComboBox courseNameComboBox;
        private System.Windows.Forms.Button JoinBtn;
        private System.Windows.Forms.RadioButton B_RadioBtn;
        private System.Windows.Forms.RadioButton A_RankRadioBtn;
        private System.Windows.Forms.RadioButton Taxi_RadioBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
