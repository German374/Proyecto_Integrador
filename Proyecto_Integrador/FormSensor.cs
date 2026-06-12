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
            // ===== COLOR DEL FORM =====
            this.BackColor = Color.FromArgb(230, 240, 245);

            // ===== BOTONES =====
            btnGuardarSensor.BackColor = Color.FromArgb(46, 134, 193);
            btnGuardarSensor.ForeColor = Color.White;
            btnGuardarSensor.FlatStyle = FlatStyle.Flat;
            btnGuardarSensor.FlatAppearance.BorderSize = 0;

            btnEliminarSensor.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminarSensor.ForeColor = Color.White;
            btnEliminarSensor.FlatStyle = FlatStyle.Flat;
            btnEliminarSensor.FlatAppearance.BorderSize = 0;

            btnIrMedicion.BackColor = Color.FromArgb(39, 174, 96);
            btnIrMedicion.ForeColor = Color.White;
            btnIrMedicion.FlatStyle = FlatStyle.Flat;
            btnIrMedicion.FlatAppearance.BorderSize = 0;

            // ===== COMBOBOX =====
            cmbAula.FlatStyle = FlatStyle.Flat;
            cmbTipoSensor.FlatStyle = FlatStyle.Flat;

            cmbAula.Font = new Font("Segoe UI", 9);
            cmbTipoSensor.Font = new Font("Segoe UI", 9);

            // ===== DATAGRIDVIEW =====
            dgvSensor.BackgroundColor = Color.White;
            dgvSensor.BorderStyle = BorderStyle.FixedSingle;

            dgvSensor.EnableHeadersVisualStyles = false;

            dgvSensor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvSensor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvSensor.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvSensor.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(52, 152, 219);

            dgvSensor.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvSensor.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);

            dgvSensor.GridColor = Color.LightGray;

            // ===== CARGAR DATOS =====
            CargarCombos();
            CargarDatos();
        }

        private void CargarCombos()
        {
            // COMBO AULA 
            DataTable dtAula = logicaAula.MostrarAula();

            DataRow filaAula = dtAula.NewRow();
            filaAula["idAula"] = 0;
            filaAula["nombre"] = "Seleccione aula";
            dtAula.Rows.InsertAt(filaAula, 0);

            cmbAula.DataSource = dtAula;
            cmbAula.DisplayMember = "nombre";
            cmbAula.ValueMember = "idAula";
            cmbAula.SelectedIndex = 0;

            // COMBO TIPO SENSOR
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