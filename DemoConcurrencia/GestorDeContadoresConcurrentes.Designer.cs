namespace DemoConcurrencia
{
    partial class FrmGestorContadoresConcurrentes
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
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(30, 44);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 45);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(30, 115);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 45);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(30, 189);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 45);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmGestorContadoresConcurrentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Name = "FrmGestorContadoresConcurrentes";
            Text = "GestorDeContadoresConcurrentes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}