using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Desenvolvimento_de_tela_com_panel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPeso.Text) && !string.IsNullOrEmpty(txtAltura.Text))
            {
                try
                {
                    double peso = Convert.ToDouble(txtPeso.Text);
                    double altura = Convert.ToDouble(txtAltura.Text);

                    double imc = peso / (altura * altura);

                    lblResultado.Content = "IMC: " + imc.ToString("N2");

                    if (imc < 18.5)
                    {
                        lblResultado.Content += " (Baixo peso)";
                    }
                    else if (imc >= 18.5 && imc < 24.9)
                    {
                        lblResultado.Content += " (Peso saudável)";
                    }
                    else if (imc >= 25 && imc < 29.9)
                    {
                        lblResultado.Content += " (Sobrepeso)";
                    }
                    else if (imc >= 30 && imc < 34.9)
                    {
                        lblResultado.Content += " (Obesidade grau 1)";
                    }
                    else if (imc >= 35 && imc < 39.9)
                    {
                        lblResultado.Content += " (Obesidade grau 2)";
                    }
                    else
                    {
                        lblResultado.Content += " (Obesidade grau 3)";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error de calculo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Insira um valor válido para Peso e Altura.", "Campo vazio", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}