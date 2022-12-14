using Perugini_WPF_Doctores.Clases;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Doctores
{
    public partial class Mis_Turnos : Page
    {
        int Id_Doctor;

        public Mis_Turnos(int Id_Doc)
        {
            InitializeComponent();

            Id_Doctor = Id_Doc;

            cargarTurnos();
        }

        private void cargarTurnos()
        {
            DataTable turnosTabla = Conector.mostrarMisTurnos(Id_Doctor, true);
            grid_turnos.SelectedValuePath = "Id";
            grid_turnos.ItemsSource = turnosTabla.DefaultView;
        }

        private void Boton_Eliminar_Turno_Click(object sender, RoutedEventArgs e)
        {
            Conector.borrarTurno((int)grid_turnos.SelectedValue);
            cargarTurnos();
        }

        private void Boton_Aceptar_Turno_Click(object sender, RoutedEventArgs e)
        {
            DataRowView turnosDRV = (DataRowView)grid_turnos.SelectedItems[0];
            string comentarios = turnosDRV.Row[7].ToString();

            if (!Verificador.verificarStringLargo(comentarios))
                return;

            Conector.confirmarTurno((int)grid_turnos.SelectedValue, comentarios, 1);
            cargarTurnos();
        }

        private void Boton_Rechazar_Turno_Click(object sender, RoutedEventArgs e)
        {
            DataRowView turnosDRV = (DataRowView)grid_turnos.SelectedItems[0];
            string comentarios = turnosDRV.Row[7].ToString();

            if (!Verificador.verificarStringLargo(comentarios))
                return;

            Conector.confirmarTurno((int)grid_turnos.SelectedValue, comentarios, 2);
            cargarTurnos();
        }
    }
}
