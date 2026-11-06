using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Datos
{
    /// <summary>
    /// Clase que gestiona las operaciones de base de datos relacionadas con los estudiantes.
    /// Implementa métodos para crear, leer y actualizar estudiantes en la base de datos.
    /// </summary>
    public class CD_Estudiante
    {
        /// <summary>
        /// Instancia de conexión a la base de datos.
        /// </summary>
        private CD_Conexion conexion = new CD_Conexion();
        /// <summary>
        /// Registra un nuevo estudiante en el sistema.
        /// </summary>
        /// <param name="nombre">Nombre del estudiante.</param>
        /// <param name="apellido">Apellido del estudiante.</param>
        /// <param name="rut">RUT del estudiante.</param>
        /// <param name="cursoID">Identificador del curso al que pertenece el estudiante.</param>
        /// <param name="usuarioID">Identificador del usuario que registra al estudiante.</param>
        /// <returns>Retorna true si el estudiante se registró exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public bool CD_CrearEstudiante(string nombre, string apellido, string rut, int cursoID, int usuarioID)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                int filasAfectadas = 0;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_CREATE_CrearEstudiante";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Rut", rut);
                comando.Parameters.AddWithValue("@CursoID", cursoID);
                comando.Parameters.AddWithValue("UsuarioID", usuarioID);

                filasAfectadas = comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return filasAfectadas > 0;

            } catch (Exception ex)
            {
                conexion.CerrarConexion();
                throw new Exception("Error al crear estudiante: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todos los estudiantes registrados en el sistema.
        /// </summary>
        /// <returns>
        /// Retorna un <see cref="DataTable"/> que contiene todas las asistencias
        /// con sus respectivos datos (EstudianteID, NombreEstudiante, ApellidoEstudiante,
        /// Rut, NombreCurso, NombreCompleto).
        /// </returns>
        /// <exception cref="Exception">
        /// Se lanza una excepción si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        /// <remarks>
        /// Este método ejecuta el procedimiento almacenado <c>SP_READ_LeerEstudiantes</c>
        /// para recuperar todos los registros de la tabla Estudiante.
        /// </remarks>
        public DataTable CD_VerEstudiantes()
        {
            try
            {
                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_READ_LeerEstudiantes";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            } catch (Exception ex)
            {
                conexion.CerrarConexion();
                throw new Exception("Error al visualizar estudiantes: " + ex.Message);
            }
        }
        /// <summary>
        /// Actualiza los datos de un estudiante existente.
        /// </summary>
        /// <param name="estudianteID">Identificador único del estudiante a actualizar.</param>
        /// <param name="nombre">Nuevo nombre del estudiante.</param>
        /// <param name="apellido">Nuevo apellido del estudiante.</param>
        /// <param name="rut">Nuevo RUT del estudiante.</param>
        /// <param name="cursoID">Nuevo identificador del curso al que pertenece el estudiante.</param>
        /// <param name="usuarioID">Identificador del usuario que realiza la actualización.</param>
        /// <returns>Retorna true si el estudiante se actualizó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public bool CD_ActualizarEstudiante(int estudianteID, string nombre, string apellido, string rut, int cursoID, int usuarioID)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                int filasAfectadas = 0;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_UPDATE_ActualizarEstudiante";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@EstudianteID", estudianteID);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Rut", rut);
                comando.Parameters.AddWithValue("@CursoID", cursoID);
                comando.Parameters.AddWithValue("@UsuarioID", usuarioID);

                filasAfectadas = comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return filasAfectadas > 0; 
            } catch (Exception ex)
            {
                conexion.CerrarConexion();
                throw new Exception("Error al actualizar estuiante: " + ex.Message);
            }
            
        }
    }
}
