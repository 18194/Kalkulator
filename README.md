# Kalkulator
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
        //Tutaj jest przycisk "Del" , ma za zadanie usuwa?? ca???? zawarto???? pola z danymi
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }
        // Przycisk R odpowiada za usuni??cie ostatniej cyfry tj."BackSpace"
        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }
        //tutaj jest pole w kt??re b??d?? "wstawiane" wyniki
        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}



<Window x:Class="MyCalculatorv1.MainWindow" xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" Title="Kalkulator_@Kozlowski" Height="310" Width="237" ResizeMode="NoResize" WindowStartupLocation="CenterScreen" Topmost="True">
    <Grid Background="White" Height="270" VerticalAlignment="Top">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="6*"/>
            <ColumnDefinition Width="82*"/>
            <ColumnDefinition Width="0*"/>
            <ColumnDefinition Width="126*"/>
            <ColumnDefinition Width="23*"/>
        </Grid.ColumnDefinitions>
        <Button Content="7" HorizontalAlignment="Left" Margin="5,115,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2,2,2,1" Click="Button_Click_1" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>

        <TextBox Height="38" TextWrapping="Wrap" VerticalAlignment="Top" Margin="4,20,0,0" HorizontalAlignment="Left" Width="201" FontSize="20" Background="Black" BorderThickness="2" Name="tb" Text="" Grid.ColumnSpan="3" TextChanged="tb_TextChanged" Grid.Column="1">
            <TextBox.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}" />
            </TextBox.Foreground>

        </TextBox>

        <Button Content="8" HorizontalAlignment="Left" Margin="56,115,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.ColumnSpan="3" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="9" HorizontalAlignment="Left" Margin="26,115,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="2" Grid.ColumnSpan="2">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="/" HorizontalAlignment="Left" Margin="76,115,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="2" Grid.ColumnSpan="2">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="4" HorizontalAlignment="Left" Margin="5,151,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="5" HorizontalAlignment="Left" Margin="56,151,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.ColumnSpan="3" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="6" HorizontalAlignment="Left" Margin="26,151,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="2" Grid.ColumnSpan="2">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="*" HorizontalAlignment="Left" Margin="76,151,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="2" Grid.ColumnSpan="2">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="1" HorizontalAlignment="Left" Margin="5,187,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="2" HorizontalAlignment="Left" Margin="56,187,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.ColumnSpan="3" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="3" HorizontalAlignment="Left" Margin="26,187,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="2" Grid.ColumnSpan="2">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="-" HorizontalAlignment="Left" Margin="76,187,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="2" Grid.ColumnSpan="2">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="0" HorizontalAlignment="Left" Margin="5,223,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="=" HorizontalAlignment="Left" Margin="56,223,0,0" VerticalAlignment="Top" Width="97" Height="31" FontSize="18" BorderThickness="2" Click="Result_click" Grid.ColumnSpan="3" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="+" HorizontalAlignment="Left" Margin="76,223,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Button_Click_1" Grid.Column="2" Grid.ColumnSpan="2">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="Wyjdz" HorizontalAlignment="Left" Margin="26,79,0,0" VerticalAlignment="Top" Width="97" Height="31" FontSize="18" BorderThickness="2" Click="Off_Click_1" Grid.Column="2" Grid.ColumnSpan="2">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="Del" HorizontalAlignment="Left" Margin="5,79,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="Del_Click" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>
        <Button Content="R" HorizontalAlignment="Left" Margin="56,79,0,0" VerticalAlignment="Top" Width="46" Height="31" FontSize="18" BorderThickness="2" Click="R_Click" Grid.ColumnSpan="3" Grid.Column="1">
            <Button.Foreground>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.Foreground>
            <Button.BorderBrush>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowColorKey}}"/>
            </Button.BorderBrush>
            <Button.Background>
                <SolidColorBrush Color="{DynamicResource {x:Static SystemColors.WindowTextColorKey}}"/>
            </Button.Background>
        </Button>

    </Grid>
</Window>  



#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574C03301BBB2AD8E47895B84A9C0F0477D8E073"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod zosta?? wygenerowany przez narz??dzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mog?? spowodowa?? nieprawid??owe zachowanie i zostan?? utracone, je??li
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MyCalculatorv1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Lab1_18194_Kozlowski_Kamil;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.tb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 29 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 40 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 51 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 62 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 73 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 84 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 95 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 106 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 117 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 128 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 139 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 150 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 161 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Result_click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 172 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 183 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Off_Click_1);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 194 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Del_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 205 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.R_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

