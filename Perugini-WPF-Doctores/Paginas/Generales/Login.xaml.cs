using Perugini_WPF_Doctores.Clases;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Generales
{
    public partial class Login : Page
    {
        MainWindow mainWindow = null;
        Conector conector;

        public Login(MainWindow mainWindow, Conector conector)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.conector = conector;
        }

        private void Boton_Ingresar_Doctores_Click(object sender, RoutedEventArgs e)
        {
            int id = verificarUsuario(true);
            if (id == 0)
                MessageBox.Show("Los datos ingresados son incorrectos.", "Error en el login", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                if (!(id == (-1)))
                mainWindow.uiDoctores(id);
        }

        private void Boton_Ingresar_Pacientes_Click(object sender, RoutedEventArgs e)
        {
            int id = verificarUsuario(false);
            if (id == 0)
                MessageBox.Show("Los datos ingresados son incorrectos.", "Error en el login", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                if (!(id == (-1)))
                mainWindow.uiPacientes(id);
        }

        private int verificarUsuario(bool doc_paciente) // doc_paciente - True doc.
        {
            string nombreDeUsuario = box_nombreDeUsuario.Text;
            string clave = box_clave.Password;

            if (nombreDeUsuario == "" || clave == "")
            {
                MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
                return (-1);
            }
            else
                return conector.login(nombreDeUsuario, clave, doc_paciente);
        }

        private void Boton_NuevaCuenta_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.registro();
        }
    }
}
