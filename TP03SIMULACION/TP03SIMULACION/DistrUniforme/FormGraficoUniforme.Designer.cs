
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.dgvKs = new System.Windows.Forms.DataGridView();
            this.desde1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poacu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peacu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absPoacuPeacu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConcl = new System.Windows.Forms.Label();
            this.lblCal = new System.Windows.Forms.Label();
            this.lblTab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtUniforme
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtUniforme.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrtUniforme.Legends.Add(legend4);
            this.chrtUniforme.Location = new System.Drawing.Point(11, 301);
            this.chrtUniforme.Margin = new System.Windows.Forms.Padding(2);
            this.chrtUniforme.Name = "chrtUniforme";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrtUniforme.Series.Add(series4);
            this.chrtUniforme.Size = new System.Drawing.Size(603, 364);
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
            this.dgvChi.AllowUserToAddRows = false;
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desde2,
            this.Hasta2,
            this.FrecuenciaObservada2,
            this.FrecuenciaEsperada2,
            this.C2,
            this.Cacu2});
            this.dgvChi.Location = new System.Drawing.Point(680, 90);
            this.dgvChi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.RowHeadersWidth = 51;
            this.dgvChi.RowTemplate.Height = 24;
            this.dgvChi.Size = new System.Drawing.Size(655, 206);
            this.dgvChi.TabIndex = 9;
            this.dgvChi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChi_CellContentClick);
            // 
            // Desde2
            // 
            this.Desde2.HeaderText = "Desde";
            this.Desde2.MinimumWidth = 6;
            this.Desde2.Name = "Desde2";
            this.Desde2.ReadOnly = true;
            // 
            // Hasta2
            // 
            this.Hasta2.HeaderText = "Hasta";
            this.Hasta2.MinimumWidth = 6;
            this.Hasta2.Name = "Hasta2";
            this.Hasta2.ReadOnly = true;
            // 
            // FrecuenciaObservada2
            // 
            this.FrecuenciaObservada2.HeaderText = "Frecuencia Observada";
            this.FrecuenciaObservada2.MinimumWidth = 6;
            this.FrecuenciaObservada2.Name = "FrecuenciaObservada2";
            this.FrecuenciaObservada2.ReadOnly = true;
            // 
            // FrecuenciaEsperada2
            // 
            this.FrecuenciaEsperada2.HeaderText = "Frecuencia Esperada";
            this.FrecuenciaEsperada2.MinimumWidth = 6;
            this.FrecuenciaEsperada2.Name = "FrecuenciaEsperada2";
            this.FrecuenciaEsperada2.ReadOnly = true;
            // 
            // C2
            // 
            this.C2.HeaderText = "C()";
            this.C2.MinimumWidth = 6;
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            // 
            // Cacu2
            // 
            this.Cacu2.HeaderText = "C(acu)";
            this.Cacu2.MinimumWidth = 6;
            this.Cacu2.Name = "Cacu2";
            this.Cacu2.ReadOnly = true;
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
            this.dgvFrecuencia.AllowUserToAddRows = false;
            this.dgvFrecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.marcaClase,
            this.frecuenciaObservada,
            this.probabilidad,
            this.frecuenciaEsperada});
            this.dgvFrecuencia.Location = new System.Drawing.Point(9, 46);
            this.dgvFrecuencia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFrecuencia.Name = "dgvFrecuencia";
            this.dgvFrecuencia.RowHeadersWidth = 51;
            this.dgvFrecuencia.RowTemplate.Height = 24;
            this.dgvFrecuencia.Size = new System.Drawing.Size(654, 209);
            this.dgvFrecuencia.TabIndex = 12;
            this.dgvFrecuencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrecuencia_CellContentClick);
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.MinimumWidth = 6;
            this.desde.Name = "desde";
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.MinimumWidth = 6;
            this.hasta.Name = "hasta";
            // 
            // marcaClase
            // 
            this.marcaClase.HeaderText = "Marca De Clase";
            this.marcaClase.MinimumWidth = 6;
            this.marcaClase.Name = "marcaClase";
            // 
            // frecuenciaObservada
            // 
            this.frecuenciaObservada.HeaderText = "Frecuencia Observada";
            this.frecuenciaObservada.MinimumWidth = 6;
            this.frecuenciaObservada.Name = "frecuenciaObservada";
            // 
            // probabilidad
            // 
            this.probabilidad.HeaderText = "Probabilidad";
            this.probabilidad.MinimumWidth = 6;
            this.probabilidad.Name = "probabilidad";
            // 
            // frecuenciaEsperada
            // 
            this.frecuenciaEsperada.HeaderText = "Frecuencia Esperada";
            this.frecuenciaEsperada.MinimumWidth = 6;
            this.frecuenciaEsperada.Name = "frecuenciaEsperada";
            // 
            // Generar2
            // 
            this.Generar2.Location = new System.Drawing.Point(336, 16);
            this.Generar2.Margin = new System.Windows.Forms.Padding(2);
            this.Generar2.Name = "Generar2";
            this.Generar2.Size = new System.Drawing.Size(104, 26);
            this.Generar2.TabIndex = 13;
            this.Generar2.Text = "Generar Grafico";
            this.Generar2.UseVisualStyleBackColor = true;
            this.Generar2.Click += new System.EventHandler(this.Generar2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(739, 40);
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
            this.lblCalculado.Location = new System.Drawing.Point(835, 39);
            this.lblCalculado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalculado.Name = "lblCalculado";
            this.lblCalculado.Size = new System.Drawing.Size(0, 13);
            this.lblCalculado.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Valor de Tabla";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(830, 14);
            this.lblTabla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(0, 13);
            this.lblTabla.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(739, 65);
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
            this.lblConclusion.Location = new System.Drawing.Point(815, 65);
            this.lblConclusion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(0, 13);
            this.lblConclusion.TabIndex = 19;
            // 
            // dgvKs
            // 
            this.dgvKs.AllowUserToAddRows = false;
            this.dgvKs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde1,
            this.hasta1,
            this.fo,
            this.fe,
            this.po,
            this.pe,
            this.poacu,
            this.peacu,
            this.absPoacuPeacu});
            this.dgvKs.Location = new System.Drawing.Point(680, 311);
            this.dgvKs.Name = "dgvKs";
            this.dgvKs.Size = new System.Drawing.Size(605, 255);
            this.dgvKs.TabIndex = 20;
            // 
            // desde1
            // 
            this.desde1.HeaderText = "Desde";
            this.desde1.Name = "desde1";
            this.desde1.Width = 60;
            // 
            // hasta1
            // 
            this.hasta1.HeaderText = "Hasta";
            this.hasta1.Name = "hasta1";
            this.hasta1.Width = 60;
            // 
            // fo
            // 
            this.fo.HeaderText = "Frecuencia Observada";
            this.fo.Name = "fo";
            this.fo.Width = 60;
            // 
            // fe
            // 
            this.fe.HeaderText = "Frecuencia Esperada";
            this.fe.Name = "fe";
            this.fe.Width = 60;
            // 
            // po
            // 
            this.po.HeaderText = "Po";
            this.po.Name = "po";
            this.po.Width = 60;
            // 
            // pe
            // 
            this.pe.HeaderText = "Pe";
            this.pe.Name = "pe";
            this.pe.Width = 60;
            // 
            // poacu
            // 
            this.poacu.HeaderText = "Po(acu)";
            this.poacu.Name = "poacu";
            this.poacu.Width = 60;
            // 
            // peacu
            // 
            this.peacu.HeaderText = "Pe(acu)";
            this.peacu.Name = "peacu";
            this.peacu.Width = 60;
            // 
            // absPoacuPeacu
            // 
            this.absPoacuPeacu.HeaderText = "l Po(Acu) - Pe(Acu) l";
            this.absPoacuPeacu.Name = "absPoacuPeacu";
            this.absPoacuPeacu.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Valor calculado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor tabulado:";
            // 
            // lblConcl
            // 
            this.lblConcl.AutoSize = true;
            this.lblConcl.Location = new System.Drawing.Point(689, 635);
            this.lblConcl.Name = "lblConcl";
            this.lblConcl.Size = new System.Drawing.Size(0, 13);
            this.lblConcl.TabIndex = 23;
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Location = new System.Drawing.Point(770, 582);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(0, 13);
            this.lblCal.TabIndex = 24;
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Location = new System.Drawing.Point(770, 609);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(0, 13);
            this.lblTab.TabIndex = 25;
            // 
            // FormGraficoUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 743);
            this.Controls.Add(this.lblTab);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.lblConcl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvKs);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCalculado);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.Generar2);
            this.Controls.Add(this.dgvFrecuencia);
            this.Controls.Add(this.txtCantIntervalos);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtUniforme;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.TextBox txtCantIntervalos;
        private System.Windows.Forms.DataGridView dgvFrecuencia;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsperada;
        private System.Windows.Forms.DataGridView dgvKs;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn po;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn poacu;
        private System.Windows.Forms.DataGridViewTextBoxColumn peacu;
        private System.Windows.Forms.DataGridViewTextBoxColumn absPoacuPeacu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConcl;
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Label lblTab;
    }
}