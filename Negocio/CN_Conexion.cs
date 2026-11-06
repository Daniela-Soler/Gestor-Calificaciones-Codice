using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    /// <summary>
    /// Clase de lógica de negocio que verifica la conectividad con la base de datos.
    /// Actúa como intermediario entre la capa de presentación y la capa de datos para validar conexiones.
    /// </summary>
    public class CN_Conexion
    {
        /// <summary>
        /// Instancia de la clase de conexión de la capa de datos.
        /// </summary>
        private readonly CD_Conexion cdc = new CD_Conexion();
        /// <summary>
        /// Verifica si es posible establecer conexión con la base de datos.
        /// </summary>
        /// <returns>Retorna true si la conexión se establece exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando ocurre un error al intentar conectar con la base de datos.
        /// </exception>
        public bool CN_VerificarConexion()
        {
            try
            {
                return cdc.ProbarConexion();
            } catch (Exception ex)
            {
                throw new Exception("Error al probar la conexión con la base de datos: " + ex.Message);
            }
        }
    }
}
