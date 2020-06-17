using System;
using System.Windows;
using System.Windows.Controls;
using TechnicalCalculator.BL.ViewModel;

namespace TechnicalCalculator.UI
{
    public partial class MainWindow : Window
    {
        private CalculatorViewModel CalculatorViewModel { get; }

        public MainWindow()
        {
            InitializeComponent();

            CalculatorViewModel = new CalculatorViewModel();
            DataContext = CalculatorViewModel;
        }

        private void buttonNumber_Click(object sender, RoutedEventArgs e)
        {
            if (textBlockResult.Text.Length == 1 && textBlockResult.Text == "0") textBlockResult.Text = string.Empty;

            textBlockResult.Text += ((Button)e.OriginalSource).Content.ToString();
        }
    }
}
