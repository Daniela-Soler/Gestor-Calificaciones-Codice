using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Tarea_3___Instituto_Codice
{
    /// <summary>
    /// Formulario del menú principal del sistema Instituto Códice.
    /// Proporciona acceso a todos los módulos de gestión del sistema.
    /// </summary>
    public partial class MenuPrincipal : Form
    {
        /// <summary>
        /// Constructor de la clase MenuPrincipal.
        /// Inicializa los componentes del menú principal.
        /// </summary>
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento del botón "Gestión de Estudiantes".
        /// Abre el formulario de gestión de estudiantes.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void button1_Click(object sender, EventArgs e) // Gestion estudiantes
        {
            GestionEstudiantes objeto = new GestionEstudiantes();
            objeto.Show();
        }
        /// <summary>
        /// Evento del botón "Gestión de Asignaturas".
        /// Abre el formulario de gestión de asignaturas.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void button2_Click(object sender, EventArgs e) // Gestion Asignaturas
        {
            GestionAsignaturas objeto = new GestionAsignaturas();
            objeto.Show();
        }
        /// <summary>
        /// Evento del botón "Gestión de Cursos".
        /// Abre el formulario de gestión de cursos.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnGestionCursos_Click(object sender, EventArgs e) // Gestion Cursos
        {
            GestionCursos objeto = new GestionCursos();
            objeto.Show();
        }
        /// <summary>
        /// Evento del botón "Gestión de Calificaciones".
        /// Abre el formulario de gestión de calificaciones.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnGestionCalificaciones_Click(object sender, EventArgs e)
        {
            GestionCalificaciones objeto = new GestionCalificaciones();
            objeto.Show();
        }
        /// <summary>
        /// Evento del botón "Gestión de Asistencia".
        /// Abre el formulario de gestión de asistencia.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnGestionAsistencia_Click(object sender, EventArgs e)
        {
            GestionAsistencia objeto = new GestionAsistencia();
            objeto.Show();
        }
    }
}
