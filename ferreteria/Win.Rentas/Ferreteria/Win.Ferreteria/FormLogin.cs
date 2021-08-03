
using BL.Rentas;
using System;
using System.Windows.Forms;

namespace Win.Ferreteria
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        
        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "Verificando...";
            Application.DoEvents();

          var usuarioDB = _seguridad.Autorizar(usuario, contrasena);

            if (usuarioDB != null)
            {
                Program.UsuarioLogueado = usuarioDB;

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            button1.Enabled = true;
            button1.Text = "Aceptar";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (e.KeyChar == Convert.ToChar(Keys.Enter)
                && !string.IsNullOrEmpty(textBox1.Text))
                {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
               && !string.IsNullOrEmpty(textBox2.Text))
            {
                button1.PerformClick();
            }
        }
    }
}
