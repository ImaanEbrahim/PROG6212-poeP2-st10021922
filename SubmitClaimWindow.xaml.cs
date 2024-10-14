using Microsoft.Win32;
using System;
using System.Windows;

namespace CMCS_APP2._0
{
    public partial class SubmitClaimsWindow : Window
    {
        public SubmitClaimsWindow()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            // Create an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            // Set filter for file types (allow only .pdf, .docx, .xlsx)
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Word documents (*.docx)|*.docx|Excel sheets (*.xlsx)|*.xlsx";
            
            // Show dialog and get result
            bool? result = openFileDialog.ShowDialog();
            
            // Process the selected file
            if (result == true)
            {
                // Display the selected file name
                FileNameTextBlock.Text = $"Selected File: {openFileDialog.FileName}";
            }
            else
            {
                FileNameTextBlock.Text = "No file selected";
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Get input values from textboxes
            string hoursWorked = HoursWorkedTextBox.Text;
            string hourlyRate = HourlyRateTextBox.Text;
            string notes = NotesTextBox.Text;
            string fileName = FileNameTextBlock.Text;

            // Basic validation (you can enhance this)
            if (string.IsNullOrEmpty(hoursWorked) || string.IsNullOrEmpty(hourlyRate) || fileName == "No file selected")
            {
                MessageBox.Show("Please fill in all fields and upload a supporting document.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Simulate claim submission logic
            MessageBox.Show($"Claim submitted successfully!\n\nHours Worked: {hoursWorked}\nHourly Rate: {hourlyRate}\nNotes: {notes}\nUploaded File: {fileName}", 
                            "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            
            // Clear the form (optional)
            HoursWorkedTextBox.Clear();
            HourlyRateTextBox.Clear();
            NotesTextBox.Clear();
            FileNameTextBlock.Text = "No file selected";
        }
    }
}
