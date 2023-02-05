using System;
using System.Collections;
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

namespace Calculadora
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

        string operador = "";
        bool numero_negativo;

        private void b_masmenos_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero_negativo)
            {
                numero.Content = numero.Content.ToString().Replace("-", "");
                numero_negativo = false;
            } else
            {
                numero.Content = numero.Content.ToString().Insert(0, "-");
                numero_negativo = true;
            }
        }

        private void b_CE_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            Label numero_anterior = (Label)this.FindName("numero_anterior");
            numero.Content = "0";
            numero_anterior.Content = "";
        }

        private void b_7_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if(numero.Content.ToString().Equals("0")) {
                numero.Content = "7";
            } else
            {
                numero.Content += "7";
            }
        }

        private void b_4_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().Equals("0"))
            {
                numero.Content = "4";
            }
            else
            {
                numero.Content += "4";
            }
        }

        private void b_1_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().Equals("0"))
            {
                numero.Content = "1";
            }
            else
            {
                numero.Content += "1";
            }
        }

        private void b_8_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().Equals("0"))
            {
                numero.Content = "8";
            }
            else
            {
                numero.Content += "8";
            }
        }

        private void b_5_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().Equals("0"))
            {
                numero.Content = "5";
            }
            else
            {
                numero.Content += "5";
            }
        }

        private void b_2_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().Equals("0"))
            {
                numero.Content = "2";
            }
            else
            {
                numero.Content += "2";
            }
        }

        private void b_0_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().Equals("0"))
            {
                numero.Content = "0";
            }
            else
            {
                numero.Content += "0";
            }
        }

        private void b_borrar_Click(object sender, RoutedEventArgs e)
        {
            if (numero.Content.ToString().Length == 1)
            {
                numero.Content = "0";
            }
            else if(!numero.Content.Equals("0"))
            {
                numero.Content = numero.Content.ToString().Remove(numero.Content.ToString().Length - 1, 1);
            }
            
        }

        private void b_9_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().Equals("0"))
            {
                numero.Content = "9";
            }
            else
            {
                numero.Content += "9";
            }
        }

        private void b_6_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().Equals("0"))
            {
                numero.Content = "6";
            }
            else
            {
                numero.Content += "6";
            }
        }

        private void b_3_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().Equals("0"))
            {
                numero.Content = "3";
            }
            else
            {
                numero.Content += "3";
            }
        }

        private void b_coma_Click(object sender, RoutedEventArgs e)
        {
            Label numero = (Label)this.FindName("numero");
            if (numero.Content.ToString().IndexOf(',') < -1)
                numero.Content += ",";
        }

        private void b_dividir_Click(object sender, RoutedEventArgs e)
        {
            operador = "÷";
            numero_anterior.Content = numero.Content.ToString() + " " + operador;
            numero.Content = "0";
        }

        private void b_multiplicar_Click(object sender, RoutedEventArgs e)
        {
            operador = "*";
            numero_anterior.Content = numero.Content.ToString() + " " + operador;
            numero.Content = "0";
        }

        private void b_menos_Click(object sender, RoutedEventArgs e)
        {
            operador= "-";
            numero_anterior.Content = numero.Content.ToString() + " " + operador;
            numero.Content = "0";
        }

        private void b_mas_Click(object sender, RoutedEventArgs e)
        {
            operador = "+";
            numero_anterior.Content = numero.Content.ToString() + " " + operador;
            numero.Content = "0";
        }

        private void b_igual_Click(object sender, RoutedEventArgs e)
        {
            var arrayoperacion = numero_anterior.Content.ToString().Split(' ');
            string primernumero = arrayoperacion[0];
            Console.WriteLine(primernumero);
            switch(operador)
            {
                case "+":
                        numero_anterior.Content += " " + numero.Content.ToString();
                        numero.Content = long.Parse(primernumero) + long.Parse(numero.Content.ToString());
                    break;
                case "-":
                    numero_anterior.Content += " " + numero.Content.ToString();
                    numero.Content = long.Parse(primernumero) - long.Parse(numero.Content.ToString());
                    break;
                case "*":
                    numero_anterior.Content += " " + numero.Content.ToString();
                    numero.Content = long.Parse(primernumero) * long.Parse(numero.Content.ToString());
                    break;
                case "÷":
                    numero_anterior.Content += " " + numero.Content.ToString();
                    numero.Content = long.Parse(primernumero) / long.Parse(numero.Content.ToString());
                    break;
            }
        }

        private void MenuItemMoneda_Click(object sender, RoutedEventArgs e)
        {
            Window1 ventanamoneda = new Window1();
            ventanamoneda.Show();
            this.Close();
        }
    }
}
