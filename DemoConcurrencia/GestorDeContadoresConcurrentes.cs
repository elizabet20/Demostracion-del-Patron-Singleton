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
    public partial class FrmGestorContadoresConcurrentes : Form
    {
        public FrmGestorContadoresConcurrentes()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                semaforo.Wait();



                lock (bloqueo)
                {
                    contador++;
                    Thread.Sleep(1000);

                    this.Invoke((MethodInvoker)delegate
                    {
                        lblC.Text = contador.ToString();
                    });
                    Monitor.Pulse(bloqueo);
                }

                semaforo.Release();
            });
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
