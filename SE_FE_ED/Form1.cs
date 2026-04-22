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
            timerPanel.Interval = 15;
            timerPanel.Start();
        }
        double temperatura = 0, tempPredict = 0, tempMin = 0, tempMax = 0, tempAmb = 0;
        decimal porcentajeActual=0, porcentajeObjetivo=0, temporal;

        private void timerPanel_Tick(object sender, EventArgs e)
        {
            if (porcentajeObjetivo >= 100)
                porcentajeObjetivo = 100;
            else if (porcentajeObjetivo <= 0)
                porcentajeObjetivo = 0;

            lblPotencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            porcentajeActual += (porcentajeObjetivo - porcentajeActual) / 5;
            porcentajeObjetivo = Math.Round(porcentajeObjetivo,2, MidpointRounding.AwayFromZero);
            temporal = Math.Round(porcentajeActual, 2, MidpointRounding.AwayFromZero);
            lblPotencia.Text = $"{temporal}%";

            if (Math.Abs(porcentajeActual - porcentajeObjetivo) < 1)
            {
                porcentajeActual = porcentajeObjetivo;
                lblPotencia.Text = $"{porcentajeActual}%";
                timerPanel.Stop();
            }
            plPotencia.Invalidate();
            lblPotencia.Paint += lblPotencia_Paint;
            lblPotencia.Invalidate();
        }

        private void PanelFan_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(plPotencia.ClientRectangle, Color.FromArgb(174, 218, 255), Color.FromArgb(137, 147, 255), 0f))   // color final
            {
                int ancho = (int)(plPotencia.Width * porcentajeActual / 100);

                e.Graphics.FillRectangle(brush, 0, 0, ancho, plPotencia.Height);
            }
        }

        private void lblPotencia_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(lblPotencia.BackColor);

            var colores = ObtenerColores(porcentajeActual);

            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(lblPotencia.ClientRectangle, colores.inicio, colores.fin,0f))
            {
                using (var formato = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                {
                    e.Graphics.DrawString(
                        lblPotencia.Text,
                        lblPotencia.Font,
                        brush,
                        lblPotencia.ClientRectangle,
                        formato
                    );
                }
            }
        }

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

        private (Color inicio, Color fin) ObtenerColores(decimal porcentaje)
        {
            if (porcentaje < 30)
                return (Color.FromArgb(246, 246, 246), Color.FromArgb(174, 218, 255));

            if (porcentaje < 60)
                return (Color.FromArgb(174, 218, 255), Color.FromArgb(85, 154, 255));

            if (porcentaje < 85)
                return (Color.FromArgb(85, 154, 255), Color.FromArgb(137, 147, 255));

            return (Color.FromArgb(137, 147, 255), Color.FromArgb(137, 147, 255));
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
