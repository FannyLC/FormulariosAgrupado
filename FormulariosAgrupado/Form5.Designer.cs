namespace Comparar_numeros
{
    partial class Form5
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.buttonComparar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(298, 139);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero1.TabIndex = 0;
            this.textBoxNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(438, 139);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero2.TabIndex = 1;
            // 
            // buttonComparar
            // 
            this.buttonComparar.Location = new System.Drawing.Point(371, 217);
            this.buttonComparar.Name = "buttonComparar";
            this.buttonComparar.Size = new System.Drawing.Size(75, 23);
            this.buttonComparar.TabIndex = 2;
            this.buttonComparar.Text = "Comparar";
            this.buttonComparar.UseVisualStyleBackColor = true;
            this.buttonComparar.Click += new System.EventHandler(this.buttonComparar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(575, 145);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonComparar);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Button buttonComparar;
        private System.Windows.Forms.Label labelResultado;
    }
}

