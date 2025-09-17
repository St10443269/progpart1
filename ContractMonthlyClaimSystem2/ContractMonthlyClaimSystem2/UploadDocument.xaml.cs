using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class UploadDocument : Window
    {
      public UploadDocument()
        {
         InitializeComponent();
        }
        private void UploadBtn_Click(object sender, RoutedEventArgs e)
        {
         MessageBox.Show("Document uploaded successfully!", "Upload", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
