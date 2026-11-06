using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    /// <summary>
    /// Clase que proporciona métodos de filtrado y consulta de datos específicos relacionados con estudiantes, cursos y asignaturas.
    /// Permite obtener información filtrada para las diferentes vistas de la aplicación.
    /// </summary>
    public class CD_Filtros
    {
        /// <summary>
        /// Obtiene todos los estudiantes pertenecientes a un curso específico.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso.</param>
        /// <returns>
        /// DataTable con la información de los estudiantes del curso especificado.
        /// (EstudianteID, NombreCompleto)
        /// </returns>
        public DataTable CD_EstudiantesPorCurso(int cursoID)
        {
            CD_Conexion conexion = new CD_Conexion();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            SqlDataReader leer;

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EstudientesPorCurso";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@CursoID", cursoID);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
        /// <summary>
        /// Obtiene todas las asignaturas asociadas a un curso específico.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso.</param>
        /// <returns>
        /// DataTable con la información de las asignaturas del curso especificado
        /// (AsignaturaID, NombreAsignatura).
        /// </returns>
        public DataTable CD_AsignaturasPorCurso(int cursoID)
        {
            CD_Conexion conexion = new CD_Conexion();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            SqlDataReader leer;

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AsignaturasPorCurso";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@CursoID", cursoID);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
        /// <summary>
        /// Obtiene los estudiantes inscritos en una asignatura específica dentro de un curso determinado.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <returns>
        /// DataTable con la información de los estudiantes que cursan la asignatura especificada
        /// (CalificacionID, EstudianteID, Estudiante, AsignaturaID, Asignatura, Nota, FechaRegistro).
        /// </returns>
        public DataTable CD_EstudiantesPorAsignaturaYCurso(int cursoID, int asignaturaID)
        {
            CD_Conexion conexion = new CD_Conexion();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            SqlDataReader leer;

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EstudiantesPorAsignaturaYCurso";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@CursoID", cursoID);
            comando.Parameters.AddWithValue("@AsignaturaID", asignaturaID);


            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
        /// <summary>
        /// Obtiene los registros de asistencia de los estudiantes para una asignatura y curso específicos.
        /// </summary>
        /// <param name="cursoID">Identificador único del curso.</param>
        /// <param name="asignaturaID">Identificador único de la asignatura.</param>
        /// <returns>
        /// DataTable con la información de asistencias de los estudiantes en la asignatura y curso especificados.
        /// (AsistenciaID, EstudianteID, Estudiante, AsignaturaID, Asignatura, FechaAsistencia, Estado)
        /// </returns>
        public DataTable CD_AsistenciasPorCursoYAsignatura(int cursoID, int asignaturaID)
        {
            CD_Conexion conexion = new CD_Conexion();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            SqlDataReader leer;

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EstudiantesAsistenciaPorAsignaturaYCurso";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@CursoID", cursoID);
            comando.Parameters.AddWithValue("@AsignaturaID", asignaturaID);


            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
