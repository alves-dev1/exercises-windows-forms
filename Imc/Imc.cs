using System;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Atividades
{
    public partial class Imc : Form
    {
        public Imc()
        {
            InitializeComponent();
            PrepararGrafico();
        }

        private void PrepararGrafico()
        {
            ChartArea area = new ChartArea("AreaIMC");
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 40;
            area.AxisY.Title = "IMC (kg/m²)";
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            graficoImc.ChartAreas.Add(area);

            Series coluna = new Series("IMC");
            coluna.ChartArea = "AreaIMC";
            coluna.ChartType = SeriesChartType.Column;
            coluna.IsValueShownAsLabel = true;
            coluna.LabelFormat = "0.00";
            coluna.Color = Color.SteelBlue;
            graficoImc.Series.Add(coluna);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double peso = (double)numPeso.Value;
            double altura = (double)numAltura.Value;
            double imc = peso / (altura * altura);

            lblResultado.Text = "IMC: " + imc.ToString("N2", new CultureInfo("pt-BR")) + " kg/m²";

            graficoImc.Series["IMC"].Points.Clear();
            graficoImc.Series["IMC"].Points.AddXY("IMC calculado", imc);

            graficoImc.ChartAreas["AreaIMC"].AxisY.Maximum = Math.Max(40, Math.Ceiling(imc / 10) * 10 + 10);
        }
    }
}
