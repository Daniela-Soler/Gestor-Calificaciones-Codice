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
    /// Clase encargada de realizar operaciones de base de datos relacionadas con asignaturas.
    /// Implementa métodos para crear, leer y actualizar asignaturas en la base de datos.
    /// </summary>
    public class CD_Asignatura
    {
        /// <summary>
        /// Instancia de conexión a la base de datos.
        /// </summary>
        private CD_Conexion conexion = new CD_Conexion();
        /// <summary>
        /// Crea una nueva asignatura en la base de datos.
        /// </summary>
        /// <param name="cursoID">ID del curso al que pertenece la asignatura. Debe ser mayor a 0.</param>
        /// <param name="nombre">Nombre de la asignatura a crear. No debe estar vacío.</param>
        /// <param name="usuarioID">ID del usuario que realiza la operación. Debe ser mayor a 0.</param>
        /// <returns>
        /// Retorna <c>true</c> si la asignatura se creó exitosamente; 
        /// <c>false</c> en caso contrario.
        /// </returns>
        /// <exception cref="Exception">
        /// Se lanza una excepción si ocurre un error durante la operación en la base de datos.
        /// </exception>
        /// <remarks>
        /// Este método ejecuta el procedimiento almacenado <c>SP_CREATE_CrearAsignatura</c>
        /// para insertar un nuevo registro de asignatura en la tabla Asignatura.
        /// </remarks>
        public bool CD_CrearAsignatura(int cursoID, string nombre, int usuarioID)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();
                
                int filasAfectadas = 0;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_CREATE_CrearAsignatura";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("CursoID", cursoID);
                comando.Parameters.AddWithValue("NombreAsignatura", nombre);
                comando.Parameters.AddWithValue("UsuarioID", usuarioID);

                filasAfectadas = comando.ExecuteNonQuery();

                conexion.CerrarConexion();

                return filasAfectadas > 0;
            } catch (Exception ex)
            {
                throw new Exception("Error al crear una asignatura: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todas las asignaturas registradas en la base de datos.
        /// </summary>
        /// <returns>
        /// Retorna un <see cref="DataTable"/> que contiene todas las asignaturas 
        /// con sus respectivos datos (AsignaturaID, NombreAsignatura y NombreCurso).
        /// Si no hay asignaturas, retorna un DataTable vacío.
        /// </returns>
        /// <exception cref="Exception">
        /// Se lanza una excepción si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        /// <remarks>
        /// Este método ejecuta el procedimiento almacenado <c>SP_READ_LeerAsignaturas</c>
        /// para recuperar todos los registros de la tabla Asignatura.
        /// </remarks>
        public DataTable CD_VerAsignaturas()
        {
            try
            {
                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();

                comando.Parameters.Clear();

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_READ_LeerAsignaturas";
                comando.CommandType = CommandType.StoredProcedure;

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();

                return tabla;
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar las asignaturas guardadas: " + ex.Message);
            }
            
        }
        /// <summary>
        /// Actualiza los datos de una asignatura existente en la base de datos.
        /// </summary>
        /// <param name="asignaturaID">ID de la asignatura a actualizar. Debe ser mayor a 0.</param>
        /// <param name="cursoID">Nuevo ID del curso al que pertenecerá la asignatura. Debe ser mayor a 0.</param>
        /// <param name="nombre">Nuevo nombre de la asignatura. No debe estar vacío.</param>
        /// <param name="usuarioID">ID del usuario que realiza la operación. Debe ser mayor a 0.</param>
        /// <returns>
        /// Retorna <c>true</c> si la asignatura se actualizó exitosamente; 
        /// <c>false</c> en caso contrario.
        /// </returns>
        /// <exception cref="Exception">
        /// Se lanza una excepción si ocurre un error durante la operación en la base de datos.
        /// </exception>
        /// <remarks>
        /// Este método ejecuta el procedimiento almacenado <c>SP_UPDATE_ActualizarAsignatura</c>
        /// para modificar los datos de una asignatura existente en la tabla Asignatura.
        /// </remarks>
        public bool CD_ActualizarAsignatura(int asignaturaID, int cursoID, string nombre, int usuarioID)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();
                
                int filasAfectadas = 0;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_UPDATE_ActualizarAsignatura";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("AsignaturaID", asignaturaID);
                comando.Parameters.AddWithValue("CursoID", cursoID);
                comando.Parameters.AddWithValue("NombreAsignatura", nombre);
                comando.Parameters.AddWithValue("UsuarioID", usuarioID);

                filasAfectadas = comando.ExecuteNonQuery();

                conexion.CerrarConexion();

                return filasAfectadas > 0;
            } catch (Exception ex)
            {
                throw new Exception("Error al actualizar una asignatura: " + ex.Message);
            }
        }
    }
}
