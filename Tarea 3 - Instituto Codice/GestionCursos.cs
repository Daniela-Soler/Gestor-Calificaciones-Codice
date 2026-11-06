using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3___Instituto_Codice
{
    /// <summary>
    /// Formulario de gestión de cursos del sistema Instituto Códice.
    /// Permite crear, visualizar y actualizar información de cursos.
    /// </summary>
    public partial class GestionCursos : Form
    {
        private CN_Cursos curso = new CN_Cursos();
        /// <summary>
        /// Constructor de la clase GestionCursos.
        /// Inicializa los componentes del formulario y carga la lista de cursos.
        /// </summary>
        public GestionCursos()
        {
            InitializeComponent();
            SeleccionarCurso();
        }
        /// <summary>
        /// Se ejecuta cuando se carga el formulario.
        /// Muestra todos los cursos registrados en el DataGridView.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void GestionCursos_Load(object sender, EventArgs e)
        {
            MostrarCursos();
        }
        /// <summary>
        /// Obtiene y muestra todos los cursos en el DataGridView principal.
        /// </summary>
        private void MostrarCursos()
        {
            CN_Cursos cursos = new CN_Cursos();
            dataGridView1.DataSource = cursos.CN_VerCursos();
        }
        /// <summary>
        /// Carga la lista de cursos en el ComboBox para la sección de actualización.
        /// </summary>
        private void SeleccionarCurso()
        {
            DataTable tabla = curso.CN_VerCursos();
            CbSeleccionCurso.DataSource = tabla;
            CbSeleccionCurso.DisplayMember = "NombreCurso";
            CbSeleccionCurso.ValueMember = "CursoID";
            CbSeleccionCurso.SelectedIndex = -1;
        }
        //--------------- Crear Form
        /// <summary>
        /// Evento del botón "Crear" en la sección de ingreso de cursos.
        /// Registra un nuevo curso en la base de datos con el nombre ingresado.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnCrearCurso_Click(object sender, EventArgs e)
        {
            string nombre = TbCreateNombreCurso.Text.Trim();
            bool verificacion = curso.CN_CrearCurso(nombre, SesionUsuario.UsuarioID);

            if (verificacion)
            {
                MessageBox.Show("Curso registrado con éxito.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Evento del botón "Limpiar" en la sección de creación de cursos.
        /// Reinicia los campos del formulario de ingreso.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnLimpiarFormCurso_Click(object sender, EventArgs e)
        {
            TbCreateNombreCurso.Clear();
            TbCreateNombreCurso.Focus();
        }
        //------------- Actualizar Form
        /// <summary>
        /// Evento del botón "Actualizar" en la sección de actualización de cursos.
        /// Modifica el nombre del curso seleccionado en la base de datos.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnActualizarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                int cursoID = Convert.ToInt32(CbSeleccionCurso.SelectedValue);
                string nombre = TbUpdateNombreCurso.Text.Trim();

                bool verificacion = curso.CN_ActualizarCurso(cursoID, nombre, SesionUsuario.UsuarioID);
                if (verificacion)
                {
                    MessageBox.Show($"Actualización del nombre del curso actualizada con éxito",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el curso: " + ex,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento del botón "Limpiar" en la sección de actualización de cursos.
        /// Reinicia todos los campos del formulario de actualización.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnLimpiarFormAct_Click(object sender, EventArgs e)
        {
            CbSeleccionCurso.SelectedIndex = -1;
            TbUpdateNombreCurso.Clear();
            CbSeleccionCurso.Focus();
        }
    }
}
