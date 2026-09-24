namespace Atividades
{
    partial class Curso
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.chkEnsinoMedio = new System.Windows.Forms.CheckBox();
            this.grpEnsinoFundamental = new System.Windows.Forms.GroupBox();
            this.rdbPublico = new System.Windows.Forms.RadioButton();
            this.rdbParticular = new System.Windows.Forms.RadioButton();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.btnConcluirCadastro = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.grpEnsinoFundamental.SuspendLayout();
            this.SuspendLayout();

            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(129, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome completo";

            this.txtNome.Location = new System.Drawing.Point(30, 58);
            this.txtNome.MaxLength = 120;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 29);
            this.txtNome.TabIndex = 1;

            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(30, 115);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(159, 21);
            this.lblAnoNascimento.TabIndex = 2;
            this.lblAnoNascimento.Text = "Ano de Nascimento";

            this.txtAnoNascimento.Location = new System.Drawing.Point(30, 143);
            this.txtAnoNascimento.MaxLength = 4;
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(350, 29);
            this.txtAnoNascimento.TabIndex = 3;

            this.chkEnsinoMedio.AutoSize = true;
            this.chkEnsinoMedio.Location = new System.Drawing.Point(30, 219);
            this.chkEnsinoMedio.Name = "chkEnsinoMedio";
            this.chkEnsinoMedio.Size = new System.Drawing.Size(220, 25);
            this.chkEnsinoMedio.TabIndex = 4;
            this.chkEnsinoMedio.Text = "Ensino Médio Completo";
            this.chkEnsinoMedio.UseVisualStyleBackColor = true;

            this.grpEnsinoFundamental.Controls.Add(this.rdbPublico);
            this.grpEnsinoFundamental.Controls.Add(this.rdbParticular);
            this.grpEnsinoFundamental.Location = new System.Drawing.Point(450, 28);
            this.grpEnsinoFundamental.Name = "grpEnsinoFundamental";
            this.grpEnsinoFundamental.Size = new System.Drawing.Size(380, 132);
            this.grpEnsinoFundamental.TabIndex = 5;
            this.grpEnsinoFundamental.TabStop = false;
            this.grpEnsinoFundamental.Text = "Ensino Fundamental";

            this.rdbPublico.AutoSize = true;
            this.rdbPublico.Location = new System.Drawing.Point(22, 40);
            this.rdbPublico.Name = "rdbPublico";
            this.rdbPublico.Size = new System.Drawing.Size(82, 25);
            this.rdbPublico.TabIndex = 0;
            this.rdbPublico.TabStop = true;
            this.rdbPublico.Text = "Público";
            this.rdbPublico.UseVisualStyleBackColor = true;

            this.rdbParticular.AutoSize = true;
            this.rdbParticular.Location = new System.Drawing.Point(22, 79);
            this.rdbParticular.Name = "rdbParticular";
            this.rdbParticular.Size = new System.Drawing.Size(101, 25);
            this.rdbParticular.TabIndex = 1;
            this.rdbParticular.TabStop = true;
            this.rdbParticular.Text = "Particular";
            this.rdbParticular.UseVisualStyleBackColor = true;

            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(450, 179);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(145, 21);
            this.lblCurso.TabIndex = 6;
            this.lblCurso.Text = "Escolha um curso";

            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.ItemHeight = 21;
            this.lstCursos.Items.AddRange(new object[] {
            "Informática",
            "Automação",
            "Logística"});
            this.lstCursos.Location = new System.Drawing.Point(450, 207);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.lstCursos.Size = new System.Drawing.Size(380, 67);
            this.lstCursos.TabIndex = 7;

            this.btnConcluirCadastro.Location = new System.Drawing.Point(30, 314);
            this.btnConcluirCadastro.Name = "btnConcluirCadastro";
            this.btnConcluirCadastro.Size = new System.Drawing.Size(235, 190);
            this.btnConcluirCadastro.TabIndex = 8;
            this.btnConcluirCadastro.Text = "Concluir Cadastro";
            this.btnConcluirCadastro.UseVisualStyleBackColor = true;
            this.btnConcluirCadastro.Click += new System.EventHandler(this.btnConcluirCadastro_Click);

            this.txtResultado.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultado.Location = new System.Drawing.Point(285, 314);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(545, 190);
            this.txtResultado.TabIndex = 9;

            this.AcceptButton = this.btnConcluirCadastro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 535);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnConcluirCadastro);
            this.Controls.Add(this.lstCursos);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.grpEnsinoFundamental);
            this.Controls.Add(this.chkEnsinoMedio);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cursos";
            this.grpEnsinoFundamental.ResumeLayout(false);
            this.grpEnsinoFundamental.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAnoNascimento;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.CheckBox chkEnsinoMedio;
        private System.Windows.Forms.GroupBox grpEnsinoFundamental;
        private System.Windows.Forms.RadioButton rdbPublico;
        private System.Windows.Forms.RadioButton rdbParticular;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.Button btnConcluirCadastro;
        private System.Windows.Forms.TextBox txtResultado;
    }
}
