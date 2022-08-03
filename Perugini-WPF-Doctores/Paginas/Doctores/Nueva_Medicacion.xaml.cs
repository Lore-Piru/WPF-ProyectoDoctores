using Perugini_WPF_Doctores.Clases;
using Perugini_WPF_Doctores.Vistas;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Doctores
{
    public partial class Nueva_Medicacion : Page
    {
        VistaDoctores vistaDoctores;

        public Nueva_Medicacion(VistaDoctores vistaDoctores)
        {
            InitializeComponent();

            this.vistaDoctores = vistaDoctores;
        }

        private void Boton_Nueva_Medicacion_Click(object sender, RoutedEventArgs e)
        {
            string nombre = box_nombre.Text;
            string dosis_string = box_dosis.Text;

            if (!Verificador.verificarStringLargo(nombre))
                return;

            float dosis;
            if (Verificador.verificarFloat(dosis_string).respuesta)
                dosis = Verificador.verificarFloat(dosis_string).num;
            else
            {
                MessageBox.Show("La dosis ingresada es incorrecta, por favor cambiela. Muchas gracias", "Error en la dosis", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Conector.nuevaMedicacion(nombre, dosis);
            MessageBox.Show($"La medicación se creó correctamente con el nombre {nombre} y la dosis {dosis}.", "La medicación se creó correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
            vistaDoctores.irAMedicaciones();
        }
    }
}
