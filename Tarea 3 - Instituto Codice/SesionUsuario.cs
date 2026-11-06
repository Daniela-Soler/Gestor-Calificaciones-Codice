using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3___Instituto_Codice
{
    /// <summary>
    /// Clase estática que gestiona la sesión del usuario autenticado en la aplicación.
    /// Almacena la información del usuario activo y proporciona métodos para gestionar el estado de sesión.
    /// </summary>
    public static class SesionUsuario
    {
        /// <summary>
        /// Obtiene o establece el identificador único del usuario con sesión activa.
        /// </summary>
        /// <value>ID del usuario, 0 si no hay sesión activa.</value>
        public static int UsuarioID { get; set; }
        /// <summary>
        /// Obtiene o establece el nombre del usuario con sesión activa.
        /// </summary>
        /// <value>Nombre del usuario autenticado.</value>
        public static string NombreUsuario { get; set; }

        /// <summary>
        /// Verifica si existe una sesión activa en el sistema.
        /// </summary>
        /// <returns>
        /// Retorna true si hay un usuario con sesión activa (UsuarioID mayor a 0), false en caso contrario.
        /// </returns>
        public static bool SesionActiva()
        {
            return UsuarioID > 0;
        }
        /// <summary>
        /// Cierra la sesión actual del usuario, limpiando todos los datos de sesión.
        /// Restablece el UsuarioID a 0 y el NombreUsuario a cadena vacía.
        /// </summary>
        public static void CerrarSesion()
        {
            UsuarioID = 0;
            NombreUsuario = string.Empty;
        }
    }
}
