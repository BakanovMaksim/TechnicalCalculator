using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TechnicalCalculator.BL.Controller;
using TechnicalCalculator.BL.Model;

namespace TechnicalCalculator.UI
{
    public partial class MainWindow : Window
    {
        private CalculatorViewModelcs CalculatorController { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            CalculatorController = new CalculatorViewModelcs();
        }

        /// <summary>
        /// Запись на экран чисел и бинарных операций.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNumber_Click(object sender, RoutedEventArgs e) => ShowButtonContent(e);

        private void buttonOperation_Click(object sender, RoutedEventArgs e)
        {
            var itemsOperation = textBlockResult.Text.Where(p => !char.IsDigit(p) && p != '.');

            if (itemsOperation.Count() == 1)
            {
                CompletionData();
            }

            ShowButtonContent(e);
        }

        /// <summary>
        /// Получение первого,второго операнда и операции и вывод результата на экран.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnter_Click(object sender, RoutedEventArgs e) => CompletionData();

        private void CompletionData()
        {
            var itemsFirstNumber = textBlockResult.Text.TakeWhile(p => char.IsDigit(p));
            var itemsSecondNumber = textBlockResult.Text.SkipWhile(p => char.IsDigit(p) || p == '.').SkipWhile(p => !char.IsDigit(p)).TakeWhile(p => char.IsDigit(p) || p == '.');
            var itemsOperation = textBlockResult.Text.SkipWhile(p => char.IsDigit(p) || p == '.').TakeWhile(p => !char.IsDigit(p));

            if (ParseString(itemsOperation) == "!")
            {
                var firstNumber = new Number() { Value = double.Parse(ParseString(itemsFirstNumber)) };
                CalculatorController.SelectedOperation(ParseString(itemsOperation), new Operands(firstNumber, new Number() { Value = 0 }));
            }
            else
            {
                var firstNumber = new Number() { Value = double.Parse(ParseString(itemsFirstNumber)) };
                var secondNumber = new Number() { Value = double.Parse(ParseString(itemsSecondNumber)) };
                var operands = new Operands(firstNumber, secondNumber);

                CalculatorController.SelectedOperation(ParseString(itemsOperation), operands);
            }

            textBlockResult.Text = CalculatorController.ResultNumber.Value.ToString();
        }

        /// <summary>
        /// Отображение контента кнопки на экран.
        /// </summary>
        private void ShowButtonContent(RoutedEventArgs e)
        {
            if (textBlockResult.Text.Length == 1 && textBlockResult.Text == "0") textBlockResult.Text = string.Empty;

            textBlockResult.Text += ((Button)e.OriginalSource).Content.ToString();
        }

        /// <summary>
        /// Парсинг в string отложенных данных из linq.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private string ParseString(IEnumerable<char> items)
        {
            var str = "";

            foreach (var item in items)
                str += item;

            return str;
        }

        /// <summary>
        /// Очистка поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, RoutedEventArgs e) => textBlockResult.Text = 0.ToString();

        private void buttonExponentiation_Click(object sender, RoutedEventArgs e) => textBlockResult.Text += "^";

        private void buttonFactorial_Click(object sender, RoutedEventArgs e) => textBlockResult.Text += "!";

        private void buttonSaveMemory_Click(object sender, RoutedEventArgs e) => textBlockMemory.Text = CalculatorController.ResultNumber.Value.ToString();

        private void buttonEnterMemory_Click(object sender, RoutedEventArgs e) => textBlockResult.Text += textBlockMemory.Text;

        private void buttonClearMemory_Click(object sender, RoutedEventArgs e) => textBlockMemory.Text = string.Empty;

        private void buttonAddMemory_Click(object sender, RoutedEventArgs e) => textBlockMemory.Text = (double.Parse(textBlockMemory.Text) + double.Parse(textBlockResult.Text)).ToString();

        private void buttonSubMemory_Click(object sender, RoutedEventArgs e) => textBlockMemory.Text = (double.Parse(textBlockMemory.Text) - double.Parse(textBlockResult.Text)).ToString();
    }
}
