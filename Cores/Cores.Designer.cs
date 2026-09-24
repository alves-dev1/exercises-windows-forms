namespace Atividades
{
    partial class Cores
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOrientacao = new System.Windows.Forms.Label();
            this.btnExemplo = new System.Windows.Forms.Button();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.lblCorAtual = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(680, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Troca de cores de botão";

            this.lblOrientacao.Location = new System.Drawing.Point(24, 53);
            this.lblOrientacao.Name = "lblOrientacao";
            this.lblOrientacao.Size = new System.Drawing.Size(680, 26);
            this.lblOrientacao.TabIndex = 1;
            this.lblOrientacao.Text = "Escolha uma cor para o botão grande abaixo.";

            this.btnExemplo.Location = new System.Drawing.Point(184, 106);
            this.btnExemplo.Name = "btnExemplo";
            this.btnExemplo.Size = new System.Drawing.Size(340, 100);
            this.btnExemplo.TabIndex = 2;
            this.btnExemplo.Text = "Botão de exemplo";
            this.btnExemplo.UseVisualStyleBackColor = true;

            this.btnVermelho.Location = new System.Drawing.Point(24, 243);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(148, 42);
            this.btnVermelho.TabIndex = 3;
            this.btnVermelho.Text = "Vermelho";
            this.btnVermelho.UseVisualStyleBackColor = true;

            this.btnVerde.Location = new System.Drawing.Point(194, 243);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(148, 42);
            this.btnVerde.TabIndex = 4;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;

            this.btnAzul.Location = new System.Drawing.Point(364, 243);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(148, 42);
            this.btnAzul.TabIndex = 5;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;

            this.btnAmarelo.Location = new System.Drawing.Point(534, 243);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(148, 42);
            this.btnAmarelo.TabIndex = 6;
            this.btnAmarelo.Text = "Amarelo";
            this.btnAmarelo.UseVisualStyleBackColor = true;

            this.lblCorAtual.Location = new System.Drawing.Point(24, 322);
            this.lblCorAtual.Name = "lblCorAtual";
            this.lblCorAtual.Size = new System.Drawing.Size(658, 26);
            this.lblCorAtual.TabIndex = 7;
            this.lblCorAtual.Text = "Cor do botão: padrão";

            this.btnRestaurar.Location = new System.Drawing.Point(24, 376);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(264, 42);
            this.btnRestaurar.TabIndex = 8;
            this.btnRestaurar.Text = "Restaurar cor padrão";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblOrientacao);
            this.Controls.Add(this.btnExemplo);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.lblCorAtual);
            this.Controls.Add(this.btnRestaurar);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 445);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca de cores de botão";
            this.btnExemplo.Click += new System.EventHandler(this.btnExemplo_Click);
            this.btnVermelho.Click += new System.EventHandler(this.btnVermelho_Click);
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOrientacao;
        private System.Windows.Forms.Button btnExemplo;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Label lblCorAtual;
        private System.Windows.Forms.Button btnRestaurar;
    }
}
