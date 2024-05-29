namespace FormulariosAgrupado
{
    partial class BotonInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(109, 113);
            button1.Name = "button1";
            button1.Size = new Size(148, 41);
            button1.TabIndex = 0;
            button1.Text = "Pasaje del Metro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(313, 113);
            button2.Name = "button2";
            button2.Size = new Size(148, 41);
            button2.TabIndex = 1;
            button2.Text = "Calculadora";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(192, 0, 0);
            button3.Location = new Point(530, 112);
            button3.Name = "button3";
            button3.Size = new Size(137, 43);
            button3.TabIndex = 2;
            button3.Text = "Comparar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 302);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Grupo 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 340);
            label2.Name = "label2";
            label2.Size = new Size(147, 17);
            label2.TabIndex = 4;
            label2.Text = "FANNY LUNA CASADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 371);
            label3.Name = "label3";
            label3.Size = new Size(162, 17);
            label3.TabIndex = 5;
            label3.Text = "GILBERT MATEO ACOSTA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 398);
            label4.Name = "label4";
            label4.Size = new Size(193, 17);
            label4.TabIndex = 6;
            label4.Text = "JOSIAS HERNANDEZ ESPIRITU";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(602, 275);
            button4.Name = "button4";
            button4.Size = new Size(123, 35);
            button4.TabIndex = 7;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BotonInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BotonInicial";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button4;
    }
}
