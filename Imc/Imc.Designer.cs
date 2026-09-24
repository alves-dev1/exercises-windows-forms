namespace Atividades
{
    partial class Imc
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
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.lblAltura = new System.Windows.Forms.Label();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.graficoImc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblNota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(680, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "IMC gráfico";

            this.lblFormula.Location = new System.Drawing.Point(24, 53);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(656, 26);
            this.lblFormula.TabIndex = 1;
            this.lblFormula.Text = "IMC = peso em kg / (altura em metros × altura em metros)";

            this.lblPeso.Location = new System.Drawing.Point(24, 104);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(150, 26);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso (kg)";

            this.numPeso.Location = new System.Drawing.Point(24, 133);
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(160, 27);
            this.numPeso.TabIndex = 3;
            this.numPeso.Minimum = 1m;
            this.numPeso.Maximum = 500m;
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Value = 70m;
            this.numPeso.Increment = 0.5m;

            this.lblAltura.Location = new System.Drawing.Point(210, 104);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(150, 26);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura (m)";

            this.numAltura.Location = new System.Drawing.Point(210, 133);
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(160, 27);
            this.numAltura.TabIndex = 5;
            this.numAltura.Minimum = 0.5m;
            this.numAltura.Maximum = 3m;
            this.numAltura.DecimalPlaces = 2;
            this.numAltura.Value = 1.70m;
            this.numAltura.Increment = 0.01m;

            this.btnCalcular.Location = new System.Drawing.Point(405, 124);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(275, 42);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular IMC";
            this.btnCalcular.UseVisualStyleBackColor = true;

            this.lblResultado.Location = new System.Drawing.Point(24, 193);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(656, 40);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Clique em Calcular IMC.";
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);

            this.graficoImc.Location = new System.Drawing.Point(24, 248);
            this.graficoImc.Name = "graficoImc";
            this.graficoImc.Size = new System.Drawing.Size(656, 314);
            this.graficoImc.TabIndex = 8;

            this.lblNota.Location = new System.Drawing.Point(24, 580);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(656, 26);
            this.lblNota.TabIndex = 9;
            this.lblNota.Text = "O gráfico representa o valor numérico calculado.";
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.numPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.numAltura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.graficoImc);
            this.Controls.Add(this.lblNota);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 622);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Imc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC gráfico";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoImc;
        private System.Windows.Forms.Label lblNota;
    }
}
