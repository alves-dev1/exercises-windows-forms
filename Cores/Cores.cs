using System;
using System.Windows.Forms;
using System.Drawing;

namespace Atividades
{
    public partial class Cores : Form
    {
        public Cores()
        {
            InitializeComponent();
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {

            btnExemplo.UseVisualStyleBackColor = false;
            btnExemplo.BackColor = Color.Red;
            btnExemplo.ForeColor = Color.Black;
            lblCorAtual.Text = "Cor do botão: vermelho";
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {

            btnExemplo.UseVisualStyleBackColor = false;
            btnExemplo.BackColor = Color.Green;
            btnExemplo.ForeColor = Color.White;
            lblCorAtual.Text = "Cor do botão: verde";
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {

            btnExemplo.UseVisualStyleBackColor = false;
            btnExemplo.BackColor = Color.Blue;
            btnExemplo.ForeColor = Color.White;
            lblCorAtual.Text = "Cor do botão: azul";
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {

            btnExemplo.UseVisualStyleBackColor = false;
            btnExemplo.BackColor = Color.Yellow;
            btnExemplo.ForeColor = Color.Black;
            lblCorAtual.Text = "Cor do botão: amarelo";
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnExemplo.BackColor = SystemColors.Control;
            btnExemplo.ForeColor = SystemColors.ControlText;
            btnExemplo.UseVisualStyleBackColor = true;
            lblCorAtual.Text = "Cor do botão: padrão";
        }

        private void btnExemplo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblCorAtual.Text, "Botão de exemplo");
        }
    }
}
