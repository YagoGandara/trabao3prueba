
namespace TP03SIMULACION
{
    partial class FormNMuller
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
            this.btnGenerarAleatorios = new System.Windows.Forms.Button();
            this.dgvNormalMullerAleatorio = new System.Windows.Forms.DataGridView();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormalMullerAleatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarAleatorios
            // 
            this.btnGenerarAleatorios.Location = new System.Drawing.Point(276, 48);
            this.btnGenerarAleatorios.Name = "btnGenerarAleatorios";
            this.btnGenerarAleatorios.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarAleatorios.TabIndex = 0;
            this.btnGenerarAleatorios.Text = "Generar";
            this.btnGenerarAleatorios.UseVisualStyleBackColor = true;
            this.btnGenerarAleatorios.Click += new System.EventHandler(this.btnGenerarAleatorios_Click);
            // 
            // dgvNormalMullerAleatorio
            // 
            this.dgvNormalMullerAleatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNormalMullerAleatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.x});
            this.dgvNormalMullerAleatorio.Location = new System.Drawing.Point(110, 87);
            this.dgvNormalMullerAleatorio.Name = "dgvNormalMullerAleatorio";
            this.dgvNormalMullerAleatorio.Size = new System.Drawing.Size(244, 222);
            this.dgvNormalMullerAleatorio.TabIndex = 1;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(176, 48);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(75, 20);
            this.txtN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad N:";
            // 
            // i
            // 
            this.i.HeaderText = "i(iteración)";
            this.i.Name = "i";
            // 
            // x
            // 
            this.x.HeaderText = "x(aleatorio)";
            this.x.Name = "x";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "GENERAR GRAFICO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNMuller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.dgvNormalMullerAleatorio);
            this.Controls.Add(this.btnGenerarAleatorios);
            this.Name = "FormNMuller";
            this.Text = "FormNMuller";
            this.Load += new System.EventHandler(this.FormNMuller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormalMullerAleatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarAleatorios;
        private System.Windows.Forms.DataGridView dgvNormalMullerAleatorio;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.Button button1;
    }
}