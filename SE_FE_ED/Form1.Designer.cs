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
            this.chTemp = new LiveCharts.WinForms.CartesianChart();
            this.gauTemp = new LiveCharts.WinForms.SolidGauge();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblGráfica = new System.Windows.Forms.Label();
            this.lblTempMin = new System.Windows.Forms.Label();
            this.lblTempMax = new System.Windows.Forms.Label();
            this.lblMínima = new System.Windows.Forms.Label();
            this.lblMáxima = new System.Windows.Forms.Label();
            this.lblEstadoTitle = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chTemp
            // 
            this.chTemp.Location = new System.Drawing.Point(41, 209);
            this.chTemp.Name = "chTemp";
            this.chTemp.Size = new System.Drawing.Size(709, 191);
            this.chTemp.TabIndex = 0;
            this.chTemp.Text = "cartesianChart1";
            // 
            // gauTemp
            // 
            this.gauTemp.Location = new System.Drawing.Point(55, 34);
            this.gauTemp.Name = "gauTemp";
            this.gauTemp.Size = new System.Drawing.Size(225, 168);
            this.gauTemp.TabIndex = 1;
            this.gauTemp.Text = "solidGauge1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Probar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
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
            this.lblGráfica.Location = new System.Drawing.Point(66, 402);
            this.lblGráfica.Name = "lblGráfica";
            this.lblGráfica.Size = new System.Drawing.Size(684, 23);
            this.lblGráfica.TabIndex = 5;
            this.lblGráfica.Text = "Historial de temperatura";
            this.lblGráfica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempMin
            // 
            this.lblTempMin.AutoSize = true;
            this.lblTempMin.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblTempMin.Location = new System.Drawing.Point(356, 25);
            this.lblTempMin.Name = "lblTempMin";
            this.lblTempMin.Size = new System.Drawing.Size(108, 23);
            this.lblTempMin.TabIndex = 6;
            this.lblTempMin.Text = "Temp Mín (C°)\r\n";
            this.lblTempMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempMax
            // 
            this.lblTempMax.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblTempMax.Location = new System.Drawing.Point(561, 25);
            this.lblTempMax.Name = "lblTempMax";
            this.lblTempMax.Size = new System.Drawing.Size(153, 23);
            this.lblTempMax.TabIndex = 7;
            this.lblTempMax.Text = "Temp Máx (C°)";
            this.lblTempMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMínima
            // 
            this.lblMínima.BackColor = System.Drawing.Color.Transparent;
            this.lblMínima.Font = new System.Drawing.Font("Poppins", 50F, System.Drawing.FontStyle.Bold);
            this.lblMínima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.lblMínima.Location = new System.Drawing.Point(322, 25);
            this.lblMínima.Name = "lblMínima";
            this.lblMínima.Size = new System.Drawing.Size(186, 126);
            this.lblMínima.TabIndex = 8;
            this.lblMínima.Text = "00";
            this.lblMínima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMáxima
            // 
            this.lblMáxima.BackColor = System.Drawing.Color.Transparent;
            this.lblMáxima.Font = new System.Drawing.Font("Poppins", 50F, System.Drawing.FontStyle.Bold);
            this.lblMáxima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.lblMáxima.Location = new System.Drawing.Point(517, 25);
            this.lblMáxima.Name = "lblMáxima";
            this.lblMáxima.Size = new System.Drawing.Size(255, 148);
            this.lblMáxima.TabIndex = 9;
            this.lblMáxima.Text = "000";
            this.lblMáxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstadoTitle
            // 
            this.lblEstadoTitle.AutoSize = true;
            this.lblEstadoTitle.Font = new System.Drawing.Font("Poppins SemiBold", 15F);
            this.lblEstadoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblEstadoTitle.Location = new System.Drawing.Point(352, 151);
            this.lblEstadoTitle.Name = "lblEstadoTitle";
            this.lblEstadoTitle.Size = new System.Drawing.Size(113, 44);
            this.lblEstadoTitle.TabIndex = 10;
            this.lblEstadoTitle.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblEstado.Location = new System.Drawing.Point(455, 151);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(146, 44);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Sin datos";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEstadoTitle);
            this.Controls.Add(this.lblTempMax);
            this.Controls.Add(this.lblTempMin);
            this.Controls.Add(this.lblGráfica);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gauTemp);
            this.Controls.Add(this.chTemp);
            this.Controls.Add(this.lblMínima);
            this.Controls.Add(this.lblMáxima);
            this.Name = "Form1";
            this.Text = "Sistema de monitoreo de temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chTemp;
        private LiveCharts.WinForms.SolidGauge gauTemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblGráfica;
        private System.Windows.Forms.Label lblTempMin;
        private System.Windows.Forms.Label lblTempMax;
        private System.Windows.Forms.Label lblMínima;
        private System.Windows.Forms.Label lblMáxima;
        private System.Windows.Forms.Label lblEstadoTitle;
        private System.Windows.Forms.Label lblEstado;
    }
}

