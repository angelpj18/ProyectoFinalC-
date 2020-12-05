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
using System.Windows.Shapes;

namespace PandaHotelWPF
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventana = new MainWindow();
            ventana.ShowDialog();
        }

   


        private void MenuCategoria_Click(object sender, RoutedEventArgs e)
        {
            Categoria ventanaCate = new Categoria();
            ventanaCate.ShowDialog();
        }

        private void MenuPiso_Click(object sender, RoutedEventArgs e)
        {
            w_Piso ventanaPiso = new Piso();
            ventanaPiso.ShowDialog();
        }
    }
}
