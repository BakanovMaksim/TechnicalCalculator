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
           
        }
    }
}
