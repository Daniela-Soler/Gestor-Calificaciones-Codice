namespace Tarea_3___Instituto_Codice
{
    partial class GestionCalificaciones
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
            BtnCrearCalificacion = new Button();
            BtnLimpiarFormCrear = new Button();
            McFechaCrear = new MonthCalendar();
            TbNotaCrear = new TextBox();
            CbAsignaturaCrear = new ComboBox();
            CbEstudianteCrear = new ComboBox();
            CbCursoCrear = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label13 = new Label();
            groupBox3 = new GroupBox();
            TbCalificacionAct = new TextBox();
            TbAsignaturaAct = new TextBox();
            CbSeleccionarAsignaturaAct = new ComboBox();
            TbEstudianteAct = new TextBox();
            CbSeleccionarCursoAct = new ComboBox();
            BtnActualizarCalificacion = new Button();
            BtnLimpiarFormAct = new Button();
            label8 = new Label();
            label11 = new Label();
            label9 = new Label();
            DtpFechaAct = new DateTimePicker();
            label10 = new Label();
            TbNotasAct = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(502, 42);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Calificaciones";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnCrearCalificacion);
            groupBox1.Controls.Add(BtnLimpiarFormCrear);
            groupBox1.Controls.Add(McFechaCrear);
            groupBox1.Controls.Add(TbNotaCrear);
            groupBox1.Controls.Add(CbAsignaturaCrear);
            groupBox1.Controls.Add(CbEstudianteCrear);
            groupBox1.Controls.Add(CbCursoCrear);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 573);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Calificación";
            // 
            // BtnCrearCalificacion
            // 
            BtnCrearCalificacion.BackColor = Color.PeachPuff;
            BtnCrearCalificacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCrearCalificacion.Location = new Point(285, 513);
            BtnCrearCalificacion.Name = "BtnCrearCalificacion";
            BtnCrearCalificacion.Size = new Size(112, 34);
            BtnCrearCalificacion.TabIndex = 9;
            BtnCrearCalificacion.Text = "Ingresar";
            BtnCrearCalificacion.UseVisualStyleBackColor = false;
            BtnCrearCalificacion.Click += BtnCrearCalificacion_Click;
            // 
            // BtnLimpiarFormCrear
            // 
            BtnLimpiarFormCrear.BackColor = Color.PapayaWhip;
            BtnLimpiarFormCrear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLimpiarFormCrear.Location = new Point(78, 513);
            BtnLimpiarFormCrear.Name = "BtnLimpiarFormCrear";
            BtnLimpiarFormCrear.Size = new Size(112, 34);
            BtnLimpiarFormCrear.TabIndex = 2;
            BtnLimpiarFormCrear.Text = "Limpiar";
            BtnLimpiarFormCrear.UseVisualStyleBackColor = false;
            BtnLimpiarFormCrear.Click += BtnLimpiarFormCrear_Click;
            // 
            // McFechaCrear
            // 
            McFechaCrear.Location = new Point(78, 239);
            McFechaCrear.MaxSelectionCount = 1;
            McFechaCrear.Name = "McFechaCrear";
            McFechaCrear.TabIndex = 2;
            // 
            // TbNotaCrear
            // 
            TbNotaCrear.Location = new Point(243, 166);
            TbNotaCrear.Name = "TbNotaCrear";
            TbNotaCrear.Size = new Size(182, 32);
            TbNotaCrear.TabIndex = 2;
            // 
            // CbAsignaturaCrear
            // 
            CbAsignaturaCrear.FormattingEnabled = true;
            CbAsignaturaCrear.Location = new Point(243, 127);
            CbAsignaturaCrear.Name = "CbAsignaturaCrear";
            CbAsignaturaCrear.Size = new Size(182, 33);
            CbAsignaturaCrear.TabIndex = 8;
            // 
            // CbEstudianteCrear
            // 
            CbEstudianteCrear.FormattingEnabled = true;
            CbEstudianteCrear.Location = new Point(243, 87);
            CbEstudianteCrear.Name = "CbEstudianteCrear";
            CbEstudianteCrear.Size = new Size(182, 33);
            CbEstudianteCrear.TabIndex = 7;
            CbEstudianteCrear.SelectedIndexChanged += CbEstudianteCrear_SelectedIndexChanged;
            // 
            // CbCursoCrear
            // 
            CbCursoCrear.FormattingEnabled = true;
            CbCursoCrear.Location = new Point(243, 46);
            CbCursoCrear.Name = "CbCursoCrear";
            CbCursoCrear.Size = new Size(182, 33);
            CbCursoCrear.TabIndex = 6;
            CbCursoCrear.SelectedIndexChanged += CbCursoCrear_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 205);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 2;
            label6.Text = "Fecha Ingreso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 169);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 5;
            label5.Text = "Nota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 130);
            label4.Name = "label4";
            label4.Size = new Size(190, 25);
            label4.TabIndex = 4;
            label4.Text = "Seleccionar Asignatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 90);
            label3.Name = "label3";
            label3.Size = new Size(187, 25);
            label3.TabIndex = 3;
            label3.Text = "Seleccionar Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 49);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 2;
            label2.Text = "Seleccionar Curso";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.OldLace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(584, 188);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(621, 296);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 46);
            label7.Name = "label7";
            label7.Size = new Size(151, 25);
            label7.TabIndex = 4;
            label7.Text = "Seleccionar Curso";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(326, 49);
            label13.Name = "label13";
            label13.Size = new Size(190, 25);
            label13.TabIndex = 6;
            label13.Text = "Seleccionar Asignatura";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TbCalificacionAct);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(TbAsignaturaAct);
            groupBox3.Controls.Add(CbSeleccionarAsignaturaAct);
            groupBox3.Controls.Add(TbEstudianteAct);
            groupBox3.Controls.Add(CbSeleccionarCursoAct);
            groupBox3.Controls.Add(BtnActualizarCalificacion);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(BtnLimpiarFormAct);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(DtpFechaAct);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(552, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(688, 573);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar Calificación";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // TbCalificacionAct
            // 
            TbCalificacionAct.Enabled = false;
            TbCalificacionAct.Location = new Point(89, 454);
            TbCalificacionAct.Name = "TbCalificacionAct";
            TbCalificacionAct.Size = new Size(60, 32);
            TbCalificacionAct.TabIndex = 15;
            // 
            // TbAsignaturaAct
            // 
            TbAsignaturaAct.Enabled = false;
            TbAsignaturaAct.Location = new Point(458, 405);
            TbAsignaturaAct.Name = "TbAsignaturaAct";
            TbAsignaturaAct.ReadOnly = true;
            TbAsignaturaAct.Size = new Size(195, 32);
            TbAsignaturaAct.TabIndex = 14;
            // 
            // CbSeleccionarAsignaturaAct
            // 
            CbSeleccionarAsignaturaAct.Enabled = false;
            CbSeleccionarAsignaturaAct.FormattingEnabled = true;
            CbSeleccionarAsignaturaAct.Location = new Point(522, 43);
            CbSeleccionarAsignaturaAct.Name = "CbSeleccionarAsignaturaAct";
            CbSeleccionarAsignaturaAct.Size = new Size(131, 33);
            CbSeleccionarAsignaturaAct.TabIndex = 7;
            CbSeleccionarAsignaturaAct.SelectedIndexChanged += CbSeleccionarAsignaturaAct_SelectedIndexChanged;
            // 
            // TbEstudianteAct
            // 
            TbEstudianteAct.Enabled = false;
            TbEstudianteAct.Location = new Point(132, 405);
            TbEstudianteAct.Name = "TbEstudianteAct";
            TbEstudianteAct.ReadOnly = true;
            TbEstudianteAct.Size = new Size(188, 32);
            TbEstudianteAct.TabIndex = 13;
            // 
            // CbSeleccionarCursoAct
            // 
            CbSeleccionarCursoAct.FormattingEnabled = true;
            CbSeleccionarCursoAct.Location = new Point(189, 46);
            CbSeleccionarCursoAct.Name = "CbSeleccionarCursoAct";
            CbSeleccionarCursoAct.Size = new Size(131, 33);
            CbSeleccionarCursoAct.TabIndex = 5;
            CbSeleccionarCursoAct.SelectedIndexChanged += CbSeleccionarCursoAct_SelectedIndexChanged;
            // 
            // BtnActualizarCalificacion
            // 
            BtnActualizarCalificacion.BackColor = Color.PeachPuff;
            BtnActualizarCalificacion.Enabled = false;
            BtnActualizarCalificacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnActualizarCalificacion.Location = new Point(389, 513);
            BtnActualizarCalificacion.Name = "BtnActualizarCalificacion";
            BtnActualizarCalificacion.Size = new Size(112, 34);
            BtnActualizarCalificacion.TabIndex = 11;
            BtnActualizarCalificacion.Text = "Actualizar";
            BtnActualizarCalificacion.UseVisualStyleBackColor = false;
            BtnActualizarCalificacion.Click += BtnActualizarCalificacion_Click;
            // 
            // BtnLimpiarFormAct
            // 
            BtnLimpiarFormAct.BackColor = Color.PapayaWhip;
            BtnLimpiarFormAct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLimpiarFormAct.Location = new Point(184, 513);
            BtnLimpiarFormAct.Name = "BtnLimpiarFormAct";
            BtnLimpiarFormAct.Size = new Size(112, 34);
            BtnLimpiarFormAct.TabIndex = 10;
            BtnLimpiarFormAct.Text = "Limpiar";
            BtnLimpiarFormAct.UseVisualStyleBackColor = false;
            BtnLimpiarFormAct.Click += BtnLimpiarFormAct_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 408);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 1;
            label8.Text = "Estudiante";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(169, 458);
            label11.Name = "label11";
            label11.Size = new Size(127, 25);
            label11.TabIndex = 5;
            label11.Text = "Fecha Registro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(355, 408);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 2;
            label9.Text = "Asignatura";
            // 
            // DtpFechaAct
            // 
            DtpFechaAct.Enabled = false;
            DtpFechaAct.Location = new Point(302, 454);
            DtpFechaAct.Name = "DtpFechaAct";
            DtpFechaAct.Size = new Size(351, 32);
            DtpFechaAct.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(32, 458);
            label10.Name = "label10";
            label10.Size = new Size(51, 25);
            label10.TabIndex = 3;
            label10.Text = "Nota";
            // 
            // TbNotasAct
            // 
            TbNotasAct.Location = new Point(89, 455);
            TbNotasAct.Name = "TbNotasAct";
            TbNotasAct.Size = new Size(56, 31);
            TbNotasAct.TabIndex = 15;
            // 
            // GestionCalificaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1280, 687);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Name = "GestionCalificaciones";
            Text = "Gestión de Calificaciones - Instituto Códice";
            Load += GestionCalificaciones_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button BtnCrearCalificacion;
        private Button BtnLimpiarFormCrear;
        private MonthCalendar McFechaCrear;
        private TextBox TbNotaCrear;
        private ComboBox CbAsignaturaCrear;
        private ComboBox CbEstudianteCrear;
        private ComboBox CbCursoCrear;
        private DataGridView dataGridView1;
        private ComboBox TbNotaAct;
        private Label label7;
        private Label label13;
        private GroupBox groupBox3;
        private ComboBox CbSeleccionarAsignaturaAct;
        private ComboBox CbSeleccionarCursoAct;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker DtpFechaAct;
        private Label label11;
        private Button BtnLimpiarFormAct;
        private Button BtnActualizarCalificacion;
        private TextBox TbEstudianteAct;
        private TextBox TbAsignaturaAct;
        private TextBox TbNotasAct;
        private TextBox TbCalificacionAct;
    }
}