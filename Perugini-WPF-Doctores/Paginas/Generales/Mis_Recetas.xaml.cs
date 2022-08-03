using Perugini_WPF_Doctores.Clases;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Generales
{
    public partial class Mis_Recetas : Page
    {
        int id;
        bool doc_paciente;

        public Mis_Recetas(int id, bool doc_paciente) // doc_paciente - True doc.
        {
            InitializeComponent();

            this.id = id;
            this.doc_paciente = doc_paciente;

            recargarRecetas();
        }

        public void recargarRecetas()
        {
            DataTable recetasTabla = Conector.mostrarRecetas(id, doc_paciente);
            grid_recetas.SelectedValuePath = "Id";
            grid_recetas.ItemsSource = recetasTabla.DefaultView;
        }

        private void Boton_Borrar_Receta_Click(object sender, RoutedEventArgs e)
        {
            Conector.borrarReceta((int)grid_recetas.SelectedValue);
            recargarRecetas();
        }
    }
}
