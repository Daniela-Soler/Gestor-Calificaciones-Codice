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
    /// Formulario para la gestión completa de asistencias del Instituto CODICE.
    /// Permite registrar y actualizar asistencias de estudiantes por curso y asignatura.
    /// Incluye filtrado dinámico y visualización en DataGridView con checkboxes para marcar asistencia.
    /// </summary>
    public partial class GestionAsistencia : Form
    {
        /// <summary>
        /// Almacena el ID de la asistencia seleccionada para actualización.
        /// </summary>
        private int asistenciaSeleccionadaID = 0;
        /// <summary>
        /// Inicializa una nueva instancia del formulario de gestión de asistencias.
        /// Configura los eventos del DataGridView para manejar cambios en tiempo real.
        /// </summary>
        public GestionAsistencia()
        {
            InitializeComponent();
            this.dataGridViewAct.CurrentCellDirtyStateChanged += dataGridViewAct_CurrentCellDirtyStateChanged;
            this.dataGridViewAct.CellValueChanged += dataGridViewAct_CellValueChanged;
            this.dataGridViewAct.SelectionChanged += dataGridViewAct_SelectionChanged;
        }
        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Carga las listas de cursos para los formularios de creación y actualización.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void GestionAsistencia_Load(object sender, EventArgs e)
        {
            CargarCursos();
            CargarCursosActualizar();
        }
        // ---------------------- Form Ingresar Asistencia
        /// <summary>
        /// Carga la lista de cursos disponibles en el ComboBox del formulario de creación de asistencias.
        /// Desactiva temporalmente el evento SelectedIndexChanged para evitar ejecuciones no deseadas.
        /// </summary>
        private void CargarCursos()
        {
            try
            {
                CN_Cursos objCursos = new CN_Cursos();
                CbSeleccionarCursoCrear.SelectedIndexChanged -= CbSeleccionarCursoCrear_SelectedIndexChanged;
                DataTable dtCursos = objCursos.CN_VerCursos();

                CbSeleccionarCursoCrear.DataSource = dtCursos;
                CbSeleccionarCursoCrear.DisplayMember = "NombreCurso";
                CbSeleccionarCursoCrear.ValueMember = "CursoID";
                CbSeleccionarCursoCrear.SelectedIndex = -1; // Iniciar sin selección

                LimpiarAsignaturas();
                CbSeleccionarCursoCrear.SelectedIndexChanged += CbSeleccionarCursoCrear_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cursos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Limpia y deshabilita el ComboBox de asignaturas del formulario de creación.
        /// </summary>
        private void LimpiarAsignaturas()
        {
            CbSeleccionarAsignaturaCrear.DataSource = null;
            CbSeleccionarAsignaturaCrear.Items.Clear();
            CbSeleccionarAsignaturaCrear.Text = "-- Seleccione Asignatura --";
            CbSeleccionarAsignaturaCrear.Enabled = false;
        }
        /// <summary>
        /// Maneja el evento SelectedIndexChanged del ComboBox de cursos en el formulario de creación.
        /// Carga las asignaturas correspondientes al curso seleccionado.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void CbSeleccionarCursoCrear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbSeleccionarCursoCrear.SelectedIndex == -1 || CbSeleccionarCursoCrear.SelectedValue == null)
            {
                LimpiarAsignaturas();
                dataGridViewCrear.DataSource = null;
                return;
            }
            try
            {
                int cursoID = Convert.ToInt32(CbSeleccionarCursoCrear.SelectedValue);
                CN_Filtros objFiltros = new CN_Filtros();
                DataTable dtAsignaturas = objFiltros.CN_AsignaturasPorCurso(cursoID);

                CbSeleccionarAsignaturaCrear.SelectedIndexChanged -= CbSeleccionarAsignaturaCrear_SelectedIndexChanged;

                CbSeleccionarAsignaturaCrear.DataSource = dtAsignaturas;
                CbSeleccionarAsignaturaCrear.DisplayMember = "NombreAsignatura";
                CbSeleccionarAsignaturaCrear.ValueMember = "AsignaturaID";
                CbSeleccionarAsignaturaCrear.SelectedIndex = -1;
                CbSeleccionarAsignaturaCrear.Enabled = true;

                CbSeleccionarAsignaturaCrear.SelectedIndexChanged += CbSeleccionarAsignaturaCrear_SelectedIndexChanged;
                dataGridViewCrear.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asignaturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Maneja el evento SelectedIndexChanged del ComboBox de asignaturas en el formulario de creación.
        /// Carga los estudiantes del curso seleccionado en un DataGridView con columna de checkbox para marcar asistencia.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void CbSeleccionarAsignaturaCrear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbSeleccionarAsignaturaCrear.SelectedIndex == -1 || CbSeleccionarAsignaturaCrear.SelectedValue == null ||
        CbSeleccionarCursoCrear.SelectedIndex == -1)
            {
                dataGridViewCrear.DataSource = null;
                return;
            }
            try
            {
                int cursoID = Convert.ToInt32(CbSeleccionarCursoCrear.SelectedValue);
                int asignaturaID = Convert.ToInt32(CbSeleccionarAsignaturaCrear.SelectedValue);

                CN_Filtros objFiltros = new CN_Filtros();
                DataTable dtEstudiantes = objFiltros.CN_EstudiantesPorCurso(cursoID);

                dataGridViewCrear.DataSource = null;
                dataGridViewCrear.Columns.Clear();

                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "AsistenciaEstado", // Nombre clave para la captura
                    HeaderText = "Asistió",
                    Width = 60,
                    TrueValue = true,
                    FalseValue = false,
                    ThreeState = false // Solo dos estados (True/False)
                };

                dataGridViewCrear.Columns.Add(checkColumn);
                dataGridViewCrear.DataSource = dtEstudiantes;
                if (dataGridViewCrear.Columns.Contains("EstudianteID"))
                {
                    dataGridViewCrear.Columns["EstudianteID"].Visible = false;
                }
                if (dataGridViewCrear.Columns.Contains("Estudiante"))
                {
                    dataGridViewCrear.Columns["Estudiante"].HeaderText = "Estudiante";
                    dataGridViewCrear.Columns["Estudiante"].ReadOnly = true;
                }
                dataGridViewCrear.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la planilla de asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Maneja el evento Click del botón para registrar asistencias.
        /// Recorre todas las filas del DataGridView y registra la asistencia de cada estudiante según el estado del checkbox.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        /// <remarks>
        /// Valida que se hayan seleccionado curso y asignatura antes de proceder.
        /// Muestra un resumen con el número de registros exitosos y fallidos.
        /// </remarks>
        private void BtnIngresarAsistencia_Click(object sender, EventArgs e)
        {
            if (CbSeleccionarCursoCrear.SelectedValue == null || CbSeleccionarAsignaturaCrear.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar Curso y Asignatura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridViewCrear.Rows.Count == 0 || dataGridViewCrear.DataSource == null)
            {
                MessageBox.Show("No hay estudiantes para registrar asistencia.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int asignaturaID = Convert.ToInt32(CbSeleccionarAsignaturaCrear.SelectedValue);
            DateTime fechaRegistro = DtpFechaCrear.Value.Date;
            int usuarioID = SesionUsuario.UsuarioID;

            CN_Asistencia objAsistencia = new CN_Asistencia();
            int registrosExitosos = 0;
            int registrosFallidos = 0;

            foreach (DataGridViewRow row in dataGridViewCrear.Rows)
            {
                if (row.IsNewRow) continue;

                try
                {
                    int estudianteID = Convert.ToInt32(row.Cells["EstudianteID"].Value);
                    object cellValue = row.Cells["AsistenciaEstado"].Value;
                    bool estadoAsistencia = (cellValue != null && cellValue != DBNull.Value) ? Convert.ToBoolean(cellValue) : false;

                    bool exito = objAsistencia.CN_IngresarAsistencia(
                        estudianteID,
                        asignaturaID,
                        fechaRegistro,
                        estadoAsistencia,
                        usuarioID);
                    if (exito)
                    {
                        registrosExitosos++;
                    } else
                    {
                        registrosFallidos++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al procesar fila: {ex.Message}");
                    registrosFallidos++;
                }
            }
            if (registrosExitosos > 0)
            {
                MessageBox.Show($"Registro de asistencia completado.{Environment.NewLine}Asistencias Guardadas: {registrosExitosos}{Environment.NewLine}Errores/Duplicados: {registrosFallidos}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLimpiarFormCrear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se pudo registrar la asistencia de ningún estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Maneja el evento Click del botón para limpiar el formulario de creación de asistencias.
        /// Restablece todos los campos y controles a sus valores predeterminados.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnLimpiarFormCrear_Click(object sender, EventArgs e)
        {
            CbSeleccionarCursoCrear.SelectedIndex = -1;
            LimpiarAsignaturas();
            dataGridViewCrear.DataSource = null;
            dataGridViewCrear.Columns.Clear();
            DtpFechaCrear.Value = DateTime.Now;
            CbSeleccionarCursoCrear.Focus();
        }
        // ------------------------------ Form Actualizar Asistencia
        /// <summary>
        /// Carga la lista de cursos disponibles en el ComboBox del formulario de actualización de asistencias.
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

                LimpiarAsignaturasActualizar();
                CbSeleccionarCursoAct.SelectedIndexChanged += CbSeleccionarCursoAct_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cursos para Actualizar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Limpia y deshabilita el ComboBox de asignaturas del formulario de actualización.
        /// </summary>
        private void LimpiarAsignaturasActualizar()
        {
            CbSeleccionarAsignaturaAct.DataSource = null;
            CbSeleccionarAsignaturaAct.Items.Clear();
            CbSeleccionarAsignaturaAct.Text = "-- Seleccione Asignatura --";
            CbSeleccionarAsignaturaAct.Enabled = false;
        }
        /// <summary>
        /// Maneja el evento SelectedIndexChanged del ComboBox de cursos en el formulario de actualización.
        /// Carga las asignaturas correspondientes al curso seleccionado.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void CbSeleccionarCursoAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbSeleccionarCursoAct.SelectedIndex == -1 || CbSeleccionarCursoAct.SelectedValue == null)
            {
                LimpiarAsignaturasActualizar();
                dataGridViewAct.DataSource = null;
                return;
            }
            try
            {
                int cursoID = Convert.ToInt32(CbSeleccionarCursoAct.SelectedValue);
                CN_Filtros objFiltros = new CN_Filtros();
                DataTable dtAsignaturas = objFiltros.CN_AsignaturasPorCurso(cursoID);
                CbSeleccionarAsignaturaAct.SelectedIndexChanged -= CbSeleccionarAsignaturaAct_SelectedIndexChanged;

                CbSeleccionarAsignaturaAct.DataSource = dtAsignaturas;
                CbSeleccionarAsignaturaAct.DisplayMember = "NombreAsignatura";
                CbSeleccionarAsignaturaAct.ValueMember = "AsignaturaID";
                CbSeleccionarAsignaturaAct.SelectedIndex = -1;
                CbSeleccionarAsignaturaAct.Enabled = true;

                CbSeleccionarAsignaturaAct.SelectedIndexChanged += CbSeleccionarAsignaturaAct_SelectedIndexChanged;
                dataGridViewAct.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asignaturas para Actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Maneja el evento SelectedIndexChanged del ComboBox de asignaturas en el formulario de actualización.
        /// Filtra y muestra las asistencias registradas para el curso y asignatura seleccionados.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void CbSeleccionarAsignaturaAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbSeleccionarAsignaturaAct.SelectedIndex == -1 || CbSeleccionarAsignaturaAct.SelectedValue == null)
            {
                dataGridViewAct.DataSource = null;
                return;
            }

            try
            {
                int cursoID = Convert.ToInt32(CbSeleccionarCursoAct.SelectedValue);
                int asignaturaID = Convert.ToInt32(CbSeleccionarAsignaturaAct.SelectedValue);
                CN_Filtros objFiltros = new CN_Filtros();
                DataTable dtAsistencias = objFiltros.CN_AsistenciasPorCursoYAsignatura(cursoID, asignaturaID);

                dataGridViewAct.DataSource = dtAsistencias;
                PersonalizarDataGridViewActualizar();
                asistenciaSeleccionadaID = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar asistencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Personaliza la apariencia y configuración del DataGridView de actualización.
        /// Oculta columnas no necesarias, establece nombres de encabezados y configura propiedades de solo lectura.
        /// </summary>
        private void PersonalizarDataGridViewActualizar()
        {
            if (dataGridViewAct.DataSource == null || dataGridViewAct.Columns.Count == 0)
            {
                return;
            }
            if (dataGridViewAct.Columns.Contains("AsistenciaID"))
            {
                dataGridViewAct.Columns["AsistenciaID"].Visible = false;
            }
            if (dataGridViewAct.Columns.Contains("EstudianteID"))
            {
                dataGridViewAct.Columns["EstudianteID"].Visible = false;
            }
            if (dataGridViewAct.Columns.Contains("AsignaturaID"))
            {
                dataGridViewAct.Columns["AsignaturaID"].Visible = false;
            }
            if (dataGridViewAct.Columns.Contains("Estudiante"))
            {
                dataGridViewAct.Columns["Estudiante"].HeaderText = "Estudiante";
                dataGridViewAct.Columns["Estudiante"].ReadOnly = true;
                dataGridViewAct.Columns["Estudiante"].Width = 200;
            }
            if (dataGridViewAct.Columns.Contains("Asignatura"))
            {
                dataGridViewAct.Columns["Asignatura"].Visible = false; // Ya está filtrado
            }
            if (dataGridViewAct.Columns.Contains("FechaAsistencia"))
            {
                dataGridViewAct.Columns["FechaAsistencia"].HeaderText = "Fecha Registro";
                dataGridViewAct.Columns["FechaAsistencia"].ReadOnly = true;
                dataGridViewAct.Columns["FechaAsistencia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewAct.Columns["FechaAsistencia"].Width = 120;
            }
            if (dataGridViewAct.Columns.Contains("Estado"))
            {
                dataGridViewAct.Columns["Estado"].HeaderText = "Asistió";
                dataGridViewAct.Columns["Estado"].Width = 80;
            }
            dataGridViewAct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// Maneja el evento CurrentCellDirtyStateChanged del DataGridView de actualización.
        /// Confirma inmediatamente los cambios realizados en las celdas para habilitar la edición en tiempo real.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void dataGridViewAct_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewAct.IsCurrentCellDirty)
            {
                dataGridViewAct.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        /// <summary>
        /// Maneja el evento SelectionChanged del DataGridView de actualización.
        /// Captura el ID de la asistencia seleccionada y habilita/deshabilita el botón de actualización según corresponda.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void dataGridViewAct_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAct.DataSource == null || dataGridViewAct.SelectedRows.Count == 0)
            {
                asistenciaSeleccionadaID = 0;
                BtnActualizarAsistencia.Enabled = false;
                return;
            }
            try
            {
                DataGridViewRow row = dataGridViewAct.SelectedRows[0];

                if (row.IsNewRow)
                {
                    asistenciaSeleccionadaID = 0;
                    BtnActualizarAsistencia.Enabled = false;
                    return;
                }
                if (row.Cells["AsistenciaID"].Value != null && row.Cells["AsistenciaID"].Value != DBNull.Value)
                {
                    asistenciaSeleccionadaID = Convert.ToInt32(row.Cells["AsistenciaID"].Value);
                    BtnActualizarAsistencia.Enabled = true; // ⭐ Habilitar botón al seleccionar
                }
                else
                {
                    asistenciaSeleccionadaID = 0;
                    BtnActualizarAsistencia.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar registro: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                asistenciaSeleccionadaID = 0;
                BtnActualizarAsistencia.Enabled = false;
            }
        }
        /// <summary>
        /// Maneja el evento CellValueChanged del DataGridView de actualización.
        /// Detecta cambios en la columna de estado de asistencia y prepara el registro para actualización.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento que contiene el índice de fila y columna modificada.</param>
        private void dataGridViewAct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridViewAct.Columns.Contains("Estado") &&
                e.ColumnIndex == dataGridViewAct.Columns["Estado"].Index)
            {
                try
                {
                    DataGridViewRow row = dataGridViewAct.Rows[e.RowIndex];
                    if (row.Cells["AsistenciaID"].Value != null && row.Cells["AsistenciaID"].Value != DBNull.Value)
                    {
                        asistenciaSeleccionadaID = Convert.ToInt32(row.Cells["AsistenciaID"].Value);
                        BtnActualizarAsistencia.Enabled = true;
                        dataGridViewAct.ClearSelection();
                        row.Selected = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar cambio: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Maneja el evento Click del botón para actualizar una asistencia existente.
        /// Valida la selección, confirma con el usuario y actualiza el registro de asistencia con la fecha actual.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        /// <remarks>
        /// Muestra un diálogo de confirmación con los detalles del cambio antes de proceder.
        /// Actualiza la fecha de registro a la fecha actual del sistema.
        /// Recarga el DataGridView después de una actualización exitosa.
        /// </remarks>
        private void BtnActualizarAsistencia_Click(object sender, EventArgs e)
        {
            if (asistenciaSeleccionadaID <= 0)
            {
                MessageBox.Show("Debe seleccionar una asistencia para actualizar.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridViewAct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = dataGridViewAct.SelectedRows[0];
            try
            {
                int estudianteID = Convert.ToInt32(row.Cells["EstudianteID"].Value);
                int asignaturaID = Convert.ToInt32(row.Cells["AsignaturaID"].Value);

                object cellValue = row.Cells["Estado"].Value;
                bool nuevoEstado = (cellValue != null && cellValue != DBNull.Value) 
                    ? Convert.ToBoolean(cellValue): false;

                DateTime fechaActual = DateTime.Now.Date;
                int usuarioID = SesionUsuario.UsuarioID;
                string nombreEstudiante = row.Cells["Estudiante"].Value.ToString();
                string estadoTexto = nuevoEstado ? "ASISTIÓ" : "FALTÓ";

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de actualizar la asistencia?\n\n" +
                    $"Estudiante: {nombreEstudiante}\n" +
                    $"Nuevo Estado: {estadoTexto}\n" +
                    $"Fecha de Actualización: {fechaActual:dd/MM/yyyy}",
                    "Confirmar Actualización",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    CN_Asistencia objAsistencia = new CN_Asistencia();
                    bool exito = objAsistencia.CN_ActualizarAsistencia(
                        asistenciaSeleccionadaID,
                        estudianteID,
                        asignaturaID,
                        fechaActual, // ⭐ Fecha actual de la actualización
                        nuevoEstado,
                        usuarioID);

                    if (exito)
                    {
                        MessageBox.Show("Asistencia actualizada exitosamente.",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int cursoID = Convert.ToInt32(CbSeleccionarCursoAct.SelectedValue);
                        int asignaturaIDFiltro = Convert.ToInt32(CbSeleccionarAsignaturaAct.SelectedValue);
                        CN_Filtros objFiltros = new CN_Filtros();
                        DataTable dtAsistencias = objFiltros.CN_AsistenciasPorCursoYAsignatura(cursoID, asignaturaIDFiltro);

                        dataGridViewAct.DataSource = dtAsistencias;
                        PersonalizarDataGridViewActualizar();
                        asistenciaSeleccionadaID = 0;
                        BtnActualizarAsistencia.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("La asistencia no fue actualizada.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la asistencia: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Maneja el evento Click del botón para limpiar el formulario de actualización de asistencias.
        /// Restablece todos los campos y controles a sus valores predeterminados y deshabilita el botón de actualización.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnLimpiarFormAct_Click(object sender, EventArgs e)
        {
            CbSeleccionarCursoAct.SelectedIndex = -1;
            LimpiarAsignaturasActualizar();
            dataGridViewAct.DataSource = null;
            dataGridViewAct.Columns.Clear();
            asistenciaSeleccionadaID = 0;
            BtnActualizarAsistencia.Enabled = false;
            CbSeleccionarCursoAct.Focus();
        }
        private void dataGridViewAct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
