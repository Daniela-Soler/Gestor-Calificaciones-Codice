using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    /// <summary>
    /// Clase que gestiona las operaciones de base de datos relacionadas con asistencias de estudiantes.
    /// Implementa métodos para crear, leer y actualizar asistencias en la base de datos.
    /// </summary>
    public class CD_Asistencia
    {
        /// <summary>
        /// Instancia de conexión a la base de datos.
        /// </summary>
        private CD_Conexion conexion = new CD_Conexion();
        /// <summary>
        /// Registra una nueva asistencia de un estudiante en una asignatura específica.
        /// </summary>
        /// <param name="estudianteID">Identificador único del estudiante.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <param name="fecha">Fecha en la que se registra la asistencia.</param>
        /// <param name="estado">Estado de la asistencia (true para presente, false para ausente).</param>
        /// <param name="usuarioID">Identificador del usuario que registra la asistencia.</param>
        /// <returns>Retorna true si la asistencia se registró exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public bool CD_IngresarAsistencia(int estudianteID, int asignaturaID, DateTime fecha, bool estado, int usuarioID)
        {
            try
            {
                SqlCommand comando = new SqlCommand();

                int filasAfectadas = 0;
                comando.Parameters.Clear();

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_CREATE_RegistrarAsistencia";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@EstudianteID", estudianteID);
                comando.Parameters.AddWithValue("@AsignaturaID", asignaturaID);
                comando.Parameters.AddWithValue("@FechaAsistencia", fecha);
                comando.Parameters.AddWithValue("@Estado", estado);
                comando.Parameters.AddWithValue("@UsuarioID", usuarioID);

                filasAfectadas = comando.ExecuteNonQuery();
                conexion.CerrarConexion();

                return filasAfectadas > 0;
            } catch (Exception ex)
            {
                throw new Exception("Error al ingresar una asistencia: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todas las asistencias registradas en el sistema.
        /// </summary>
        /// <returns>
        /// Retorna un <see cref="DataTable"/> que contiene todas las asistencias
        /// con sus respectivos datos (AsistenciaID, EstudianteID, Estudiante, AsignaturaID,
        /// Asignatura, FechaAsistencia, Estado).
        /// Si no hay asistencias, retorna un DataTable vacío.
        /// </returns>
        /// <exception cref="Exception">
        /// Se lanza una excepción si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        /// <remarks>
        /// Este método ejecuta el procedimiento almacenado <c>SP_READ_LeerAsistencias</c>
        /// para recuperar todos los registros de la tabla Asistencia.
        /// </remarks>
        public DataTable CD_VerAsistencias()
        {
            try
            {
                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();

                comando.Parameters.Clear();

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_READ_LeerAsistencias";
                comando.CommandType = CommandType.StoredProcedure;

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();

                return tabla;
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar las asistencias guardadas: " + ex.Message);
            }
            
        }
        /// <summary>
        /// Actualiza los datos de una asistencia existente.
        /// </summary>
        /// <param name="asistenciaID">Identificador único de la asistencia a actualizar.</param>
        /// <param name="estudianteID">Identificador único del estudiante.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <param name="fecha">Nueva fecha de la asistencia.</param>
        /// <param name="estado">Nuevo estado de la asistencia (true para presente, false para ausente).</param>
        /// <param name="usuarioID">Identificador del usuario que realiza la actualización.</param>
        /// <returns>Retorna true si la asistencia se actualizó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public bool CD_ActualizarAsistencia(int asistenciaID, int estudianteID, int asignaturaID, DateTime fecha, bool estado, int usuarioID)
        {
            try
            {
                SqlCommand comando = new SqlCommand();

                int filasAfectadas = 0;
                comando.Parameters.Clear();

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_UPDATE_ActualizarAsistencia";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@AsistenciaID", asistenciaID);
                comando.Parameters.AddWithValue("@EstudianteID", estudianteID);
                comando.Parameters.AddWithValue("@AsignaturaID", asignaturaID);
                comando.Parameters.AddWithValue("@FechaAsistencia", fecha);
                comando.Parameters.AddWithValue("@Estado", estado);
                comando.Parameters.AddWithValue("@UsuarioID", usuarioID);

                filasAfectadas = comando.ExecuteNonQuery();
                conexion.CerrarConexion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar una asistencia: " + ex.Message);
            }
        }
    }
}
