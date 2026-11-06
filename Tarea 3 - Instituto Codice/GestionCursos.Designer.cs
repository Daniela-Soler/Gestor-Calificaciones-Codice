namespace Tarea_3___Instituto_Codice
{
    partial class GestionCursos
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
            label4 = new Label();
            TbCreateNombreCurso = new TextBox();
            CbSeleccionCurso = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            TbUpdateNombreCurso = new TextBox();
            BtnActualizarCurso = new Button();
            BtnCrearCurso = new Button();
            BtnLimpiarFormCurso = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
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
            label1.Location = new Point(269, 36);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Cursos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 67);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // TbCreateNombreCurso
            // 
            TbCreateNombreCurso.Location = new Point(132, 64);
            TbCreateNombreCurso.Name = "TbCreateNombreCurso";
            TbCreateNombreCurso.Size = new Size(150, 31);
            TbCreateNombreCurso.TabIndex = 4;
            // 
            // CbSeleccionCurso
            // 
            CbSeleccionCurso.FormattingEnabled = true;
            CbSeleccionCurso.Location = new Point(515, 139);
            CbSeleccionCurso.Name = "CbSeleccionCurso";
            CbSeleccionCurso.Size = new Size(182, 33);
            CbSeleccionCurso.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 142);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 6;
            label5.Text = "Curso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 190);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 7;
            label6.Text = "Nombre";
            // 
            // TbUpdateNombreCurso
            // 
            TbUpdateNombreCurso.Location = new Point(515, 184);
            TbUpdateNombreCurso.Name = "TbUpdateNombreCurso";
            TbUpdateNombreCurso.Size = new Size(182, 31);
            TbUpdateNombreCurso.TabIndex = 8;
            // 
            // BtnActualizarCurso
            // 
            BtnActualizarCurso.BackColor = Color.PeachPuff;
            BtnActualizarCurso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnActualizarCurso.Location = new Point(179, 140);
            BtnActualizarCurso.Name = "BtnActualizarCurso";
            BtnActualizarCurso.Size = new Size(112, 34);
            BtnActualizarCurso.TabIndex = 9;
            BtnActualizarCurso.Text = "Actualizar";
            BtnActualizarCurso.UseVisualStyleBackColor = false;
            BtnActualizarCurso.Click += BtnActualizarCurso_Click;
            // 
            // BtnCrearCurso
            // 
            BtnCrearCurso.BackColor = Color.PeachPuff;
            BtnCrearCurso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCrearCurso.Location = new Point(170, 140);
            BtnCrearCurso.Name = "BtnCrearCurso";
            BtnCrearCurso.Size = new Size(112, 34);
            BtnCrearCurso.TabIndex = 10;
            BtnCrearCurso.Text = "Enviar";
            BtnCrearCurso.UseVisualStyleBackColor = false;
            BtnCrearCurso.Click += BtnCrearCurso_Click;
            // 
            // BtnLimpiarFormCurso
            // 
            BtnLimpiarFormCurso.BackColor = Color.PapayaWhip;
            BtnLimpiarFormCurso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLimpiarFormCurso.Location = new Point(42, 140);
            BtnLimpiarFormCurso.Name = "BtnLimpiarFormCurso";
            BtnLimpiarFormCurso.Size = new Size(112, 34);
            BtnLimpiarFormCurso.TabIndex = 11;
            BtnLimpiarFormCurso.Text = "Limpiar";
            BtnLimpiarFormCurso.UseVisualStyleBackColor = false;
            BtnLimpiarFormCurso.Click += BtnLimpiarFormCurso_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.OldLace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 325);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(538, 273);
            dataGridView1.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TbCreateNombreCurso);
            groupBox1.Controls.Add(BtnCrearCurso);
            groupBox1.Controls.Add(BtnLimpiarFormCurso);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 198);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Curso";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnLimpiarFormAct);
            groupBox2.Controls.Add(BtnActualizarCurso);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(393, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 198);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actualizar Curso";
            // 
            // BtnLimpiarFormAct
            // 
            BtnLimpiarFormAct.BackColor = Color.PapayaWhip;
            BtnLimpiarFormAct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLimpiarFormAct.Location = new Point(46, 140);
            BtnLimpiarFormAct.Name = "BtnLimpiarFormAct";
            BtnLimpiarFormAct.Size = new Size(112, 34);
            BtnLimpiarFormAct.TabIndex = 12;
            BtnLimpiarFormAct.Text = "Limpiar";
            BtnLimpiarFormAct.UseVisualStyleBackColor = false;
            BtnLimpiarFormAct.Click += BtnLimpiarFormAct_Click;
            // 
            // GestionCursos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(762, 627);
            Controls.Add(dataGridView1);
            Controls.Add(TbUpdateNombreCurso);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CbSeleccionCurso);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "GestionCursos";
            Text = "GestionCursos";
            Load += GestionCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox TbCreateNombreCurso;
        private ComboBox CbSeleccionCurso;
        private Label label5;
        private Label label6;
        private TextBox TbUpdateNombreCurso;
        private Button BtnActualizarCurso;
        private Button BtnCrearCurso;
        private Button BtnLimpiarFormCurso;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnLimpiarFormAct;
    }
}