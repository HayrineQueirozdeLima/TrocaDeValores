
namespace RestoDaDivisao
{
    partial class frmRestoDeDivisao
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
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lblResto = new System.Windows.Forms.Label();
            this.bttRealizarDivisao = new System.Windows.Forms.Button();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(15, 23);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(75, 17);
            this.lblDividendo.TabIndex = 0;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(230, 23);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(59, 17);
            this.lblDivisor.TabIndex = 1;
            this.lblDivisor.Text = "Divisor: ";
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(230, 69);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(49, 17);
            this.lblResto.TabIndex = 2;
            this.lblResto.Text = "Resto:";
            // 
            // bttRealizarDivisao
            // 
            this.bttRealizarDivisao.Location = new System.Drawing.Point(36, 62);
            this.bttRealizarDivisao.Name = "bttRealizarDivisao";
            this.bttRealizarDivisao.Size = new System.Drawing.Size(180, 30);
            this.bttRealizarDivisao.TabIndex = 3;
            this.bttRealizarDivisao.Text = "Realizar divisão";
            this.bttRealizarDivisao.UseVisualStyleBackColor = true;
            this.bttRealizarDivisao.Click += new System.EventHandler(this.bttRealizarDivisao_Click);
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(295, 20);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(122, 22);
            this.txtDivisor.TabIndex = 4;
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(102, 20);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(122, 22);
            this.txtDividendo.TabIndex = 5;
            // 
            // txtResto
            // 
            this.txtResto.Location = new System.Drawing.Point(285, 66);
            this.txtResto.Name = "txtResto";
            this.txtResto.Size = new System.Drawing.Size(132, 22);
            this.txtResto.TabIndex = 6;
            // 
            // frmRestoDeDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 120);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.bttRealizarDivisao);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblDividendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRestoDeDivisao";
            this.Text = "Resto de uma divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.Button bttRealizarDivisao;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtResto;
    }
}