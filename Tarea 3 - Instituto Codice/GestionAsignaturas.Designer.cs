namespace Tarea_3___Instituto_Codice
{
    partial class GestionAsignaturas
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            TbNombreCursoCrear = new TextBox();
            BtnCrearAsignatura = new Button();
            BtnLimpiarForm = new Button();
            CbSeleccionarAsignatura = new ComboBox();
            TbNombreCursoAct = new TextBox();
            BtnActualizarAsignatura = new Button();
            groupBox1 = new GroupBox();
            CbVerCursosCrear = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            CbVerCursoAct = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            BtnLimpiarFormAct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 51);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Asignaturas";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.OldLace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(228, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(498, 225);
            dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 99);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // TbNombreCursoCrear
            // 
            TbNombreCursoCrear.Location = new Point(187, 96);
            TbNombreCursoCrear.Name = "TbNombreCursoCrear";
            TbNombreCursoCrear.Size = new Size(182, 31);
            TbNombreCursoCrear.TabIndex = 4;
            // 
            // BtnCrearAsignatura
            // 
            BtnCrearAsignatura.BackColor = Color.PeachPuff;
            BtnCrearAsignatura.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCrearAsignatura.Location = new Point(228, 156);
            BtnCrearAsignatura.Name = "BtnCrearAsignatura";
            BtnCrearAsignatura.Size = new Size(112, 34);
            BtnCrearAsignatura.TabIndex = 5;
            BtnCrearAsignatura.Text = "Enviar";
            BtnCrearAsignatura.UseVisualStyleBackColor = false;
            BtnCrearAsignatura.Click += BtnCrearAsignatura_Click;
            // 
            // BtnLimpiarForm
            // 
            BtnLimpiarForm.BackColor = Color.PapayaWhip;
            BtnLimpiarForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLimpiarForm.Location = new Point(69, 156);
            BtnLimpiarForm.Name = "BtnLimpiarForm";
            BtnLimpiarForm.Size = new Size(112, 34);
            BtnLimpiarForm.TabIndex = 6;
            BtnLimpiarForm.Text = "Limpiar";
            BtnLimpiarForm.UseVisualStyleBackColor = false;
            BtnLimpiarForm.Click += BtnLimpiarForm_Click;
            // 
            // CbSeleccionarAsignatura
            // 
            CbSeleccionarAsignatura.FormattingEnabled = true;
            CbSeleccionarAsignatura.Location = new Point(214, 32);
            CbSeleccionarAsignatura.Name = "CbSeleccionarAsignatura";
            CbSeleccionarAsignatura.Size = new Size(182, 33);
            CbSeleccionarAsignatura.TabIndex = 9;
            CbSeleccionarAsignatura.SelectedIndexChanged += CbSeleccionarAsignatura_SelectedIndexChanged;
            // 
            // TbNombreCursoAct
            // 
            TbNombreCursoAct.Location = new Point(214, 114);
            TbNombreCursoAct.Name = "TbNombreCursoAct";
            TbNombreCursoAct.Size = new Size(182, 32);
            TbNombreCursoAct.TabIndex = 11;
            // 
            // BtnActualizarAsignatura
            // 
            BtnActualizarAsignatura.BackColor = Color.PeachPuff;
            BtnActualizarAsignatura.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnActualizarAsignatura.Location = new Point(242, 156);
            BtnActualizarAsignatura.Name = "BtnActualizarAsignatura";
            BtnActualizarAsignatura.Size = new Size(112, 34);
            BtnActualizarAsignatura.TabIndex = 12;
            BtnActualizarAsignatura.Text = "Actualizar";
            BtnActualizarAsignatura.UseVisualStyleBackColor = false;
            BtnActualizarAsignatura.Click += BtnActualizarAsignatura_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbVerCursosCrear);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnCrearAsignatura);
            groupBox1.Controls.Add(BtnLimpiarForm);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TbNombreCursoCrear);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(41, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 205);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Asignatura";
            // 
            // CbVerCursosCrear
            // 
            CbVerCursosCrear.FormattingEnabled = true;
            CbVerCursosCrear.Location = new Point(187, 49);
            CbVerCursosCrear.Name = "CbVerCursosCrear";
            CbVerCursosCrear.Size = new Size(182, 33);
            CbVerCursosCrear.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 52);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 16;
            label2.Text = "Seleccionar Curso";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CbVerCursoAct);
            groupBox2.Controls.Add(TbNombreCursoAct);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(BtnLimpiarFormAct);
            groupBox2.Controls.Add(CbSeleccionarAsignatura);
            groupBox2.Controls.Add(BtnActualizarAsignatura);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(481, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(433, 205);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actualizar Asignatura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 117);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 16;
            label6.Text = "Nombre";
            // 
            // CbVerCursoAct
            // 
            CbVerCursoAct.FormattingEnabled = true;
            CbVerCursoAct.Location = new Point(214, 74);
            CbVerCursoAct.Name = "CbVerCursoAct";
            CbVerCursoAct.Size = new Size(182, 33);
            CbVerCursoAct.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 77);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 16;
            label5.Text = "Seleccionar Curso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 35);
            label4.Name = "label4";
            label4.Size = new Size(190, 25);
            label4.TabIndex = 16;
            label4.Text = "Seleccionar Asignatura";
            // 
            // BtnLimpiarFormAct
            // 
            BtnLimpiarFormAct.BackColor = Color.PapayaWhip;
            BtnLimpiarFormAct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLimpiarFormAct.Location = new Point(71, 156);
            BtnLimpiarFormAct.Name = "BtnLimpiarFormAct";
            BtnLimpiarFormAct.Size = new Size(112, 34);
            BtnLimpiarFormAct.TabIndex = 16;
            BtnLimpiarFormAct.Text = "Limpiar";
            BtnLimpiarFormAct.UseVisualStyleBackColor = false;
            BtnLimpiarFormAct.Click += BtnLimpiarFormAct_Click;
            // 
            // GestionAsignaturas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(954, 613);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "GestionAsignaturas";
            Text = "GestionAsignaturas";
            Load += GestionAsignaturas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox TbNombreCursoCrear;
        private Button BtnCrearAsignatura;
        private Button BtnLimpiarForm;
        private ComboBox CbSeleccionarAsignatura;
        private TextBox TbNombreCursoAct;
        private Button BtnActualizarAsignatura;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnLimpiarFormAct;
        private ComboBox CbVerCursosCrear;
        private Label label2;
        private Label label6;
        private ComboBox CbVerCursoAct;
        private Label label5;
        private Label label4;
    }
}