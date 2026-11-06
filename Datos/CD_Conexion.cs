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
    /// Clase que gestiona la conexión a la base de datos SQL Server.
    /// Proporciona métodos para abrir, cerrar y probar la conexión.
    /// </summary>
    public class CD_Conexion
    {
        /// <summary>
        /// Objeto SqlConnection con la cadena de conexión a la base de datos InstitutoCODICE.
        /// </summary>
        private SqlConnection Conexion = new SqlConnection("Data Source=MIWATSUKI\\SQLEXPRESS;Initial Catalog=InstitutoCODICE;Integrated Security=True");
        /// <summary>
        /// Verifica si es posible establecer conexión con la base de datos.
        /// </summary>
        /// <returns>Retorna true si la conexión se establece exitosamente, false si ocurre un error.</returns>
        public bool ProbarConexion()
        {
            try
            {
                Conexion.Open();
                return true;
            } catch (SqlException)
            {
                return false;
            }
        }
        /// <summary>
        /// Abre la conexión a la base de datos si está cerrada.
        /// </summary>
        /// <returns>Retorna el objeto SqlConnection abierto.</returns>
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }
        /// <summary>
        /// Cierra la conexión a la base de datos si está abierta.
        /// </summary>
        /// <returns>Retorna el objeto SqlConnection cerrado.</returns>
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
