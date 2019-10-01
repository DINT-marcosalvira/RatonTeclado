using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RatonTeclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            CajaTexto3.Text = CajaTexto3.Text.Replace('a', ' ');
            CajaTexto3.Text = CajaTexto3.Text.Replace('e', ' ');
            CajaTexto3.Text = CajaTexto3.Text.Replace('i', ' ');
            CajaTexto3.Text = CajaTexto3.Text.Replace('o', ' ');
            CajaTexto3.Text = CajaTexto3.Text.Replace('u', ' ');
            CajaTexto3.Text = CajaTexto3.Text.Replace('A', ' ');
            CajaTexto3.Text = CajaTexto3.Text.Replace('E', ' ');
            CajaTexto3.Text = CajaTexto3.Text.Replace('I', ' ');
            CajaTexto3.Text = CajaTexto3.Text.Replace('O', ' ');
            CajaTexto3.Text = CajaTexto3.Text.Replace('U', ' ');
        }

        private void CajaTexto_MouseEnter(object sender, MouseEventArgs e)
        {
            if (CajaTexto1.IsMouseOver)
            {
                CajaTextoRaton.Text = "TextBox 1";
            }
            else if(CajaTexto2.IsMouseOver)
            {
                CajaTextoRaton.Text = "TextBox 2";
            }
            else if (CajaTexto3.IsMouseOver)
            {
                CajaTextoRaton.Text = "TextBox 3";
            }
        }

        private void CajaTexto_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!CajaTexto1.IsMouseOver)
            {
                CajaTextoRaton.Text = "";
            }
            else if (!CajaTexto3.IsMouseOver)
            {
                CajaTextoRaton.Text = "";
            }
            else if (!CajaTexto2.IsMouseOver)
            {
                CajaTextoRaton.Text = "";
            }
        }

        private void CajaTexto1_TextChanged(object sender, TextChangedEventArgs e)
        {
            CajaTexto1.Text = CajaTexto1.Text.ToUpper();
        }

        private void CajaTexto2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                CajaTexto2.Text = "Ayuda";
            }
        }


        private void CajaTexto1_GotFocus(object sender, RoutedEventArgs e)
        {
            CajaTextoFoco.Text = "TextBlock1";
        }

        private void CajaTexto2_GotFocus(object sender, RoutedEventArgs e)
        {
            CajaTextoFoco.Text = "TextBlock2";
        }

        private void CajaTexto3_GotFocus(object sender, RoutedEventArgs e)
        {
            CajaTextoFoco.Text = "TextBlock3";
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            CajaBotonIzq.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CajaBotonDer.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            CajaBotonIzq.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CajaBotonDer.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
        }
    }
}
