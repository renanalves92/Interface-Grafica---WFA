namespace ConversaoDolarParaReal
{
    partial class FormConversaoMoeda
    {
        private System.ComponentModel.IContainer components = null;

        // Limpeza de recursos usados.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Método necessário para o Designer de Suporte
        private void InitializeComponent()
        {
            this.labelCotacao = new System.Windows.Forms.Label();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCotacao
            // 
            this.labelCotacao.AutoSize = true;
            this.labelCotacao.Location = new System.Drawing.Point(20, 20);
            this.labelCotacao.Name = "labelCotacao";
            this.labelCotacao.Size = new System.Drawing.Size(100, 15);
            this.labelCotacao.TabIndex = 0;
            this.labelCotacao.Text = "Cotação do dólar:";
            // 
            // txtCotacao
            // 
            this.txtCotacao.Location = new System.Drawing.Point(150, 17);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(100, 23);
            this.txtCotacao.TabIndex = 1;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(20, 60);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(120, 15);
            this.labelQuantidade.TabIndex = 2;
            this.labelQuantidade.Text = "Quantidade (dólares):";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(150, 57);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidade.TabIndex = 3;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(80, 100);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(120, 30);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(20, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(60, 19);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Reais: ";
            // 
            // FormConversaoMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.txtCotacao);
            this.Controls.Add(this.labelCotacao);
            this.Name = "FormConversaoMoeda";
            this.Text = "Conversão Dólar para Real";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCotacao;
        private System.Windows.Forms.TextBox txtCotacao;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
    }
}
