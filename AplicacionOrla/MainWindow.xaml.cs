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

namespace AplicacionOrla
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

        private void MouseEnter41(object sender, MouseEventArgs e)
        {
            LabelPuesto41.Text = "Aritz Perez";
        }

        private void MouseLeave41(object sender, MouseEventArgs e)
        {
            LabelPuesto41.Text = "Aritz P";
        }

        private void MouseClick41(object sender, RoutedEventArgs e)
        {
            LabelPuesto41.Text = "aperezdmorr@educacion.navarra.es";
        }

        private void DoubleClick41(object sender, MouseButtonEventArgs e)
        {
            {
                
                Perfil win2 = new Perfil("Aritz", "Perez",
                "email_alumno@educacion.navarra.es", "Imagenes/Usuario.jpg");
                win2.Show();
            }
        }
    }

}
