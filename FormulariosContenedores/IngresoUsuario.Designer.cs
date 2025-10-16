namespace FormulariosContenedores
{
    partial class IngresoUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblMonitor = new Label();
            btnGuardar = new Button();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(57, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(57, 87);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Digite su nombre";
            txtNombre.Size = new Size(112, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(186, 84);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Digite su apellido";
            txtApellido.Size = new Size(112, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblMonitor
            // 
            lblMonitor.BackColor = Color.White;
            lblMonitor.BorderStyle = BorderStyle.Fixed3D;
            lblMonitor.Location = new Point(57, 168);
            lblMonitor.Name = "lblMonitor";
            lblMonitor.Size = new Size(241, 48);
            lblMonitor.TabIndex = 4;
            lblMonitor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(140, 245);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(60, 127);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección";
            
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(186, 124);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Digite su dirección";
            txtDireccion.Size = new Size(112, 23);
            txtDireccion.TabIndex = 7;
            // 
            // IngresoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 330);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(btnGuardar);
            Controls.Add(lblMonitor);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "IngresoUsuario";
            Text = "Ingreso Usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblMonitor;
        private Button btnGuardar;
        private Label lblDireccion;
        private TextBox txtDireccion;
    }
}
