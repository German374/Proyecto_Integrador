using System;
using System.Data;
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
            cmbSensor.Items.Clear();

            cmbSensor.Items.Add("3 - DHT11 Temperatura");
            cmbSensor.Items.Add("4 - DHT11 Humedad");
            cmbSensor.Items.Add("5 - SGP30 CO2");
            cmbSensor.Items.Add("6 - KY-037 Ruido");

            CargarMediciones();
        }

        private void btnMedir_Click(object sender, EventArgs e)
        {
            if (cmbSensor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un sensor");
                return;
            }

            if (txtResultado.Text == "")
            {
                MessageBox.Show("Ingrese un valor");
                return;
            }

            string seleccionado = cmbSensor.SelectedItem.ToString();

            int idSensor = int.Parse(seleccionado.Split('-')[0].Trim());

            double valor = double.Parse(txtResultado.Text);

            logica.InsertarMedicion(valor, idSensor);

            MessageBox.Show("Medición guardada correctamente");

            CargarMediciones();
        }

        private void btnMedir_Click_1(object sender, EventArgs e)
        {
            btnMedir_Click(sender, e);
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
