
namespace TP03SIMULACION
{
    partial class FormExponencial
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
            this.dgvExpo = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGenerar = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExpo
            // 
            this.dgvExpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.x});
            this.dgvExpo.Location = new System.Drawing.Point(122, 125);
            this.dgvExpo.Name = "dgvExpo";
            this.dgvExpo.Size = new System.Drawing.Size(243, 247);
            this.dgvExpo.TabIndex = 0;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            // 
            // txtGenerar
            // 
            this.txtGenerar.Location = new System.Drawing.Point(290, 84);
            this.txtGenerar.Name = "txtGenerar";
            this.txtGenerar.Size = new System.Drawing.Size(75, 23);
            this.txtGenerar.TabIndex = 1;
            this.txtGenerar.Text = "Generar";
            this.txtGenerar.UseVisualStyleBackColor = true;
            this.txtGenerar.Click += new System.EventHandler(this.txtGenerar_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(223, 84);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(61, 20);
            this.txtN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de n:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtGenerar);
            this.Controls.Add(this.dgvExpo);
            this.Name = "FormExponencial";
            this.Text = "FormExponencial";
            this.Load += new System.EventHandler(this.FormExponencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.Button txtGenerar;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}