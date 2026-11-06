using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    /// <summary>
    /// Clase que gestiona las operaciones de base de datos relacionadas con la autenticación y gestión de usuarios.
    /// </summary>
    public class CD_Usuario
    {
        /// <summary>
        /// Instancia de conexión a la base de datos.
        /// </summary>
        private CD_Conexion conexion = new CD_Conexion();
        /// <summary>
        /// Registra un nuevo usuario en el sistema.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <param name="clave">Contraseña del usuario.</param>
        /// <returns>Retorna true si el usuario se registró exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public bool RegistrarUsuario(string nombre, string correo, string clave)
        {
            try
            {
                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();

                int filasAfectadas = 0;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_CREATE_RegistrarUsuario";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreUsuario", nombre);
                comando.Parameters.AddWithValue("@CorreoUsuario", correo);
                comando.Parameters.AddWithValue("@Clave", clave);

                filasAfectadas = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar un usuario: " + ex.Message);
            }
        }
        /// <summary>
        /// Valida las credenciales de un usuario para autenticación en el sistema.
        /// </summary>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <param name="clave">Contraseña del usuario.</param>
        /// <returns>DataTable con la información del usuario si las credenciales son válidas, tabla vacía en caso contrario.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al ejecutar el procedimiento almacenado.</exception>
        public DataTable ValidarUsuario(string correo, string clave)
        {
            try
            {
                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();
                 
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SP_ValidacionClave";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@CorreoUsuario", correo);
                comando.Parameters.AddWithValue("@Clave", clave);

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                comando.Parameters.Clear();

                return tabla;
            } catch (Exception ex)
            {
                conexion.CerrarConexion();
                throw new Exception("Error al validar la conexión de usuario: " + ex.Message);
            }
        }
    }
}
