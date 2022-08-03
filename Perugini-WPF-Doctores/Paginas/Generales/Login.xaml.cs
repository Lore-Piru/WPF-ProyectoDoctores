using Perugini_WPF_Doctores.Clases;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Generales
{
    public partial class Login : Page
    {
        MainWindow mainWindow = null;

        public Login(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void Boton_Ingresar_Doctores_Click(object sender, RoutedEventArgs e)
        {
            int id = verificarUsuario(true);
            if (id == 0)
                MessageBox.Show("Los datos ingresados son incorrectos.", "Error en el login", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                if (id != (-1))
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

            if (!Verificador.verificarCredenciales(nombreDeUsuario, clave))
                return (-1);
            else
                return Conector.login(nombreDeUsuario, clave, doc_paciente);
        }

        private void Boton_NuevaCuenta_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.registro();
        }
    }
}
