
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
            this.SuspendLayout();
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(197, 221);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(69, 22);
            this.txtB.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(197, 183);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(69, 22);
            this.txtA.TabIndex = 1;
            // 
            // cxDistribuUnifor
            // 
            this.cxDistribuUnifor.AutoSize = true;
            this.cxDistribuUnifor.Location = new System.Drawing.Point(173, 144);
            this.cxDistribuUnifor.Name = "cxDistribuUnifor";
            this.cxDistribuUnifor.Size = new System.Drawing.Size(87, 21);
            this.cxDistribuUnifor.TabIndex = 2;
            this.cxDistribuUnifor.Text = "Uniforme";
            this.cxDistribuUnifor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "B:";
            // 
            // btnUniformess
            // 
            this.btnUniformess.Location = new System.Drawing.Point(303, 220);
            this.btnUniformess.Name = "btnUniformess";
            this.btnUniformess.Size = new System.Drawing.Size(75, 23);
            this.btnUniformess.TabIndex = 5;
            this.btnUniformess.Text = "Siguiente";
            this.btnUniformess.UseVisualStyleBackColor = true;
            this.btnUniformess.Click += new System.EventHandler(this.btnUniformess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUniformess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cxDistribuUnifor);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

