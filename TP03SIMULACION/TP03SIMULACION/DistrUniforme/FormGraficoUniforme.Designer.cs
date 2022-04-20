
namespace TP03SIMULACION.DistrUniforme
{
    partial class FormGraficoUniforme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtUniforme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cx8 = new System.Windows.Forms.CheckBox();
            this.cx10 = new System.Windows.Forms.CheckBox();
            this.cx15 = new System.Windows.Forms.CheckBox();
            this.cx20 = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dvgChi = new System.Windows.Forms.DataGridView();
            this.Desde2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaObservada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaEsperada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cacu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chrtChi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCantIntervalos = new System.Windows.Forms.TextBox();
            this.dgvFrecuencia = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtUniforme
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtUniforme.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtUniforme.Legends.Add(legend1);
            this.chrtUniforme.Location = new System.Drawing.Point(6, 438);
            this.chrtUniforme.Name = "chrtUniforme";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtUniforme.Series.Add(series1);
            this.chrtUniforme.Size = new System.Drawing.Size(813, 448);
            this.chrtUniforme.TabIndex = 0;
            this.chrtUniforme.Text = "DistribucionUniforme";
            this.chrtUniforme.Click += new System.EventHandler(this.chrtUniforme_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 25);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad De Intervalos";
            // 
            // cx8
            // 
            this.cx8.AutoSize = true;
            this.cx8.Location = new System.Drawing.Point(271, 27);
            this.cx8.Name = "cx8";
            this.cx8.Size = new System.Drawing.Size(103, 21);
            this.cx8.TabIndex = 4;
            this.cx8.Text = "8 Intervalos";
            this.cx8.UseVisualStyleBackColor = true;
            this.cx8.CheckedChanged += new System.EventHandler(this.cx8_CheckedChanged);
            // 
            // cx10
            // 
            this.cx10.AutoSize = true;
            this.cx10.Location = new System.Drawing.Point(380, 27);
            this.cx10.Name = "cx10";
            this.cx10.Size = new System.Drawing.Size(111, 21);
            this.cx10.TabIndex = 5;
            this.cx10.Text = "10 intervalos";
            this.cx10.UseVisualStyleBackColor = true;
            this.cx10.CheckedChanged += new System.EventHandler(this.cx10_CheckedChanged);
            // 
            // cx15
            // 
            this.cx15.AutoSize = true;
            this.cx15.Location = new System.Drawing.Point(497, 27);
            this.cx15.Name = "cx15";
            this.cx15.Size = new System.Drawing.Size(111, 21);
            this.cx15.TabIndex = 6;
            this.cx15.Text = "15 Intervalos";
            this.cx15.UseVisualStyleBackColor = true;
            this.cx15.CheckedChanged += new System.EventHandler(this.cx15_CheckedChanged);
            // 
            // cx20
            // 
            this.cx20.AutoSize = true;
            this.cx20.Location = new System.Drawing.Point(614, 27);
            this.cx20.Name = "cx20";
            this.cx20.Size = new System.Drawing.Size(111, 21);
            this.cx20.TabIndex = 7;
            this.cx20.Text = "20 Intervalos";
            this.cx20.UseVisualStyleBackColor = true;
            this.cx20.CheckedChanged += new System.EventHandler(this.cx20_CheckedChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(775, 28);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dvgChi
            // 
            this.dvgChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desde2,
            this.Hasta2,
            this.FrecuenciaObservada2,
            this.FrecuenciaEsperada2,
            this.C,
            this.Cacu,
            this.Column1});
            this.dvgChi.Location = new System.Drawing.Point(849, 140);
            this.dvgChi.Name = "dvgChi";
            this.dvgChi.RowHeadersWidth = 51;
            this.dvgChi.RowTemplate.Height = 24;
            this.dvgChi.Size = new System.Drawing.Size(931, 265);
            this.dvgChi.TabIndex = 9;
            // 
            // Desde2
            // 
            this.Desde2.HeaderText = "Desde";
            this.Desde2.MinimumWidth = 6;
            this.Desde2.Name = "Desde2";
            this.Desde2.ReadOnly = true;
            this.Desde2.Width = 125;
            // 
            // Hasta2
            // 
            this.Hasta2.HeaderText = "Hasta";
            this.Hasta2.MinimumWidth = 6;
            this.Hasta2.Name = "Hasta2";
            this.Hasta2.ReadOnly = true;
            this.Hasta2.Width = 125;
            // 
            // FrecuenciaObservada2
            // 
            this.FrecuenciaObservada2.HeaderText = "Frecuencia Observada";
            this.FrecuenciaObservada2.MinimumWidth = 6;
            this.FrecuenciaObservada2.Name = "FrecuenciaObservada2";
            this.FrecuenciaObservada2.ReadOnly = true;
            this.FrecuenciaObservada2.Width = 125;
            // 
            // FrecuenciaEsperada2
            // 
            this.FrecuenciaEsperada2.HeaderText = "Frecuencia Esperada";
            this.FrecuenciaEsperada2.MinimumWidth = 6;
            this.FrecuenciaEsperada2.Name = "FrecuenciaEsperada2";
            this.FrecuenciaEsperada2.ReadOnly = true;
            this.FrecuenciaEsperada2.Width = 125;
            // 
            // C
            // 
            this.C.HeaderText = "C()";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 125;
            // 
            // Cacu
            // 
            this.Cacu.HeaderText = "C(acu)";
            this.Cacu.MinimumWidth = 6;
            this.Cacu.Name = "Cacu";
            this.Cacu.ReadOnly = true;
            this.Cacu.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // chrtChi
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtChi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtChi.Legends.Add(legend2);
            this.chrtChi.Location = new System.Drawing.Point(902, 438);
            this.chrtChi.Name = "chrtChi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtChi.Series.Add(series2);
            this.chrtChi.Size = new System.Drawing.Size(810, 481);
            this.chrtChi.TabIndex = 10;
            this.chrtChi.Text = "Chi-Cuadrado";
            this.chrtChi.Click += new System.EventHandler(this.chrtChi_Click);
            // 
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(128, 63);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(100, 22);
            this.txtCantIntervalos.TabIndex = 11;
            this.txtCantIntervalos.TextChanged += new System.EventHandler(this.txtCantIntervalos_TextChanged);
            // 
            // dgvFrecuencia
            // 
            this.dgvFrecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.marcaClase,
            this.frecuenciaObservada,
            this.probabilidad,
            this.frecuenciaEsperada});
            this.dgvFrecuencia.Location = new System.Drawing.Point(12, 140);
            this.dgvFrecuencia.Name = "dgvFrecuencia";
            this.dgvFrecuencia.RowHeadersWidth = 51;
            this.dgvFrecuencia.RowTemplate.Height = 24;
            this.dgvFrecuencia.Size = new System.Drawing.Size(807, 265);
            this.dgvFrecuencia.TabIndex = 12;
            this.dgvFrecuencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrecuencia_CellContentClick);
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.MinimumWidth = 6;
            this.desde.Name = "desde";
            this.desde.Width = 125;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.MinimumWidth = 6;
            this.hasta.Name = "hasta";
            this.hasta.Width = 125;
            // 
            // marcaClase
            // 
            this.marcaClase.HeaderText = "Marca De Clase";
            this.marcaClase.MinimumWidth = 6;
            this.marcaClase.Name = "marcaClase";
            this.marcaClase.Width = 125;
            // 
            // frecuenciaObservada
            // 
            this.frecuenciaObservada.HeaderText = "Frecuencia Observada";
            this.frecuenciaObservada.MinimumWidth = 6;
            this.frecuenciaObservada.Name = "frecuenciaObservada";
            this.frecuenciaObservada.Width = 125;
            // 
            // probabilidad
            // 
            this.probabilidad.HeaderText = "Probabilidad";
            this.probabilidad.MinimumWidth = 6;
            this.probabilidad.Name = "probabilidad";
            this.probabilidad.Width = 125;
            // 
            // frecuenciaEsperada
            // 
            this.frecuenciaEsperada.HeaderText = "Frecuencia Esperada";
            this.frecuenciaEsperada.MinimumWidth = 6;
            this.frecuenciaEsperada.Name = "frecuenciaEsperada";
            this.frecuenciaEsperada.Width = 125;
            // 
            // Generar2
            // 
            this.Generar2.Location = new System.Drawing.Point(614, 63);
            this.Generar2.Name = "Generar2";
            this.Generar2.Size = new System.Drawing.Size(84, 23);
            this.Generar2.TabIndex = 13;
            this.Generar2.Text = "Generar2";
            this.Generar2.UseVisualStyleBackColor = true;
            this.Generar2.Click += new System.EventHandler(this.Generar2_Click);
            // 
            // FormGraficoUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1863, 991);
            this.Controls.Add(this.Generar2);
            this.Controls.Add(this.dgvFrecuencia);
            this.Controls.Add(this.txtCantIntervalos);
            this.Controls.Add(this.chrtChi);
            this.Controls.Add(this.dvgChi);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cx20);
            this.Controls.Add(this.cx15);
            this.Controls.Add(this.cx10);
            this.Controls.Add(this.cx8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.chrtUniforme);
            this.Name = "FormGraficoUniforme";
            this.Text = "Grafico Uniforme";
            this.Load += new System.EventHandler(this.FormGraficoUniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtUniforme;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cx8;
        private System.Windows.Forms.CheckBox cx10;
        private System.Windows.Forms.CheckBox cx15;
        private System.Windows.Forms.CheckBox cx20;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dvgChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaObservada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaEsperada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cacu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtChi;
        private System.Windows.Forms.TextBox txtCantIntervalos;
        private System.Windows.Forms.DataGridView dgvFrecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsperada;
        private System.Windows.Forms.Button Generar2;
    }
}