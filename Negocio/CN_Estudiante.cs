using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    /// <summary>
    /// Clase de lógica de negocio que gestiona las operaciones relacionadas con estudiantes.
    /// Incluye validaciones de campos obligatorios, longitud de datos y otras reglas de negocio.
    /// </summary>
    public class CN_Estudiante
    {
        /// <summary>
        /// Crea un nuevo estudiante con validaciones exhaustivas de negocio.
        /// Valida campos obligatorios, longitud máxima de caracteres y sesión de usuario.
        /// </summary>
        /// <param name="nombre">Nombre del estudiante (máximo 50 caracteres).</param>
        /// <param name="apellido">Apellido del estudiante (máximo 50 caracteres).</param>
        /// <param name="rut">RUT del estudiante (máximo 20 caracteres).</param>
        /// <param name="cursoID">Identificador del curso al que pertenece el estudiante.</param>
        /// <param name="usuarioID">Identificador del usuario que registra al estudiante.</param>
        /// <returns>Retorna true si el estudiante se creó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_CrearEstudiante(string nombre, string apellido, string rut, int cursoID, int usuarioID)
        {
            CD_Estudiante estudiante = new CD_Estudiante();
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (string.IsNullOrWhiteSpace(apellido))
                {
                    throw new Exception("El apeliido es obligatorio");
                }
                if (string.IsNullOrWhiteSpace(rut))
                {
                    throw new Exception("El rut es obligatorio");
                }
                if (cursoID <= 0)
                {
                    throw new Exception("Seleccione unu curso válido");
                }
                if (nombre.Length > 50)
                {
                    throw new Exception("El nombre no puede superar los 50 caracteres");
                }
                if (apellido.Length > 50)
                {
                    throw new Exception("El apellido no puede superar los 50 caracteres");
                }
                if (rut.Length > 20)
                {
                    throw new Exception("El rut no puede superar los 20 caracteres");
                }
                if (usuarioID <= 0)
                {
                    throw new Exception("Vuelva al inicio de sesión para registrar un estudiante");
                }
                return estudiante.CD_CrearEstudiante(nombre, apellido, rut, cursoID, usuarioID);
            } catch (Exception ex)
            {
                throw new Exception("Error al crear un estudiante: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todos los estudiantes registrados en el sistema.
        /// </summary>
        /// <returns>DataTable con la información de todos los estudiantes.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al obtener los datos.</exception>
        public DataTable CN_VerEstudiantes()
        {
            CD_Estudiante estudiante = new CD_Estudiante();
            try
            {
                DataTable tabla = new DataTable();
                tabla = estudiante.CD_VerEstudiantes();
                return tabla;
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar los estudiantes: " + ex.Message);
            }
        }
        /// <summary>
        /// Actualiza los datos de un estudiante existente con validaciones exhaustivas de negocio.
        /// Valida campos obligatorios, longitud máxima de caracteres y sesión de usuario.
        /// </summary>
        /// <param name="estudianteID">Identificador único del estudiante a actualizar.</param>
        /// <param name="nombre">Nuevo nombre del estudiante (máximo 50 caracteres).</param>
        /// <param name="apellido">Nuevo apellido del estudiante (máximo 50 caracteres).</param>
        /// <param name="rut">Nuevo RUT del estudiante (máximo 20 caracteres).</param>
        /// <param name="cursoID">Nuevo identificador del curso al que pertenece el estudiante.</param>
        /// <param name="usuarioID">Identificador del usuario que realiza la actualización.</param>
        /// <returns>Retorna true si el estudiante se actualizó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_ActualizarEstudiante(int estudianteID, string nombre, string apellido, string rut, int cursoID, int usuarioID)
        {
            CD_Estudiante estudiante = new CD_Estudiante();
            try
            {
                if (estudianteID <= 0)
                {
                    throw new Exception("Ingrese un estudiante válido a actualizar.");
                }
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (string.IsNullOrWhiteSpace(apellido))
                {
                    throw new Exception("El apeliido es obligatorio");
                }
                if (string.IsNullOrWhiteSpace(rut))
                {
                    throw new Exception("El rut es obligatorio");
                }
                if (cursoID <= 0)
                {
                    throw new Exception("Seleccione unu curso válido");
                }
                if (nombre.Length > 50)
                {
                    throw new Exception("El nombre no puede superar los 50 caracteres");
                }
                if (apellido.Length > 50)
                {
                    throw new Exception("El apellido no puede superar los 50 caracteres");
                }
                if (rut.Length > 20)
                {
                    throw new Exception("El rut no puede superar los 20 caracteres");
                }
                if (usuarioID <= 0)
                {
                    throw new Exception("Vuelva al inicio de sesión para registrar un estudiante");
                }
                return estudiante.CD_ActualizarEstudiante(estudianteID, nombre, apellido, rut, cursoID, usuarioID);
            } catch (Exception ex)
            {
                throw new Exception("Error al actualizar un estudiante: " + ex.Message);
            }
        }
    }
}
