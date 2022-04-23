
namespace TP03SIMULACION
{
    partial class FormGraficoExponencial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtCantIntervalos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExponencialF = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDeClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.chDistribucion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.desde0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaObservada0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaEsperada0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAcumulativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalculadoRes = new System.Windows.Forms.Label();
            this.lblTablaRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencialF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(143, 15);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(100, 20);
            this.txtCantIntervalos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad intervalos:";
            // 
            // dgvExponencialF
            // 
            this.dgvExponencialF.AllowUserToAddRows = false;
            this.dgvExponencialF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExponencialF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.marcaDeClase,
            this.frecuenciaObservada,
            this.probabilidad,
            this.frecuenciaEsperada});
            this.dgvExponencialF.Location = new System.Drawing.Point(40, 41);
            this.dgvExponencialF.Name = "dgvExponencialF";
            this.dgvExponencialF.Size = new System.Drawing.Size(645, 236);
            this.dgvExponencialF.TabIndex = 2;
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.Name = "desde";
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.Name = "hasta";
            // 
            // marcaDeClase
            // 
            this.marcaDeClase.HeaderText = "Marca De Clase";
            this.marcaDeClase.Name = "marcaDeClase";
            // 
            // frecuenciaObservada
            // 
            this.frecuenciaObservada.HeaderText = "Frecuencia Observada";
            this.frecuenciaObservada.Name = "frecuenciaObservada";
            // 
            // probabilidad
            // 
            this.probabilidad.HeaderText = "Probabilidad";
            this.probabilidad.Name = "probabilidad";
            // 
            // frecuenciaEsperada
            // 
            this.frecuenciaEsperada.HeaderText = "Frecuencia Esperada";
            this.frecuenciaEsperada.Name = "frecuenciaEsperada";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(280, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // chDistribucion
            // 
            chartArea2.Name = "ChartArea1";
            this.chDistribucion.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chDistribucion.Legends.Add(legend2);
            this.chDistribucion.Location = new System.Drawing.Point(40, 298);
            this.chDistribucion.Name = "chDistribucion";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chDistribucion.Series.Add(series2);
            this.chDistribucion.Size = new System.Drawing.Size(557, 336);
            this.chDistribucion.TabIndex = 4;
            this.chDistribucion.Text = "chart1";
            // 
            // dgvChi
            // 
            this.dgvChi.AllowUserToAddRows = false;
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde0,
            this.hasta0,
            this.frecuenciaObservada0,
            this.frecuenciaEsperada0,
            this.c,
            this.cAcumulativo});
            this.dgvChi.Location = new System.Drawing.Point(703, 41);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.Size = new System.Drawing.Size(645, 236);
            this.dgvChi.TabIndex = 5;
            // 
            // desde0
            // 
            this.desde0.HeaderText = "Desde";
            this.desde0.Name = "desde0";
            // 
            // hasta0
            // 
            this.hasta0.HeaderText = "Hasta";
            this.hasta0.Name = "hasta0";
            // 
            // frecuenciaObservada0
            // 
            this.frecuenciaObservada0.HeaderText = "Frecuencia Observada";
            this.frecuenciaObservada0.Name = "frecuenciaObservada0";
            // 
            // frecuenciaEsperada0
            // 
            this.frecuenciaEsperada0.HeaderText = "Frecuencia Esperada";
            this.frecuenciaEsperada0.Name = "frecuenciaEsperada0";
            // 
            // c
            // 
            this.c.HeaderText = "C()";
            this.c.Name = "c";
            // 
            // cAcumulativo
            // 
            this.cAcumulativo.HeaderText = "C(Acu)";
            this.cAcumulativo.Name = "cAcumulativo";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(703, 335);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(0, 13);
            this.lblConclusion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor calculado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor tabulado:";
            // 
            // lblCalculadoRes
            // 
            this.lblCalculadoRes.AutoSize = true;
            this.lblCalculadoRes.Location = new System.Drawing.Point(793, 284);
            this.lblCalculadoRes.Name = "lblCalculadoRes";
            this.lblCalculadoRes.Size = new System.Drawing.Size(0, 13);
            this.lblCalculadoRes.TabIndex = 9;
            // 
            // lblTablaRes
            // 
            this.lblTablaRes.AutoSize = true;
            this.lblTablaRes.Location = new System.Drawing.Point(793, 311);
            this.lblTablaRes.Name = "lblTablaRes";
            this.lblTablaRes.Size = new System.Drawing.Size(0, 13);
            this.lblTablaRes.TabIndex = 10;
            // 
            // FormGraficoExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblTablaRes);
            this.Controls.Add(this.lblCalculadoRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.dgvChi);
            this.Controls.Add(this.chDistribucion);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvExponencialF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantIntervalos);
            this.Name = "FormGraficoExponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGraficoExponencial";
            this.Load += new System.EventHandler(this.FormGraficoExponencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencialF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantIntervalos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExponencialF;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDeClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsperada;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDistribucion;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde0;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta0;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaObservada0;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsperada0;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAcumulativo;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCalculadoRes;
        private System.Windows.Forms.Label lblTablaRes;
    }
}