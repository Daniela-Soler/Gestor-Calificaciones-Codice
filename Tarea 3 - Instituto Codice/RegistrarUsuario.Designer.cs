namespace Tarea_3___Instituto_Codice
{
    partial class RegistrarUsuario
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TbCrearNombreUsuario = new TextBox();
            TbCrearCorreoUsuario = new TextBox();
            TbCrearClaveUsuario = new TextBox();
            BtnRegistrarUsuario = new Button();
            BtnLimpiarForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 52);
            label1.Name = "label1";
            label1.Size = new Size(226, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 130);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 187);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 246);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Clave";
            // 
            // TbCrearNombreUsuario
            // 
            TbCrearNombreUsuario.Location = new Point(191, 127);
            TbCrearNombreUsuario.Name = "TbCrearNombreUsuario";
            TbCrearNombreUsuario.Size = new Size(204, 31);
            TbCrearNombreUsuario.TabIndex = 4;
            // 
            // TbCrearCorreoUsuario
            // 
            TbCrearCorreoUsuario.Location = new Point(191, 181);
            TbCrearCorreoUsuario.Name = "TbCrearCorreoUsuario";
            TbCrearCorreoUsuario.Size = new Size(204, 31);
            TbCrearCorreoUsuario.TabIndex = 5;
            // 
            // TbCrearClaveUsuario
            // 
            TbCrearClaveUsuario.Location = new Point(191, 240);
            TbCrearClaveUsuario.Name = "TbCrearClaveUsuario";
            TbCrearClaveUsuario.Size = new Size(204, 31);
            TbCrearClaveUsuario.TabIndex = 6;
            // 
            // BtnRegistrarUsuario
            // 
            BtnRegistrarUsuario.BackColor = Color.PeachPuff;
            BtnRegistrarUsuario.Location = new Point(258, 322);
            BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            BtnRegistrarUsuario.Size = new Size(112, 34);
            BtnRegistrarUsuario.TabIndex = 7;
            BtnRegistrarUsuario.Text = "Registrar";
            BtnRegistrarUsuario.UseVisualStyleBackColor = false;
            BtnRegistrarUsuario.Click += BtnRegistrarUsuario_Click;
            // 
            // BtnLimpiarForm
            // 
            BtnLimpiarForm.BackColor = Color.PapayaWhip;
            BtnLimpiarForm.Location = new Point(99, 322);
            BtnLimpiarForm.Name = "BtnLimpiarForm";
            BtnLimpiarForm.Size = new Size(112, 34);
            BtnLimpiarForm.TabIndex = 8;
            BtnLimpiarForm.Text = "Limpiar";
            BtnLimpiarForm.UseVisualStyleBackColor = false;
            BtnLimpiarForm.Click += BtnLimpiarForm_Click;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(514, 404);
            Controls.Add(BtnLimpiarForm);
            Controls.Add(BtnRegistrarUsuario);
            Controls.Add(TbCrearClaveUsuario);
            Controls.Add(TbCrearCorreoUsuario);
            Controls.Add(TbCrearNombreUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarUsuario";
            Text = "Registrar Usuario - Instituto Códice";
            Load += RegistrarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TbCrearNombreUsuario;
        private TextBox TbCrearCorreoUsuario;
        private TextBox TbCrearClaveUsuario;
        private Button BtnRegistrarUsuario;
        private Button BtnLimpiarForm;
    }
}