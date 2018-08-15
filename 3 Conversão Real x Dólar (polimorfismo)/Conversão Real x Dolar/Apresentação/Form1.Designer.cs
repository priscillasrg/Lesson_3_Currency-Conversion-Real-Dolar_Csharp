namespace Conversão_Real_x_Dolar
{
    partial class frmPrincipal
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
            this.lblInfoValorReal = new System.Windows.Forms.Label();
            this.txbNumeroReal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblInfoValorDolar = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txbNumeroDolar = new System.Windows.Forms.TextBox();
            this.lblPriscillaRizzardo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfoValorReal
            // 
            this.lblInfoValorReal.AutoSize = true;
            this.lblInfoValorReal.Location = new System.Drawing.Point(12, 36);
            this.lblInfoValorReal.Name = "lblInfoValorReal";
            this.lblInfoValorReal.Size = new System.Drawing.Size(196, 13);
            this.lblInfoValorReal.TabIndex = 0;
            this.lblInfoValorReal.Text = "Informe o valor em reais para conversão";
            // 
            // txbNumeroReal
            // 
            this.txbNumeroReal.Location = new System.Drawing.Point(218, 33);
            this.txbNumeroReal.Name = "txbNumeroReal";
            this.txbNumeroReal.Size = new System.Drawing.Size(82, 20);
            this.txbNumeroReal.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(124, 122);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblInfoValorDolar
            // 
            this.lblInfoValorDolar.AutoSize = true;
            this.lblInfoValorDolar.Location = new System.Drawing.Point(12, 75);
            this.lblInfoValorDolar.Name = "lblInfoValorDolar";
            this.lblInfoValorDolar.Size = new System.Drawing.Size(160, 13);
            this.lblInfoValorDolar.TabIndex = 3;
            this.lblInfoValorDolar.Text = "Informe a cotação atual do dólar";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(12, 173);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 4;
            this.lblResposta.Text = "Resposta";
            // 
            // txbNumeroDolar
            // 
            this.txbNumeroDolar.Location = new System.Drawing.Point(178, 72);
            this.txbNumeroDolar.Name = "txbNumeroDolar";
            this.txbNumeroDolar.Size = new System.Drawing.Size(81, 20);
            this.txbNumeroDolar.TabIndex = 5;
            // 
            // lblPriscillaRizzardo
            // 
            this.lblPriscillaRizzardo.AutoSize = true;
            this.lblPriscillaRizzardo.Location = new System.Drawing.Point(175, 252);
            this.lblPriscillaRizzardo.Name = "lblPriscillaRizzardo";
            this.lblPriscillaRizzardo.Size = new System.Drawing.Size(130, 13);
            this.lblPriscillaRizzardo.TabIndex = 6;
            this.lblPriscillaRizzardo.Text = "Made by Priscilla Rizzardo";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(334, 285);
            this.Controls.Add(this.lblPriscillaRizzardo);
            this.Controls.Add(this.txbNumeroDolar);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblInfoValorDolar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbNumeroReal);
            this.Controls.Add(this.lblInfoValorReal);
            this.Name = "frmPrincipal";
            this.Text = "Conversão Real em Dólar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoValorReal;
        private System.Windows.Forms.TextBox txbNumeroReal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblInfoValorDolar;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txbNumeroDolar;
        private System.Windows.Forms.Label lblPriscillaRizzardo;
    }
}

