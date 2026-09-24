using System;
using System.Windows.Forms;

namespace Atividades
{
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void btnConcluirCadastro_Click(object sender, EventArgs e)
        {

            txtResultado.Clear();

            string nome = txtNome.Text.Trim();

            if (nome == "")
            {
                MessageBox.Show("Digite o nome completo.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            int anoNascimento;
            if (!int.TryParse(txtAnoNascimento.Text, out anoNascimento))
            {
                MessageBox.Show("Digite um ano de nascimento válido, usando números.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnoNascimento.Focus();
                return;
            }

            int anoAtual = DateTime.Now.Year;

            if (anoNascimento < 1 || anoNascimento > anoAtual)
            {
                MessageBox.Show("O ano de nascimento deve ser maior que zero e não pode ser futuro.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnoNascimento.Focus();
                return;
            }

            if (!rdbPublico.Checked && !rdbParticular.Checked)
            {
                MessageBox.Show("Selecione onde cursou o Ensino Fundamental.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rdbPublico.Focus();
                return;
            }

            if (lstCursos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um curso na lista.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstCursos.Focus();
                return;
            }

            int idade = anoAtual - anoNascimento;

            string ensinoMedio;
            if (chkEnsinoMedio.Checked)
            {
                ensinoMedio = "Ensino Médio Completo";
            }
            else
            {
                ensinoMedio = "Ensino Médio Incompleto";
            }

            string ensinoFundamental;
            if (rdbPublico.Checked)
            {
                ensinoFundamental = "Ensino Fundamental em Escola Pública";
            }
            else
            {
                ensinoFundamental = "Ensino Fundamental em Escola Particular";
            }

            string curso = lstCursos.SelectedItem.ToString();

            txtResultado.Text = "Nome: " + nome + Environment.NewLine
                + "Idade: " + idade + " anos" + Environment.NewLine
                + ensinoMedio + Environment.NewLine
                + ensinoFundamental + Environment.NewLine
                + "Curso Escolhido: " + curso;
        }
    }
}
