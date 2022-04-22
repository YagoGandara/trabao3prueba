
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
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.Desde2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaObservada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaEsperada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cacu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblCalculado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
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
            this.chrtUniforme.Location = new System.Drawing.Point(4, 356);
            this.chrtUniforme.Margin = new System.Windows.Forms.Padding(2);
            this.chrtUniforme.Name = "chrtUniforme";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtUniforme.Series.Add(series1);
            this.chrtUniforme.Size = new System.Drawing.Size(610, 364);
            this.chrtUniforme.TabIndex = 0;
            this.chrtUniforme.Text = "DistribucionUniforme";
            this.chrtUniforme.Click += new System.EventHandler(this.chrtUniforme_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(9, 20);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(56, 19);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad De Intervalos";
            // 
            // dgvChi
            // 
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desde2,
            this.Hasta2,
            this.FrecuenciaObservada2,
            this.FrecuenciaEsperada2,
            this.C2,
            this.Cacu2});
            this.dgvChi.Location = new System.Drawing.Point(637, 114);
            this.dgvChi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.RowHeadersWidth = 51;
            this.dgvChi.RowTemplate.Height = 24;
            this.dgvChi.Size = new System.Drawing.Size(698, 215);
            this.dgvChi.TabIndex = 9;
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
            // C2
            // 
            this.C2.HeaderText = "C()";
            this.C2.MinimumWidth = 6;
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 125;
            // 
            // Cacu2
            // 
            this.Cacu2.HeaderText = "C(acu)";
            this.Cacu2.MinimumWidth = 6;
            this.Cacu2.Name = "Cacu2";
            this.Cacu2.ReadOnly = true;
            this.Cacu2.Width = 125;
            // 
            // chrtChi
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtChi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtChi.Legends.Add(legend2);
            this.chrtChi.Location = new System.Drawing.Point(676, 356);
            this.chrtChi.Margin = new System.Windows.Forms.Padding(2);
            this.chrtChi.Name = "chrtChi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtChi.Series.Add(series2);
            this.chrtChi.Size = new System.Drawing.Size(608, 391);
            this.chrtChi.TabIndex = 10;
            this.chrtChi.Text = "Chi-Cuadrado";
            this.chrtChi.Click += new System.EventHandler(this.chrtChi_Click);
            // 
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(246, 20);
            this.txtCantIntervalos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(76, 20);
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
            this.dgvFrecuencia.Location = new System.Drawing.Point(9, 114);
            this.dgvFrecuencia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFrecuencia.Name = "dgvFrecuencia";
            this.dgvFrecuencia.RowHeadersWidth = 51;
            this.dgvFrecuencia.RowTemplate.Height = 24;
            this.dgvFrecuencia.Size = new System.Drawing.Size(605, 215);
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
            this.Generar2.Location = new System.Drawing.Point(343, 6);
            this.Generar2.Margin = new System.Windows.Forms.Padding(2);
            this.Generar2.Name = "Generar2";
            this.Generar2.Size = new System.Drawing.Size(63, 47);
            this.Generar2.TabIndex = 13;
            this.Generar2.Text = "Generar Grafico";
            this.Generar2.UseVisualStyleBackColor = true;
            this.Generar2.Click += new System.EventHandler(this.Generar2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(754, 20);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(84, 13);
            this.lbl2.TabIndex = 14;
            this.lbl2.Text = "Valor Calculado:";
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCalculado
            // 
            this.lblCalculado.AutoSize = true;
            this.lblCalculado.Location = new System.Drawing.Point(842, 20);
            this.lblCalculado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalculado.Name = "lblCalculado";
            this.lblCalculado.Size = new System.Drawing.Size(0, 13);
            this.lblCalculado.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Valor de Tabla";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(835, 54);
            this.lblTabla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(0, 13);
            this.lblTabla.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(754, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Conclusion: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(823, 81);
            this.lblConclusion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(0, 13);
            this.lblConclusion.TabIndex = 19;
            // 
            // FormGraficoUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1171, 609);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCalculado);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.Generar2);
            this.Controls.Add(this.dgvFrecuencia);
            this.Controls.Add(this.txtCantIntervalos);
            this.Controls.Add(this.chrtChi);
            this.Controls.Add(this.dgvChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.chrtUniforme);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGraficoUniforme";
            this.Text = "Grafico Uniforme";
            this.Load += new System.EventHandler(this.FormGraficoUniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtUniforme;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChi;
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
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblCalculado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaObservada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaEsperada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cacu2;
    }
}