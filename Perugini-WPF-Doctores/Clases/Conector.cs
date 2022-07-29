using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Perugini_WPF_Doctores.Clases
{
    public class Conector
    {
        private SqlConnection conexionSQL;
        private string conexion;

        public Conector()
        {
            conexion = ConfigurationManager.ConnectionStrings["BD_ProyectoDoctores"].ConnectionString;
        }

        #region personas
        public void nuevaPersona(List<string> datos, int tipoDeDoc, int numDeDoc, bool doc_paciente) // doc_paciente - True doc.
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta;

            if (doc_paciente)
                consulta = "NuevoDoctor";
            else
                consulta = "NuevoPaciente";

            SqlCommand comando_crearPersona = new SqlCommand(consulta, conexionSQL);

            comando_crearPersona.Parameters.AddWithValue("nombre", datos[0]);
            comando_crearPersona.Parameters.AddWithValue("apellido", datos[1]);
            comando_crearPersona.Parameters.AddWithValue("nombreDeUsuario", datos[2]);
            comando_crearPersona.Parameters.AddWithValue("clave", datos[3]);
            comando_crearPersona.Parameters.AddWithValue("tipoDeDoc", tipoDeDoc);
            comando_crearPersona.Parameters.AddWithValue("numDeDoc", numDeDoc);

            comando_crearPersona.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_crearPersona.ExecuteNonQuery();
            conexionSQL.Close();
        }

        public DataTable infoPersona(int id, bool doc_paciente) // doc_paciente - True doc.
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta;

            if (doc_paciente)
                consulta = "spMiInfoDoctor";
            else
                consulta = "spMiInfoPaciente";

            SqlCommand comando_infoPersona = new SqlCommand(consulta, conexionSQL);

            comando_infoPersona.Parameters.AddWithValue("Id", id);

            comando_infoPersona.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador_infoPersona = new SqlDataAdapter(comando_infoPersona);

            DataTable infoPersona = new DataTable();

            using (comando_infoPersona)
            using (adaptador_infoPersona)
            {
                adaptador_infoPersona.Fill(infoPersona);
            }
            return infoPersona;
        }

        public void actualizarPersona(int Id, string nombre, string apellido, string nombreDeUsuario,
                        string clave, int tipoDeDoc, int numDeDoc, bool doc_paciente) // doc_paciente - True doc.
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta;

            if (doc_paciente)
                consulta = "EditarDoctor";
            else
                consulta = "EditarPaciente";

            SqlCommand comando_actualizarPersona = new SqlCommand(consulta, conexionSQL);

            comando_actualizarPersona.Parameters.AddWithValue("Id", Id);
            comando_actualizarPersona.Parameters.AddWithValue("nombre", nombre);
            comando_actualizarPersona.Parameters.AddWithValue("apellido", apellido);
            comando_actualizarPersona.Parameters.AddWithValue("nombreDeUsuario", nombreDeUsuario);
            comando_actualizarPersona.Parameters.AddWithValue("clave", clave);
            comando_actualizarPersona.Parameters.AddWithValue("tipoDeDoc", tipoDeDoc);
            comando_actualizarPersona.Parameters.AddWithValue("numDeDoc", numDeDoc);

            comando_actualizarPersona.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_actualizarPersona.ExecuteNonQuery();
            conexionSQL.Close();
        }

        public int login(string nombreDeUsuario, string clave, bool doc_paciente) // doc_paciente - True doc.
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta;

            if (doc_paciente)
                consulta = "spLoginDoctores";
            else
                consulta = "spLoginPacientes";

            SqlCommand comando_login = new SqlCommand(consulta, conexionSQL);

            comando_login.Parameters.AddWithValue("nombreDeUsuario", nombreDeUsuario);
            comando_login.Parameters.AddWithValue("clave", clave);

            comando_login.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador_login = new SqlDataAdapter(comando_login);

            DataTable id_DT = new DataTable();

            using (comando_login)
            using (adaptador_login)
            {
                adaptador_login.Fill(id_DT);
            }
            DataRow id_DR = id_DT.Rows[0];
            return int.Parse(id_DR[0].ToString());
        }

        public void borrarPersona(int id, bool doc_paciente) // doc_paciente - True doc.
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta;

            if (doc_paciente)
                consulta = "EliminarDoctor";
            else
                consulta = "EliminarPaciente";

            SqlCommand comando_borrarPersona = new SqlCommand(consulta, conexionSQL);
            comando_borrarPersona.Parameters.AddWithValue("Id", id);
            comando_borrarPersona.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_borrarPersona.ExecuteNonQuery();
            conexionSQL.Close();
        }

        #endregion

        #region turnos
        public void nuevoTurno(int id_paciente, int id_doctor, DateTime horarioInicio,
            int duracion, int tipoDeTurno, string comentariosPaciente)
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta = "NuevoTurno";
            SqlCommand comando_crearReceta = new SqlCommand(consulta, conexionSQL);

            comando_crearReceta.Parameters.AddWithValue("paciente", id_paciente);
            comando_crearReceta.Parameters.AddWithValue("doctor", id_doctor);
            comando_crearReceta.Parameters.AddWithValue("horarioInicio", horarioInicio);
            comando_crearReceta.Parameters.AddWithValue("duracion", duracion);
            comando_crearReceta.Parameters.AddWithValue("tipoDeTurno", tipoDeTurno);
            comando_crearReceta.Parameters.AddWithValue("comentariosPaciente", comentariosPaciente);
            comando_crearReceta.Parameters.AddWithValue("comentariosDoc", "");

            comando_crearReceta.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_crearReceta.ExecuteNonQuery();
            conexionSQL.Close();
        }

        public DataTable mostrarMisTurnos(int id, bool doc_paciente) // doc_paciente - True doc.
        {
            actualizarTurnosPasados();

            conexionSQL = new SqlConnection(conexion);

            string consulta;

            if (doc_paciente)
                consulta = "spMisTurnosDoctor";
            else
                consulta = "spMisTurnosPaciente";

            SqlCommand comando_todosMisTurnos = new SqlCommand(consulta, conexionSQL);

            if (doc_paciente)
                comando_todosMisTurnos.Parameters.AddWithValue("IdDoctor", id);
            else
                comando_todosMisTurnos.Parameters.AddWithValue("IdPaciente", id);

            comando_todosMisTurnos.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador_todosMisTurnos = new SqlDataAdapter(comando_todosMisTurnos);

            DataTable turnos = new DataTable();

            using (comando_todosMisTurnos)
            using (adaptador_todosMisTurnos)
            {
                adaptador_todosMisTurnos.Fill(turnos);
            }
            return turnos;
        }

        private void actualizarTurnosPasados()
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta = "ActualizarTurnosPasados";
            SqlCommand comando_actualizarTurnosPasados = new SqlCommand(consulta, conexionSQL);
            comando_actualizarTurnosPasados.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_actualizarTurnosPasados.ExecuteNonQuery();
            conexionSQL.Close();
        }

        public void confirmarTurno(int id, string comentariosDoc, int id_estado)
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta = "EditarTurno";
            SqlCommand comando_confirmarTurno = new SqlCommand(consulta, conexionSQL);

            comando_confirmarTurno.Parameters.AddWithValue("Id", id);
            comando_confirmarTurno.Parameters.AddWithValue("comentariosDoc", comentariosDoc);
            comando_confirmarTurno.Parameters.AddWithValue("idEstado", id_estado);

            comando_confirmarTurno.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_confirmarTurno.ExecuteNonQuery();
            conexionSQL.Close();
        }

        public void borrarTurno(int id)
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta = "EliminarTurno";
            SqlCommand comando_borrarTurno = new SqlCommand(consulta, conexionSQL);
            comando_borrarTurno.Parameters.AddWithValue("Id", id);
            comando_borrarTurno.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_borrarTurno.ExecuteNonQuery();
            conexionSQL.Close();
        }

        #endregion

        #region recetas

        public void nuevaReceta(int id_paciente, int id_doctor, int id_medicacion, string frecuencia, string comentarios)
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta = "NuevaReceta";
            SqlCommand comando_crearReceta = new SqlCommand(consulta, conexionSQL);
            comando_crearReceta.Parameters.AddWithValue("paciente", id_paciente);
            comando_crearReceta.Parameters.AddWithValue("doctor", id_doctor);
            comando_crearReceta.Parameters.AddWithValue("medicacion", id_medicacion);
            comando_crearReceta.Parameters.AddWithValue("frecuencia", frecuencia);
            comando_crearReceta.Parameters.AddWithValue("comentarios", comentarios);
            comando_crearReceta.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_crearReceta.ExecuteNonQuery();
            conexionSQL.Close();
        }

        public DataTable mostrarRecetas(int id, bool doc_paciente) // doc_paciente - True doc.
        {
            conexionSQL = new SqlConnection(conexion);
            string consulta;

            if (doc_paciente)
                consulta = "spMisRecetasDoctor";
            else
                consulta = "spMisRecetasPaciente";

            DataTable recetas = new DataTable();

            using (SqlDataAdapter adaptador_todasLasRecetas = new SqlDataAdapter())
            {
                SqlCommand comando_todasMisRecetas = new SqlCommand(consulta, conexionSQL);

                if (doc_paciente)
                    comando_todasMisRecetas.Parameters.AddWithValue("IdDoctor", id);
                else
                    comando_todasMisRecetas.Parameters.AddWithValue("IdPaciente", id);

                comando_todasMisRecetas.CommandType = CommandType.StoredProcedure;

                adaptador_todasLasRecetas.SelectCommand = comando_todasMisRecetas;

                adaptador_todasLasRecetas.Fill(recetas);
            }
            return recetas;
        }

        public void borrarReceta(int id)
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta = "EliminarReceta";
            SqlCommand comando_borrarReceta = new SqlCommand(consulta, conexionSQL);
            comando_borrarReceta.Parameters.AddWithValue("Id", id);
            comando_borrarReceta.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_borrarReceta.ExecuteNonQuery();
            conexionSQL.Close();
        }

        #endregion

        #region medicaciones
        public void nuevaMedicacion(string nombre, float dosis)
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta = "NuevaMedicacion";
            SqlCommand comando_crearMedicacion = new SqlCommand(consulta, conexionSQL);
            comando_crearMedicacion.Parameters.AddWithValue("nombre", nombre);
            comando_crearMedicacion.Parameters.AddWithValue("dosisEnMg", dosis);
            comando_crearMedicacion.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_crearMedicacion.ExecuteNonQuery();
            conexionSQL.Close();
        }
        public DataTable mostrarMedicaciones()
        {
            conexionSQL = new SqlConnection(conexion);
            string consulta = "spTodasLasMedicaciones";
            SqlDataAdapter adaptador_todasLasMedicaciones = new SqlDataAdapter(consulta, conexionSQL);

            DataTable medicaciones = new DataTable();

            using (adaptador_todasLasMedicaciones)
            {
                adaptador_todasLasMedicaciones.Fill(medicaciones);
            }
            return medicaciones;
        }

        public void actualizarMedicacion(int id, string nombre, float dosis)
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta = "EditarMedicacion";
            SqlCommand comando_actualizarMedicacion = new SqlCommand(consulta, conexionSQL);
            comando_actualizarMedicacion.Parameters.AddWithValue("Id", id);
            comando_actualizarMedicacion.Parameters.AddWithValue("nombre", nombre);
            comando_actualizarMedicacion.Parameters.AddWithValue("dosisEnMg", dosis);
            comando_actualizarMedicacion.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_actualizarMedicacion.ExecuteNonQuery();
            conexionSQL.Close();
        }

        public void borrarMedicacion(int id)
        {
            conexionSQL = new SqlConnection(conexion);

            string consulta = "EliminarMedicacion";
            SqlCommand comando_borrarMedicacion = new SqlCommand(consulta, conexionSQL);
            comando_borrarMedicacion.Parameters.AddWithValue("Id", id);
            comando_borrarMedicacion.CommandType = CommandType.StoredProcedure;

            conexionSQL.Open();
            comando_borrarMedicacion.ExecuteNonQuery();
            conexionSQL.Close();
        }

        #endregion

        #region ComboBoxes

        public DataTable comboBoxPacientes()
        {
            conexionSQL = new SqlConnection(conexion);
            string consulta = "spPacientes";
            SqlDataAdapter adaptador_Pacientes = new SqlDataAdapter(consulta, conexionSQL);

            DataTable pacientes = new DataTable();

            using (adaptador_Pacientes)
            {
                adaptador_Pacientes.Fill(pacientes);
            }
            return pacientes;
        }

        public DataTable comboBoxDoctores()
        {
            conexionSQL = new SqlConnection(conexion);
            string consulta = "spDoctores";
            SqlDataAdapter adaptador_Doctores = new SqlDataAdapter(consulta, conexionSQL);

            DataTable doctores = new DataTable();

            using (adaptador_Doctores)
            {
                adaptador_Doctores.Fill(doctores);
            }
            return doctores;
        }

        public DataTable comboBoxTipoDeTurno()
        {
            conexionSQL = new SqlConnection(conexion);
            string consulta = "spTiposDeTurnos";
            SqlDataAdapter adaptador_TiposDeTurnos = new SqlDataAdapter(consulta, conexionSQL);

            DataTable tiposDeTurnos = new DataTable();

            using (adaptador_TiposDeTurnos)
            {
                adaptador_TiposDeTurnos.Fill(tiposDeTurnos);
            }
            return tiposDeTurnos;
        }

        public DataTable comboBoxMedicaciones()
        {
            conexionSQL = new SqlConnection(conexion);
            string consulta = "spMedicaciones";
            SqlDataAdapter adaptador_Medicaciones = new SqlDataAdapter(consulta, conexionSQL);

            DataTable medicaciones = new DataTable();

            using (adaptador_Medicaciones)
            {
                adaptador_Medicaciones.Fill(medicaciones);
            }
            return medicaciones;
        }

        #endregion
    }
}
