
namespace TP03SIMULACION
{
    partial class FormGraficoJiCuadradoNORMALMULLER
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
            this.dgvFrecuenciaNormal = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDeClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantIntervalos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarGrafico = new System.Windows.Forms.Button();
            this.chDistribucionNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvChiCuadrado = new System.Windows.Forms.DataGridView();
            this.desde0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaObservada0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaEsperada0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalculadoRes = new System.Windows.Forms.Label();
            this.lblTablaRes = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuenciaNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDistribucionNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrecuenciaNormal
            // 
            this.dgvFrecuenciaNormal.AllowUserToAddRows = false;
            this.dgvFrecuenciaNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuenciaNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.marcaDeClase,
            this.frecuenciaObservada,
            this.probabilidad,
            this.frecuenciaEsperada});
            this.dgvFrecuenciaNormal.Location = new System.Drawing.Point(41, 60);
            this.dgvFrecuenciaNormal.Name = "dgvFrecuenciaNormal";
            this.dgvFrecuenciaNormal.Size = new System.Drawing.Size(644, 225);
            this.dgvFrecuenciaNormal.TabIndex = 0;
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
            this.marcaDeClase.HeaderText = "Marca de Clase";
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
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(162, 23);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(74, 20);
            this.txtCantIntervalos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de intervalos:";
            // 
            // btnGenerarGrafico
            // 
            this.btnGenerarGrafico.Location = new System.Drawing.Point(242, 17);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(126, 31);
            this.btnGenerarGrafico.TabIndex = 3;
            this.btnGenerarGrafico.Text = "Generar Grafico";
            this.btnGenerarGrafico.UseVisualStyleBackColor = true;
            this.btnGenerarGrafico.Click += new System.EventHandler(this.btnGenerarGrafico_Click);
            // 
            // chDistribucionNormal
            // 
            chartArea1.Name = "ChartArea1";
            this.chDistribucionNormal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chDistribucionNormal.Legends.Add(legend1);
            this.chDistribucionNormal.Location = new System.Drawing.Point(44, 340);
            this.chDistribucionNormal.Name = "chDistribucionNormal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chDistribucionNormal.Series.Add(series1);
            this.chDistribucionNormal.Size = new System.Drawing.Size(587, 371);
            this.chDistribucionNormal.TabIndex = 4;
            this.chDistribucionNormal.Text = "chart1";
            // 
            // dgvChiCuadrado
            // 
            this.dgvChiCuadrado.AllowUserToAddRows = false;
            this.dgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiCuadrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde0,
            this.hasta0,
            this.frecuenciaObservada0,
            this.frecuenciaEsperada0,
            this.c,
            this.cAcu});
            this.dgvChiCuadrado.Location = new System.Drawing.Point(706, 60);
            this.dgvChiCuadrado.Name = "dgvChiCuadrado";
            this.dgvChiCuadrado.Size = new System.Drawing.Size(643, 225);
            this.dgvChiCuadrado.TabIndex = 5;
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
            // cAcu
            // 
            this.cAcu.HeaderText = "C(acu)";
            this.cAcu.Name = "cAcu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor calculado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor tabulado:";
            // 
            // lblCalculadoRes
            // 
            this.lblCalculadoRes.AutoSize = true;
            this.lblCalculadoRes.Location = new System.Drawing.Point(791, 310);
            this.lblCalculadoRes.Name = "lblCalculadoRes";
            this.lblCalculadoRes.Size = new System.Drawing.Size(0, 13);
            this.lblCalculadoRes.TabIndex = 11;
            // 
            // lblTablaRes
            // 
            this.lblTablaRes.AutoSize = true;
            this.lblTablaRes.Location = new System.Drawing.Point(791, 340);
            this.lblTablaRes.Name = "lblTablaRes";
            this.lblTablaRes.Size = new System.Drawing.Size(0, 13);
            this.lblTablaRes.TabIndex = 12;
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(709, 374);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(0, 13);
            this.lblConclusion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(933, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "CHI CUADRADO";
            // 
            // FormGraficoJiCuadradoNORMALMULLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.lblTablaRes);
            this.Controls.Add(this.lblCalculadoRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvChiCuadrado);
            this.Controls.Add(this.chDistribucionNormal);
            this.Controls.Add(this.btnGenerarGrafico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantIntervalos);
            this.Controls.Add(this.dgvFrecuenciaNormal);
            this.Name = "FormGraficoJiCuadradoNORMALMULLER";
            this.Text = "FormGraficoJiCuadradoNORMALMULLER";
            this.Load += new System.EventHandler(this.FormGraficoJiCuadradoNORMALMULLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuenciaNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDistribucionNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrecuenciaNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDeClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsperada;
        private System.Windows.Forms.TextBox txtCantIntervalos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDistribucionNormal;
        private System.Windows.Forms.DataGridView dgvChiCuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde0;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta0;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaObservada0;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsperada0;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAcu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCalculadoRes;
        private System.Windows.Forms.Label lblTablaRes;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label label4;
    }
}