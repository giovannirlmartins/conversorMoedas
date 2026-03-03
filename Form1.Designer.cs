namespace conversorMoedas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConverter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtValorReal = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblValorReal = new System.Windows.Forms.Label();
            this.lblValorDolar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConverter.Location = new System.Drawing.Point(125, 211);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(76, 41);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtValorReal
            // 
            this.txtValorReal.Location = new System.Drawing.Point(112, 176);
            this.txtValorReal.Name = "txtValorReal";
            this.txtValorReal.Size = new System.Drawing.Size(100, 20);
            this.txtValorReal.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(134, 300);
            this.lblResultado.MinimumSize = new System.Drawing.Size(50, 10);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(50, 15);
            this.lblResultado.TabIndex = 3;
            // 
            // lblValorReal
            // 
            this.lblValorReal.AutoSize = true;
            this.lblValorReal.Location = new System.Drawing.Point(109, 143);
            this.lblValorReal.Name = "lblValorReal";
            this.lblValorReal.Size = new System.Drawing.Size(103, 13);
            this.lblValorReal.TabIndex = 4;
            this.lblValorReal.Text = "Digite o valor em R$";
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Location = new System.Drawing.Point(131, 274);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(57, 13);
            this.lblValorDolar.TabIndex = 5;
            this.lblValorDolar.Text = "Valor em $";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.lblValorDolar);
            this.Controls.Add(this.lblValorReal);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValorReal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConverter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtValorReal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblValorReal;
        private System.Windows.Forms.Label lblValorDolar;
    }
}

