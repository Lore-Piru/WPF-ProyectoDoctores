using Perugini_WPF_Doctores.Clases;
using Perugini_WPF_Doctores.Vistas;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Doctores
{
    public partial class Nueva_Medicacion : Page
    {
        Conector conector;
        VistaDoctores vistaDoctores;

        public Nueva_Medicacion(Conector conector, VistaDoctores vistaDoctores)
        {
            InitializeComponent();

            this.conector = conector;
            this.vistaDoctores = vistaDoctores;
        }

        private void Boton_Nueva_Medicacion_Click(object sender, RoutedEventArgs e)
        {
            string nombre = box_nombre.Text;
            if (nombre == "" || box_dosis.Text == "")
                MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                float dosis;
                if (float.TryParse(box_dosis.Text.Replace(',', '.'), out dosis))
                {
                    conector.nuevaMedicacion(nombre, dosis);
                    MessageBox.Show($"La medicación se creó correctamente con el nombre {nombre} y la dosis {dosis}.", "La medicación se creó correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
                    vistaDoctores.irAMedicaciones();
                }
                else
                    MessageBox.Show("La dosis ingresada es incorrecta, por favor cambiela. Muchas gracias", "Error en la dosis", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
