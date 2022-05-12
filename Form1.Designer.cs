namespace ProjetoPoo
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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(87, 287);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(147, 49);
            this.btnregistrar.TabIndex = 0;
            this.btnregistrar.Text = "registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(252, 287);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(144, 49);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(83, 18);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(49, 20);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "nome";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreco.Location = new System.Drawing.Point(83, 97);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(49, 20);
            this.lblpreco.TabIndex = 3;
            this.lblpreco.Text = "preço";
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantidade.Location = new System.Drawing.Point(83, 174);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(89, 20);
            this.lblquantidade.TabIndex = 4;
            this.lblquantidade.Text = "quantidade";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(87, 131);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(367, 20);
            this.txtpreco.TabIndex = 5;
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(87, 213);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(367, 20);
            this.txtquantidade.TabIndex = 6;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(85, 57);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(369, 20);
            this.txtnome.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "projeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtnome;
    }
}

