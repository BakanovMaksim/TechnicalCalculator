using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TechnicalCalculator.BL.Controller;

namespace TechnicalCalculator.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CalculatorController CalculatorController { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            CalculatorController = new CalculatorController();
        }

        private void buttonNumber_Click(object sender, RoutedEventArgs e)
        {
            if (textBlockResult.Text.Length == 1 && textBlockResult.Text == "0") textBlockResult.Text = string.Empty;

            textBlockResult.Text += ((Button)e.OriginalSource).Content.ToString();
        }

        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            var firstItem = textBlockResult.Text.TakeWhile(p => char.IsDigit(p));

            var x = int.Parse(ParseInt(firstItem));

            var secondItem = textBlockResult.Text.SkipWhile(p => char.IsDigit(p)).SkipWhile(p => !char.IsDigit(p)).TakeWhile(p => char.IsDigit(p));
            var y = int.Parse(ParseInt(secondItem));

            var itemOperation = textBlockResult.Text.SkipWhile(p => char.IsDigit(p)).TakeWhile(p => !char.IsDigit(p));
            var operation = ParseInt(itemOperation);

            var result = CalculatorController.SelectedOperation(operation,x,y);

            textBlockResult.Text = result.ToString();
        }

        private string ParseInt(IEnumerable<char> items)
        {
            var str = "";

            foreach (var item in items)
                str += item;

            return str;
        }
    }
}
