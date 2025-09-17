using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class SubmitClaim : Window
    {
     public SubmitClaim()
        {
         InitializeComponent();
        }
        private void SubmitClaimBtn_Click(object sender, RoutedEventArgs e)
        {
        MessageBox.Show("Claim submitted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
//Stack Overflow(2010) WPF ListView with GridView Available at: https://stackoverflow.com/questions/2788234/wpf-listview-with-gridview(Accessed: 17 September 2025).
//Stack Overflow (2015) How to center WPF window on screen? Available at: https://stackoverflow.com/questions/385263/how-to-center-wpf-window-on-screen] (Accessed: 17 September 2025).