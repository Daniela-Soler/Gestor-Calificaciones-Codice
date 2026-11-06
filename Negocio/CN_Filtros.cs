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
    /// Clase de lógica de negocio que proporciona métodos de filtrado para consultas específicas.
    /// Permite obtener datos filtrados por curso, asignatura o combinaciones de ambos.
    /// </summary>
    public class CN_Filtros
    {
        /// <summary>
        /// Obtiene todos los estudiantes pertenecientes a un curso específico con validación.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso.</param>
        /// <returns>DataTable con la información de los estudiantes del curso especificado.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando el curso no es válido o hay errores al obtener los datos.
        /// </exception>
        public DataTable CN_EstudiantesPorCurso(int cursoID)
        {
            CD_Filtros filtros = new CD_Filtros();
            try
            {
                if (cursoID <= 0)
                {
                    throw new Exception("Ingrese un curso válido.");
                }
                return filtros.CD_EstudiantesPorCurso(cursoID);
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar los estudiantes por curso: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todas las asignaturas asociadas a un curso específico con validación.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso.</param>
        /// <returns>DataTable con la información de las asignaturas del curso especificado.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando el curso no es válido o hay errores al obtener los datos.
        /// </exception>
        public DataTable CN_AsignaturasPorCurso(int cursoID)
        {
            CD_Filtros filtros = new CD_Filtros();
            try
            {
                if (cursoID <= 0)
                {
                    throw new Exception("Ingrese un curso válido.");
                }
                return filtros.CD_AsignaturasPorCurso(cursoID);
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar las asignaturas por curso: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene los estudiantes inscritos en una asignatura específica dentro de un curso determinado.
        /// Valida que tanto el curso como la asignatura sean válidos.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <returns>DataTable con la información de los estudiantes que cursan la asignatura especificada.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando los identificadores no son válidos o hay errores al obtener los datos.
        /// </exception>
        public DataTable CN_EstudiantesPorAsignaturaYCurso(int cursoID, int asignaturaID)
        {
            CD_Filtros filtros = new CD_Filtros();
            try
            {
                if (cursoID <= 0)
                {
                    throw new Exception("Ingrese un curso válido.");
                }
                if (asignaturaID <= 0)
                {
                    throw new Exception("Ingrese una asignatura válida.");
                }
                return filtros.CD_EstudiantesPorAsignaturaYCurso(cursoID, asignaturaID);
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar los estudiantes por curso y asignatura: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene los registros de asistencia de los estudiantes para una asignatura y curso específicos.
        /// Valida que tanto el curso como la asignatura sean válidos.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <returns>DataTable con la información de asistencias de los estudiantes en la asignatura y curso especificados.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando los identificadores no son válidos o hay errores al obtener los datos.
        /// </exception>
        public DataTable CN_AsistenciasPorCursoYAsignatura(int cursoID, int asignaturaID)
        {
            CD_Filtros filtros = new CD_Filtros();
            try
            {
                if (cursoID <= 0)
                {
                    throw new Exception("Ingrese un curso válido.");
                }
                if (asignaturaID <= 0)
                {
                    throw new Exception("Ingrese una asignatura válida.");
                }
                return filtros.CD_AsistenciasPorCursoYAsignatura(cursoID, asignaturaID);
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar las asistencias por asignatura y curso: " + ex.Message);
            }
        }
    }
}
