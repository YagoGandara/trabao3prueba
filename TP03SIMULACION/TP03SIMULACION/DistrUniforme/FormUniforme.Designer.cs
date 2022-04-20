
namespace TP03SIMULACION.DistrUniforme
{
    partial class FormUniforme
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
            this.dgvUniforme = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarUniforms = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniforme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUniforme
            // 
            this.dgvUniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.RND,
            this.X});
            this.dgvUniforme.Location = new System.Drawing.Point(178, 84);
            this.dgvUniforme.Name = "dgvUniforme";
            this.dgvUniforme.RowHeadersWidth = 51;
            this.dgvUniforme.RowTemplate.Height = 24;
            this.dgvUniforme.Size = new System.Drawing.Size(429, 240);
            this.dgvUniforme.TabIndex = 0;
            this.dgvUniforme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUniforme_CellContentClick);
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.MinimumWidth = 6;
            this.i.Name = "i";
            this.i.ReadOnly = true;
            this.i.Width = 125;
            // 
            // RND
            // 
            this.RND.HeaderText = "RND";
            this.RND.MinimumWidth = 6;
            this.RND.Name = "RND";
            this.RND.ReadOnly = true;
            this.RND.Width = 125;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 125;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(394, 41);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de numeros a generar:";
            // 
            // btnGenerarUniforms
            // 
            this.btnGenerarUniforms.Location = new System.Drawing.Point(636, 300);
            this.btnGenerarUniforms.Name = "btnGenerarUniforms";
            this.btnGenerarUniforms.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarUniforms.TabIndex = 3;
            this.btnGenerarUniforms.Text = "Generar";
            this.btnGenerarUniforms.UseVisualStyleBackColor = true;
            this.btnGenerarUniforms.Click += new System.EventHandler(this.btnGenerarUniforms_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerarUniforms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.dgvUniforme);
            this.Name = "FormUniforme";
            this.Text = "FormUniforme";
            this.Load += new System.EventHandler(this.FormUniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUniforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarUniforms;
        private System.Windows.Forms.Button button1;
    }
}