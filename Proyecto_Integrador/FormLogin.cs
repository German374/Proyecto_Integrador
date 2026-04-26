using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class FormLogin : Form
    {
        string cadena = @"Server=DESKTOP-A2HL4RA\SQLDEVELOPER;Database=Proyecto_Integrador;Trusted_Connection=True;TrustServerCertificate=True;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Ingrese usuario";
            txtUsuario.ForeColor = Color.Gray;

            txtContrasena.Text = "Ingrese contraseña";
            txtContrasena.ForeColor = Color.Gray;
            txtContrasena.UseSystemPasswordChar = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.ForeColor == Color.Gray || txtContrasena.ForeColor == Color.Gray)
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();

            string query = "SELECT COUNT(*) FROM USUARIO WHERE nombre=@user AND contrasena=@pass";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Parameters.AddWithValue("@pass", contrasena);

            int count = (int)cmd.ExecuteScalar();
            cn.Close();

            if (count > 0)
            {
                MessageBox.Show("Bienvenido");

                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.ForeColor == Color.Gray)
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Ingrese usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.ForeColor == Color.Gray)
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.Text = "Ingrese contraseña";
                txtContrasena.ForeColor = Color.Gray;
            }
        }
    }
}
