namespace Impar_ou_Par_2
{
    partial class FrmImpPar
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
            this.lblInstrucao1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstrucao2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVerif = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstrucao1
            // 
            this.lblInstrucao1.AutoSize = true;
            this.lblInstrucao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao1.Location = new System.Drawing.Point(80, 83);
            this.lblInstrucao1.Name = "lblInstrucao1";
            this.lblInstrucao1.Size = new System.Drawing.Size(162, 17);
            this.lblInstrucao1.TabIndex = 0;
            this.lblInstrucao1.Text = "Digite um número inteiro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(336, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Impar ou Par";
            // 
            // lblInstrucao2
            // 
            this.lblInstrucao2.AutoSize = true;
            this.lblInstrucao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao2.Location = new System.Drawing.Point(21, 124);
            this.lblInstrucao2.Name = "lblInstrucao2";
            this.lblInstrucao2.Size = new System.Drawing.Size(221, 17);
            this.lblInstrucao2.TabIndex = 2;
            this.lblInstrucao2.Text = "Digite um segundo número inteiro";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResult.Location = new System.Drawing.Point(6, 46);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Location = new System.Drawing.Point(12, 406);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(119, 32);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVerif
            // 
            this.btnVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerif.Location = new System.Drawing.Point(318, 245);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(119, 32);
            this.btnVerif.TabIndex = 5;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(193, 245);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 32);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(248, 82);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(189, 20);
            this.txtNum1.TabIndex = 7;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(248, 123);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(189, 20);
            this.txtNum2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(31, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // FrmImpPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblInstrucao2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblInstrucao1);
            this.Name = "FrmImpPar";
            this.Text = " Impar ou Par";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstrucao1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstrucao2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

