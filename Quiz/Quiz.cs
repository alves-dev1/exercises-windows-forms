using System;
using System.Windows.Forms;

namespace Atividades
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            if (!rdbP1A.Checked && !rdbP1B.Checked && !rdbP1C.Checked)
            {
                MessageBox.Show("Responda à pergunta 1.", "Quiz");
                btnCorrigir.Focus();
                return;
            }
            if (!rdbP2A.Checked && !rdbP2B.Checked && !rdbP2C.Checked)
            {
                MessageBox.Show("Responda à pergunta 2.", "Quiz");
                btnCorrigir.Focus();
                return;
            }
            if (!rdbP3A.Checked && !rdbP3B.Checked && !rdbP3C.Checked)
            {
                MessageBox.Show("Responda à pergunta 3.", "Quiz");
                btnCorrigir.Focus();
                return;
            }
            if (!rdbP4A.Checked && !rdbP4B.Checked && !rdbP4C.Checked)
            {
                MessageBox.Show("Responda à pergunta 4.", "Quiz");
                btnCorrigir.Focus();
                return;
            }
            if (!rdbP5A.Checked && !rdbP5B.Checked && !rdbP5C.Checked)
            {
                MessageBox.Show("Responda à pergunta 5.", "Quiz");
                btnCorrigir.Focus();
                return;
            }

            int acertos = 0;
            if (rdbP1A.Checked)
            {
                acertos = acertos + 1;
            }
            if (rdbP2B.Checked)
            {
                acertos = acertos + 1;
            }
            if (rdbP3C.Checked)
            {
                acertos = acertos + 1;
            }
            if (rdbP4A.Checked)
            {
                acertos = acertos + 1;
            }
            if (rdbP5B.Checked)
            {
                acertos = acertos + 1;
            }
            int nota = acertos * 2;
            txtResultado.Text = "Acertos: " + acertos + " de 5" + Environment.NewLine
                + "Nota: " + nota + " de 10" + Environment.NewLine
                + "Gabarito: 1 - TextBox; 2 - RadioButton; 3 - Checked;"
                + Environment.NewLine + "4 - Click; 5 - MessageBox.Show.";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbP1A.Checked = false;
            rdbP1B.Checked = false;
            rdbP1C.Checked = false;
            rdbP2A.Checked = false;
            rdbP2B.Checked = false;
            rdbP2C.Checked = false;
            rdbP3A.Checked = false;
            rdbP3B.Checked = false;
            rdbP3C.Checked = false;
            rdbP4A.Checked = false;
            rdbP4B.Checked = false;
            rdbP4C.Checked = false;
            rdbP5A.Checked = false;
            rdbP5B.Checked = false;
            rdbP5C.Checked = false;
            txtResultado.Clear();
            btnCorrigir.Focus();
        }
    }
}
