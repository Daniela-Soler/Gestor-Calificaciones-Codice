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
    /// Clase de lógica de negocio que gestiona las operaciones relacionadas con cursos.
    /// Incluye validaciones de longitud de campos y otras reglas de negocio antes de interactuar con la capa de datos.
    /// </summary>
    public class CN_Cursos
    {
        /// <summary>
        /// Crea un nuevo curso con validaciones de negocio.
        /// Valida que el nombre no esté vacío y no exceda los 50 caracteres.
        /// </summary>
        /// <param name="nombre">Nombre del curso.</param>
        /// <param name="usuarioid">Identificador del usuario que crea el curso.</param>
        /// <returns>Retorna true si el curso se creó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_CrearCurso(string nombre, int usuarioid)
        {
            CD_Cursos curso = new CD_Cursos();
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (nombre.Length > 50)
                {
                    throw new Exception("El nombre no puede superar los 50 caracteres");
                }
                return curso.CD_CrearCurso(nombre, usuarioid);
            } catch (Exception ex)
            {
                throw new Exception("Error al crear un curso: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todos los cursos registrados en el sistema.
        /// </summary>
        /// <returns>DataTable con la información de todos los cursos.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al obtener los datos.</exception>
        public DataTable CN_VerCursos()
        {
            CD_Cursos curso = new CD_Cursos();
            try
            {
                DataTable tabla = new DataTable();
                tabla = curso.CD_VerCursos();
                return tabla;
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar los cursos");
            }
        }
        /// <summary>
        /// Actualiza los datos de un curso existente con validaciones de negocio.
        /// Valida que el nombre sea válido y que el usuario tenga sesión activa.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso a actualizar.</param>
        /// <param name="nombre">Nuevo nombre del curso.</param>
        /// <param name="usuarioID">Identificador del usuario que realiza la actualización.</param>
        /// <returns>Retorna true si el curso se actualizó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_ActualizarCurso(int cursoID, string nombre, int usuarioID)
        {
            CD_Cursos curso = new CD_Cursos();
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (cursoID <= 0)
                {
                    throw new Exception("Ingrese un curso válido a actualizar.");
                }
                if (usuarioID <= 0)
                {
                    throw new Exception("Se cerró sesión del usuario, por favor inicie sesión nuevamente.");
                }
                return curso.CD_ActualizarCurso(cursoID, nombre, usuarioID);
            } catch (Exception ex)
            {
                throw new Exception("Error al actualizar el curso: " +  ex);
            }
        }
    }
}
