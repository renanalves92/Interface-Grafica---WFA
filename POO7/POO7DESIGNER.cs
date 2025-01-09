namespace ComparadorValores
{
    partial class FormComparador
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
            this.labelValor1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.labelValor2 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValor1
            // 
            this.labelValor1.AutoSize = true;
            this.labelValor1.Location = new System.Drawing.Point(20, 20);
            this.labelValor1.Name = "labelValor1";
            this.labelValor1.Size = new System.Drawing.Size(100, 15);
            this.labelValor1.TabIndex = 0;
            this.labelValor1.Text = "Primeiro valor:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(150, 17);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 23);
            this.txtValor1.TabIndex = 1;
            // 
            // labelValor2
            // 
            this.labelValor2.AutoSize = true;
            this.labelValor2.Location = new System.Drawing.Point(20, 60);
            this.labelValor2.Name = "labelValor2";
            this.labelValor2.Size = new System.Drawing.Size(105, 15);
            this.labelValor2.TabIndex = 2;
            this.labelValor2.Text = "Segundo valor:";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(150, 57);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 23);
            this.txtValor2.TabIndex = 3;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(80, 100);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(120, 30);
            this.btnComparar.TabIndex = 4;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(20, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(81, 19);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // FormComparador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.labelValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.labelValor1);
            this.Name = "FormComparador";
            this.Text = "Comparador de Valores";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelValor1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label labelValor2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblResultado;
    }
}
