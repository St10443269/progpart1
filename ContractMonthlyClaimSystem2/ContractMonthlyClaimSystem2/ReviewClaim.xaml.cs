using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class ReviewClaim : Window
    {
    public ReviewClaim()
        {
       InitializeComponent();
        }
        private void ApproveBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim approved successfully.", "Approval", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

    private void RejectBtn_Click(object sender, RoutedEventArgs e)
        {
     MessageBox.Show("Claim rejected with comments.", "Rejection", MessageBoxButton.OK, MessageBoxImage.Warning);
            this.Close();
        }
    }
}
//Stack Overflow (2011) How to open a new window in WPF? Available at: https://stackoverflow.com/questions/1472498/how-to-open-a-new-window-in-wpf(Accessed: 17 September 2025).
//Stack Overflow(2013) How to handle button click event in WPF? Available at: https://stackoverflow.com/questions/11186363/how-to-handle-button-click-event-in-wpf(Accessed: 17 September 2025).
