using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic;

namespace Proyecto_Integrador
{
    public partial class FormTipoSensor : Form
    {
        LogicaTipoSensor logica = new LogicaTipoSensor();
        int idTipo = 0;

        public FormTipoSensor()
        {
            InitializeComponent();
        }

        private void FormTipoSensor_Load(object sender, EventArgs e)
        {
            PonerPlaceholder();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvTipoSensor.DataSource = logica.MostrarTipoSensor();
        }

        private void PonerPlaceholder()
        {
            txtNombreTipo.Text = "Ingrese nombre (ej: DHT11)";
            txtNombreTipo.ForeColor = Color.Gray;

            txtVariable.Text = "Ingrese variable (ej: Temperatura)";
            txtVariable.ForeColor = Color.Gray;

            txtUnidad.Text = "Ingrese unidad (ej: °C, ppm, dB)";
            txtUnidad.ForeColor = Color.Gray;
        }

        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            if (txtNombreTipo.ForeColor == Color.Gray || txtVariable.ForeColor == Color.Gray || txtUnidad.ForeColor == Color.Gray)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            logica.InsertarTipoSensor(txtNombreTipo.Text, txtVariable.Text, txtUnidad.Text);

            MessageBox.Show("Datos guardados correctamente");

            CargarDatos();
            Limpiar();
        }

        private void btnEditarTipo_Click(object sender, EventArgs e)
        {
            if (idTipo == 0)
            {
                MessageBox.Show("Seleccione un registro para editar");
                return;
            }

            if (txtNombreTipo.ForeColor == Color.Gray || txtVariable.ForeColor == Color.Gray || txtUnidad.ForeColor == Color.Gray)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            logica.EditarTipoSensor(idTipo, txtNombreTipo.Text, txtVariable.Text, txtUnidad.Text);

            MessageBox.Show("Datos actualizados correctamente");

            CargarDatos();
            Limpiar();
        }

        private void btnEliminarTS_Click(object sender, EventArgs e)
        {
            if (dgvTipoSensor.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un tipo de sensor");
                return;
            }

            int idTipo = Convert.ToInt32(dgvTipoSensor.CurrentRow.Cells["idTipo"].Value);

            logica.EliminarTipoSensor(idTipo);

            MessageBox.Show("Tipo de sensor eliminado correctamente");

            CargarDatos();
            Limpiar();
        }

        // 🔥 CORREGIDO AQUÍ (YA NO USA nombre/variable/unidad)
        private void dgvTipoSensor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idTipo = Convert.ToInt32(dgvTipoSensor.Rows[e.RowIndex].Cells["idTipo"].Value);

                string descripcion = dgvTipoSensor.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();

                string[] partes = descripcion.Split('-');

                if (partes.Length >= 2)
                {
                    txtNombreTipo.Text = partes[0].Trim();
                    txtNombreTipo.ForeColor = Color.Black;

                    string resto = partes[1].Trim();

                    int inicio = resto.IndexOf("(");
                    int fin = resto.IndexOf(")");

                    if (inicio >= 0 && fin > inicio)
                    {
                        txtVariable.Text = resto.Substring(0, inicio).Trim();
                        txtUnidad.Text = resto.Substring(inicio + 1, fin - inicio - 1).Trim();
                    }
                    else
                    {
                        txtVariable.Text = resto;
                        txtUnidad.Text = "";
                    }

                    txtVariable.ForeColor = Color.Black;
                    txtUnidad.ForeColor = Color.Black;
                }
            }
        }

        private void Limpiar()
        {
            PonerPlaceholder();
            idTipo = 0;
        }

        private void btnSensor_Click(object sender, EventArgs e)
        {
            FormSensor form = new FormSensor();
            form.Show();
        }

        // ================= PLACEHOLDERS =================

        private void txtNombreTipo_Enter(object sender, EventArgs e)
        {
            if (txtNombreTipo.ForeColor == Color.Gray)
            {
                txtNombreTipo.Text = "";
                txtNombreTipo.ForeColor = Color.Black;
            }
        }

        private void txtNombreTipo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreTipo.Text))
            {
                txtNombreTipo.Text = "Ingrese nombre (ej: DHT11)";
                txtNombreTipo.ForeColor = Color.Gray;
            }
        }

        private void txtVariable_Enter(object sender, EventArgs e)
        {
            if (txtVariable.ForeColor == Color.Gray)
            {
                txtVariable.Text = "";
                txtVariable.ForeColor = Color.Black;
            }
        }

        private void txtVariable_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVariable.Text))
            {
                txtVariable.Text = "Ingrese variable (ej: Temperatura)";
                txtVariable.ForeColor = Color.Gray;
            }
        }

        private void txtUnidad_Enter(object sender, EventArgs e)
        {
            if (txtUnidad.ForeColor == Color.Gray)
            {
                txtUnidad.Text = "";
                txtUnidad.ForeColor = Color.Black;
            }
        }

        private void txtUnidad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnidad.Text))
            {
                txtUnidad.Text = "Ingrese unidad (ej: °C, ppm, dB)";
                txtUnidad.ForeColor = Color.Gray;
            }
        }
    }
}