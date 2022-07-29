using Perugini_WPF_Doctores.Clases;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Doctores
{
    public partial class Medicaciones : Page
    {
        Conector conector;
        public Medicaciones(Conector conector)
        {
            InitializeComponent();
            this.conector = conector;

            recargarGridMedicaciones();
        }

        private void Boton_Borrar_Medicacion_Click(object sender, RoutedEventArgs e)
        {
            conector.borrarMedicacion((int)grid_medicaciones.SelectedValue);
            recargarGridMedicaciones();
        }
        private void Boton_Actualizar_Medicacion_Click(object sender, RoutedEventArgs e)
        {
            DataRowView medicacionesDRV = (DataRowView)grid_medicaciones.SelectedItems[0];

            string nombre = medicacionesDRV.Row[1].ToString();
            string dosis_string = medicacionesDRV.Row[2].ToString();

            if (nombre == "" || dosis_string == "")
                MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                float dosis;
                if (float.TryParse(dosis_string.Replace(',', '.'), out dosis))
                {
                    int id = int.Parse(medicacionesDRV.Row[0].ToString());
                    conector.actualizarMedicacion(id, nombre, dosis);
                    MessageBox.Show($"La medicación se actualizó correctamente con el nombre {nombre} y la dosis {dosis}.", "La medicación se actualizó correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
                    recargarGridMedicaciones();
                }
                else
                    MessageBox.Show("La dosis ingresada es incorrecta, por favor cambiela. Muchas gracias", "Error en la dosis", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void recargarGridMedicaciones()
        {
            DataTable medicacionesTabla = conector.mostrarMedicaciones();
            grid_medicaciones.SelectedValuePath = "Id";
            grid_medicaciones.ItemsSource = medicacionesTabla.DefaultView;
        }
    }
}
