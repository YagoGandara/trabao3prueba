
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarUniforms = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvUniforme.Location = new System.Drawing.Point(32, 57);
            this.dgvUniforme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUniforme.Name = "dgvUniforme";
            this.dgvUniforme.RowHeadersWidth = 51;
            this.dgvUniforme.RowTemplate.Height = 24;
            this.dgvUniforme.Size = new System.Drawing.Size(430, 279);
            this.dgvUniforme.TabIndex = 0;
            this.dgvUniforme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUniforme_CellContentClick);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(191, 30);
            this.txtN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(76, 20);
            this.txtN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de numeros a generar:";
            // 
            // btnGenerarUniforms
            // 
            this.btnGenerarUniforms.Location = new System.Drawing.Point(288, 27);
            this.btnGenerarUniforms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerarUniforms.Name = "btnGenerarUniforms";
            this.btnGenerarUniforms.Size = new System.Drawing.Size(66, 25);
            this.btnGenerarUniforms.TabIndex = 3;
            this.btnGenerarUniforms.Text = "Generar";
            this.btnGenerarUniforms.UseVisualStyleBackColor = true;
            this.btnGenerarUniforms.Click += new System.EventHandler(this.btnGenerarUniforms_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // i
            // 
            this.i.HeaderText = "i(iteración)";
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
            this.X.HeaderText = "X(aleatorio)";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 125;
            // 
            // FormUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerarUniforms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.dgvUniforme);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUniforme";
            this.Text = "FormUniforme";
            this.Load += new System.EventHandler(this.FormUniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUniforme;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarUniforms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
    }
}