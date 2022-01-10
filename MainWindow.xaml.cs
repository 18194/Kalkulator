using System;
using System.Windows;
using System.Windows.Controls;

namespace MyCalculatorv1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //przycisk "B" jest przypisany calej grupie przyciskow ktorego wartosc jest rowna tekstowi zawartemu w "buttonie" , zaoszczedza to miejsca w kodzie
            Button b = (Button)sender;
            tb.Text += b.Content.ToString();
        }
        //przycisk "wynikowy" "="
        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result(); //wyswietlanie wyniku
            }
            catch (Exception)
            {
                tb.Text = "Error!"; //jesli bedzie brak danych to pojawi sie error.
            }
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (tb.Text.Contains("+"))
            {
                iOp = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                iOp = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                iOp = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                iOp = tb.Text.IndexOf("/");
            }
            else
            {
                //blad  
            }

            op = tb.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(tb.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));

            if (op == "+")
            {
                tb.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                tb.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                tb.Text += "=" + (op1 * op2);
            }
            else
            {
                tb.Text += "=" + (op1 / op2);
            }
        }
        //Przycisk "Wyjdz" odpowiadajacy za wyjscie z programu
        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //Tutaj jest przycisk "Del" , ma za zadanie usuwać całą zawartość pola z danymi
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }
        // Przycisk R odpowiada za usunięcie ostatniej cyfry tj."BackSpace"
        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }
        //tutaj jest pole w które będą "wstawiane" wyniki
        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}