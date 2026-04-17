using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;
using System.Xml;

namespace SE_FE_ED
{
    public partial class Form1 : Form
    {
        LineSeries serTemp;
        LineSeries tempTeórica;
        LineSeries tempAmbiental;
        public Form1()
        {
            InitializeComponent();
            //Aquí empieza la configuración del chart
            serTemp = new LineSeries { Title = "Temperatura (C°)", Values = new ChartValues<double>(), Stroke = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFrom("#8993FF"), Fill = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFromString("#41AEDAFF"), PointGeometrySize = 0 };
            chTemp.AxisY.Add(new Axis{Title = "Temperatura (°C)", MinValue = 0, MaxValue = 100});
            chTemp.AxisX.Add(new Axis { Title = "Tiempo (s)", MinValue = 0 /*, MaxValue = 30*/ });
            tempTeórica = new LineSeries {Title = "Temperatura teórica", Values = new ChartValues<double>(), Stroke = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFrom("#AEDAFF"), Fill = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFrom("#31F6F6F6"), PointGeometrySize = 0 };
            tempAmbiental = new LineSeries { Title = "Temperatura ambiental", Values = new ChartValues<double>(), Stroke = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFrom("#559AFF"), Fill = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFrom("#311F2A44"), PointGeometrySize = 0};
            chTemp.Series = new SeriesCollection { serTemp, tempTeórica, tempAmbiental };

            //Aquí empieza la configuración de las barras tipo 'Speedtest' pq la configuración desde el menú de propiedades está bugueada y no se guarda ningún cambio, y yo no sé pq
            gauTemp.From = 0;
            gauTemp.To = 100;
            gauTemp.FromColor = (System.Windows.Media.Color)new System.Windows.Media.ColorConverter().ConvertFrom("#FFAEDAFF");
            gauTemp.ToColor = (System.Windows.Media.Color)new System.Windows.Media.ColorConverter().ConvertFrom("#FF8993FF");
            gauTemp.ForeGround = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFrom("#FFF6F6F6");
            gauPredict.From = 0;
            gauPredict.To = 100;
            gauPredict.FromColor = (System.Windows.Media.Color)new System.Windows.Media.ColorConverter().ConvertFrom("#FFF6F6F6");
            gauPredict.ToColor = (System.Windows.Media.Color)new System.Windows.Media.ColorConverter().ConvertFrom("#FFAEDAFF");
            gauPredict.ForeGround = (System.Windows.Media.Brush)new System.Windows.Media.BrushConverter().ConvertFrom("#FFF6F6F6");

            //Configuración del timer
            contador.Interval = 1000;
            contador.Start();
        }
        double temperatura = 0, tempPredict = 0, tempMin = 0, tempMax = 0, tempAmb = 0;

        int segundos = -1, minutos = 0, horas = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            //chTemp.AxisX[0].MaxValue = segundos + 2; <- PROBAR CON EL SENSOR CONECTADO

            segundos++;
            if (segundos >= 60)
            {
                segundos = 0;
                minutos++;
            }
            
            if(minutos >= 60)
            {
                minutos = 0;
                horas++;
            }

            lblContador.Text = $"{horas}h | {minutos}m | {segundos}s";
        }

        private void ActualizaciónDatos()
        {
            serTemp.Values.Add(temperatura);
            tempTeórica.Values.Add(tempPredict);
            tempAmbiental.Values.Add(tempAmb);
            lblTemAmb.Text = Convert.ToString(tempAmb);

            if (tempMin == 0 || serTemp.Values.Count < 1)
            {
                tempMin = temperatura;
                lblMínima.Text = Convert.ToString(tempMin);
            }
            else if (temperatura < tempMin)
            {
                tempMin = temperatura;
                lblMínima.Text = Convert.ToString(tempMin);
            }

            if (temperatura > tempMax)
            {
                tempMax = temperatura;
                lblMáxima.Text = Convert.ToString(tempMax);
            }

            if(temperatura <= 45)
            {
                lblEstado.Text = "Bajo";
                lblEstado.ForeColor = Color.FromArgb(0, 246, 246, 246);
            }
            else if(temperatura >= 46 && temperatura <= 70)
            {
                lblEstado.Text = "Normal";
                lblEstado.ForeColor = Color.FromArgb(0, 174, 218, 255);
            }
            else if(temperatura >= 71 && temperatura <= 84)
            {
                lblEstado.Text = "Alto";
                lblEstado.ForeColor = Color.FromArgb(0, 85, 154, 255);
            }
            else
            {
                lblEstado.Text = "Crítico";
                lblEstado.ForeColor = Color.FromArgb(0, 137, 147, 255);
            }
        }
    }
}
