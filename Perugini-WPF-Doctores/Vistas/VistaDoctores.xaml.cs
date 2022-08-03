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

        Mis_Turnos mis_turnos;
        Mis_Recetas mis_Recetas;
        Nueva_Receta nueva_Receta;
        Medicaciones medicaciones;
        Nueva_Medicacion nueva_Medicacion;
        EditarUsuario editar_Usuario;

        public VistaDoctores(int Id_Doc, MainWindow mainWindow)
        {
            Id_Doctor = Id_Doc;
            this.mainWindow = mainWindow;

            nueva_Receta = new Nueva_Receta(Id_Doctor, this);
            medicaciones = new Medicaciones();
            nueva_Medicacion = new Nueva_Medicacion(this);
            mis_turnos = new Mis_Turnos(Id_Doctor);
            mis_Recetas = new Mis_Recetas(Id_Doctor, true);
            editar_Usuario = new EditarUsuario(Id_Doctor, this.mainWindow, true);

            InitializeComponent();
            Frame_VistaDoctores.Navigate(mis_turnos);
        }

        private void Boton_Mis_Turnos_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaDoctores.Navigate(mis_turnos);
        }

        internal void irARecetas()
        {
            mis_Recetas.recargarRecetas();
            Frame_VistaDoctores.Navigate(mis_Recetas);
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
