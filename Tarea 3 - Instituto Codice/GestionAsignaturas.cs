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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea_3___Instituto_Codice
{
    /// <summary>
    /// Formulario para la gestión completa de asignaturas del Instituto CODICE.
    /// Permite crear, visualizar y actualizar asignaturas asociadas a cursos específicos.
    /// </summary>
    public partial class GestionAsignaturas : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia del formulario de gestión de asignaturas.
        /// Carga las listas de cursos y asignaturas disponibles.
        /// </summary>
        public GestionAsignaturas()
        {
            InitializeComponent();
            ListaCursosCrear();
            ListaCursosAct();
            ListaAsignaturas();
        }
        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Carga y muestra todas las asignaturas en el DataGridView al iniciar el formulario.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void GestionAsignaturas_Load(object sender, EventArgs e)
        {
            MostrarAsignaturas();
        }
        /// <summary>
        /// Carga y muestra todas las asignaturas registradas en el sistema en el DataGridView.
        /// </summary>
        private void MostrarAsignaturas()
        {
            CN_Asignatura asignatura = new CN_Asignatura();
            dataGridView1.DataSource = asignatura.CN_VerAsignaturas();
        }
        /// <summary>
        /// Carga la lista de cursos disponibles en el ComboBox del formulario de creación de asignaturas.
        /// </summary>
        private void ListaCursosCrear()
        {
            CN_Cursos curso = new CN_Cursos();
            DataTable objetos = curso.CN_VerCursos();
            CbVerCursosCrear.DataSource = objetos;
            CbVerCursosCrear.DisplayMember = "NombreCurso";
            CbVerCursosCrear.ValueMember = "CursoID";
            CbVerCursosCrear.SelectedIndex = -1;
        }
        /// <summary>
        /// Carga la lista de cursos disponibles en el ComboBox del formulario de actualización de asignaturas.
        /// </summary>
        private void ListaCursosAct()
        {
            CN_Cursos curso = new CN_Cursos();
            DataTable objetos = curso.CN_VerCursos();
            CbVerCursoAct.DataSource = objetos;
            CbVerCursoAct.DisplayMember = "NombreCurso";
            CbVerCursoAct.ValueMember = "CursoID";
            CbVerCursoAct.SelectedIndex = -1;
        }
        /// <summary>
        /// Carga la lista de todas las asignaturas registradas en el ComboBox del formulario de actualización.
        /// </summary>
        private void ListaAsignaturas()
        {
            CN_Asignatura asignatura = new CN_Asignatura();
            DataTable objetos = asignatura.CN_VerAsignaturas();
            CbSeleccionarAsignatura.DataSource = objetos;
            CbSeleccionarAsignatura.DisplayMember = "NombreAsignatura";
            CbSeleccionarAsignatura.ValueMember = "AsignaturaID";
            CbSeleccionarAsignatura.SelectedIndex = -1;
        }
        /// <summary>
        /// Maneja el evento Click del botón para crear una nueva asignatura.
        /// Valida los datos y registra la nueva asignatura en el sistema.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        /// <remarks>
        /// Muestra mensajes de confirmación o error según el resultado de la operación.
        /// Utiliza el ID del usuario en sesión para el registro.
        /// </remarks>
        private void BtnCrearAsignatura_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Asignatura asignatura = new CN_Asignatura();
                int cursoID = Convert.ToInt32(CbVerCursosCrear.SelectedValue);
                string nombre = TbNombreCursoCrear.Text.Trim();

                bool verificacion = asignatura.CN_CrearAsignatura(cursoID, nombre, SesionUsuario.UsuarioID);

                if (verificacion)
                {
                    MessageBox.Show($"La creación de la asignatura {nombre} ha sido exitosa.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error en la creación de la asignatura {nombre}.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la creación de la asignatura: " + ex,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Maneja el evento Click del botón para limpiar el formulario de creación.
        /// Restablece todos los campos del formulario de creación a sus valores predeterminados.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnLimpiarForm_Click(object sender, EventArgs e)
        {
            CbVerCursosCrear.SelectedIndex = -1;
            TbNombreCursoCrear.Clear();
            CbVerCursosCrear.Focus();
        }
        /// <summary>
        /// Maneja el evento Click del botón para limpiar el formulario de actualización.
        /// Restablece todos los campos del formulario de actualización a sus valores predeterminados.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnLimpiarFormAct_Click(object sender, EventArgs e)
        {
            CbSeleccionarAsignatura.SelectedIndex = -1;
            CbVerCursoAct.SelectedIndex = -1;
            TbNombreCursoAct.Clear();
            CbSeleccionarAsignatura.Focus();
        }
        /// <summary>
        /// Maneja el evento Click del botón para actualizar una asignatura existente.
        /// Valida los datos y actualiza la información de la asignatura seleccionada.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        /// <remarks>
        /// Muestra mensajes de confirmación o error según el resultado de la operación.
        /// Utiliza el ID del usuario en sesión para registrar la actualización.
        /// </remarks>
        private void BtnActualizarAsignatura_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Asignatura asignatura = new CN_Asignatura();
                int asignaturaID = Convert.ToInt32(CbSeleccionarAsignatura.SelectedValue);
                int cursoID = Convert.ToInt32(CbVerCursoAct.SelectedValue);
                string nombre = TbNombreCursoAct.Text.Trim();

                bool verificacion = asignatura.CN_ActualizarAsignatura(asignaturaID, cursoID, nombre, SesionUsuario.UsuarioID);

                if (verificacion)
                {
                    MessageBox.Show("La actualización de la asignatura ha sido exitosa.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar la asignatura {nombre}.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar una asignatura: " + ex,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CbSeleccionarAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
