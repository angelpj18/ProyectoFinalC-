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
    /// Lógica de interacción para Categoria.xaml
    /// </summary>
    public partial class Categoria : Window
    {
        public  Categoria()
        {
            InitializeComponent();
        }

        private  async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            Categor p = new Categor();
            p.descripcion = txtCategoria.Text;
            p.precioCategoria = txtPrecio.Text;
          

            await Categor.AgregarCategoria(p); //No olvidar el await
            ObtenerDatos();
        }

        private async void ObtenerDatos()
        {
            List<Categor> lista = await Categor.ObtenerTodos(); //No olvidar el await
            lstCategoria.ItemsSource = lista;
        }

      

    }
}
