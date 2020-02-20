using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Jared Gain
 * CIS 466
 * 10/2/2017
 * This project displays the class results after entering
 * a certain amount of students and their exam scores
 */
namespace TwoDimArrayAssignemt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Delcare field variables
        private int numOfStudents = 0;
        private int numOfExams = 0;
        private string studentName = "";
        private int[,] studentScores = new int[0, 0];
        private string[] studentNames = new string[0];
        private int nameCounter = 0;
        private int rowCounter = 0;
        private int colCounter = 0;

        private void numOfStudentsButton_Click(object sender, EventArgs e)
        {
            // Try-Catch statement
            try
            {
                if (IsStudentDataValid())
                {
                    // Convert data
                    numOfStudents = Convert.ToInt32(numOfStudentsTextbox.Text);

                    // Hide or disable appropriate objects on form
                    numOfStudentsLabel.Visible = false;
                    numOfStudentsTextbox.Visible = false;
                    numOfStudentsButton.Visible = false;
                    numOfExamsTextbox.Focus();
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (OverflowException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (DivideByZeroException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n"
                                + ex.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
        }

        private void numOfExamsButton_Click(object sender, EventArgs e)
        {
            // Try-Catch statement
            try
            {
                if (IsExamDataValid())
                {
                    // Convert data
                    numOfExams = Convert.ToInt32(numOfExamsTextbox.Text);

                    // Initialize a 2D int array
                    studentScores = new int[numOfStudents, numOfExams];

                    // Initialize new value for array
                    studentNames = new string[numOfStudents];

                    // Hide or disable appropriate objects on form
                    numOfExamsLabel.Visible = false;
                    numOfExamsTextbox.Visible = false;
                    numOfExamsButton.Visible = false;
                    studentNameTextbox.Focus();
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (OverflowException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (DivideByZeroException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n"
                                + ex.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            // Try-Catch statement
            try
            {
                if (IsNameDataValid())
                {
                    if (nameCounter < numOfStudents)
                    {
                        // Add elements to array
                        studentNames[nameCounter] = studentNameTextbox.Text;

                        // Increment counter
                        nameCounter++;

                        // Hide or disable appropriate objects on form
                        studentNameTextbox.Enabled = false;
                        studentNameLabel.Visible = false;
                        nameButton.Visible = false;
                        examScoreTextbox.Enabled = true;
                        examScoreTextbox.Focus();
                        scoreButton.Enabled = true;
                    }
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n"
                                + ex.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            // Try-Catch statement
            try
            {
                if (IsScoreDataValid())
                {
                    if (colCounter < numOfExams)
                    {
                        studentScores[rowCounter, colCounter] = int.Parse(examScoreTextbox.Text);

                        // Increment column counter
                        colCounter++;

                        // Clear textbox
                        examScoreTextbox.Text = "";
                        examScoreTextbox.Focus();

                        if (colCounter == numOfExams)
                        {
                            MessageBox.Show("All Scores have been entered for " + studentNames[rowCounter] +
                                            ".", "Student Update");
                            // Increment row counter
                            rowCounter++;

                            // Set column counter back to zero
                            colCounter = 0;

                            // Hide or disable appropriate objects on form
                            studentNameLabel.Visible = true;
                            nameButton.Visible = true;
                            studentNameTextbox.Enabled = true;
                            studentNameTextbox.Text = "";
                            studentNameTextbox.Focus();
                            examScoreTextbox.Enabled = false;
                            scoreButton.Enabled = false;
                        }
                    }
                    
                    if (rowCounter == numOfStudents)
                    {
                        classGroupBox.Visible = false;
                        classResultsButton.Visible = true;
                        MessageBox.Show("All Student Scores have been entered. Please Press Show " +
                                       "Results Button.", "Student Update");
                    }
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (OverflowException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (DivideByZeroException error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.GetType().ToString() + "\n\n"
                                + error.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n"
                                + ex.StackTrace, "Entry Error");
                numOfStudentsTextbox.Focus();
            }
        }

        private void classResultsButton_Click(object sender, EventArgs e)
        {
            // Declare and initialize local string variables
            string output = "";
            int sum = 0;
            int average = 0;

            // Nest For Loop
            for (int row = 0; row < studentScores.GetLength(0); row++)
            {
                output = output + studentNames[row] + " ";

                for (int col = 0; col < studentScores.GetLength(1); col++)
                {
                    // Traverse through array
                    output = output + studentScores[row, col] + " ";

                    // Calculate sum of row
                    sum = sum + studentScores[row, col];
                }

                // Calculate average
                average = sum / numOfExams;

                output = output + average.ToString("n2") + "\n";

                //Set sum and average to zero
                sum = 0;
                average = 0;
            }

            // Display Results
            outputLabel.Text = output;
        }

        // IsStudentDataValid method
        private bool IsStudentDataValid()
        {
            return

            IsPresent(numOfStudentsTextbox, "Number of Students") &&
            IsInteger(numOfStudentsTextbox, "Number of Students") &&
            IsGreaterThanZero(numOfStudentsTextbox, "Number of Students");
        }

        // IsExamDataValid method
        private bool IsExamDataValid()
        {
            return

            IsPresent(numOfExamsTextbox, "Number of Exams") &&
            IsInteger(numOfExamsTextbox, "Number of Exams") &&
            IsGreaterThanZero(numOfExamsTextbox, "Number of Exams");
        }

        // IsNameDataValid method
        private bool IsNameDataValid()
        {
            return

            IsPresent(studentNameTextbox, "Student Name");
        }

        // IsScoreDataValid method
        private bool IsScoreDataValid()
        {
            return

            IsPresent(examScoreTextbox, "Student Score") &&
            IsInteger(examScoreTextbox, "Student Score") &&
            IsGreaterThanZero(examScoreTextbox, "Student Score");
        }

        // IsPresent method
        public bool IsPresent(TextBox textbox, string name)
        {
            // Set flag variable to true
            bool value = true;

            if (textbox.Text == "")
            {
                MessageBox.Show(name + " is a required field. Please enter a valid data type.", "Entry Error");
                textbox.Focus();
                textbox.ForeColor = Color.Red;
                value = false;
            }
            return value;
        }

        // IsInteger method
        public bool IsInteger(TextBox textbox, string name)
        {
            // Declare and initialize variable
            int number = 0;

            // Set flag variable to true
            bool value = true;

            if (!(Int32.TryParse(textbox.Text, out number)))
            {
                MessageBox.Show(name + " must be an integer. Please enter a valid data type.", "Entry Error");
                textbox.Focus();
                textbox.ForeColor = Color.Red;
                value = false;
            }
            return value;
        }

        // IsGreaterThanZero method
        public bool IsGreaterThanZero(TextBox textbox, string name)
        {
            // Declare and initialize variable
            int number = Convert.ToInt32(textbox.Text);

            // Set flag variable to true
            bool value = true;

            if (number <= 0)
            {
                MessageBox.Show(name + " must be greater than 0. Please enter valid data.", "Entry Error");
                textbox.Focus();
                textbox.ForeColor = Color.Red;
                value = false;
            }
            return value;
        }
    }
}
