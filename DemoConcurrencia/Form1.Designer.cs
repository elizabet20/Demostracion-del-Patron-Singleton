namespace DemoConcurrencia
{
    partial class frmBloqueos
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
            btnIncrementar = new Button();
            lblContador = new Label();
            btnDisminuir = new Button();
            splitContainer1 = new SplitContainer();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIncrementar
            // 
            btnIncrementar.BackColor = Color.FromArgb(255, 128, 255);
            btnIncrementar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncrementar.Location = new Point(36, 20);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(91, 40);
            btnIncrementar.TabIndex = 0;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = false;
            btnIncrementar.Click += button1_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(77, 174);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(13, 15);
            lblContador.TabIndex = 1;
            lblContador.Text = "0";
            // 
            // btnDisminuir
            // 
            btnDisminuir.BackColor = Color.FromArgb(192, 255, 192);
            btnDisminuir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisminuir.Location = new Point(36, 90);
            btnDisminuir.Name = "btnDisminuir";
            btnDisminuir.Size = new Size(91, 37);
            btnDisminuir.TabIndex = 2;
            btnDisminuir.Text = "Disminuir";
            btnDisminuir.UseVisualStyleBackColor = false;
            btnDisminuir.Click += btnDisminuir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnIncrementar);
            splitContainer1.Panel1.Controls.Add(btnDisminuir);
            splitContainer1.Panel1.Controls.Add(lblContador);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(620, 338);
            splitContainer1.SplitterDistance = 282;
            splitContainer1.TabIndex = 3;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(334, 338);
            txtResultado.TabIndex = 1;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // frmBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmBloqueos";
            Text = "Gestion de Bloqueos";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnIncrementar;
        private Label lblContador;
        private Button btnDisminuir;
        private SplitContainer splitContainer1;
        private TextBox txtResultado;
    }
}