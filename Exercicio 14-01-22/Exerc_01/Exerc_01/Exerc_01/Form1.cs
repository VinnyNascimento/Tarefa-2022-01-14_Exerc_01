using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerc_01
{
    public partial class Form1 : Form
    {
        private Semaforo semaf;
        public Form1()
        {
            InitializeComponent();
            this.semaf = new Semaforo();
            atualizaInterface();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.semaf.setVermelho(int.Parse(txtRua.Text));
            atualizaInterface();
        }
        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            this.semaf.setAmarelo(int.Parse(txtRua.Text));
            atualizaInterface();
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.semaf.setVerde(int.Parse(txtRua.Text));
            atualizaInterface();
        }
        public void atualizaInterface()
        {
            lblRua1.Text = this.semaf.getEstado(1).ToString();
            lblRua2.Text = this.semaf.getEstado(2).ToString();
            picRua1.Image =
                (this.semaf.getEstado(1) == 1) ? Properties.Resources.semaforo_verde :
                (this.semaf.getEstado(1) == 2) ? Properties.Resources.semaforo_amarelo :
                Properties.Resources.semaforo_vermelho;
            picRua2.Image =
                (this.semaf.getEstado(2) == 1) ? Properties.Resources.semaforo_verde :
                (this.semaf.getEstado(2) == 2) ? Properties.Resources.semaforo_amarelo :
                Properties.Resources.semaforo_vermelho;
            lblStatus.Text = this.semaf.getEstado().ToString();

        }
        private void picVermelho_Click(object sender, EventArgs e)
        {

        }


    }
}

