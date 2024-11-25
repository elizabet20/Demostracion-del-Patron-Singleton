namespace DemoConcurrencia
{
    partial class frmPatronSingleton
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
            btnAsignarcadenaconexión = new Button();
            btnObtenerCadenaConexión = new Button();
            lblCadenaConexión = new Label();
            txtCadenaConexión = new TextBox();
            lblCadenaConexiónRecuperada = new Label();
            lblCadenaConexiónResuelta = new Label();
            lblCadenaConexionRecuperada = new Label();
            SuspendLayout();
            // 
            // btnAsignarcadenaconexión
            // 
            btnAsignarcadenaconexión.Location = new Point(32, 112);
            btnAsignarcadenaconexión.Name = "btnAsignarcadenaconexión";
            btnAsignarcadenaconexión.Size = new Size(107, 70);
            btnAsignarcadenaconexión.TabIndex = 0;
            btnAsignarcadenaconexión.Text = "Asignar cadena de conexión";
            btnAsignarcadenaconexión.UseVisualStyleBackColor = true;
            btnAsignarcadenaconexión.Click += btnAsignarconexión_Click;
            // 
            // btnObtenerCadenaConexión
            // 
            btnObtenerCadenaConexión.Location = new Point(32, 210);
            btnObtenerCadenaConexión.Name = "btnObtenerCadenaConexión";
            btnObtenerCadenaConexión.Size = new Size(107, 70);
            btnObtenerCadenaConexión.TabIndex = 1;
            btnObtenerCadenaConexión.Text = "Obtener cadena de conexión";
            btnObtenerCadenaConexión.UseVisualStyleBackColor = true;
            btnObtenerCadenaConexión.Click += btnObtenerCadenaConexión_Click;
            // 
            // lblCadenaConexión
            // 
            lblCadenaConexión.AutoSize = true;
            lblCadenaConexión.Location = new Point(71, 15);
            lblCadenaConexión.Name = "lblCadenaConexión";
            lblCadenaConexión.Size = new Size(115, 15);
            lblCadenaConexión.TabIndex = 2;
            lblCadenaConexión.Text = "Cadena de conexión";
            lblCadenaConexión.Click += lblCadenaConexiónRecuperada_Click;
            // 
            // txtCadenaConexión
            // 
            txtCadenaConexión.Location = new Point(32, 44);
            txtCadenaConexión.Name = "txtCadenaConexión";
            txtCadenaConexión.Size = new Size(378, 23);
            txtCadenaConexión.TabIndex = 3;
            // 
            // lblCadenaConexiónRecuperada
            // 
            lblCadenaConexiónRecuperada.AutoSize = true;
            lblCadenaConexiónRecuperada.Location = new Point(257, 334);
            lblCadenaConexiónRecuperada.Name = "lblCadenaConexiónRecuperada";
            lblCadenaConexiónRecuperada.Size = new Size(0, 15);
            lblCadenaConexiónRecuperada.TabIndex = 4;
            // 
            // lblCadenaConexiónResuelta
            // 
            lblCadenaConexiónResuelta.AutoSize = true;
            lblCadenaConexiónResuelta.Location = new Point(508, 334);
            lblCadenaConexiónResuelta.Name = "lblCadenaConexiónResuelta";
            lblCadenaConexiónResuelta.Size = new Size(0, 15);
            lblCadenaConexiónResuelta.TabIndex = 5;
            // 
            // lblCadenaConexionRecuperada
            // 
            lblCadenaConexionRecuperada.AutoSize = true;
            lblCadenaConexionRecuperada.Location = new Point(388, 226);
            lblCadenaConexionRecuperada.Name = "lblCadenaConexionRecuperada";
            lblCadenaConexionRecuperada.Size = new Size(0, 15);
            lblCadenaConexionRecuperada.TabIndex = 6;
            // 
            // frmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCadenaConexionRecuperada);
            Controls.Add(lblCadenaConexiónResuelta);
            Controls.Add(lblCadenaConexiónRecuperada);
            Controls.Add(txtCadenaConexión);
            Controls.Add(lblCadenaConexión);
            Controls.Add(btnObtenerCadenaConexión);
            Controls.Add(btnAsignarcadenaconexión);
            Name = "frmPatronSingleton";
            Text = "Demostracion del Patron Singleton";
            Load += frmPatronSingleton_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignarcadenaconexión;
        private Button btnObtenerCadenaConexión;
        private Label lblCadenaConexión;
        private TextBox txtCadenaConexión;
        private Label lblCadenaConexiónRecuperada;
        private Label lblCadenaConexiónResuelta;
        private Label lblCadenaConexionRecuperada;
    }
}