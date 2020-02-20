namespace TwoDimArrayAssignemt
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
            this.numOfStudentsLabel = new System.Windows.Forms.Label();
            this.numOfExamsLabel = new System.Windows.Forms.Label();
            this.numOfStudentsTextbox = new System.Windows.Forms.TextBox();
            this.numOfExamsTextbox = new System.Windows.Forms.TextBox();
            this.numOfStudentsButton = new System.Windows.Forms.Button();
            this.numOfExamsButton = new System.Windows.Forms.Button();
            this.classGroupBox = new System.Windows.Forms.GroupBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.examScoreTextbox = new System.Windows.Forms.TextBox();
            this.examScoreLabel = new System.Windows.Forms.Label();
            this.studentNameTextbox = new System.Windows.Forms.TextBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.classResultsButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.classGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numOfStudentsLabel
            // 
            this.numOfStudentsLabel.AutoSize = true;
            this.numOfStudentsLabel.Location = new System.Drawing.Point(13, 25);
            this.numOfStudentsLabel.Name = "numOfStudentsLabel";
            this.numOfStudentsLabel.Size = new System.Drawing.Size(132, 13);
            this.numOfStudentsLabel.TabIndex = 7;
            this.numOfStudentsLabel.Text = "Enter Number of Students:";
            // 
            // numOfExamsLabel
            // 
            this.numOfExamsLabel.AutoSize = true;
            this.numOfExamsLabel.Location = new System.Drawing.Point(24, 66);
            this.numOfExamsLabel.Name = "numOfExamsLabel";
            this.numOfExamsLabel.Size = new System.Drawing.Size(121, 13);
            this.numOfExamsLabel.TabIndex = 8;
            this.numOfExamsLabel.Text = "Enter Number of Exams:";
            // 
            // numOfStudentsTextbox
            // 
            this.numOfStudentsTextbox.Location = new System.Drawing.Point(152, 17);
            this.numOfStudentsTextbox.Name = "numOfStudentsTextbox";
            this.numOfStudentsTextbox.Size = new System.Drawing.Size(100, 20);
            this.numOfStudentsTextbox.TabIndex = 0;
            // 
            // numOfExamsTextbox
            // 
            this.numOfExamsTextbox.Location = new System.Drawing.Point(152, 59);
            this.numOfExamsTextbox.Name = "numOfExamsTextbox";
            this.numOfExamsTextbox.Size = new System.Drawing.Size(100, 20);
            this.numOfExamsTextbox.TabIndex = 2;
            // 
            // numOfStudentsButton
            // 
            this.numOfStudentsButton.Location = new System.Drawing.Point(259, 13);
            this.numOfStudentsButton.Name = "numOfStudentsButton";
            this.numOfStudentsButton.Size = new System.Drawing.Size(126, 23);
            this.numOfStudentsButton.TabIndex = 1;
            this.numOfStudentsButton.Text = "Number of Students";
            this.numOfStudentsButton.UseVisualStyleBackColor = true;
            this.numOfStudentsButton.Click += new System.EventHandler(this.numOfStudentsButton_Click);
            // 
            // numOfExamsButton
            // 
            this.numOfExamsButton.Location = new System.Drawing.Point(259, 56);
            this.numOfExamsButton.Name = "numOfExamsButton";
            this.numOfExamsButton.Size = new System.Drawing.Size(126, 23);
            this.numOfExamsButton.TabIndex = 3;
            this.numOfExamsButton.Text = "Number of Exams";
            this.numOfExamsButton.UseVisualStyleBackColor = true;
            this.numOfExamsButton.Click += new System.EventHandler(this.numOfExamsButton_Click);
            // 
            // classGroupBox
            // 
            this.classGroupBox.Controls.Add(this.scoreButton);
            this.classGroupBox.Controls.Add(this.nameButton);
            this.classGroupBox.Controls.Add(this.examScoreTextbox);
            this.classGroupBox.Controls.Add(this.examScoreLabel);
            this.classGroupBox.Controls.Add(this.studentNameTextbox);
            this.classGroupBox.Controls.Add(this.studentNameLabel);
            this.classGroupBox.Location = new System.Drawing.Point(12, 112);
            this.classGroupBox.Name = "classGroupBox";
            this.classGroupBox.Size = new System.Drawing.Size(373, 100);
            this.classGroupBox.TabIndex = 4;
            this.classGroupBox.TabStop = false;
            this.classGroupBox.Text = "Enter Student Name and Scores";
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(290, 54);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(75, 23);
            this.scoreButton.TabIndex = 3;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(290, 18);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 1;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // examScoreTextbox
            // 
            this.examScoreTextbox.Location = new System.Drawing.Point(140, 57);
            this.examScoreTextbox.Name = "examScoreTextbox";
            this.examScoreTextbox.Size = new System.Drawing.Size(100, 20);
            this.examScoreTextbox.TabIndex = 2;
            // 
            // examScoreLabel
            // 
            this.examScoreLabel.AutoSize = true;
            this.examScoreLabel.Location = new System.Drawing.Point(18, 65);
            this.examScoreLabel.Name = "examScoreLabel";
            this.examScoreLabel.Size = new System.Drawing.Size(95, 13);
            this.examScoreLabel.TabIndex = 5;
            this.examScoreLabel.Text = "Enter Exam Score:";
            // 
            // studentNameTextbox
            // 
            this.studentNameTextbox.Location = new System.Drawing.Point(140, 22);
            this.studentNameTextbox.Name = "studentNameTextbox";
            this.studentNameTextbox.Size = new System.Drawing.Size(143, 20);
            this.studentNameTextbox.TabIndex = 0;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(15, 30);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(106, 13);
            this.studentNameLabel.TabIndex = 4;
            this.studentNameLabel.Text = "Enter Student Name:";
            // 
            // classResultsButton
            // 
            this.classResultsButton.Location = new System.Drawing.Point(50, 245);
            this.classResultsButton.Name = "classResultsButton";
            this.classResultsButton.Size = new System.Drawing.Size(75, 37);
            this.classResultsButton.TabIndex = 5;
            this.classResultsButton.Text = "Show Class Results";
            this.classResultsButton.UseVisualStyleBackColor = true;
            this.classResultsButton.Visible = false;
            this.classResultsButton.Click += new System.EventHandler(this.classResultsButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(152, 215);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(143, 114);
            this.outputLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 338);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.classResultsButton);
            this.Controls.Add(this.classGroupBox);
            this.Controls.Add(this.numOfExamsButton);
            this.Controls.Add(this.numOfStudentsButton);
            this.Controls.Add(this.numOfExamsTextbox);
            this.Controls.Add(this.numOfStudentsTextbox);
            this.Controls.Add(this.numOfExamsLabel);
            this.Controls.Add(this.numOfStudentsLabel);
            this.Name = "Form1";
            this.Text = "Enter Names and Scores for Exams";
            this.classGroupBox.ResumeLayout(false);
            this.classGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfStudentsLabel;
        private System.Windows.Forms.Label numOfExamsLabel;
        private System.Windows.Forms.TextBox numOfStudentsTextbox;
        private System.Windows.Forms.TextBox numOfExamsTextbox;
        private System.Windows.Forms.Button numOfStudentsButton;
        private System.Windows.Forms.Button numOfExamsButton;
        private System.Windows.Forms.GroupBox classGroupBox;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.TextBox examScoreTextbox;
        private System.Windows.Forms.Label examScoreLabel;
        private System.Windows.Forms.TextBox studentNameTextbox;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Button classResultsButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

