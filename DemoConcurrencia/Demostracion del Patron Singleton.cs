using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class frmPatronSingleton : Form
    {
        public frmPatronSingleton()
        {
            InitializeComponent();
        }

        private void frmPatronSingleton_Load(object sender, EventArgs e)
        {

        }

        private void btnAsignarconexión_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            cadenaConexion.cadenaConexion = txtCadenaConexión.Text;

        }

        private void btnObtenerCadenaConexión_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexión = Singleton.Instance;
            lblCadenaConexión.Text = cadenaConexión.cadenaConexion;
        }

        private void lblCadenaConexiónRecuperada_Click(object sender, EventArgs e)
        {

        }
    }
}
