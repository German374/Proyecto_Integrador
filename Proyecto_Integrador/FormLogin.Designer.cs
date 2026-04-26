namespace Proyecto_Integrador
{
    partial class FormLogin
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
            txtUsuario = new TextBox();
            label2 = new Label();
            txtContrasena = new TextBox();
            btnLogin = new Button();
            SuspendLayout();

            label1.AutoSize = true;
            label1.Location = new Point(380, 60);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.Text = "Usuario";

            txtUsuario.Location = new Point(312, 90);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 23);
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;

            label2.AutoSize = true;
            label2.Location = new Point(370, 150);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.Text = "Contraseña";

            txtContrasena.Location = new Point(312, 200);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(180, 23);
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;

            btnLogin.Location = new Point(360, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 25);
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtContrasena;
        private Button btnLogin;
    }
}