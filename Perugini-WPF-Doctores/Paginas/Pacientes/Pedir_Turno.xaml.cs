using Perugini_WPF_Doctores.Clases;
using Perugini_WPF_Doctores.Vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Perugini_WPF_Doctores.Paginas.Pacientes
{
    public partial class Pedir_Turno : Page
    {
        int id_Paciente;
        VistaPacientes vistaPacientes;

        public Pedir_Turno(int id_pac, VistaPacientes vistaPacientes)
        {
            InitializeComponent();

            id_Paciente = id_pac;
            this.vistaPacientes = vistaPacientes;

            CargarComboBoxes();
        }

        private void CargarComboBoxes()
        {
            box_doctores.DisplayMemberPath = "Nombre";
            box_doctores.SelectedValue = "Id";
            DataTable doctores = Conector.comboBoxDoctores();
            box_doctores.ItemsSource = doctores.DefaultView;

            box_tipoDeTurno.DisplayMemberPath = "TipoDeTurno";
            box_tipoDeTurno.SelectedValue = "Id";
            DataTable tiposDeTurnos = Conector.comboBoxTipoDeTurno();
            box_tipoDeTurno.ItemsSource = tiposDeTurnos.DefaultView;
        }

        private void Boton_Nuevo_Turnos_Click(object sender, RoutedEventArgs e)
        {
            string duracion_string = box_duracion.Text;
            string comentarios = box_comentarios.Text;

            if (!Verificador.verificarStringLargo(comentarios))
                return;

            if (duracion_string == "" || box_fecha.SelectedDate == null
                || box_doctores == null || box_tipoDeTurno == null)
            {
                MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int duracion;

            if (Verificador.verificarInt(duracion_string).respuesta)
                duracion = Verificador.verificarInt(duracion_string).num;
            else
            {
                MessageBox.Show("La duración ingresada es incorrecta, por favor cambiela. Muchas gracias", "Error en la duración", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DataRowView doctorDRV = (DataRowView)box_doctores.SelectionBoxItem;
            int doctor = int.Parse(doctorDRV.Row[0].ToString());
            DataRowView tipoDeTurnoDRV = (DataRowView)box_tipoDeTurno.SelectionBoxItem;
            int tipoDeTurno = int.Parse(tipoDeTurnoDRV.Row[0].ToString());

            string hora = $"{box_hora.Text}:{box_minutos.Text}";
            string fecha = box_fecha.SelectedDate.ToString().Replace(" 12:00:00 AM", "");
            DateTime fechaYHora = DateTime.Parse($"{fecha} {hora}");

            Conector.nuevoTurno(id_Paciente, doctor, fechaYHora, duracion, tipoDeTurno, comentarios);

            MessageBox.Show("El turno se creó correctamente.", "El turno se creó correctamente", MessageBoxButton.OK, MessageBoxImage.Information);
            vistaPacientes.irAMisTurnos();
        }
    }
}
