using System.Windows;
using Perugini_WPF_Doctores.Clases;
using Perugini_WPF_Doctores.Paginas.Generales;
using Perugini_WPF_Doctores.Vistas;

namespace Perugini_WPF_Doctores
{

    public partial class MainWindow : Window
    {
        Conector conector;
        public MainWindow()
        {
            InitializeComponent();

            conector = new Conector();

            volverAlLogin();
        }
        internal void volverAlLogin()
        {
            FrameMain.Navigate(new Login(this, conector));
        }
        internal void uiDoctores(int Id_doc)
        {
            FrameMain.Navigate(new VistaDoctores(Id_doc, this, conector));
        }
        internal void uiPacientes(int Id_paciente)
        {
            FrameMain.Navigate(new VistaPacientes(Id_paciente, this, conector));
        }
        internal void registro()
        {
            FrameMain.Navigate(new Registro(this, conector));
        }
    }
}
