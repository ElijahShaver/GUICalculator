using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Security.Cryptography.X509Certificates;

namespace AvaloniaCalc
{
    public partial class MainWindow : Window
    {
        Solver solver;

        string top = "", bottom = "";

        public void DisplayLine()
        {
            TextBox1.Text = top + "\n----------\n" + bottom;
        }
        public MainWindow()
        {
            InitializeComponent();

            DisplayLine();

            solver = new Solver();
        }
        public void ACClickHandler(object sender, RoutedEventArgs args)
        {
            solver.Clear();
        }
        public void Button1ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "1";
            solver.Accumulate("1");
            DisplayLine();
        }
        public void Button2ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "2";
            solver.Accumulate("2");
            DisplayLine();
        }
        public void Button3ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "3";
            solver.Accumulate("3");
            DisplayLine();
        }
        public void Button4ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "4";
            solver.Accumulate("4");
            DisplayLine();
        }
        public void Button5ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "5";
            solver.Accumulate("5");
            DisplayLine();
        }
        public void Button6ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "6";
            solver.Accumulate("6");
            DisplayLine();
        }
        public void Button7ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "7";
            solver.Accumulate("7");
            DisplayLine();
        }
        public void Button8ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "8";
            solver.Accumulate("8");
            DisplayLine();
        }
        public void Button9ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "9";
            solver.Accumulate("9");
            DisplayLine();
        }
        public void Button0ClickHandler(object sender, RoutedEventArgs args)
        {
            top += "0";
            solver.Accumulate("0");
            DisplayLine();
        }
        public void AddClickHandler(object sender, RoutedEventArgs args)
        {
            top += "+";
            solver.Accumulate("+");
            DisplayLine();
        }
        public void SubtractClickHandler(object sender, RoutedEventArgs args)
        {
            top += "-";
            solver.Accumulate("-");
            DisplayLine();
        }
        public void MultiplyClickHandler(object sender, RoutedEventArgs args)
        {
            top += "*";
            solver.Accumulate("*");
            DisplayLine();
        }
        public void DivideClickHandler(object sender, RoutedEventArgs args)
        {
            top += "/";
            solver.Accumulate("/");
            DisplayLine();
        }
        public void ModularClickHandler(object sender, RoutedEventArgs args)
        {
            top += "%";
            solver.Accumulate("%");
            DisplayLine();
        }
        public void DecimalClickHandler(object sender, RoutedEventArgs args)
        {
            top += ".";
            solver.Accumulate(".");
            DisplayLine();
        }
        public void PLMClickHandler(object sender, RoutedEventArgs args)
        {
            top += "-";
            solver.Accumulate("-");
            DisplayLine();
        }
        public void EqualsClickHandler(object sender, RoutedEventArgs args)
        {
            solver.Solve();
            bottom = solver.wholeDouble.ToString();
            DisplayLine();
        }
    }
}