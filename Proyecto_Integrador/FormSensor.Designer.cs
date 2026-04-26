namespace Proyecto_Integrador
{
    partial class FormSensor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbAula = new ComboBox();
            cmbTipoSensor = new ComboBox();
            dgvSensor = new DataGridView();
            btnGuardarSensor = new Button();
            btnEliminarSensor = new Button();
            btnIrMedicion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSensor).BeginInit();
            SuspendLayout();
            // 
            // cmbAula
            // 
            cmbAula.FormattingEnabled = true;
            cmbAula.Location = new Point(81, 90);
            cmbAula.Name = "cmbAula";
            cmbAula.Size = new Size(121, 23);
            cmbAula.TabIndex = 0;
            // 
            // cmbTipoSensor
            // 
            cmbTipoSensor.FormattingEnabled = true;
            cmbTipoSensor.Location = new Point(81, 289);
            cmbTipoSensor.Name = "cmbTipoSensor";
            cmbTipoSensor.Size = new Size(121, 23);
            cmbTipoSensor.TabIndex = 1;
            // 
            // dgvSensor
            // 
            dgvSensor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSensor.Location = new Point(314, 143);
            dgvSensor.Name = "dgvSensor";
            dgvSensor.Size = new Size(433, 169);
            dgvSensor.TabIndex = 2;
            // 
            // btnGuardarSensor
            // 
            btnGuardarSensor.Location = new Point(295, 55);
            btnGuardarSensor.Name = "btnGuardarSensor";
            btnGuardarSensor.Size = new Size(111, 23);
            btnGuardarSensor.TabIndex = 3;
            btnGuardarSensor.Text = "Guardar Sensor";
            btnGuardarSensor.UseVisualStyleBackColor = true;
            btnGuardarSensor.Click += btnGuardarSensor_Click;
            // 
            // btnEliminarSensor
            // 
            btnEliminarSensor.Location = new Point(474, 55);
            btnEliminarSensor.Name = "btnEliminarSensor";
            btnEliminarSensor.Size = new Size(112, 23);
            btnEliminarSensor.TabIndex = 4;
            btnEliminarSensor.Text = "Eliminar Sensor";
            btnEliminarSensor.UseVisualStyleBackColor = true;
            btnEliminarSensor.Click += btnEliminarSensor_Click;
            // 
            // btnIrMedicion
            // 
            btnIrMedicion.Location = new Point(648, 55);
            btnIrMedicion.Name = "btnIrMedicion";
            btnIrMedicion.Size = new Size(99, 23);
            btnIrMedicion.TabIndex = 5;
            btnIrMedicion.Text = "Ir a medición";
            btnIrMedicion.UseVisualStyleBackColor = true;
            btnIrMedicion.Click += btnIrMedicion_Click;
            // 
            // FormSensor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIrMedicion);
            Controls.Add(btnEliminarSensor);
            Controls.Add(btnGuardarSensor);
            Controls.Add(dgvSensor);
            Controls.Add(cmbTipoSensor);
            Controls.Add(cmbAula);
            Name = "FormSensor";
            Text = "FormSensor";
            Load += FormSensor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSensor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbAula;
        private ComboBox cmbTipoSensor;
        private DataGridView dgvSensor;
        private Button btnGuardarSensor;
        private Button btnEliminarSensor;
        private Button btnIrMedicion;
    }
}