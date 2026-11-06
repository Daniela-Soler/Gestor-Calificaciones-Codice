namespace Tarea_3___Instituto_Codice
{
    partial class GestionAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            BtnIngresarAsistencia = new Button();
            BtnLimpiarFormCrear = new Button();
            DtpFechaCrear = new DateTimePicker();
            label4 = new Label();
            CbSeleccionarAsignaturaCrear = new ComboBox();
            CbSeleccionarCursoCrear = new ComboBox();
            dataGridViewCrear = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            BtnActualizarAsistencia = new Button();
            BtnLimpiarFormAct = new Button();
            dataGridViewAct = new DataGridView();
            CbSeleccionarAsignaturaAct = new ComboBox();
            label6 = new Label();
            CbSeleccionarCursoAct = new ComboBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCrear).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(503, 44);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Asistencia";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnIngresarAsistencia);
            groupBox1.Controls.Add(BtnLimpiarFormCrear);
            groupBox1.Controls.Add(DtpFechaCrear);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CbSeleccionarAsignaturaCrear);
            groupBox1.Controls.Add(CbSeleccionarCursoCrear);
            groupBox1.Controls.Add(dataGridViewCrear);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 522);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Asistencia";
            // 
            // BtnIngresarAsistencia
            // 
            BtnIngresarAsistencia.BackColor = Color.PeachPuff;
            BtnIngresarAsistencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIngresarAsistencia.Location = new Point(344, 464);
            BtnIngresarAsistencia.Name = "BtnIngresarAsistencia";
            BtnIngresarAsistencia.Size = new Size(112, 34);
            BtnIngresarAsistencia.TabIndex = 2;
            BtnIngresarAsistencia.Text = "Enviar";
            BtnIngresarAsistencia.UseVisualStyleBackColor = false;
            BtnIngresarAsistencia.Click += BtnIngresarAsistencia_Click;
            // 
            // BtnLimpiarFormCrear
            // 
            BtnLimpiarFormCrear.BackColor = Color.PapayaWhip;
            BtnLimpiarFormCrear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLimpiarFormCrear.Location = new Point(104, 464);
            BtnLimpiarFormCrear.Name = "BtnLimpiarFormCrear";
            BtnLimpiarFormCrear.Size = new Size(112, 34);
            BtnLimpiarFormCrear.TabIndex = 2;
            BtnLimpiarFormCrear.Text = "Limpiar";
            BtnLimpiarFormCrear.UseVisualStyleBackColor = false;
            BtnLimpiarFormCrear.Click += BtnLimpiarFormCrear_Click;
            // 
            // DtpFechaCrear
            // 
            DtpFechaCrear.Location = new Point(172, 403);
            DtpFechaCrear.Name = "DtpFechaCrear";
            DtpFechaCrear.Size = new Size(349, 32);
            DtpFechaCrear.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 404);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 3;
            label4.Text = "Fecha Registro";
            // 
            // CbSeleccionarAsignaturaCrear
            // 
            CbSeleccionarAsignaturaCrear.FormattingEnabled = true;
            CbSeleccionarAsignaturaCrear.Location = new Point(276, 89);
            CbSeleccionarAsignaturaCrear.Name = "CbSeleccionarAsignaturaCrear";
            CbSeleccionarAsignaturaCrear.Size = new Size(221, 33);
            CbSeleccionarAsignaturaCrear.TabIndex = 2;
            CbSeleccionarAsignaturaCrear.SelectedIndexChanged += CbSeleccionarAsignaturaCrear_SelectedIndexChanged;
            // 
            // CbSeleccionarCursoCrear
            // 
            CbSeleccionarCursoCrear.FormattingEnabled = true;
            CbSeleccionarCursoCrear.Location = new Point(276, 45);
            CbSeleccionarCursoCrear.Name = "CbSeleccionarCursoCrear";
            CbSeleccionarCursoCrear.Size = new Size(221, 33);
            CbSeleccionarCursoCrear.TabIndex = 2;
            CbSeleccionarCursoCrear.SelectedIndexChanged += CbSeleccionarCursoCrear_SelectedIndexChanged;
            // 
            // dataGridViewCrear
            // 
            dataGridViewCrear.BackgroundColor = Color.OldLace;
            dataGridViewCrear.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCrear.Location = new Point(39, 149);
            dataGridViewCrear.Name = "dataGridViewCrear";
            dataGridViewCrear.RowHeadersWidth = 62;
            dataGridViewCrear.Size = new Size(482, 225);
            dataGridViewCrear.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 92);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 2;
            label3.Text = "Seleccionar Asignatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 48);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 2;
            label2.Text = "Seleccionar Curso";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnActualizarAsistencia);
            groupBox2.Controls.Add(BtnLimpiarFormAct);
            groupBox2.Controls.Add(dataGridViewAct);
            groupBox2.Controls.Add(CbSeleccionarAsignaturaAct);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CbSeleccionarCursoAct);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(629, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(553, 522);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actualizar Asistencia";
            // 
            // BtnActualizarAsistencia
            // 
            BtnActualizarAsistencia.BackColor = Color.PeachPuff;
            BtnActualizarAsistencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnActualizarAsistencia.Location = new Point(329, 464);
            BtnActualizarAsistencia.Name = "BtnActualizarAsistencia";
            BtnActualizarAsistencia.Size = new Size(112, 34);
            BtnActualizarAsistencia.TabIndex = 3;
            BtnActualizarAsistencia.Text = "Enviar";
            BtnActualizarAsistencia.UseVisualStyleBackColor = false;
            BtnActualizarAsistencia.Click += BtnActualizarAsistencia_Click;
            // 
            // BtnLimpiarFormAct
            // 
            BtnLimpiarFormAct.BackColor = Color.PapayaWhip;
            BtnLimpiarFormAct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLimpiarFormAct.Location = new Point(108, 464);
            BtnLimpiarFormAct.Name = "BtnLimpiarFormAct";
            BtnLimpiarFormAct.Size = new Size(112, 34);
            BtnLimpiarFormAct.TabIndex = 3;
            BtnLimpiarFormAct.Text = "Limpiar";
            BtnLimpiarFormAct.UseVisualStyleBackColor = false;
            BtnLimpiarFormAct.Click += BtnLimpiarFormAct_Click;
            // 
            // dataGridViewAct
            // 
            dataGridViewAct.BackgroundColor = Color.OldLace;
            dataGridViewAct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAct.Location = new Point(30, 149);
            dataGridViewAct.Name = "dataGridViewAct";
            dataGridViewAct.RowHeadersWidth = 62;
            dataGridViewAct.Size = new Size(482, 286);
            dataGridViewAct.TabIndex = 4;
            dataGridViewAct.CellContentClick += dataGridViewAct_CellContentClick;
            // 
            // CbSeleccionarAsignaturaAct
            // 
            CbSeleccionarAsignaturaAct.FormattingEnabled = true;
            CbSeleccionarAsignaturaAct.Location = new Point(255, 94);
            CbSeleccionarAsignaturaAct.Name = "CbSeleccionarAsignaturaAct";
            CbSeleccionarAsignaturaAct.Size = new Size(215, 33);
            CbSeleccionarAsignaturaAct.TabIndex = 3;
            CbSeleccionarAsignaturaAct.SelectedIndexChanged += CbSeleccionarAsignaturaAct_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 97);
            label6.Name = "label6";
            label6.Size = new Size(190, 25);
            label6.TabIndex = 3;
            label6.Text = "Seleccionar Asignatura";
            // 
            // CbSeleccionarCursoAct
            // 
            CbSeleccionarCursoAct.FormattingEnabled = true;
            CbSeleccionarCursoAct.Location = new Point(255, 45);
            CbSeleccionarCursoAct.Name = "CbSeleccionarCursoAct";
            CbSeleccionarCursoAct.Size = new Size(215, 33);
            CbSeleccionarCursoAct.TabIndex = 3;
            CbSeleccionarCursoAct.SelectedIndexChanged += CbSeleccionarCursoAct_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 48);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 3;
            label5.Text = "Seleccionar Curso";
            // 
            // GestionAsistencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1216, 652);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "GestionAsistencia";
            Text = "GestionAsistencia";
            Load += GestionAsistencia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCrear).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox CbSeleccionarCursoCrear;
        private DataGridView dataGridViewCrear;
        private Label label3;
        private Label label2;
        private Button BtnIngresarAsistencia;
        private Button BtnLimpiarFormCrear;
        private DateTimePicker DtpFechaCrear;
        private Label label4;
        private ComboBox CbSeleccionarAsignaturaCrear;
        private GroupBox groupBox2;
        private Button BtnActualizarAsistencia;
        private Button BtnLimpiarFormAct;
        private DataGridView dataGridViewAct;
        private ComboBox CbSeleccionarAsignaturaAct;
        private Label label6;
        private ComboBox CbSeleccionarCursoAct;
        private Label label5;
    }
}