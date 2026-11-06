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
    /// Clase de lógica de negocio que gestiona las operaciones relacionadas con asistencias de estudiantes.
    /// Incluye validaciones antes de interactuar con la capa de datos.
    /// </summary>
    public class CN_Asistencia
    {
        /// <summary>
        /// Registra una nueva asistencia de un estudiante con validaciones de negocio.
        /// </summary>
        /// <param name="estudianteID">Identificador único del estudiante.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <param name="fecha">Fecha en la que se registra la asistencia.</param>
        /// <param name="estado">Estado de la asistencia (true para presente, false para ausente).</param>
        /// <param name="usuarioID">Identificador del usuario que registra la asistencia.</param>
        /// <returns>Retorna true si la asistencia se registró exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_IngresarAsistencia(int estudianteID, int asignaturaID, DateTime fecha, bool estado, int usuarioID)
        {
            CD_Asistencia asistencia = new CD_Asistencia();
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
                if (usuarioID <= 0)
                {
                    throw new Exception("Desconexión de la aplicación, vuelva al login");
                }
                return asistencia.CD_IngresarAsistencia(estudianteID, asignaturaID, fecha, estado, usuarioID);
            } catch (Exception ex)
            {
                throw new Exception("Error al ingresar una asistencia: " + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene todas las asistencias registradas en el sistema.
        /// </summary>
        /// <returns>DataTable con la información de todas las asistencias.</returns>
        /// <exception cref="Exception">Se lanza cuando ocurre un error al obtener los datos.</exception>
        public DataTable CN_VerAsistencias()
        {
            CD_Asistencia asistencia = new CD_Asistencia();
            try
            {
                DataTable tabla = new DataTable();
                tabla = asistencia.CD_VerAsistencias();
                return tabla;
            } catch (Exception ex)
            {
                throw new Exception("Error al visualizar las asistencias: " + ex.Message);
            }
        }
        /// <summary>
        /// Actualiza los datos de una asistencia existente con validaciones de negocio.
        /// </summary>
        /// <param name="asistenciaID">Identificador único de la asistencia a actualizar.</param>
        /// <param name="estudianteID">Identificador único del estudiante.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <param name="fecha">Nueva fecha de la asistencia.</param>
        /// <param name="estado">Nuevo estado de la asistencia (true para presente, false para ausente).</param>
        /// <param name="usuarioID">Identificador del usuario que realiza la actualización.</param>
        /// <returns>Retorna true si la asistencia se actualizó exitosamente, false en caso contrario.</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando las validaciones de negocio fallan o hay errores en la capa de datos.
        /// </exception>
        public bool CN_ActualizarAsistencia(int asistenciaID, int estudianteID, int asignaturaID, DateTime fecha, bool estado, int usuarioID)
        {
            CD_Asistencia asistencia = new CD_Asistencia();
            try
            {
                if (asistenciaID <= 0)
                {
                    throw new Exception("Seleccione un registro válido.");
                }
                if (estudianteID <= 0)
                {
                    throw new Exception("Seleccione un estudiante válido.");
                }
                if (asignaturaID <= 0)
                {
                    throw new Exception("Seleccione una asignatura válida.");
                }
                if (usuarioID <= 0)
                {
                    throw new Exception("Desconexión de la aplicación, vuelva al login");
                }
                return asistencia.CD_ActualizarAsistencia(asistenciaID, estudianteID, asignaturaID, fecha, estado, usuarioID);
            } catch (Exception ex)
            {
                throw new Exception("Error al actualizar una asistencia: " + ex.Message);
            }
        }
    }
}
