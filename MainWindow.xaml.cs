using System.Windows;

namespace CMCS_APP2._0
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaimsWindow submitWindow = new SubmitClaimsWindow();
            submitWindow.Show();
        }

        private void ApproveClaims_Click(object sender, RoutedEventArgs e)
        {
            ApproveClaimsWindow approveWindow = new ApproveClaimsWindow();
            approveWindow.Show();
        }

        private void ViewStatus_Click(object sender, RoutedEventArgs e)
        {
            ViewStatusWindow statusWindow = new ViewStatusWindow();
            statusWindow.Show();
        }
    }
}

