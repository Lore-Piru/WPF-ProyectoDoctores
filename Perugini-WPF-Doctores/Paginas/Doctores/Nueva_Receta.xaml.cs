using Perugini_WPF_Doctores.Clases;
using Perugini_WPF_Doctores.Vistas;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Doctores
{
    public partial class Nueva_Receta : Page
    {
        int Id_Doctor;
        Conector conector;
        VistaDoctores vistaDoctores;

        public Nueva_Receta(int Id_Doc, Conector conector, VistaDoctores vistaDoctores)
        {
            InitializeComponent();

            this.conector = conector;
            Id_Doctor = Id_Doc;
            this.vistaDoctores = vistaDoctores;

            cargarComboBoxes();
        }

        private void cargarComboBoxes()
        {
            box_paciente.DisplayMemberPath = "Nombre";
            box_paciente.SelectedValue = "Id";
            DataTable pacientes = conector.comboBoxPacientes();
            box_paciente.ItemsSource = pacientes.DefaultView;

            box_medicacion.DisplayMemberPath = "NombreYDosis";
            box_medicacion.SelectedValue = "Id";
            DataTable medicaciones = conector.comboBoxMedicaciones();
            box_medicacion.ItemsSource = medicaciones.DefaultView;
        }

        private void Boton_Nueva_Receta_Click(object sender, RoutedEventArgs e)
        {
            string frecuencia = box_frecuencia.Text;
            string comentarios = box_comentarios.Text;

            if (frecuencia == "" || comentarios == "" || box_paciente.SelectedItem == null || box_medicacion.SelectedItem == null)
                MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                DataRowView pacienteDRV = (DataRowView)box_paciente.SelectionBoxItem;
                int paciente = int.Parse(pacienteDRV.Row[0].ToString());
                DataRowView medicacionDRV = (DataRowView)box_medicacion.SelectionBoxItem;
                int medicacion = int.Parse(medicacionDRV.Row[0].ToString());

                conector.nuevaReceta(paciente, Id_Doctor, medicacion, frecuencia, comentarios);

                MessageBox.Show($"La receta se creó correctamente.", "La receta se creó correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
                vistaDoctores.irARecetas();
            }
        }
    }
}
