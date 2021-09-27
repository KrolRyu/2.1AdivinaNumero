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

namespace _2._1AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        int numero;
        public MainWindow()
        {
            InitializeComponent();
            numero = r.Next(0, 101);
        }

        private void Comprobar_Click(object sender, RoutedEventArgs e)
        {            
            if (int.Parse(Input.Text) == numero)
            {
                Resultado.Text = "¡Has acertado!";
            }
            else if (int.Parse(Input.Text) > numero)
            {
                Resultado.Text = "Te has pasado";
            }
            else
            {
                Resultado.Text = "Te has quedado corto";
            }
        }

        private void Reiniciar_Click(object sender, RoutedEventArgs e)
        {
            numero = r.Next(0, 101);
            Resultado.Text = "";
            Input.Text = "";
        }
    }
}
