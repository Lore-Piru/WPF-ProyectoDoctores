using Perugini_WPF_Doctores.Clases;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Generales
{
    public partial class Mis_Recetas : Page
    {
        Conector conector;
        int id;
        bool doc_paciente;

        public Mis_Recetas(int id, Conector conector, bool doc_paciente) // doc_paciente - True doc.
        {
            InitializeComponent();

            this.conector = conector;
            this.id = id;
            this.doc_paciente = doc_paciente;

            recargarRecetas();
        }

        public void recargarRecetas()
        {
            DataTable recetasTabla = conector.mostrarRecetas(id, doc_paciente);
            grid_recetas.SelectedValuePath = "Id";
            grid_recetas.ItemsSource = recetasTabla.DefaultView;
        }

        private void Boton_Borrar_Receta_Click(object sender, RoutedEventArgs e)
        {
            conector.borrarReceta((int)grid_recetas.SelectedValue);
            recargarRecetas();
        }
    }
}
