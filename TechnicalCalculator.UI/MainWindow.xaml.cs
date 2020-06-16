using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TechnicalCalculator.BL.Model;
using TechnicalCalculator.BL.ViewModel;

namespace TechnicalCalculator.UI
{
    public partial class MainWindow : Window
    {
        public CalculatorViewModel CalculatorViewModel { get; set; }

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

        private void buttonOperation_Click(object sender, RoutedEventArgs e)
        {
            var itemsOperation = textBlockResult.Text.Where(p => !char.IsDigit(p) && p != '.');

            if (itemsOperation.Count() == 1)
            {
                //CompletionData();
            }

            //ShowButtonContent(e);
        }

        private void buttonExponentiation_Click(object sender, RoutedEventArgs e) => textBlockResult.Text += "^";

        private void buttonFactorial_Click(object sender, RoutedEventArgs e) => textBlockResult.Text += "!";
    }
}
