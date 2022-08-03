using Perugini_WPF_Doctores.Clases;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Pacientes
{
    public partial class Mis_Turnos : Page
    {
        int Id_Paciente;
        public Mis_Turnos(int Id_Pac)
        {
            InitializeComponent();

            Id_Paciente = Id_Pac;

            cargarTurnos();
        }

        public void cargarTurnos()
        {
            DataTable turnosTabla = Conector.mostrarMisTurnos(Id_Paciente, false);
            grid_turnos.SelectedValuePath = "Id";
            grid_turnos.ItemsSource = turnosTabla.DefaultView;
        }

        private void Boton_Borrar_Turno_Click(object sender, RoutedEventArgs e)
        {
            Conector.borrarTurno((int)grid_turnos.SelectedValue);
            cargarTurnos();
        }
    }
}
