using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic;

namespace Proyecto_Integrador
{
    public partial class FormMedicion : Form
    {
        LogicaMedicion logica = new LogicaMedicion();

        public FormMedicion()
        {
            InitializeComponent();
        }

        private void CargarMediciones()
        {
            dgvMediciones.DataSource = logica.MostrarMedicion();
        }

        private void FormMedicion_Load(object sender, EventArgs e)
        {
            AplicarEstilos();

            cmbSensor.Items.Clear();

            cmbSensor.Items.Add("3 - DHT11 Temperatura");
            cmbSensor.Items.Add("4 - DHT11 Humedad");
            cmbSensor.Items.Add("5 - MQ-135 Calidad del aire");
            cmbSensor.Items.Add("6 - KY-037 Ruido");

            PonerPlaceholderValor();

            CargarMediciones();
        }

        private void AplicarEstilos()
        {
            this.BackColor = Color.FromArgb(230, 240, 245);

            btnMedir.BackColor = Color.FromArgb(46, 134, 193);
            btnMedir.ForeColor = Color.White;
            btnMedir.FlatStyle = FlatStyle.Flat;
            btnMedir.FlatAppearance.BorderSize = 0;
            btnMedir.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            cmbSensor.FlatStyle = FlatStyle.Flat;
            cmbSensor.Font = new Font("Segoe UI", 9);

            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Font = new Font("Segoe UI", 9);

            dgvMediciones.BackgroundColor = Color.White;
            dgvMediciones.BorderStyle = BorderStyle.FixedSingle;
            dgvMediciones.EnableHeadersVisualStyles = false;

            dgvMediciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvMediciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMediciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            dgvMediciones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvMediciones.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMediciones.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgvMediciones.GridColor = Color.LightGray;
        }

        private void PonerPlaceholderValor()
        {
            txtResultado.Text = "Ingrese valor";
            txtResultado.ForeColor = Color.Gray;
        }

        private void btnMedir_Click(object sender, EventArgs e)
        {
            if (cmbSensor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un sensor");
                return;
            }

            if (txtResultado.ForeColor == Color.Gray || string.IsNullOrWhiteSpace(txtResultado.Text))
            {
                MessageBox.Show("Ingrese un valor");
                return;
            }

            string seleccionado = cmbSensor.SelectedItem.ToString();

            int idSensor = int.Parse(seleccionado.Split('-')[0].Trim());

            double valor;

            if (!double.TryParse(txtResultado.Text, out valor))
            {
                MessageBox.Show("Ingrese solo números en el valor");
                return;
            }

            logica.InsertarMedicion(valor, idSensor);

            MessageBox.Show("Medición guardada correctamente");

            CargarMediciones();
            PonerPlaceholderValor();
            cmbSensor.SelectedIndex = -1;
        }

        private void btnMedir_Click_1(object sender, EventArgs e)
        {
            btnMedir_Click(sender, e);
        }

        private void txtResultado_Enter(object sender, EventArgs e)
        {
            if (txtResultado.ForeColor == Color.Gray)
            {
                txtResultado.Text = "";
                txtResultado.ForeColor = Color.Black;
            }
        }

        private void txtResultado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResultado.Text))
            {
                PonerPlaceholderValor();
            }
        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)8 &&
                e.KeyChar != '.' &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIrMedicion_Click(object sender, EventArgs e)
        {
            FormSensor frm = new FormSensor();
            frm.Show();
            this.Hide();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
