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
    /// Clase de lógica de negocio que gestiona las operaciones relacionadas con asignaturas.
    /// Incluye validaciones antes de interactuar con la capa de datos.
    /// </summary>
    public class CN_Asignatura
    {
        /// <summary>
        /// Crea una nueva asignatura con validaciones de negocio.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso al que pertenece la asignatura.</param>
        /// <param name="nombre">Nombre de la asignatura.</param>
        /// <param name="usuarioID">Identificador del usuario que crea la asignatura.</param>
        /// <returns>Retorna true si la asignatura se creó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_CrearAsignatura(int cursoID, string nombre, int usuarioID)
        {
            CD_Asignatura asignatura = new CD_Asignatura();
            try
            {
                
                if (cursoID <= 0)
                {
                    throw new Exception("Seleccione un curso válido.");
                }
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new Exception("El campo nombre es obligatorio.");
                }
                if (usuarioID <= 0)
                {
                    throw new Exception("Se cerró sesión de manera imprevista, por favor vuelva al login.");
                }
                return asignatura.CD_CrearAsignatura(cursoID, nombre, usuarioID);
            } catch (Exception ex)
            {
                throw new Exception("Error al crear una asignatura: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todas las asignaturas registradas en el sistema.
        /// </summary>
        /// <returns>DataTable con la información de todas las asignaturas.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al obtener los datos.</exception>
        public DataTable CN_VerAsignaturas()
        {
            CD_Asignatura asignatura = new CD_Asignatura();
            try
            {
                DataTable tabla = new DataTable();
                tabla = asignatura.CD_VerAsignaturas();
                return tabla;
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar las asignaturas: " + ex.Message);
            }
        }
        /// <summary>
        /// Actualiza los datos de una asignatura existente con validaciones de negocio.
        /// </summary>
        /// <param name="asignaturaID">Identificador único de la asignatura a actualizar.</param>
        /// <param name="cursoID">Nuevo identificador del curso al que pertenece la asignatura.</param>
        /// <param name="nombre">Nuevo nombre de la asignatura.</param>
        /// <param name="usuarioID">Identificador del usuario que realiza la actualización.</param>
        /// <returns>Retorna true si la asignatura se actualizó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_ActualizarAsignatura(int asignaturaID, int cursoID, string nombre, int usuarioID)
        {
            CD_Asignatura asignatura = new CD_Asignatura();
            try
            {
                if (asignaturaID <= 0)
                {
                    throw new Exception("Seleccione una asignatura válida.");
                }
                if (cursoID <= 0)
                {
                    throw new Exception("Seleccione un curso válido.");
                }
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new Exception("El campo nombre es obligatorio.");
                }
                if (usuarioID <= 0)
                {
                    throw new Exception("Se cerró sesión de manera imprevista, por favor vuelva al login.");
                }
                return asignatura.CD_ActualizarAsignatura(asignaturaID, cursoID, nombre, usuarioID);
            } catch (Exception ex)
            {
                throw new Exception("Error al actualizar una asignatura: " + ex.Message);
            }
        }
    }
}
