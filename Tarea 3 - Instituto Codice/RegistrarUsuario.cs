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
    public partial class RegistrarUsuario : Form
    {
        private CN_Usuario objUsuario = new CN_Usuario();
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = TbCrearNombreUsuario.Text.Trim();
            string correo = TbCrearCorreoUsuario.Text.Trim();
            string clave = TbCrearClaveUsuario.Text.Trim();

            bool verificacion = objUsuario.IngresarUsuario(nombre, correo, clave);

            if (verificacion)
            {
                MessageBox.Show("Usuario registrado con éxito",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al registrar un usuario",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void BtnLimpiarForm_Click(object sender, EventArgs e)
        {
            TbCrearNombreUsuario.Clear();
            TbCrearCorreoUsuario.Clear();
            TbCrearClaveUsuario.Clear();
            TbCrearNombreUsuario.Focus();
        }
    }
}
