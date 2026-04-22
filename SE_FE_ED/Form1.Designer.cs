namespace SE_FE_ED
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chTemp = new LiveCharts.WinForms.CartesianChart();
            this.gauTemp = new LiveCharts.WinForms.SolidGauge();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblGráfica = new System.Windows.Forms.Label();
            this.lblTempMin = new System.Windows.Forms.Label();
            this.lblTempMax = new System.Windows.Forms.Label();
            this.lblMínima = new System.Windows.Forms.Label();
            this.lblMáxima = new System.Windows.Forms.Label();
            this.lblEstadoTitle = new System.Windows.Forms.Label();
            this.gauPredict = new LiveCharts.WinForms.SolidGauge();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPred = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblTiempoTitle = new System.Windows.Forms.Label();
            this.contador = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTemAmb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plPotencia = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.timerPanel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chTemp
            // 
            this.chTemp.Location = new System.Drawing.Point(41, 371);
            this.chTemp.Name = "chTemp";
            this.chTemp.Size = new System.Drawing.Size(819, 231);
            this.chTemp.TabIndex = 0;
            this.chTemp.Text = "cartesianChart1";
            // 
            // gauTemp
            // 
            this.gauTemp.Location = new System.Drawing.Point(55, 20);
            this.gauTemp.Name = "gauTemp";
            this.gauTemp.Size = new System.Drawing.Size(225, 168);
            this.gauTemp.TabIndex = 1;
            this.gauTemp.Text = "solidGauge1";
            // 
            // lblTemp
            // 
            this.lblTemp.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblTemp.Location = new System.Drawing.Point(55, 25);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(225, 23);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "Temperatura actual (C°)";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGráfica
            // 
            this.lblGráfica.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGráfica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblGráfica.Location = new System.Drawing.Point(66, 605);
            this.lblGráfica.Name = "lblGráfica";
            this.lblGráfica.Size = new System.Drawing.Size(794, 23);
            this.lblGráfica.TabIndex = 5;
            this.lblGráfica.Text = "Historial de temperatura";
            this.lblGráfica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempMin
            // 
            this.lblTempMin.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblTempMin.Location = new System.Drawing.Point(341, 65);
            this.lblTempMin.Name = "lblTempMin";
            this.lblTempMin.Size = new System.Drawing.Size(294, 23);
            this.lblTempMin.TabIndex = 6;
            this.lblTempMin.Text = "Temp Mín (C°)\r\n";
            this.lblTempMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempMax
            // 
            this.lblTempMax.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblTempMax.Location = new System.Drawing.Point(345, 227);
            this.lblTempMax.Name = "lblTempMax";
            this.lblTempMax.Size = new System.Drawing.Size(290, 23);
            this.lblTempMax.TabIndex = 7;
            this.lblTempMax.Text = "Temp Máx (C°)";
            this.lblTempMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMínima
            // 
            this.lblMínima.BackColor = System.Drawing.Color.Transparent;
            this.lblMínima.Font = new System.Drawing.Font("Poppins", 50F, System.Drawing.FontStyle.Bold);
            this.lblMínima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.lblMínima.Location = new System.Drawing.Point(339, 65);
            this.lblMínima.Name = "lblMínima";
            this.lblMínima.Size = new System.Drawing.Size(308, 100);
            this.lblMínima.TabIndex = 8;
            this.lblMínima.Text = "00.00";
            this.lblMínima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMáxima
            // 
            this.lblMáxima.BackColor = System.Drawing.Color.Transparent;
            this.lblMáxima.Font = new System.Drawing.Font("Poppins", 50F, System.Drawing.FontStyle.Bold);
            this.lblMáxima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.lblMáxima.Location = new System.Drawing.Point(339, 227);
            this.lblMáxima.Name = "lblMáxima";
            this.lblMáxima.Size = new System.Drawing.Size(313, 108);
            this.lblMáxima.TabIndex = 9;
            this.lblMáxima.Text = "00.00";
            this.lblMáxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstadoTitle
            // 
            this.lblEstadoTitle.Font = new System.Drawing.Font("Poppins SemiBold", 15F);
            this.lblEstadoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblEstadoTitle.Location = new System.Drawing.Point(714, 88);
            this.lblEstadoTitle.Name = "lblEstadoTitle";
            this.lblEstadoTitle.Size = new System.Drawing.Size(146, 44);
            this.lblEstadoTitle.TabIndex = 10;
            this.lblEstadoTitle.Text = "Estado:";
            this.lblEstadoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gauPredict
            // 
            this.gauPredict.Location = new System.Drawing.Point(55, 197);
            this.gauPredict.Name = "gauPredict";
            this.gauPredict.Size = new System.Drawing.Size(225, 168);
            this.gauPredict.TabIndex = 12;
            this.gauPredict.Text = "solidGauge1";
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblEstado.Location = new System.Drawing.Point(714, 129);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(146, 44);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Sin datos";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPred
            // 
            this.lblPred.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblPred.Location = new System.Drawing.Point(55, 197);
            this.lblPred.Name = "lblPred";
            this.lblPred.Size = new System.Drawing.Size(225, 23);
            this.lblPred.TabIndex = 13;
            this.lblPred.Text = "Pred. Temp. en [c] segundos";
            this.lblPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.lblContador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblContador.Location = new System.Drawing.Point(433, 668);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(202, 44);
            this.lblContador.TabIndex = 15;
            this.lblContador.Text = "0h | 0m | 0s";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempoTitle
            // 
            this.lblTiempoTitle.Font = new System.Drawing.Font("Poppins SemiBold", 15F);
            this.lblTiempoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblTiempoTitle.Location = new System.Drawing.Point(310, 668);
            this.lblTiempoTitle.Name = "lblTiempoTitle";
            this.lblTiempoTitle.Size = new System.Drawing.Size(146, 44);
            this.lblTiempoTitle.TabIndex = 14;
            this.lblTiempoTitle.Text = "Tiempo:";
            this.lblTiempoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contador
            // 
            this.contador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(695, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Temp Ambiental (C°)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemAmb
            // 
            this.lblTemAmb.BackColor = System.Drawing.Color.Transparent;
            this.lblTemAmb.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold);
            this.lblTemAmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblTemAmb.Location = new System.Drawing.Point(690, 263);
            this.lblTemAmb.Name = "lblTemAmb";
            this.lblTemAmb.Size = new System.Drawing.Size(206, 68);
            this.lblTemAmb.TabIndex = 19;
            this.lblTemAmb.Text = "00.00";
            this.lblTemAmb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 576);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // plPotencia
            // 
            this.plPotencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.plPotencia.Location = new System.Drawing.Point(59, 753);
            this.plPotencia.Name = "plPotencia";
            this.plPotencia.Size = new System.Drawing.Size(801, 17);
            this.plPotencia.TabIndex = 21;
            this.plPotencia.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFan_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(56, 725);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Potencia del ventilador:";
            // 
            // lblPotencia
            // 
            this.lblPotencia.Font = new System.Drawing.Font("Poppins", 17F, System.Drawing.FontStyle.Bold);
            this.lblPotencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblPotencia.Location = new System.Drawing.Point(722, 711);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(138, 39);
            this.lblPotencia.TabIndex = 23;
            this.lblPotencia.Text = "00.00%";
            this.lblPotencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerPanel
            // 
            this.timerPanel.Tick += new System.EventHandler(this.timerPanel_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(911, 798);
            this.Controls.Add(this.plPotencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTemAmb);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblTiempoTitle);
            this.Controls.Add(this.lblPred);
            this.Controls.Add(this.gauPredict);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEstadoTitle);
            this.Controls.Add(this.lblTempMax);
            this.Controls.Add(this.lblTempMin);
            this.Controls.Add(this.lblGráfica);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.gauTemp);
            this.Controls.Add(this.chTemp);
            this.Controls.Add(this.lblMínima);
            this.Controls.Add(this.lblMáxima);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPotencia);
            this.Name = "Form1";
            this.Text = "Sistema de monitoreo de temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chTemp;
        private LiveCharts.WinForms.SolidGauge gauTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblGráfica;
        private System.Windows.Forms.Label lblTempMin;
        private System.Windows.Forms.Label lblTempMax;
        private System.Windows.Forms.Label lblMínima;
        private System.Windows.Forms.Label lblMáxima;
        private System.Windows.Forms.Label lblEstadoTitle;
        private LiveCharts.WinForms.SolidGauge gauPredict;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPred;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblTiempoTitle;
        private System.Windows.Forms.Timer contador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTemAmb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plPotencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Timer timerPanel;
    }
}

