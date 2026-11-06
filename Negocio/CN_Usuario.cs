using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    /// <summary>
    /// Clase de lógica de negocio que gestiona la autenticación y registro de usuarios en el sistema.
    /// Incluye validaciones de campos obligatorios antes de interactuar con la capa de datos.
    /// </summary>
    public class CN_Usuario
    {
        /// <summary>
        /// Verifica las credenciales de un usuario para permitir el inicio de sesión.
        /// Valida que los campos de correo y contraseña no estén vacíos.
        /// </summary>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <param name="clave">Contraseña del usuario.</param>
        /// <returns>
        /// DataTable con la información del usuario si las credenciales son válidas, tabla vacía en caso 
        /// contrario.
        /// </returns>
        /// <exception cref="Exception">
        /// Se lanza cuando los campos obligatorios están vacíos o hay errores al validar las credenciales.
        /// </exception>
        public DataTable VerificarInicioSesion(string correo, string clave)
        {
            CD_Usuario usuario = new CD_Usuario();
            try
            {
                if (string.IsNullOrWhiteSpace(correo))
                {
                    throw new Exception("El campo correo es obligatorio");
                }
                if (string.IsNullOrWhiteSpace(clave))
                {
                    throw new Exception("El campo clave es obligatorio");
                }
                DataTable tabla = new DataTable();
                tabla = usuario.ValidarUsuario(correo, clave);
                return tabla;
            } catch (Exception ex)
            {
                throw new Exception("Error al verificar inicio de sesión: " + ex.Message);
            }
        }
        /// <summary>
        /// Registra un nuevo usuario en el sistema con validaciones de campos obligatorios.
        /// Valida que nombre, correo y contraseña no estén vacíos antes de proceder con el registro.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <param name="clave">Contraseña del usuario.</param>
        /// <returns>Retorna true si el usuario se registró exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando los campos obligatorios están vacíos o hay errores al registrar el usuario.
        /// </exception>
        public bool IngresarUsuario(string nombre, string correo, string clave)
        {
            CD_Usuario usuario = new CD_Usuario();
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new Exception("El campo nombre es obligatorio");
                }
                if (string.IsNullOrWhiteSpace(correo))
                {
                    throw new Exception("El campo correo es obligatorio");
                }
                if (string.IsNullOrWhiteSpace(clave))
                {
                    throw new Exception("El campo clave es obligatorio");
                }

                bool verificacion = usuario.RegistrarUsuario(nombre, correo, clave);

                return verificacion;
            } catch (Exception ex)
            {
                throw new Exception("Error al registrar un usuario: " + ex.Message);
            }
        }
    }
}
