
namespace TP03SIMULACION
{
    partial class Form1
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
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.cxDistribuUnifor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUniformess = new System.Windows.Forms.Button();
            this.cxExponencial = new System.Windows.Forms.CheckBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSiguienteExpo = new System.Windows.Forms.Button();
            this.cxNormalMuller = new System.Windows.Forms.CheckBox();
            this.txtDesvEstandar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSiguienteNormalMuller = new System.Windows.Forms.Button();
            this.txtMediaMuller = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(148, 180);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(53, 20);
            this.txtB.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(148, 149);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(53, 20);
            this.txtA.TabIndex = 1;
            // 
            // cxDistribuUnifor
            // 
            this.cxDistribuUnifor.AutoSize = true;
            this.cxDistribuUnifor.Location = new System.Drawing.Point(130, 117);
            this.cxDistribuUnifor.Margin = new System.Windows.Forms.Padding(2);
            this.cxDistribuUnifor.Name = "cxDistribuUnifor";
            this.cxDistribuUnifor.Size = new System.Drawing.Size(68, 17);
            this.cxDistribuUnifor.TabIndex = 2;
            this.cxDistribuUnifor.Text = "Uniforme";
            this.cxDistribuUnifor.UseVisualStyleBackColor = true;
            this.cxDistribuUnifor.CheckedChanged += new System.EventHandler(this.cxDistribuUnifor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "B:";
            // 
            // btnUniformess
            // 
            this.btnUniformess.Location = new System.Drawing.Point(126, 215);
            this.btnUniformess.Margin = new System.Windows.Forms.Padding(2);
            this.btnUniformess.Name = "btnUniformess";
            this.btnUniformess.Size = new System.Drawing.Size(75, 23);
            this.btnUniformess.TabIndex = 5;
            this.btnUniformess.Text = "Siguiente";
            this.btnUniformess.UseVisualStyleBackColor = true;
            this.btnUniformess.Click += new System.EventHandler(this.btnUniformess_Click);
            // 
            // cxExponencial
            // 
            this.cxExponencial.AutoSize = true;
            this.cxExponencial.Location = new System.Drawing.Point(349, 117);
            this.cxExponencial.Name = "cxExponencial";
            this.cxExponencial.Size = new System.Drawing.Size(84, 17);
            this.cxExponencial.TabIndex = 6;
            this.cxExponencial.Text = "Exponencial";
            this.cxExponencial.UseVisualStyleBackColor = true;
            this.cxExponencial.CheckedChanged += new System.EventHandler(this.cxExponencial_CheckedChanged);
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(405, 144);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(63, 20);
            this.txtMedia.TabIndex = 7;
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(405, 184);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(63, 20);
            this.txtLambda.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Media:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lambda:";
            // 
            // btnSiguienteExpo
            // 
            this.btnSiguienteExpo.Location = new System.Drawing.Point(349, 215);
            this.btnSiguienteExpo.Name = "btnSiguienteExpo";
            this.btnSiguienteExpo.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteExpo.TabIndex = 11;
            this.btnSiguienteExpo.Text = "Siguiente";
            this.btnSiguienteExpo.UseVisualStyleBackColor = true;
            this.btnSiguienteExpo.Click += new System.EventHandler(this.txtSiguienteExpo_Click);
            // 
            // cxNormalMuller
            // 
            this.cxNormalMuller.AutoSize = true;
            this.cxNormalMuller.Location = new System.Drawing.Point(567, 117);
            this.cxNormalMuller.Name = "cxNormalMuller";
            this.cxNormalMuller.Size = new System.Drawing.Size(90, 17);
            this.cxNormalMuller.TabIndex = 12;
            this.cxNormalMuller.Text = "Normal Muller";
            this.cxNormalMuller.UseVisualStyleBackColor = true;
            this.cxNormalMuller.CheckedChanged += new System.EventHandler(this.cxNormalMuller_CheckedChanged);
            // 
            // txtDesvEstandar
            // 
            this.txtDesvEstandar.Location = new System.Drawing.Point(650, 144);
            this.txtDesvEstandar.Name = "txtDesvEstandar";
            this.txtDesvEstandar.Size = new System.Drawing.Size(64, 20);
            this.txtDesvEstandar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Desv Estandar:";
            // 
            // btnSiguienteNormalMuller
            // 
            this.btnSiguienteNormalMuller.Location = new System.Drawing.Point(567, 215);
            this.btnSiguienteNormalMuller.Name = "btnSiguienteNormalMuller";
            this.btnSiguienteNormalMuller.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteNormalMuller.TabIndex = 15;
            this.btnSiguienteNormalMuller.Text = "Siguiente";
            this.btnSiguienteNormalMuller.UseVisualStyleBackColor = true;
            this.btnSiguienteNormalMuller.Click += new System.EventHandler(this.btnSiguienteNormalMuller_Click);
            // 
            // txtMediaMuller
            // 
            this.txtMediaMuller.Location = new System.Drawing.Point(650, 180);
            this.txtMediaMuller.Name = "txtMediaMuller";
            this.txtMediaMuller.Size = new System.Drawing.Size(64, 20);
            this.txtMediaMuller.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Media:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(809, 340);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMediaMuller);
            this.Controls.Add(this.txtDesvEstandar);
            this.Controls.Add(this.cxNormalMuller);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSiguienteNormalMuller);
            this.Controls.Add(this.btnSiguienteExpo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.cxExponencial);
            this.Controls.Add(this.btnUniformess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cxDistribuUnifor);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.CheckBox cxDistribuUnifor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUniformess;
        private System.Windows.Forms.CheckBox cxExponencial;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSiguienteExpo;
        private System.Windows.Forms.CheckBox cxNormalMuller;
        private System.Windows.Forms.TextBox txtDesvEstandar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSiguienteNormalMuller;
        private System.Windows.Forms.TextBox txtMediaMuller;
        private System.Windows.Forms.Label label6;
    }
}

