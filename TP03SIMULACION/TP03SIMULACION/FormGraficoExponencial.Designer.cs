
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencialF)).BeginInit();
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
            // FormGraficoExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvExponencialF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantIntervalos);
            this.Name = "FormGraficoExponencial";
            this.Text = "FormGraficoExponencial";
            this.Load += new System.EventHandler(this.FormGraficoExponencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExponencialF)).EndInit();
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
    }
}