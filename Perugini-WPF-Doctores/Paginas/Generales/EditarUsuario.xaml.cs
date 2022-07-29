using Perugini_WPF_Doctores.Clases;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Generales
{
    public partial class EditarUsuario : Page
    {
        int id;
        Conector conector;
        bool doc_paciente;
        MainWindow mainWindow;

        public EditarUsuario(int id, Conector conector, MainWindow mainWindow, bool doc_paciente) // doc_paciente - True doc.
        {
            InitializeComponent();

            this.id = id;
            this.conector = conector;
            this.mainWindow = mainWindow;
            this.doc_paciente = doc_paciente;

            cargarDatos();
        }

        private void cargarDatos()
        {
            DataRow datos = conector.infoPersona(id, doc_paciente).Rows[0];

            box_nombre.Text = datos[1].ToString();
            box_apellido.Text = datos[2].ToString();
            box_nombreDeUsuario.Text = datos[3].ToString();
            box_clave.Password = datos[4].ToString();
            box_tipoDeDocumento.SelectedIndex = int.Parse(datos[5].ToString());
            box_nroDeDoc.Text = datos[6].ToString();
        }

        private void Boton_GuardarCambios_Click(object sender, RoutedEventArgs e)
        {
            string nombre = box_nombre.Text;
            string apellido = box_apellido.Text;
            string nombreDeUsuario = box_nombreDeUsuario.Text;
            string clave = box_clave.Password;
            string nroDeDoc_string = box_nroDeDoc.Text;

            if (nombre == "" || apellido == "" || nombreDeUsuario == "" || clave == "" || nroDeDoc_string == "")
                MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                int nroDeDoc;
                if (int.TryParse(nroDeDoc_string, out nroDeDoc))
                {
                    int tipoDeDoc = box_tipoDeDocumento.SelectedIndex;

                    conector.actualizarPersona(id, nombre, apellido, nombreDeUsuario, clave, tipoDeDoc, nroDeDoc, doc_paciente);

                    MessageBox.Show("Sus datos fueron actualizados correctamente. Muchas gracias", "Datos guardados correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("El número de documento es incorrecto, por favor cambielo. Muchas gracias", "Error en el número de documento", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Boton_EliminarUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Al eliminar este usuario eliminiría todas las recetas y turnos relacionadas. ¿Segure que desa continuar?", "¿Seguro que desea eliminar su usuario?", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                conector.borrarPersona(id, doc_paciente);
                mainWindow.volverAlLogin();
            }
        }
    }
}
