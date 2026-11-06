using Negocio;
using System.Data;
using System.Drawing.Text;

namespace Tarea_3___Instituto_Codice
{
    /// <summary>
    /// Formulario principal de inicio de sesión de la aplicación Instituto CODICE.
    /// Permite a los usuarios autenticarse en el sistema y verificar la conexión con la base de datos.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Instancia de la clase de negocio para verificar la conexión con la base de datos.
        /// </summary>
        private CN_Conexion cnc = new CN_Conexion();
        /// <summary>
        /// Instancia de la clase de negocio para gestionar operaciones de usuario.
        /// </summary>
        private CN_Usuario usuario = new CN_Usuario();
        /// <summary>
        /// Inicializa una nueva instancia del formulario de inicio de sesión.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Maneja el evento Click del botón de prueba de conexión a la base de datos.
        /// Verifica si es posible conectarse a la base de datos y muestra un mensaje con el resultado.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void ConexionBD_Click(object sender, EventArgs e)
        {
            if (cnc.CN_VerificarConexion())
            {
                MessageBox.Show("Conexión Exitosa");
            }
            else
            {
                MessageBox.Show("Conexión Fallida");
            }
        }
        /// <summary>
        /// Maneja el evento Click del botón de inicio de sesión.
        /// Valida las credenciales del usuario y, si son correctas, inicia la sesión y abre el menú principal.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        /// <remarks>
        /// Si las credenciales son válidas, almacena la información del usuario en la clase SesionUsuario
        /// y abre el formulario MenuPrincipal.
        /// </remarks>
        private void button1_Click(object sender, EventArgs e) // Iniciar sesion
        {
            string correo = TbCorreoUsuario.Text.Trim();
            string clave = TbClaveUsuario.Text.Trim();

            DataTable datosUsuario = usuario.VerificarInicioSesion(correo, clave);

            if (datosUsuario.Rows.Count > 0)
            {
                int usuarioID = Convert.ToInt32(datosUsuario.Rows[0]["UsuarioID"]);
                if (usuarioID > 0)
                {
                    SesionUsuario.UsuarioID = usuarioID;
                    SesionUsuario.NombreUsuario = datosUsuario.Rows[0]["NombreUsuario"].ToString();

                    MessageBox.Show($"¡Bienvenido {SesionUsuario.NombreUsuario}!",
                        "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrecta",
                    "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Maneja el evento Click del botón para crear un nuevo usuario.
        /// Abre el formulario de registro de nuevos usuarios.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registro = new RegistrarUsuario();
            registro.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
