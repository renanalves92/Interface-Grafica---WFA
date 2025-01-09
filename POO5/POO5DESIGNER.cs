namespace ConversaoMilhasMaritimas
{
    partial class FormConversaoMilhas
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
            this.labelMilhas = new System.Windows.Forms.Label();
            this.txtMilhas = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMilhas
            // 
            this.labelMilhas.AutoSize = true;
            this.labelMilhas.Location = new System.Drawing.Point(20, 20);
            this.labelMilhas.Name = "labelMilhas";
            this.labelMilhas.Size = new System.Drawing.Size(128, 15);
            this.labelMilhas.TabIndex = 0;
            this.labelMilhas.Text = "Valor em milhas marítimas:";
            // 
            // txtMilhas
            // 
            this.txtMilhas.Location = new System.Drawing.Point(160, 17);
            this.txtMilhas.Name = "txtMilhas";
            this.txtMilhas.Size = new System.Drawing.Size(100, 23);
            this.txtMilhas.TabIndex = 1;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(80, 60);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(120, 30);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(20, 110);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(48, 19);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Km: ";
            // 
            // FormConversaoMilhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtMilhas);
            this.Controls.Add(this.labelMilhas);
            this.Name = "FormConversaoMilhas";
            this.Text = "Conversão Milhas para Km";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelMilhas;
        private System.Windows.Forms.TextBox txtMilhas;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
    }
}
