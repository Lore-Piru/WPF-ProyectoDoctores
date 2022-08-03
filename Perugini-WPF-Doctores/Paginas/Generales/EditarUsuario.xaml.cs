using Perugini_WPF_Doctores.Clases;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Generales
{
    public partial class EditarUsuario : Page
    {
        int id;
        bool doc_paciente;
        MainWindow mainWindow;

        public EditarUsuario(int id, MainWindow mainWindow, bool doc_paciente) // doc_paciente - True doc.
        {
            InitializeComponent();

            this.id = id;
            this.mainWindow = mainWindow;
            this.doc_paciente = doc_paciente;

            cargarDatos();
        }

        private void cargarDatos()
        {
            DataRow datos = Conector.infoPersona(id, doc_paciente).Rows[0];

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

            List<string> stringsCortos = new List<string>() { nombre, apellido };

            string nombreDeUsuario = box_nombreDeUsuario.Text;
            string clave = box_clave.Password;

            int tipoDeDoc = box_tipoDeDocumento.SelectedIndex;
            string nroDeDoc = box_nroDeDoc.Text.ToUpper();

            if (!(Verificador.verificarStringsCortos(stringsCortos)
                && Verificador.verificarCredenciales(nombreDeUsuario, clave)
                && Verificador.verificarDocumentos(tipoDeDoc, nroDeDoc)))
                return;

            Conector.actualizarPersona(id, nombre, apellido, nombreDeUsuario, clave, tipoDeDoc, nroDeDoc, doc_paciente);

            cargarDatos();

            MessageBox.Show("Sus datos fueron actualizados correctamente. Muchas gracias", "Datos guardados correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Boton_EliminarUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Al eliminar este usuario eliminiría todas las recetas y turnos relacionadas. ¿Segure que desa continuar?", "¿Seguro que desea eliminar su usuario?", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                Conector.borrarPersona(id, doc_paciente);
                mainWindow.volverAlLogin();
            }
        }
    }
}
