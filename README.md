# TechnicalCalculator
<p>Technical calculator for calculating complex expressions.</p>
<p>the reverse Polish notation algorithm is used for calculating complex expressions.</p>
<p>The application architecture is based on the MVVM pattern:</p>
  <ul>
    <li><h3>Model :file_folder:</h3>
    <p>Number.cs - contains the number model</p>
    <p>Calculator.cs - contains a model of calculator elements</p>
    <p><h4>Operations :open_file_folder:</h4></p>
    <p>BinaryOperations.cs - contains methods for calculating binary operations</p>
    <p>UnaryOperations.cs - contains methods for calculating unary operations</p>
    </li>
    <li><h3>ViewModel :file_folder:</h3>
    <p>CalculatorViewModel.cs - contains the logic and commands of the calculator</p>
    <p>ReversePolishNotation.cs - reverse Polish notation algorithm
    <p>RelayCommand.cs - implements the ICommand interface</p></li>
    <li><h3>TechnicalCalculator.UI (View) :file_folder:</h3>
    <p>MainWindow.xaml - window interface of the application</p></li>
  </ul>
![alt text] (TechnicalCalculator.png "Technical calculator")
