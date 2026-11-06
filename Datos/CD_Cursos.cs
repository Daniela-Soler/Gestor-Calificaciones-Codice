using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datos
{
    /// <summary>
    /// Clase que gestiona las operaciones de base de datos relacionadas con los cursos del instituto.
    /// Implementa métodos para crear, leer y actualizar cursos en la base de datos.
    /// </summary>
    public class CD_Cursos
    {
        /// <summary>
        /// Instancia de conexión a la base de datos.
        /// </summary>
        private CD_Conexion _conexion = new CD_Conexion();
        /// <summary>
        /// Crea un nuevo curso en el sistema.
        /// </summary>
        /// <param name="nombre">Nombre del curso a crear.</param>
        /// <param name="usuarioid">Identificador del usuario que crea el curso.</param>
        /// <returns>Retorna true si el curso se creó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public bool CD_CrearCurso(string nombre, int usuarioid)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                int filasAfectadas = 0;
                comando.Connection = _conexion.AbrirConexion();
                comando.CommandText = "SP_CREATE_CrearCurso";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreCurso", nombre);
                comando.Parameters.AddWithValue("@UsuarioID", usuarioid);

                filasAfectadas = comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                _conexion.CerrarConexion();

                return filasAfectadas > 0;

            } catch (Exception ex)
            {
                throw new Exception("Error al ingresar un curso: " + ex.Message);
            }
            
        }
        /// <summary>
        /// Obtiene todos los cursos registrados en el sistema.
        /// </summary>
        /// <returns>
        /// Retorna un <see cref="DataTable"/> que contiene todos los cursos
        /// con sus respectivos datos (CursoID, NombreCurso).
        /// Si no hay cursos, retorna un DataTable vacío.
        /// </returns>
        /// <exception cref="Exception">
        /// Se lanza una excepción si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        /// <remarks>
        /// Este método ejecuta el procedimiento almacenado <c>SP_READ_LeerCursos</c>
        /// para recuperar todos los registros de la tabla Curso.
        /// </remarks>
        public DataTable CD_VerCursos()
        {
            try
            {
                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                comando.Connection = _conexion.AbrirConexion();
                comando.CommandText = "SP_READ_LeerCursos";
                comando.CommandType = CommandType.StoredProcedure;

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                _conexion.CerrarConexion();

                return tabla;
            } catch(Exception ex)
            {
                throw new Exception("Error al visualizar los cursos guardados:" + ex.Message);
            }
        }
        /// <summary>
        /// Actualiza los datos de un curso existente.
        /// </summary>
        /// <param name="cursoid">Identificador único del curso a actualizar.</param>
        /// <param name="nombre">Nuevo nombre del curso.</param>
        /// <param name="usuarioid">Identificador del usuario que realiza la actualización.</param>
        /// <returns>Retorna true si el curso se actualizó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public bool CD_ActualizarCurso(int cursoid, string nombre, int usuarioid)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                int filasAfectadas = 0;
                comando.Connection = _conexion.AbrirConexion();
                comando.CommandText = "SP_UPDATE_ActualizarCurso";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CursoID", cursoid);
                comando.Parameters.AddWithValue("@NombreCurso", nombre);
                comando.Parameters.AddWithValue("@UsuarioID", usuarioid);

                filasAfectadas = comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                _conexion.CerrarConexion();

                return filasAfectadas > 0;
            } catch (Exception ex)
            {
                throw new Exception("Error al actualizar el curso: " + ex.Message);
            }
            
        }
    }
}
