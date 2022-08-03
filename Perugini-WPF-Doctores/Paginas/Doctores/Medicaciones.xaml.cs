using Perugini_WPF_Doctores.Clases;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Doctores
{
    public partial class Medicaciones : Page
    {
        public Medicaciones()
        {
            InitializeComponent();

            recargarGridMedicaciones();
        }

        private void Boton_Borrar_Medicacion_Click(object sender, RoutedEventArgs e)
        {
            Conector.borrarMedicacion((int)grid_medicaciones.SelectedValue);
            recargarGridMedicaciones();
        }
        private void Boton_Actualizar_Medicacion_Click(object sender, RoutedEventArgs e)
        {
            DataRowView medicacionesDRV = (DataRowView)grid_medicaciones.SelectedItems[0];

            string nombre = medicacionesDRV.Row[1].ToString();
            string dosis_string = medicacionesDRV.Row[2].ToString();

            if (!Verificador.verificarStringLargo(nombre))
                return;

            if (dosis_string == "")
            {
                MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            float dosis;
            if (Verificador.verificarFloat(dosis_string).respuesta)
                dosis = Verificador.verificarFloat(dosis_string).num;
            else
            {
                MessageBox.Show("La dosis ingresada es incorrecta, por favor cambiela. Muchas gracias", "Error en la dosis", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int id = int.Parse(medicacionesDRV.Row[0].ToString());
            Conector.actualizarMedicacion(id, nombre, dosis);
            MessageBox.Show($"La medicación se actualizó correctamente con el nombre {nombre} y la dosis {dosis}.", "La medicación se actualizó correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
            recargarGridMedicaciones();
        }

        public void recargarGridMedicaciones()
        {
            DataTable medicacionesTabla = Conector.mostrarMedicaciones();
            grid_medicaciones.SelectedValuePath = "Id";
            grid_medicaciones.ItemsSource = medicacionesTabla.DefaultView;
        }
    }
}
