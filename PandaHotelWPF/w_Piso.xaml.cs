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
    /// Lógica de interacción para w_Piso.xaml
    /// </summary>
    public partial class w_Piso : Window
    {

        ReservaAlquilerEntities datos;
        public w_Piso()
        {
            InitializeComponent();
            datos = new ReservaAlquilerEntities();
        }


        private void CargarDatosGrilla()
        {
            try
            {
                dgPiso.ItemsSource = datos.Piso.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CargarDatosGrilla();

     
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Piso piso = new Piso();
            piso.NroPiso = txtNroPiso.Text;
            piso.Descripcion = txtDescripcion.Text;
            
            datos.Piso.Add(piso);
            datos.SaveChanges();


            CargarDatosGrilla();
        }
        }
    }
