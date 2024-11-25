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
    public partial class frmBloqueos : Form
    {
        private int contador = 0;
        private object bloqueo = new();
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);
        public frmBloqueos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                        lblContador.Text = contador.ToString();
                    });
                    Monitor.Pulse(bloqueo);
                }
                
                semaforo.Release();
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                lock (bloqueo)
                {
                    while (contador <= 0)
                    {
                        ACtualizarResultado("Esperando...");
                        Monitor.Wait(bloqueo);
                    }

                    if (contador > 0)
                    {
                        contador--;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {
                            lblContador.Text = contador.ToString();
                        });

                    }
                    ACtualizarResultado("Procesando...");
                    
                }

            });
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACtualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ACtualizarResultado(mensaje)));
                return;
            }
            txtResultado.AppendText($" {DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }
    }

}
