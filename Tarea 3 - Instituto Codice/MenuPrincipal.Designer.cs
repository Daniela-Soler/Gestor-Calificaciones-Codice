namespace Tarea_3___Instituto_Codice
{
    partial class MenuPrincipal
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
            button1 = new Button();
            button2 = new Button();
            BtnGestionAsistencia = new Button();
            BtnGestionCalificaciones = new Button();
            BtnGestionCursos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 50);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "Menú Principal";
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Location = new Point(66, 121);
            button1.Name = "button1";
            button1.Size = new Size(244, 34);
            button1.TabIndex = 1;
            button1.Text = "Gestión de Estudiantes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PeachPuff;
            button2.Location = new Point(66, 179);
            button2.Name = "button2";
            button2.Size = new Size(244, 34);
            button2.TabIndex = 2;
            button2.Text = "Gestión de Asignaturas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BtnGestionAsistencia
            // 
            BtnGestionAsistencia.BackColor = Color.PeachPuff;
            BtnGestionAsistencia.Location = new Point(350, 212);
            BtnGestionAsistencia.Name = "BtnGestionAsistencia";
            BtnGestionAsistencia.Size = new Size(244, 34);
            BtnGestionAsistencia.TabIndex = 3;
            BtnGestionAsistencia.Text = "Gestión de Asistencia";
            BtnGestionAsistencia.UseVisualStyleBackColor = false;
            BtnGestionAsistencia.Click += BtnGestionAsistencia_Click;
            // 
            // BtnGestionCalificaciones
            // 
            BtnGestionCalificaciones.BackColor = Color.PeachPuff;
            BtnGestionCalificaciones.Location = new Point(350, 148);
            BtnGestionCalificaciones.Name = "BtnGestionCalificaciones";
            BtnGestionCalificaciones.Size = new Size(244, 34);
            BtnGestionCalificaciones.TabIndex = 4;
            BtnGestionCalificaciones.Text = "Gestión de Calificaciones";
            BtnGestionCalificaciones.UseVisualStyleBackColor = false;
            BtnGestionCalificaciones.Click += BtnGestionCalificaciones_Click;
            // 
            // BtnGestionCursos
            // 
            BtnGestionCursos.BackColor = Color.PeachPuff;
            BtnGestionCursos.Location = new Point(66, 238);
            BtnGestionCursos.Name = "BtnGestionCursos";
            BtnGestionCursos.Size = new Size(244, 34);
            BtnGestionCursos.TabIndex = 5;
            BtnGestionCursos.Text = "Gestión de Cursos";
            BtnGestionCursos.UseVisualStyleBackColor = false;
            BtnGestionCursos.Click += BtnGestionCursos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(661, 345);
            Controls.Add(BtnGestionCursos);
            Controls.Add(BtnGestionCalificaciones);
            Controls.Add(BtnGestionAsistencia);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            Text = "Menú Principal - Instituto Códice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button BtnGestionAsistencia;
        private Button BtnGestionCalificaciones;
        private Button BtnGestionCursos;
    }
}