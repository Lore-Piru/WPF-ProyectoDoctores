using Perugini_WPF_Doctores.Clases;
using Perugini_WPF_Doctores.Paginas.Doctores;
using Perugini_WPF_Doctores.Paginas.Generales;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Vistas
{
    public partial class VistaDoctores : UserControl
    {
        int Id_Doctor;
        MainWindow mainWindow = null;
        Conector conector;

        Mis_Turnos mis_turnos;
        Mis_Recetas mis_Recetas;
        Nueva_Receta nueva_Receta;
        Medicaciones medicaciones;
        Nueva_Medicacion nueva_Medicacion;
        EditarUsuario editar_Usuario;

        public VistaDoctores(int Id_Doc, MainWindow mainWindow, Conector conector)
        {
            Id_Doctor = Id_Doc;
            this.mainWindow = mainWindow;

            this.conector = conector;

            nueva_Receta = new Nueva_Receta(Id_Doctor, this.conector, this);
            medicaciones = new Medicaciones(this.conector);
            nueva_Medicacion = new Nueva_Medicacion(this.conector, this);
            mis_turnos = new Mis_Turnos(Id_Doctor, this.conector);
            mis_Recetas = new Mis_Recetas(Id_Doctor, this.conector, true);
            editar_Usuario = new EditarUsuario(Id_Doctor, this.conector, this.mainWindow, true);

            InitializeComponent();
            Frame_VistaDoctores.Navigate(mis_turnos);
        }

        private void Boton_Mis_Turnos_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaDoctores.Navigate(mis_turnos);
        }

        internal void irARecetas()
        {
            Frame_VistaDoctores.Navigate(mis_Recetas);
            mis_Recetas.recargarRecetas();
        }

        private void Boton_Mis_Recetas_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaDoctores.Navigate(mis_Recetas);
        }

        private void Boton_Nueva_Receta_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaDoctores.Navigate(nueva_Receta);
        }

        private void Boton_Medicaciones_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaDoctores.Navigate(medicaciones);
        }

        internal void irAMedicaciones()
        {
            Frame_VistaDoctores.Navigate(medicaciones);
            medicaciones.recargarGridMedicaciones();
        }

        private void Boton_Nueva_Medicacion_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaDoctores.Navigate(nueva_Medicacion);
        }

        private void Boton_Editar_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaDoctores.Navigate(editar_Usuario);
        }

        private void Boton_Volver_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.volverAlLogin();
        }
    }
}
