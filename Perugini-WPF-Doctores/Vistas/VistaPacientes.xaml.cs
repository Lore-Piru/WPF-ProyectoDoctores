using Perugini_WPF_Doctores.Paginas.Generales;
using Perugini_WPF_Doctores.Paginas.Pacientes;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Vistas
{
    public partial class VistaPacientes : UserControl
    {
        int Id_Paciente;
        MainWindow mainWindow = null;

        Mis_Turnos mis_turnos;
        Mis_Recetas mis_Recetas;
        Pedir_Turno pedir_Turno;
        EditarUsuario editarUsuario;

        public VistaPacientes(int Id_Pac, MainWindow mainWindow)
        {
            Id_Paciente = Id_Pac;
            InitializeComponent();

            this.mainWindow = mainWindow;

            mis_turnos = new Mis_Turnos(Id_Paciente);
            mis_Recetas = new Mis_Recetas(Id_Paciente, false);
            pedir_Turno = new Pedir_Turno(Id_Paciente, this);
            editarUsuario = new EditarUsuario(Id_Paciente, this.mainWindow, false);

            Frame_VistaPacientes.Navigate(mis_turnos);
        }

        private void Boton_Mis_Turnos_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaPacientes.Navigate(mis_turnos);
        }

        internal void irAMisTurnos()
        {
            Frame_VistaPacientes.Navigate(mis_turnos);
            mis_turnos.cargarTurnos();
        }

        private void Boton_Mis_Recetas_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaPacientes.Navigate(mis_Recetas);
        }

        private void Boton_Pedir_Turno_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaPacientes.Navigate(pedir_Turno);
        }

        private void Boton_Editar_Click(object sender, RoutedEventArgs e)
        {
            Frame_VistaPacientes.Navigate(editarUsuario);
        }

        private void Boton_Volver_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.volverAlLogin();
        }
    }
}
