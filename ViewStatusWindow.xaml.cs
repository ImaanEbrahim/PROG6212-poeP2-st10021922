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
    public partial class ViewStatusWindow : Window
    {
        public ViewStatusWindow()
        {
            InitializeComponent();
            LoadClaimStatus();
        }

        private void LoadClaimStatus()
        {
            // Load status into the DataGrid
            // This is placeholder data for now
            statusDataGrid.ItemsSource = new[]
            {
                new { LecturerName = "Jonathan Doe", ClaimID = "001", Status = "Pending" },
                new { LecturerName = "Jane Smith", ClaimID = "002", Status = "Approved" },
                 new { LecturerName = "Samantha Dennis", ClaimID = "003", Status = "Approved" }
            };
        }
    }
}

