namespace Proyecto_Integrador
{
    partial class FormTipoSensor
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
            txtNombreTipo = new TextBox();
            txtVariable = new TextBox();
            txtUnidad = new TextBox();
            dgvTipoSensor = new DataGridView();
            btnGuardarTipo = new Button();
            btnEliminarTS = new Button();
            btnEditarTipo = new Button();
            btnSensor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTipoSensor).BeginInit();
            SuspendLayout();
            // 
            // txtNombreTipo
            // 
            txtNombreTipo.Location = new Point(63, 38);
            txtNombreTipo.Name = "txtNombreTipo";
            txtNombreTipo.Size = new Size(220, 23);
            txtNombreTipo.TabIndex = 0;
            txtNombreTipo.Enter += txtNombreTipo_Enter;
            txtNombreTipo.Leave += txtNombreTipo_Leave;
            // 
            // txtVariable
            // 
            txtVariable.Location = new Point(63, 101);
            txtVariable.Name = "txtVariable";
            txtVariable.Size = new Size(220, 23);
            txtVariable.TabIndex = 1;
            txtVariable.Enter += txtVariable_Enter;
            txtVariable.Leave += txtVariable_Leave;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(63, 178);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(220, 23);
            txtUnidad.TabIndex = 2;
            txtUnidad.Enter += txtUnidad_Enter;
            txtUnidad.Leave += txtUnidad_Leave;
            // 
            // dgvTipoSensor
            // 
            dgvTipoSensor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoSensor.Location = new Point(416, 157);
            dgvTipoSensor.Name = "dgvTipoSensor";
            dgvTipoSensor.Size = new Size(302, 180);
            dgvTipoSensor.TabIndex = 4;
            dgvTipoSensor.CellClick += dgvTipoSensor_CellClick;
            // 
            // btnGuardarTipo
            // 
            btnGuardarTipo.Location = new Point(293, 38);
            btnGuardarTipo.Name = "btnGuardarTipo";
            btnGuardarTipo.Size = new Size(75, 23);
            btnGuardarTipo.TabIndex = 5;
            btnGuardarTipo.Text = "Guardar";
            btnGuardarTipo.UseVisualStyleBackColor = true;
            btnGuardarTipo.Click += btnGuardarTipo_Click;
            // 
            // btnEliminarTS
            // 
            btnEliminarTS.Location = new Point(293, 178);
            btnEliminarTS.Name = "btnEliminarTS";
            btnEliminarTS.Size = new Size(75, 23);
            btnEliminarTS.TabIndex = 6;
            btnEliminarTS.Text = "Eliminar";
            btnEliminarTS.UseVisualStyleBackColor = true;
            btnEliminarTS.Click += btnEliminarTS_Click;
            // 
            // btnEditarTipo
            // 
            btnEditarTipo.Location = new Point(293, 100);
            btnEditarTipo.Name = "btnEditarTipo";
            btnEditarTipo.Size = new Size(75, 23);
            btnEditarTipo.TabIndex = 7;
            btnEditarTipo.Text = "Editar";
            btnEditarTipo.UseVisualStyleBackColor = true;
            btnEditarTipo.Click += btnEditarTipo_Click;
            // 
            // btnSensor
            // 
            btnSensor.Location = new Point(180, 314);
            btnSensor.Name = "btnSensor";
            btnSensor.Size = new Size(75, 23);
            btnSensor.TabIndex = 8;
            btnSensor.Text = "Sensor";
            btnSensor.UseVisualStyleBackColor = true;
            btnSensor.Click += btnSensor_Click;
            // 
            // FormTipoSensor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSensor);
            Controls.Add(btnEditarTipo);
            Controls.Add(btnEliminarTS);
            Controls.Add(btnGuardarTipo);
            Controls.Add(dgvTipoSensor);
            Controls.Add(txtUnidad);
            Controls.Add(txtVariable);
            Controls.Add(txtNombreTipo);
            Name = "FormTipoSensor";
            Text = "FormTipoSensor";
            Load += FormTipoSensor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoSensor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtNombreTipo;
        private TextBox txtVariable;
        private TextBox txtUnidad;
        private DataGridView dgvTipoSensor;
        private Button btnGuardarTipo;
        private Button btnEliminarTS;
        private Button btnEditarTipo;
        private Button btnSensor;
    }
}