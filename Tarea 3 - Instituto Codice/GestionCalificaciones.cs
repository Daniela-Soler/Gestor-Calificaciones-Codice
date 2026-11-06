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
    /// Formulario de gestión de calificaciones del sistema Instituto Códice.
    /// Permite ingresar nuevas calificaciones y actualizar las existentes.
    /// </summary>
    /// <remarks>
    /// Este formulario implementa dos secciones principales:
    /// - Ingresar Calificación: Para registrar nuevas calificaciones de estudiantes
    /// - Actualizar Calificación: Para modificar calificaciones existentes
    /// </remarks>
    public partial class GestionCalificaciones : Form
    {
        /// <summary>
        /// ID de la calificación seleccionada en el DataGridView de actualización.
        /// Se utiliza para identificar qué calificación se va a modificar.
        /// </summary>
        private int calificacionSeleccionadaID = 0;
        /// <summary>
        /// Constructor de la clase GestionCalificaciones.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public GestionCalificaciones()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Se ejecuta cuando se carga el formulario.
        /// Inicializa los datos de ambas secciones (Ingresar y Actualizar).
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void GestionCalificaciones_Load(object sender, EventArgs e)
        {
            ListaCursosFormCrear();
            CargarCursosActualizar();
            InicializarSeccionActualizar();
        }
        /// <summary>
        /// Carga la lista de cursos disponibles en el ComboBox de la sección "Ingresar Calificación".
        /// </summary>
        /// <remarks>
        /// Desuscribe el evento SelectedIndexChanged antes de cargar para evitar disparos inadvertidos,
        /// y lo reactivar después de completar la carga.
        /// </remarks>
        private void ListaCursosFormCrear()
        {
            try
            {
                CbCursoCrear.SelectedIndexChanged -= CbCursoCrear_SelectedIndexChanged;

                CN_Cursos cursos = new CN_Cursos();
                DataTable cursitos = cursos.CN_VerCursos();

                CbCursoCrear.DataSource = cursitos;
                CbCursoCrear.DisplayMember = "NombreCurso";
                CbCursoCrear.ValueMember = "CursoID";
                CbCursoCrear.SelectedIndex = -1;

                CbEstudianteCrear.DataSource = null;
                CbEstudianteCrear.Items.Clear();
                CbAsignaturaCrear.DataSource = null;
                CbAsignaturaCrear.Items.Clear();
                CbCursoCrear.SelectedIndexChanged += CbCursoCrear_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cursos: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento que se dispara cuando se selecciona un curso en la sección "Ingresar Calificación".
        /// Carga los estudiantes y asignaturas correspondientes al curso seleccionado.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void CbCursoCrear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCursoCrear.SelectedIndex == -1 || CbCursoCrear.SelectedValue == null)
            {
                LimpiarComboboxDependientes();
            }
            try
            {
                // Obtener el ID del curso seleccionado
                int cursoID = Convert.ToInt32(CbCursoCrear.SelectedValue);

                CN_Filtros objFiltros = new CN_Filtros();

                // Obtener estudiantes filtrados por curso
                DataTable dtEstudiantes = objFiltros.CN_EstudiantesPorCurso(cursoID);
                ConfigurarComboBoxEstudiantes(dtEstudiantes);

                DataTable dtAsignaturas = objFiltros.CN_AsignaturasPorCurso(cursoID);
                ConfigurarComboBoxAsignaturas(dtAsignaturas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Configura el ComboBox de estudiantes con los datos obtenidos del curso seleccionado.
        /// </summary>
        /// <param name="dtEstudiantes">DataTable que contiene la lista de estudiantes del curso</param>
        public void ConfigurarComboBoxEstudiantes(DataTable dtEstudiantes)
        {
            if (dtEstudiantes.Rows.Count > 0)
            {
                CbEstudianteCrear.DataSource = dtEstudiantes;
                CbEstudianteCrear.DisplayMember = "NombreEstudiante";
                CbEstudianteCrear.ValueMember = "EstudianteID";
                CbEstudianteCrear.SelectedIndex = -1;
            }
            else
            {
                CbEstudianteCrear.DataSource = null;
                CbEstudianteCrear.Items.Clear();
                CbEstudianteCrear.Text = "-- No hay estudiantes --";
                MessageBox.Show("No hay estudiantes en este curso",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Configura el ComboBox de asignaturas con los datos obtenidos del curso seleccionado.
        /// </summary>
        /// <param name="dtAsignaturas">DataTable que contiene la lista de asignaturas del curso</param>
        private void ConfigurarComboBoxAsignaturas(DataTable dtAsignaturas)
        {
            if (dtAsignaturas.Rows.Count > 0)
            {
                CbAsignaturaCrear.DataSource = dtAsignaturas;
                CbAsignaturaCrear.DisplayMember = "NombreAsignatura";
                CbAsignaturaCrear.ValueMember = "AsignaturaID";
                CbAsignaturaCrear.SelectedIndex = -1;
            }
            else
            {
                CbAsignaturaCrear.DataSource = null;
                CbAsignaturaCrear.Items.Clear();
                CbAsignaturaCrear.Text = "-- No hay asignaturas --";
                MessageBox.Show("No hay asignaturas en este curso",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Limpia y reinicia los ComboBox de estudiantes y asignaturas.
        /// Se ejecuta cuando no hay curso seleccionado.
        /// </summary>
        public void LimpiarComboboxDependientes()
        {
            CbEstudianteCrear.DataSource = null;
            CbEstudianteCrear.Items.Clear();
            CbEstudianteCrear.Text = "-- Seleccione un curso --";

            CbAsignaturaCrear.DataSource = null;
            CbAsignaturaCrear.Items.Clear();
            CbAsignaturaCrear.Text = "-- Seleccione un curso --";
        }
        // --------------------- Form Ingresar Calificacion
        /// <summary>
        /// Evento del botón "Ingresar" en la sección de creación de calificaciones.
        /// Valida los datos y registra la nueva calificación en la base de datos.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnCrearCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
                int estudianteID = Convert.ToInt32(CbEstudianteCrear.SelectedValue);
                int asignaturaID = Convert.ToInt32(CbAsignaturaCrear.SelectedValue);
                decimal nota = Convert.ToDecimal(TbNotaCrear.Text);
                DateTime fecha = McFechaCrear.SelectionStart;

                CN_Calificacion calificacion = new CN_Calificacion();
                bool verificacion = calificacion.CN_IngresarCalificacion(
                    estudianteID, asignaturaID, nota, fecha, SesionUsuario.UsuarioID);

                if (verificacion)
                {
                    MessageBox.Show($"Calificación {nota} agregada al estudiante con éxito.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar la calificación a un estudiante.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar una calificación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Evento del botón "Limpiar" en la sección de creación de calificaciones.
        /// Reinicia todos los campos del formulario de ingreso.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnLimpiarFormCrear_Click(object sender, EventArgs e)
        {
            CbCursoCrear.SelectedIndex = -1;
            LimpiarComboboxDependientes();
            TbNotaCrear.Clear();
            McFechaCrear.SetDate(DateTime.Now);
            CbCursoCrear.Focus();
        }

        // ---------------------- Form Actualizar Calificacion
        /// <summary>
        /// Carga la lista de cursos disponibles en el ComboBox de la sección "Actualizar Calificación".
        /// </summary>
        private void CargarCursosActualizar()
        {
            try
            {
                CN_Cursos objCursos = new CN_Cursos();

                CbSeleccionarCursoAct.SelectedIndexChanged -= CbSeleccionarCursoAct_SelectedIndexChanged;
                DataTable dtCursos = objCursos.CN_VerCursos();

                CbSeleccionarCursoAct.DataSource = dtCursos;
                CbSeleccionarCursoAct.DisplayMember = "NombreCurso";
                CbSeleccionarCursoAct.ValueMember = "CursoID";
                CbSeleccionarCursoAct.SelectedIndex = -1;

                // Reactivar evento
                CbSeleccionarCursoAct.SelectedIndexChanged += CbSeleccionarCursoAct_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cursos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento que se dispara cuando se selecciona un curso en la sección "Actualizar Calificación".
        /// Carga las asignaturas correspondientes al curso seleccionado.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void CbSeleccionarCursoAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CN_Asignatura objAsignatura = new CN_Asignatura();
            CN_Filtros objFiltros = new CN_Filtros();
            CN_Cursos objCursos = new CN_Cursos();

            if (CbSeleccionarCursoAct.SelectedIndex == -1 || CbSeleccionarCursoAct.SelectedValue == null)
            {
                CbSeleccionarAsignaturaAct.Enabled = false;
                CbSeleccionarAsignaturaAct.DataSource = null;
                dataGridView1.DataSource = null;
                LimpiarCamposEditables();
                return;
            }

            try
            {
                int cursoID = Convert.ToInt32(CbSeleccionarCursoAct.SelectedValue);
                DataTable dtAsignaturas = objFiltros.CN_AsignaturasPorCurso(cursoID);

                CbSeleccionarAsignaturaAct.SelectedIndexChanged -= CbSeleccionarAsignaturaAct_SelectedIndexChanged;

                CbSeleccionarAsignaturaAct.DataSource = dtAsignaturas;
                CbSeleccionarAsignaturaAct.DisplayMember = "NombreAsignatura";
                CbSeleccionarAsignaturaAct.ValueMember = "AsignaturaID";
                CbSeleccionarAsignaturaAct.SelectedIndex = -1;
                CbSeleccionarAsignaturaAct.Enabled = true;
                CbSeleccionarAsignaturaAct.SelectedIndexChanged += CbSeleccionarAsignaturaAct_SelectedIndexChanged;

                dataGridView1.DataSource = null;
                LimpiarCamposEditables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asignaturas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento que se dispara cuando se selecciona una asignatura en la sección "Actualizar Calificación".
        /// Carga las calificaciones filtradas por curso y asignatura en el DataGridView.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void CbSeleccionarAsignaturaAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CN_Asignatura objAsignatura = new CN_Asignatura();
            CN_Cursos objCursos = new CN_Cursos();

            if (CbSeleccionarAsignaturaAct.SelectedIndex == -1 || CbSeleccionarAsignaturaAct.SelectedValue == null ||
            CbSeleccionarCursoAct.SelectedIndex == -1)
            {
                dataGridView1.DataSource = null;
                LimpiarCamposEditables();
                return;
            }
            try
            {
                int cursoID = Convert.ToInt32(CbSeleccionarCursoAct.SelectedValue);
                int asignaturaID = Convert.ToInt32(CbSeleccionarAsignaturaAct.SelectedValue);

                CN_Filtros objFiltros = new CN_Filtros();
                DataTable dtCalificaciones = objFiltros.CN_EstudiantesPorAsignaturaYCurso(cursoID, asignaturaID);

                dataGridView1.DataSource = dtCalificaciones;
                PersonalizarDataGridView();
                LimpiarCamposEditables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar calificaciones: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento que se dispara cuando se selecciona una fila en el DataGridView de actualización.
        /// Carga los datos de la calificación seleccionada en los campos de edición.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                LimpiarCamposEditables();
                return;
            }
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                calificacionSeleccionadaID = Convert.ToInt32(row.Cells["CalificacionID"].Value);
                TbEstudianteAct.Text = row.Cells["Estudiante"].Value.ToString();
                TbAsignaturaAct.Text = row.Cells["Asignatura"].Value.ToString();
                TbCalificacionAct.Text = row.Cells["Nota"].Value.ToString();
                DtpFechaAct.Value = Convert.ToDateTime(row.Cells["FechaRegistro"].Value);

                TbEstudianteAct.Enabled = true; // Solo para mostrar (ReadOnly = true)
                TbAsignaturaAct.Enabled = true; // Solo para mostrar (ReadOnly = true)
                TbCalificacionAct.Enabled = true; // EDITABLE
                DtpFechaAct.Enabled = true; // EDITABLE
                BtnActualizarCalificacion.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento del botón "Actualizar" en la sección de actualización de calificaciones.
        /// Valida los datos modificados y actualiza la calificación en la base de datos.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnActualizarCalificacion_Click(object sender, EventArgs e)
        {
            CN_Asignatura objAsignatura = new CN_Asignatura();
            CN_Filtros objFiltros = new CN_Filtros();
            CN_Cursos objCursos = new CN_Cursos();
            CN_Calificacion objCalificaciones = new CN_Calificacion();
            try
            {
                if (calificacionSeleccionadaID <= 0)
                {
                    MessageBox.Show("Debe seleccionar una calificación para actualizar",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                decimal nota;
                if (!decimal.TryParse(TbCalificacionAct.Text, out nota))
                {
                    MessageBox.Show("La nota debe ser un número válido",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbCalificacionAct.Focus();
                    return;
                }
                if (nota < 1.0m || nota > 7.0m)
                {
                    MessageBox.Show("La nota debe estar entre 1.0 y 7.0",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbCalificacionAct.Focus();
                    return;
                }
                DateTime fechaRegistro = DtpFechaAct.Value.Date;
                int usuarioID = SesionUsuario.UsuarioID;

                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int estudianteID = Convert.ToInt32(row.Cells["EstudianteID"].Value);
                int asignaturaID = Convert.ToInt32(row.Cells["AsignaturaID"].Value);

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro que desea actualizar esta calificación?",
                    "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    bool exito = objCalificaciones.CN_ActualizarCalificacion(
                        calificacionSeleccionadaID, estudianteID, asignaturaID,
                        nota, fechaRegistro, usuarioID);
                    if (exito)
                    {
                        MessageBox.Show("Calificación actualizada exitosamente",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int cursoID = Convert.ToInt32(CbSeleccionarCursoAct.SelectedValue);
                        int asignaturasID = Convert.ToInt32(CbSeleccionarAsignaturaAct.SelectedValue);
                        DataTable dtCalificaciones = objFiltros.CN_EstudiantesPorAsignaturaYCurso(cursoID, asignaturasID);
                        dataGridView1.DataSource = dtCalificaciones;

                        PersonalizarDataGridView();
                        LimpiarCamposEditables();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar calificación: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento del botón "Limpiar" en la sección de actualización de calificaciones.
        /// Reinicia todos los campos, ComboBox y el DataGridView.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void BtnLimpiarFormAct_Click(object sender, EventArgs e)
        {
            LimpiarTodoActualizar();
        }
        /// <summary>
        /// Inicializa el estado de todos los controles de la sección "Actualizar Calificación".
        /// Se ejecuta al cargar el formulario para establecer controles deshabilitados inicialmente.
        /// </summary>
        private void InicializarSeccionActualizar()
        {
            CbSeleccionarAsignaturaAct.Enabled = false;
            TbAsignaturaAct.Enabled = false;
            TbEstudianteAct.Enabled = false;
            TbCalificacionAct.Enabled = false;
            DtpFechaAct.Enabled = false;
            BtnActualizarCalificacion.Enabled = false;

            dataGridView1.DataSource = null;
        }
        /// <summary>
        /// Personaliza la apariencia del DataGridView de calificaciones.
        /// Oculta columnas de IDs y establece formatos para las columnas visibles.
        /// </summary>
        private void PersonalizarDataGridView()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                return;
            }
            if (dataGridView1.Columns.Contains("CalificacionID"))
            {
                dataGridView1.Columns["CalificacionID"].Visible = false;
            }
            if (dataGridView1.Columns.Contains("EstudianteID"))
            {
                dataGridView1.Columns["EstudianteID"].Visible = false;
            }
            if (dataGridView1.Columns.Contains("AsignaturaID"))
            {
                dataGridView1.Columns["AsignaturaID"].Visible = false;
            }

            if (dataGridView1.Columns.Contains("Estudiante"))
            {
                dataGridView1.Columns["Estudiante"].HeaderText = "Estudiante";
            }

            if (dataGridView1.Columns.Contains("Asignatura"))
            {
                dataGridView1.Columns["Asignatura"].HeaderText = "Asignatura";
            }

            if (dataGridView1.Columns.Contains("Nota"))
            {
                dataGridView1.Columns["Nota"].HeaderText = "Nota";
            }

            if (dataGridView1.Columns.Contains("FechaRegistro"))
            {
                dataGridView1.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
                dataGridView1.Columns["FechaRegistro"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        /// <summary>
        /// Limpia y reinicia solo los campos editables de la sección "Actualizar Calificación".
        /// No limpia los filtros (Curso y Asignatura), solo los datos del registro seleccionado.
        /// </summary>
        private void LimpiarCamposEditables()
        {
            calificacionSeleccionadaID = 0;
            TbEstudianteAct.Clear();
            TbAsignaturaAct.Clear();
            TbCalificacionAct.Clear();
            DtpFechaAct.Value = DateTime.Now;

            TbEstudianteAct.Enabled = false;
            TbAsignaturaAct.Enabled = false;
            TbCalificacionAct.Enabled = false;
            DtpFechaAct.Enabled = false;
            BtnActualizarCalificacion.Enabled = false;
        }
        /// <summary>
        /// Limpia completamente todos los controles de la sección "Actualizar Calificación".
        /// Reinicia filtros, DataGridView y campos editables a su estado inicial.
        /// </summary>
        private void LimpiarTodoActualizar()
        {
            CbSeleccionarCursoAct.SelectedIndex = -1;
            CbSeleccionarAsignaturaAct.SelectedIndex = -1;
            CbSeleccionarAsignaturaAct.Enabled = false;

            dataGridView1.DataSource = null;
            LimpiarCamposEditables();
            CbSeleccionarCursoAct.Focus();
        }

        private void CbEstudianteCrear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
