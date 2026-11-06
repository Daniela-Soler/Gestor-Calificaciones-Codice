namespace Tarea_3___Instituto_Codice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            BtnCrearUsuario = new Button();
            label2 = new Label();
            label3 = new Label();
            TbCorreoUsuario = new TextBox();
            TbClaveUsuario = new TextBox();
            ConexionBD = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 103);
            label1.Name = "label1";
            label1.Size = new Size(348, 32);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido a Instituto Codice!";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Location = new Point(150, 299);
            button1.Name = "button1";
            button1.Size = new Size(141, 34);
            button1.TabIndex = 1;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnCrearUsuario
            // 
            BtnCrearUsuario.BackColor = Color.PeachPuff;
            BtnCrearUsuario.Location = new Point(351, 299);
            BtnCrearUsuario.Name = "BtnCrearUsuario";
            BtnCrearUsuario.Size = new Size(141, 34);
            BtnCrearUsuario.TabIndex = 2;
            BtnCrearUsuario.Text = "Registrarse";
            BtnCrearUsuario.UseVisualStyleBackColor = false;
            BtnCrearUsuario.Click += BtnCrearUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 179);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 218);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // TbCorreoUsuario
            // 
            TbCorreoUsuario.Location = new Point(325, 179);
            TbCorreoUsuario.Name = "TbCorreoUsuario";
            TbCorreoUsuario.Size = new Size(167, 31);
            TbCorreoUsuario.TabIndex = 5;
            // 
            // TbClaveUsuario
            // 
            TbClaveUsuario.Location = new Point(325, 218);
            TbClaveUsuario.Name = "TbClaveUsuario";
            TbClaveUsuario.PasswordChar = '•';
            TbClaveUsuario.Size = new Size(167, 31);
            TbClaveUsuario.TabIndex = 6;
            // 
            // ConexionBD
            // 
            ConexionBD.BackColor = Color.AntiqueWhite;
            ConexionBD.Location = new Point(24, 31);
            ConexionBD.Name = "ConexionBD";
            ConexionBD.Size = new Size(138, 34);
            ConexionBD.TabIndex = 7;
            ConexionBD.Text = "Conexion BD";
            ConexionBD.UseVisualStyleBackColor = false;
            ConexionBD.Click += ConexionBD_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(654, 415);
            Controls.Add(ConexionBD);
            Controls.Add(TbClaveUsuario);
            Controls.Add(TbCorreoUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnCrearUsuario);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Instituto Códice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button BtnCrearUsuario;
        private Label label2;
        private Label label3;
        private TextBox TbCorreoUsuario;
        private TextBox TbClaveUsuario;
        private Button ConexionBD;
    }
}
