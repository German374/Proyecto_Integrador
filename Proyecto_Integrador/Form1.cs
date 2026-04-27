using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic;

namespace Proyecto_Integrador
{
    public partial class Form1 : Form
    {
        LogicaAula logica = new LogicaAula();
        int idAula = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Placeholder inicial
            txtNombre.Text = "Ingrese nombre del aula";
            txtNombre.ForeColor = Color.Gray;

            txtUbicacion.Text = "Ingrese ubicación";
            txtUbicacion.ForeColor = Color.Gray;

            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvAula.DataSource = logica.MostrarAula();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.ForeColor == Color.Gray || txtUbicacion.ForeColor == Color.Gray)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            logica.InsertarAula(txtNombre.Text, txtUbicacion.Text);

            MessageBox.Show("Datos guardados correctamente");

            CargarDatos();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idAula == 0)
            {
                MessageBox.Show("Seleccione un aula para editar");
                return;
            }

            if (txtNombre.ForeColor == Color.Gray || txtUbicacion.ForeColor == Color.Gray)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            logica.EditarAula(idAula, txtNombre.Text, txtUbicacion.Text);

            MessageBox.Show("Datos actualizados correctamente");

            CargarDatos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idAula == 0)
            {
                MessageBox.Show("Seleccione un aula para eliminar");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar esta aula?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                logica.EliminarAula(idAula);

                MessageBox.Show("Aula eliminada correctamente");

                CargarDatos();
                Limpiar();
            }
        }

        private void dgvAula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idAula = Convert.ToInt32(dgvAula.Rows[e.RowIndex].Cells["idAula"].Value);

                txtNombre.Text = dgvAula.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtNombre.ForeColor = Color.Black;

                txtUbicacion.Text = dgvAula.Rows[e.RowIndex].Cells["ubicacion"].Value.ToString();
                txtUbicacion.ForeColor = Color.Black;
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "Ingrese nombre del aula";
            txtNombre.ForeColor = Color.Gray;

            txtUbicacion.Text = "Ingrese ubicación";
            txtUbicacion.ForeColor = Color.Gray;

            idAula = 0;
        }

        // PLACEHOLDER NOMBRE
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.ForeColor == Color.Gray)
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Ingrese nombre del aula";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        // PLACEHOLDER UBICACION
        private void txtUbicacion_Enter(object sender, EventArgs e)
        {
            if (txtUbicacion.ForeColor == Color.Gray)
            {
                txtUbicacion.Text = "";
                txtUbicacion.ForeColor = Color.Black;
            }
        }

        private void txtUbicacion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                txtUbicacion.Text = "Ingrese ubicación";
                txtUbicacion.ForeColor = Color.Gray;
            }
        }

        private void btnTipoSensor_Click(object sender, EventArgs e)
        {
            FormTipoSensor form = new FormTipoSensor();
            form.Show();
        }
    }
}