using Perugini_WPF_Doctores.Clases;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Generales
{
    public partial class Registro : Page
    {
        MainWindow mainWindow = null;
        Conector conector;

        public Registro(MainWindow mainWindow, Conector conector)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.conector = conector;
        }

        private void Boton_Doctor_Click(object sender, RoutedEventArgs e)
        {
            crearUsuario(true);
        }

        private void Boton_Paciente_Click(object sender, RoutedEventArgs e)
        {
            crearUsuario(false);
        }

        private void crearUsuario(bool doc_paciente) // doc_paciente - True doc.
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

                    List<string> datos = new List<string>() { nombre, apellido, nombreDeUsuario, clave };

                    conector.nuevaPersona(datos, tipoDeDoc, nroDeDoc, doc_paciente);

                    if (doc_paciente)
                        mainWindow.uiDoctores(conector.login(nombreDeUsuario, clave, doc_paciente));
                    else
                        mainWindow.uiPacientes(conector.login(nombreDeUsuario, clave, doc_paciente));
                }
                else
                    MessageBox.Show("El número de documento es incorrecto, por favor cambielo. Muchas gracias", "Error en el número de documento", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
