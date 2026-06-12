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
            // COLOR DEL FORM
            this.BackColor = Color.FromArgb(230, 240, 245);

            // BOTONES
            btnGuardar.BackColor = Color.FromArgb(46, 134, 193);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;

            btnEditar.BackColor = Color.FromArgb(52, 152, 219);
            btnEditar.ForeColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Flat;

            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;

            btnTipoSensor.BackColor = Color.FromArgb(39, 174, 96);
            btnTipoSensor.ForeColor = Color.White;
            btnTipoSensor.FlatStyle = FlatStyle.Flat;

            // TEXTBOX
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtUbicacion.BorderStyle = BorderStyle.FixedSingle;

            // DATAGRIDVIEW
            dgvAula.BackgroundColor = Color.White;
            dgvAula.BorderStyle = BorderStyle.FixedSingle;
            dgvAula.EnableHeadersVisualStyles = false;

            dgvAula.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvAula.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAula.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            dgvAula.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvAula.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAula.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgvAula.GridColor = Color.LightGray;

            // TU CÓDIGO
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
            if (txtNombre.ForeColor == Color.Gray || txtUbicacion.ForeColor == Color.Gray ||
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUbicacion.Text))
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

            if (txtNombre.ForeColor == Color.Gray || txtUbicacion.ForeColor == Color.Gray ||
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUbicacion.Text))
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

        // VALIDACIÓN: nombre del aula permite letras, números y espacios
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        // VALIDACIÓN: ubicación solo permite letras y espacios
        private void txtUbicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnTipoSensor_Click(object sender, EventArgs e)
        {
            FormTipoSensor form = new FormTipoSensor();
            form.Show();
        }
    }
}