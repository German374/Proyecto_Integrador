using BusinessLogic;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class FormSensor : Form
    {
        LogicaSensor logica = new LogicaSensor();
        LogicaAula logicaAula = new LogicaAula();
        LogicaTipoSensor logicaTipo = new LogicaTipoSensor();

        public FormSensor()
        {
            InitializeComponent();
        }

        private void FormSensor_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarDatos();
        }

        private void CargarCombos()
        {
            // ===== COMBO AULA =====
            DataTable dtAula = logicaAula.MostrarAula();

            DataRow filaAula = dtAula.NewRow();
            filaAula["idAula"] = 0;
            filaAula["nombre"] = "Seleccione aula";
            dtAula.Rows.InsertAt(filaAula, 0);

            cmbAula.DataSource = dtAula;
            cmbAula.DisplayMember = "nombre";
            cmbAula.ValueMember = "idAula";
            cmbAula.SelectedIndex = 0;

            // ===== COMBO TIPO SENSOR =====
            DataTable dtTipo = logicaTipo.MostrarTipoSensor();

            DataRow filaTipo = dtTipo.NewRow();
            filaTipo["idTipo"] = 0;
            filaTipo["descripcion"] = "Seleccione tipo de sensor";
            dtTipo.Rows.InsertAt(filaTipo, 0);

            cmbTipoSensor.DataSource = dtTipo;
            cmbTipoSensor.DisplayMember = "descripcion";
            cmbTipoSensor.ValueMember = "idTipo";
            cmbTipoSensor.SelectedIndex = 0;
        }

        private void CargarDatos()
        {
            dgvSensor.DataSource = logica.MostrarSensor();
        }

        private void btnGuardarSensor_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbAula.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione un aula");
                return;
            }

            if (Convert.ToInt32(cmbTipoSensor.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione un tipo de sensor");
                return;
            }

            int idAula = Convert.ToInt32(cmbAula.SelectedValue);
            int idTipo = Convert.ToInt32(cmbTipoSensor.SelectedValue);

            logica.InsertarSensor(idAula, idTipo);

            MessageBox.Show("Sensor guardado");

            CargarDatos();

            cmbAula.SelectedIndex = 0;
            cmbTipoSensor.SelectedIndex = 0;
        }

        private void btnEliminarSensor_Click(object sender, EventArgs e)
        {
            if (dgvSensor.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            int idSensor = Convert.ToInt32(dgvSensor.CurrentRow.Cells["idSensor"].Value);

            logica.EliminarSensor(idSensor);

            MessageBox.Show("Sensor eliminado");

            CargarDatos();
        }

        private void btnIrMedicion_Click(object sender, EventArgs e)
        {
            FormMedicion frm = new FormMedicion();
            frm.Show();
            this.Hide();
        }
    }
}