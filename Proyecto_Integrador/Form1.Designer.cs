namespace Proyecto_Integrador
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtUbicacion = new TextBox();
            btnGuardar = new Button();
            dgvAula = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnTipoSensor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAula).BeginInit();
            SuspendLayout();

            // txtNombre
            txtNombre.Location = new Point(77, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 0;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;

            // txtUbicacion
            txtUbicacion.Location = new Point(77, 109);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(160, 23);
            txtUbicacion.TabIndex = 1;
            txtUbicacion.Enter += txtUbicacion_Enter;
            txtUbicacion.Leave += txtUbicacion_Leave;

            // btnGuardar
            btnGuardar.Location = new Point(92, 182);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;

            // dgvAula
            dgvAula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAula.Location = new Point(258, 149);
            dgvAula.Name = "dgvAula";
            dgvAula.Size = new Size(240, 150);
            dgvAula.TabIndex = 3;
            dgvAula.CellClick += dgvAula_CellClick;

            // btnEditar
            btnEditar.Location = new Point(248, 38);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;

            // btnEliminar
            btnEliminar.Location = new Point(248, 108);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;

            // btnTipoSensor
            btnTipoSensor.Location = new Point(144, 368);
            btnTipoSensor.Name = "btnTipoSensor";
            btnTipoSensor.Size = new Size(113, 23);
            btnTipoSensor.TabIndex = 6;
            btnTipoSensor.Text = "Tipo Sensor";
            btnTipoSensor.UseVisualStyleBackColor = true;
            btnTipoSensor.Click += btnTipoSensor_Click;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTipoSensor);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvAula);
            Controls.Add(btnGuardar);
            Controls.Add(txtUbicacion);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtNombre;
        private TextBox txtUbicacion;
        private Button btnGuardar;
        private DataGridView dgvAula;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnTipoSensor;
    }
}
