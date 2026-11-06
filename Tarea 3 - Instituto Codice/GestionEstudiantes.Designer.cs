namespace Tarea_3___Instituto_Codice
{
    partial class GestionEstudiantes
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
            DgvVistaRegistrosEstudiantes = new DataGridView();
            label3 = new Label();
            TbCrearNombreEstudiante = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TbCrearApellidoEstudiante = new TextBox();
            TbCrearRutEstudiante = new TextBox();
            BtnLimpiarFormCrear = new Button();
            BtnCrearEstudiante = new Button();
            CbSeleccionarCurso = new ComboBox();
            BtnAgregarCursoCrear = new Button();
            CbSeleccionarEstudiante = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            TbActualizarNombre = new TextBox();
            TbActualizarApellido = new TextBox();
            TbActualizarRut = new TextBox();
            CbSeleccionarCursoAct = new ComboBox();
            BtnAgregarCursoAct = new Button();
            BtnLimpiarFormAct = new Button();
            BtnActualizarEstudiante = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)DgvVistaRegistrosEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(494, 36);
            label1.Name = "label1";
            label1.Size = new Size(247, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Estudiantes";
            // 
            // DgvVistaRegistrosEstudiantes
            // 
            DgvVistaRegistrosEstudiantes.BackgroundColor = Color.OldLace;
            DgvVistaRegistrosEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVistaRegistrosEstudiantes.Location = new Point(150, 496);
            DgvVistaRegistrosEstudiantes.Name = "DgvVistaRegistrosEstudiantes";
            DgvVistaRegistrosEstudiantes.RowHeadersWidth = 62;
            DgvVistaRegistrosEstudiantes.Size = new Size(946, 370);
            DgvVistaRegistrosEstudiantes.TabIndex = 1;
            DgvVistaRegistrosEstudiantes.CellContentClick += DgvVistaRegistrosEstudiantes_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 172);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // TbCrearNombreEstudiante
            // 
            TbCrearNombreEstudiante.Location = new Point(226, 169);
            TbCrearNombreEstudiante.Name = "TbCrearNombreEstudiante";
            TbCrearNombreEstudiante.Size = new Size(297, 31);
            TbCrearNombreEstudiante.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 220);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 5;
            label4.Text = "Apellido";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 264);
            label5.Name = "label5";
            label5.Size = new Size(39, 25);
            label5.TabIndex = 6;
            label5.Text = "Rut";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 321);
            label6.Name = "label6";
            label6.Size = new Size(145, 25);
            label6.TabIndex = 7;
            label6.Text = "Seleccione Curso";
            // 
            // TbCrearApellidoEstudiante
            // 
            TbCrearApellidoEstudiante.Location = new Point(226, 214);
            TbCrearApellidoEstudiante.Name = "TbCrearApellidoEstudiante";
            TbCrearApellidoEstudiante.Size = new Size(297, 31);
            TbCrearApellidoEstudiante.TabIndex = 8;
            // 
            // TbCrearRutEstudiante
            // 
            TbCrearRutEstudiante.Location = new Point(226, 261);
            TbCrearRutEstudiante.Name = "TbCrearRutEstudiante";
            TbCrearRutEstudiante.Size = new Size(297, 31);
            TbCrearRutEstudiante.TabIndex = 9;
            // 
            // BtnLimpiarFormCrear
            // 
            BtnLimpiarFormCrear.BackColor = Color.PapayaWhip;
            BtnLimpiarFormCrear.Location = new Point(126, 382);
            BtnLimpiarFormCrear.Name = "BtnLimpiarFormCrear";
            BtnLimpiarFormCrear.Size = new Size(112, 34);
            BtnLimpiarFormCrear.TabIndex = 11;
            BtnLimpiarFormCrear.Text = "Limpiar";
            BtnLimpiarFormCrear.UseVisualStyleBackColor = false;
            BtnLimpiarFormCrear.Click += BtnLimpiarFormCrear_Click;
            // 
            // BtnCrearEstudiante
            // 
            BtnCrearEstudiante.BackColor = Color.PeachPuff;
            BtnCrearEstudiante.Location = new Point(330, 382);
            BtnCrearEstudiante.Name = "BtnCrearEstudiante";
            BtnCrearEstudiante.Size = new Size(112, 34);
            BtnCrearEstudiante.TabIndex = 12;
            BtnCrearEstudiante.Text = "Enviar";
            BtnCrearEstudiante.UseVisualStyleBackColor = false;
            BtnCrearEstudiante.Click += BtnCrearEstudiante_Click;
            // 
            // CbSeleccionarCurso
            // 
            CbSeleccionarCurso.FormattingEnabled = true;
            CbSeleccionarCurso.Location = new Point(226, 318);
            CbSeleccionarCurso.Name = "CbSeleccionarCurso";
            CbSeleccionarCurso.Size = new Size(247, 33);
            CbSeleccionarCurso.TabIndex = 14;
            CbSeleccionarCurso.SelectedIndexChanged += CbSeleccionarCurso_SelectedIndexChanged;
            // 
            // BtnAgregarCursoCrear
            // 
            BtnAgregarCursoCrear.BackColor = Color.FromArgb(255, 255, 192);
            BtnAgregarCursoCrear.Location = new Point(479, 310);
            BtnAgregarCursoCrear.Name = "BtnAgregarCursoCrear";
            BtnAgregarCursoCrear.Size = new Size(44, 47);
            BtnAgregarCursoCrear.TabIndex = 15;
            BtnAgregarCursoCrear.Text = "+";
            BtnAgregarCursoCrear.UseVisualStyleBackColor = false;
            // 
            // CbSeleccionarEstudiante
            // 
            CbSeleccionarEstudiante.FormattingEnabled = true;
            CbSeleccionarEstudiante.Location = new Point(861, 156);
            CbSeleccionarEstudiante.Name = "CbSeleccionarEstudiante";
            CbSeleccionarEstudiante.Size = new Size(285, 33);
            CbSeleccionarEstudiante.TabIndex = 17;
            CbSeleccionarEstudiante.SelectedIndexChanged += CbSeleccionarEstudiante_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FloralWhite;
            label8.Location = new Point(674, 159);
            label8.Name = "label8";
            label8.Size = new Size(181, 25);
            label8.TabIndex = 18;
            label8.Text = "Seleccione Estudiante";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(674, 204);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 19;
            label9.Text = "Nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(674, 252);
            label10.Name = "label10";
            label10.Size = new Size(78, 25);
            label10.TabIndex = 20;
            label10.Text = "Apellido";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(674, 298);
            label11.Name = "label11";
            label11.Size = new Size(39, 25);
            label11.TabIndex = 21;
            label11.Text = "Rut";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(674, 344);
            label12.Name = "label12";
            label12.Size = new Size(145, 25);
            label12.TabIndex = 22;
            label12.Text = "Seleccione Curso";
            // 
            // TbActualizarNombre
            // 
            TbActualizarNombre.Location = new Point(860, 201);
            TbActualizarNombre.Name = "TbActualizarNombre";
            TbActualizarNombre.Size = new Size(286, 31);
            TbActualizarNombre.TabIndex = 23;
            // 
            // TbActualizarApellido
            // 
            TbActualizarApellido.Location = new Point(860, 249);
            TbActualizarApellido.Name = "TbActualizarApellido";
            TbActualizarApellido.Size = new Size(286, 31);
            TbActualizarApellido.TabIndex = 24;
            // 
            // TbActualizarRut
            // 
            TbActualizarRut.Location = new Point(861, 295);
            TbActualizarRut.Name = "TbActualizarRut";
            TbActualizarRut.Size = new Size(286, 31);
            TbActualizarRut.TabIndex = 25;
            // 
            // CbSeleccionarCursoAct
            // 
            CbSeleccionarCursoAct.FormattingEnabled = true;
            CbSeleccionarCursoAct.Location = new Point(862, 341);
            CbSeleccionarCursoAct.Name = "CbSeleccionarCursoAct";
            CbSeleccionarCursoAct.Size = new Size(234, 33);
            CbSeleccionarCursoAct.TabIndex = 26;
            // 
            // BtnAgregarCursoAct
            // 
            BtnAgregarCursoAct.BackColor = Color.FromArgb(255, 255, 192);
            BtnAgregarCursoAct.Location = new Point(1102, 333);
            BtnAgregarCursoAct.Name = "BtnAgregarCursoAct";
            BtnAgregarCursoAct.Size = new Size(44, 47);
            BtnAgregarCursoAct.TabIndex = 27;
            BtnAgregarCursoAct.Text = "+";
            BtnAgregarCursoAct.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiarFormAct
            // 
            BtnLimpiarFormAct.BackColor = Color.PapayaWhip;
            BtnLimpiarFormAct.Location = new Point(793, 401);
            BtnLimpiarFormAct.Name = "BtnLimpiarFormAct";
            BtnLimpiarFormAct.Size = new Size(112, 34);
            BtnLimpiarFormAct.TabIndex = 28;
            BtnLimpiarFormAct.Text = "Limpiar";
            BtnLimpiarFormAct.UseVisualStyleBackColor = false;
            // 
            // BtnActualizarEstudiante
            // 
            BtnActualizarEstudiante.BackColor = Color.PeachPuff;
            BtnActualizarEstudiante.Location = new Point(968, 401);
            BtnActualizarEstudiante.Name = "BtnActualizarEstudiante";
            BtnActualizarEstudiante.Size = new Size(112, 34);
            BtnActualizarEstudiante.TabIndex = 29;
            BtnActualizarEstudiante.Text = "Enviar";
            BtnActualizarEstudiante.UseVisualStyleBackColor = false;
            BtnActualizarEstudiante.Click += BtnActualizarEstudiante_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(626, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 343);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar Estudiante";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FloralWhite;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(41, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(551, 343);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingresar Estudiante";
            // 
            // GestionEstudiantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1250, 889);
            Controls.Add(BtnActualizarEstudiante);
            Controls.Add(BtnLimpiarFormAct);
            Controls.Add(BtnAgregarCursoAct);
            Controls.Add(CbSeleccionarCursoAct);
            Controls.Add(TbActualizarRut);
            Controls.Add(TbActualizarApellido);
            Controls.Add(TbActualizarNombre);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(CbSeleccionarEstudiante);
            Controls.Add(BtnAgregarCursoCrear);
            Controls.Add(CbSeleccionarCurso);
            Controls.Add(BtnCrearEstudiante);
            Controls.Add(BtnLimpiarFormCrear);
            Controls.Add(TbCrearRutEstudiante);
            Controls.Add(TbCrearApellidoEstudiante);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TbCrearNombreEstudiante);
            Controls.Add(label3);
            Controls.Add(DgvVistaRegistrosEstudiantes);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "GestionEstudiantes";
            Text = "Gestion de Estudiantes - Instituto Códice";
            Load += GestionEstudiantes_Load;
            ((System.ComponentModel.ISupportInitialize)DgvVistaRegistrosEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DgvVistaRegistrosEstudiantes;
        private Label label3;
        private TextBox TbCrearNombreEstudiante;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TbCrearApellidoEstudiante;
        private TextBox TbCrearRutEstudiante;
        private Button BtnLimpiarFormCrear;
        private Button BtnCrearEstudiante;
        private Button BtnReadEstudiantes;
        private ComboBox CbSeleccionarCurso;
        private Button BtnAgregarCursoCrear;
        private ComboBox CbSeleccionarEstudiante;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox TbActualizarNombre;
        private TextBox TbActualizarApellido;
        private TextBox TbActualizarRut;
        private ComboBox CbSeleccionarCursoAct;
        private Button BtnAgregarCursoAct;
        private Button BtnLimpiarFormAct;
        private Button BtnActualizarEstudiante;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}