using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaim submitWindow = new SubmitClaim();
            submitWindow.ShowDialog();
        }

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            UploadDocument uploadWindow = new UploadDocument();
            uploadWindow.ShowDialog();
        }

        private void OpenReviewClaim(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ReviewClaim reviewWindow = new ReviewClaim();
            reviewWindow.ShowDialog();
        }
    }
}
//these references are for both the main-xaml and main.cs
//Microsoft (2023) Windows Presentation Foundation (WPF) overview. Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/overview/(Accessed: 17 September 2025).
