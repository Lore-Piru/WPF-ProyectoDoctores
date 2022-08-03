using Perugini_WPF_Doctores.Clases;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Generales
{
    public partial class Registro : Page
    {
        MainWindow mainWindow = null;

        public Registro(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
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

            List<string> stringsCortos = new List<string>() { nombre, apellido };

            string nombreDeUsuario = box_nombreDeUsuario.Text;
            string clave = box_clave.Password;

            int tipoDeDoc = box_tipoDeDocumento.SelectedIndex;
            string nroDeDoc = box_nroDeDoc.Text.ToUpper();

            if (!(Verificador.verificarStringsCortos(stringsCortos)
                && Verificador.verificarCredenciales(nombreDeUsuario, clave)
                && Verificador.verificarDocumentos(tipoDeDoc, nroDeDoc)))
                return;

            List<string> datos = new List<string>() { nombre, apellido, nombreDeUsuario, clave };
            Conector.nuevaPersona(datos, tipoDeDoc, nroDeDoc, doc_paciente);

            if (doc_paciente)
                mainWindow.uiDoctores(Conector.login(nombreDeUsuario, clave, doc_paciente));
            else
                mainWindow.uiPacientes(Conector.login(nombreDeUsuario, clave, doc_paciente));
        }

        private void Boton_Atras_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.volverAlLogin();
        }
    }
}