using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;



namespace CMCS_APP2._0
{
    public partial class ApproveClaimsWindow : Window
    {
        public ApproveClaimsWindow()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Load claims into the DataGrid
            // We can insert sample data for the claims 
            claimsDataGrid.ItemsSource = new[]
            {
                new { LecturerName = "Jonathan Doe", HoursWorked = "10", HourlyRate = "50", Status = "Pending" },
                new { LecturerName = "Samantha Dennis", HoursWorked = "10", HourlyRate = "50", Status = "Pending" }
            };
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            // Approve logic here
            MessageBox.Show("Claim Approved");
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            // Reject logic here
            MessageBox.Show("Claim Rejected");
        }
    }
}

