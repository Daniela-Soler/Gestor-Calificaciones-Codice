using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    /// <summary>
    /// Clase que gestiona las operaciones de base de datos relacionadas con las calificaciones de estudiantes.
    /// Implementa métodos para crear, leer y actualizar calificaciones en la base de datos.
    /// </summary>
    public class CD_Calificaciones
    {
        /// <summary>
        /// Instancia de conexión a la base de datos.
        /// </summary>
        private CD_Conexion conexion = new CD_Conexion();
        /// <summary>
        /// Registra una nueva calificación para un estudiante en una asignatura específica.
        /// </summary>
        /// <param name="estudianteID">Identificador único del estudiante.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <param name="nota">Valor de la nota obtenida.</param>
        /// <param name="fecha">Fecha en la que se registra la calificación.</param>
        /// <param name="usuarioID">Identificador del usuario que registra la calificación.</param>
        /// <returns>Retorna true si la calificación se registró exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public bool CD_CrearCalificacion(int estudianteID, int asignaturaID, decimal nota, DateTime fecha, int usuarioID)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                int filasAfectadas = 0;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_CREATE_IngresarCalificacion";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("EstudianteID", estudianteID);
                comando.Parameters.AddWithValue("AsignaturaID", asignaturaID);
                comando.Parameters.AddWithValue("Nota", nota);
                comando.Parameters.AddWithValue("FechaRegistro", fecha);
                comando.Parameters.AddWithValue("UsuarioID", usuarioID);

                filasAfectadas = comando.ExecuteNonQuery();

                conexion.CerrarConexion();

                return filasAfectadas > 0;
            } catch (Exception ex)
            {
                throw new Exception("Error al ingresar una calificación: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todas las calificaciones registradas en el sistema.
        /// </summary>
        /// <returns>
        /// Retorna un <see cref="DataTable"/> que contiene todas las calificaciones
        /// con sus respectivos datos (CalificacionID, NombreEstudiante, NombreAsignatura, 
        /// Nota, FechaRegistro).
        /// Si no hay calificaciones, retorna un DataTable vacío.
        /// </returns>
        /// <exception cref="Exception">
        /// Se lanza una excepción si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        /// <remarks>
        /// Este método ejecuta el procedimiento almacenado <c>SP_READ_LeerCalificaciones</c>
        /// para recuperar todos los registros de la tabla Calificaciones.
        /// </remarks>
        public DataTable CD_VerCalificaciones()
        {
            try
            {
                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_READ_LeerCalificaciones";
                comando.CommandType = CommandType.StoredProcedure;

                leer = comando.ExecuteReader();
                tabla.Load(leer);

                conexion.CerrarConexion();

                return tabla;
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar las calificaciones guardadas: " + ex.Message);
            }
        }
        /// <summary>
        /// Actualiza los datos de una calificación existente.
        /// </summary>
        /// <param name="calificacionID">Identificador único de la calificación a actualizar.</param>
        /// <param name="estudianteID">Identificador único del estudiante.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <param name="nota">Nuevo valor de la nota.</param>
        /// <param name="fecha">Nueva fecha de registro de la calificación.</param>
        /// <param name="usuarioID">Identificador del usuario que realiza la actualización.</param>
        /// <returns>Retorna true si la calificación se actualizó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public bool CD_ActualizarCalificacion(int calificacionID, int estudianteID, int asignaturaID, decimal nota, DateTime fecha, int usuarioID)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                int filasAfectadas = 0;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_UPDATE_ActualizarCalificacion";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("CalificacionID", calificacionID);
                comando.Parameters.AddWithValue("EstudianteID", estudianteID);
                comando.Parameters.AddWithValue("AsignaturaID", asignaturaID);
                comando.Parameters.AddWithValue("Nota", nota);
                comando.Parameters.AddWithValue("FechaRegistro", fecha);
                comando.Parameters.AddWithValue("UsuarioID", usuarioID);

                filasAfectadas = comando.ExecuteNonQuery();

                conexion.CerrarConexion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar una calificación: " + ex.Message);
            }
        }

    }
}
