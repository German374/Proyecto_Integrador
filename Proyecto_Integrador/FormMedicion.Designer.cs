namespace Proyecto_Integrador
{
    partial class FormMedicion
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
            label1 = new Label();
            cmbSensor = new ComboBox();
            btnMedir = new Button();
            txtResultado = new TextBox();
            dgvMediciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMediciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 84);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 4;
            label1.Text = "Seleccione sensor";
            // 
            // cmbSensor
            // 
            cmbSensor.FormattingEnabled = true;
            cmbSensor.Location = new Point(84, 124);
            cmbSensor.Name = "cmbSensor";
            cmbSensor.Size = new Size(121, 23);
            cmbSensor.TabIndex = 3;
            // 
            // btnMedir
            // 
            btnMedir.Location = new Point(107, 239);
            btnMedir.Name = "btnMedir";
            btnMedir.Size = new Size(75, 23);
            btnMedir.TabIndex = 2;
            btnMedir.Text = "Medir";
            btnMedir.UseVisualStyleBackColor = true;
            btnMedir.Click += btnMedir_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(466, 105);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 1;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // dgvMediciones
            // 
            dgvMediciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMediciones.Location = new Point(220, 155);
            dgvMediciones.Name = "dgvMediciones";
            dgvMediciones.Size = new Size(553, 215);
            dgvMediciones.TabIndex = 0;
            // 
            // FormMedicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMediciones);
            Controls.Add(txtResultado);
            Controls.Add(btnMedir);
            Controls.Add(cmbSensor);
            Controls.Add(label1);
            Name = "FormMedicion";
            Text = "FormMedicion";
            Load += FormMedicion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMediciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private ComboBox cmbSensor;
        private Button btnMedir;
        private TextBox txtResultado;
        private DataGridView dgvMediciones;
    }
}