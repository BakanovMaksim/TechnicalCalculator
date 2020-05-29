using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TechnicalCalculator.BL.Controller;
using TechnicalCalculator.BL.Model;

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
            var itemsFirstNumber = textBlockResult.Text.TakeWhile(p => char.IsDigit(p)).Select(p => p);
            var itemsSecondNumber = textBlockResult.Text.SkipWhile(p => char.IsDigit(p)).SkipWhile(p => !char.IsDigit(p)).TakeWhile(p => char.IsDigit(p));
            var itemsOperation = textBlockResult.Text.SkipWhile(p => char.IsDigit(p)).TakeWhile(p => !char.IsDigit(p));

            var firstNumber = new FirstNumber(int.Parse(ParseString(itemsFirstNumber)));
            var secondNumber = new SecondNumber(int.Parse(ParseString(itemsSecondNumber)));
            var operands = new Operands(firstNumber, secondNumber);

            CalculatorController.SelectedOperation(ParseString(itemsOperation), operands);

            textBlockResult.Text = CalculatorController.ResultNumber.Value.ToString();
        }

        private string ParseString(IEnumerable<char> items)
        {
            var str = "";

            foreach (var item in items)
                str += item;

            return str;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBlockResult.Text = 0.ToString();
        }
    }
}
