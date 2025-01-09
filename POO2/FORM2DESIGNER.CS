namespace CalculoAreaQuadrado
{
    partial class FormCalculoAreaQuadrado
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
            this.labelAresta = new System.Windows.Forms.Label();
            this.txtAresta = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAresta
            // 
            this.labelAresta.AutoSize = true;
            this.labelAresta.Location = new System.Drawing.Point(20, 20);
            this.labelAresta.Name = "labelAresta";
            this.labelAresta.Size = new System.Drawing.Size(103, 15);
            this.labelAresta.TabIndex = 0;
            this.labelAresta.Text = "Aresta do Quadrado:";
            // 
            // txtAresta
            // 
            this.txtAresta.Location = new System.Drawing.Point(140, 17);
            this.txtAresta.Name = "txtAresta";
            this.txtAresta.Size = new System.Drawing.Size(100, 23);
            this.txtAresta.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(85, 60);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Área";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(20, 110);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(48, 19);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Área: ";
            // 
            // FormCalculoAreaQuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 160);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAresta);
            this.Controls.Add(this.labelAresta);
            this.Name = "FormCalculoAreaQuadrado";
            this.Text = "Cálculo de Área do Quadrado";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelAresta;
        private System.Windows.Forms.TextBox txtAresta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}
