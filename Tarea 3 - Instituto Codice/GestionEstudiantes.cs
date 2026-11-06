using Datos;
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
    /// Formulario de gestión de estudiantes del sistema Instituto Códice.
    /// Permite crear, visualizar y actualizar información de estudiantes.
    /// </summary>
    public partial class GestionEstudiantes : Form
    {
        private CN_Estudiante objEstudianteNegocio = new CN_Estudiante();
        private CN_Cursos objCursoNegocio = new CN_Cursos();
        /// <summary>
        /// Constructor de la clase GestionEstudiantes.
        /// Inicializa los componentes y carga las listas de cursos y estudiantes.
        /// </summary>
        public GestionEstudiantes()
        {
            InitializeComponent();
            ListaCursos();
            ListaEstudiantes();
        }
        /// <summary>
        /// Obtiene y muestra todos los estudiantes en el DataGridView principal.
        /// </summary>
        private void MostrarEstudiantes()
        {
            CN_Estudiante estudiante = new CN_Estudiante();
            DgvVistaRegistrosEstudiantes.DataSource = estudiante.CN_VerEstudiantes();
        }
        /// <summary>
        /// Se ejecuta cuando se carga el formulario.
        /// Muestra todos los estudiantes registrados en el DataGridView.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void GestionEstudiantes_Load(object sender, EventArgs e)
        {
            MostrarEstudiantes();
        }
        //-------------------------Formulario de Crear Estudiante
        /// <summary>
        /// Carga la lista de cursos disponibles en el ComboBox de la sección de creación.
        /// </summary>
        private void ListaCursos()
        {
            DataTable dtCursos = objCursoNegocio.CN_VerCursos();

            CbSeleccionarCurso.DataSource = dtCursos;
            CbSeleccionarCurso.DisplayMember = "NombreCurso";
            CbSeleccionarCurso.ValueMember = "CursoID";
            CbSeleccionarCurso.SelectedIndex = -1;
        }
        /// <summary>
        /// Evento del botón "Crear" en la sección de ingreso de estudiantes.
        /// Registra un nuevo estudiante en la base de datos con los datos ingresados.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnCrearEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TbCrearNombreEstudiante.Text.Trim();
                string apellido = TbCrearApellidoEstudiante.Text.Trim();
                string rut = TbCrearRutEstudiante.Text.Trim();
                int cursoID = Convert.ToInt32(CbSeleccionarCurso.SelectedValue);
                int usuarioID = Convert.ToInt32(SesionUsuario.UsuarioID);
                bool resultado = objEstudianteNegocio.CN_CrearEstudiante(nombre, apellido, rut, cursoID, usuarioID);
                if (resultado)
                {
                    MessageBox.Show("Estudiante registrado con éxito",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al ingresar un estudiante",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento del botón "Limpiar" en la sección de creación de estudiantes.
        /// Reinicia todos los campos del formulario de ingreso.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnLimpiarFormCrear_Click(object sender, EventArgs e)
        {
            TbCrearNombreEstudiante.Clear();
            TbCrearApellidoEstudiante.Clear();
            TbCrearRutEstudiante.Clear();
            CbSeleccionarCurso.SelectedIndex = -1;
            TbCrearNombreEstudiante.Focus();
        }
        //-----------------------Formulario Actualizar Estudiante
        /// <summary>
        /// Carga la lista de estudiantes en el ComboBox de la sección de actualización.
        /// </summary>
        private void ListaEstudiantes()
        {
            DataTable dtEstudiantes = objEstudianteNegocio.CN_VerEstudiantes();
            CbSeleccionarEstudiante.DataSource = dtEstudiantes;
            CbSeleccionarEstudiante.DisplayMember = "NombreCompleto";
            // Lo que se muestra
            CbSeleccionarEstudiante.ValueMember = "EstudianteID";       // El valor real (ID)

            // Opción para dejar sin selección inicial
            CbSeleccionarEstudiante.SelectedIndex = -1;
        }
        /// <summary>
        /// Evento del botón "Actualizar" en la sección de actualización de estudiantes.
        /// Modifica los datos del estudiante seleccionado en la base de datos.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnActualizarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                int estudianteID = Convert.ToInt32(CbSeleccionarEstudiante.SelectedValue);
                string nombre = TbActualizarNombre.Text.Trim();
                string apellido = TbActualizarApellido.Text.Trim();
                string rut = TbActualizarRut.Text.Trim();
                int cursoID = Convert.ToInt32(CbSeleccionarCursoAct.SelectedValue);
                int usuarioID = Convert.ToInt32(SesionUsuario.UsuarioID);
                bool verificacion = objEstudianteNegocio.CN_ActualizarEstudiante(estudianteID, nombre, apellido, rut, cursoID, usuarioID);
                if (verificacion)
                {
                    MessageBox.Show($"Actualización del estudiante {nombre} exitosa.",
                        "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar el estudiante {nombre}.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
            {
                throw new Exception("Error al actualizar: " + ex.Message);
            }
        }
        /// <summary>
        /// Evento del botón "Limpiar" en la sección de actualización de estudiantes.
        /// Reinicia todos los campos del formulario de actualización.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnLimpiarFormAct_Click(object sender, EventArgs e)
        {
            TbActualizarNombre.Clear();
            TbActualizarApellido.Clear();
            TbActualizarRut.Clear();
            CbSeleccionarCursoAct.SelectedIndex = -1;
            CbSeleccionarEstudiante.SelectedIndex = -1;
            TbActualizarNombre.Focus();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DgvVistaRegistrosEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbSeleccionarCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CbSeleccionarEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
