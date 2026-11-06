using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    /// <summary>
    /// Clase de lógica de negocio que gestiona las operaciones relacionadas con calificaciones de estudiantes.
    /// Incluye validaciones de rango de notas y otras reglas de negocio antes de interactuar con la capa de datos.
    /// </summary>
    public class CN_Calificacion
    {
        /// <summary>
        /// Registra una nueva calificación para un estudiante con validaciones de negocio.
        /// Valida que la nota esté en el rango permitido (0 a 7).
        /// </summary>
        /// <param name="estudianteID">Identificador único del estudiante.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <param name="nota">Valor de la nota obtenida (debe estar entre 0 y 7).</param>
        /// <param name="fecha">Fecha en la que se registra la calificación.</param>
        /// <param name="usuarioID">Identificador del usuario que registra la calificación.</param>
        /// <returns>Retorna true si la calificación se registró exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_IngresarCalificacion(int estudianteID, int asignaturaID, decimal nota, DateTime fecha, int usuarioID)
        {
            CD_Calificaciones calificaciones = new CD_Calificaciones();
            try
            {
                if (estudianteID <= 0)
                {
                    throw new Exception("Seleccione un estudiante válido.");
                }
                if (asignaturaID <= 0)
                {
                    throw new Exception("Seleccione una asignatura válida.");
                }
                if (nota < 0 & nota > 7)
                {
                    throw new Exception("Ingrese una nota válida (0 a 7).");
                }
                if (usuarioID <= 0)
                {
                    throw new Exception("Se cerró sesión, por favor vaya al login.");
                }
                return calificaciones.CD_CrearCalificacion(estudianteID, asignaturaID, nota, fecha, usuarioID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar una calificación: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todas las calificaciones registradas en el sistema.
        /// </summary>
        /// <returns>DataTable con la información de todas las calificaciones.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al obtener los datos.</exception>
        public DataTable CN_VerCalificaciones()
        {
            CD_Calificaciones calificaciones = new CD_Calificaciones();
            try
            {
                DataTable tabla = new DataTable();
                tabla = calificaciones.CD_VerCalificaciones();
                return tabla;
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar las calificaciones: " + ex.Message);
            }
        }
        /// <summary>
        /// Actualiza los datos de una calificación existente con validaciones de negocio.
        /// Valida que la nota esté en el rango permitido (0 a 7).
        /// </summary>
        /// <param name="calificacionID">Identificador único de la calificación a actualizar.</param>
        /// <param name="estudianteID">Identificador único del estudiante.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <param name="nota">Nuevo valor de la nota (debe estar entre 0 y 7).</param>
        /// <param name="fecha">Nueva fecha de registro de la calificación.</param>
        /// <param name="usuarioID">Identificador del usuario que realiza la actualización.</param>
        /// <returns>Retorna true si la calificación se actualizó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_ActualizarCalificacion(int calificacionID, int estudianteID, int asignaturaID, decimal nota, DateTime fecha, int usuarioID)
        {
            CD_Calificaciones calificaciones = new CD_Calificaciones();
            try
            {
                if (calificacionID <= 0)
                {
                    throw new Exception("Seleccione un registro para modificar una calificación.");
                }
                if (estudianteID <= 0)
                {
                    throw new Exception("Seleccione un estudiante válido.");
                }
                if (asignaturaID <= 0)
                {
                    throw new Exception("Seleccione una asignatura válida.");
                }
                if (nota < 0 & nota <= 7)
                {
                    throw new Exception("Ingrese una nota válida (0 a 7).");
                }
                if (usuarioID <= 0)
                {
                    throw new Exception("Se cerró sesión, por favor vaya al login.");
                }
                return calificaciones.CD_ActualizarCalificacion(calificacionID, estudianteID, asignaturaID, nota, fecha, usuarioID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar una calificación: " + ex.Message);
            }
        } 
    }
}
