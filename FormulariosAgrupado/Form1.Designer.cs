namespace Calculadora
{
    partial class Form1
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
            txtscreen = new TextBox();
            txtmas = new Button();
            txtmenos = new Button();
            txtpor = new Button();
            txtentre = new Button();
            txtseis = new Button();
            txtocho = new Button();
            txtnueve = new Button();
            txtsiete = new Button();
            txtcinco = new Button();
            txtcuatro = new Button();
            txttres = new Button();
            txtdos = new Button();
            txtuno = new Button();
            t = new Button();
            txtpunto = new Button();
            txtigual = new Button();
            txtborrar = new Button();
            txteliminar = new Button();
            SuspendLayout();
            // 
            // txtscreen
            // 
            txtscreen.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtscreen.Location = new Point(12, 27);
            txtscreen.Multiline = true;
            txtscreen.Name = "txtscreen";
            txtscreen.Size = new Size(314, 54);
            txtscreen.TabIndex = 0;
            txtscreen.Text = "0";
            txtscreen.TextAlign = HorizontalAlignment.Right;
            // 
            // txtmas
            // 
            txtmas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtmas.Location = new Point(12, 87);
            txtmas.Name = "txtmas";
            txtmas.Size = new Size(75, 57);
            txtmas.TabIndex = 1;
            txtmas.Text = "+";
            txtmas.UseVisualStyleBackColor = true;
            txtmas.Click += txtmas_Click;
            // 
            // txtmenos
            // 
            txtmenos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtmenos.Location = new Point(93, 87);
            txtmenos.Name = "txtmenos";
            txtmenos.Size = new Size(75, 57);
            txtmenos.TabIndex = 2;
            txtmenos.Text = "-";
            txtmenos.UseVisualStyleBackColor = true;
            txtmenos.Click += txtmenos_Click;
            // 
            // txtpor
            // 
            txtpor.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtpor.Location = new Point(174, 87);
            txtpor.Name = "txtpor";
            txtpor.Size = new Size(75, 57);
            txtpor.TabIndex = 3;
            txtpor.Text = "*";
            txtpor.UseVisualStyleBackColor = true;
            txtpor.Click += txtpor_Click;
            // 
            // txtentre
            // 
            txtentre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtentre.Location = new Point(251, 87);
            txtentre.Name = "txtentre";
            txtentre.Size = new Size(75, 57);
            txtentre.TabIndex = 4;
            txtentre.Text = "/";
            txtentre.UseVisualStyleBackColor = true;
            txtentre.Click += txtentre_Click;
            // 
            // txtseis
            // 
            txtseis.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtseis.Location = new Point(174, 214);
            txtseis.Name = "txtseis";
            txtseis.Size = new Size(75, 57);
            txtseis.TabIndex = 5;
            txtseis.Text = "6";
            txtseis.UseVisualStyleBackColor = true;
            txtseis.Click += txtseis_Click;
            // 
            // txtocho
            // 
            txtocho.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtocho.Location = new Point(93, 277);
            txtocho.Name = "txtocho";
            txtocho.Size = new Size(75, 57);
            txtocho.TabIndex = 6;
            txtocho.Text = "8";
            txtocho.UseVisualStyleBackColor = true;
            txtocho.Click += txtocho_Click;
            // 
            // txtnueve
            // 
            txtnueve.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtnueve.Location = new Point(174, 277);
            txtnueve.Name = "txtnueve";
            txtnueve.Size = new Size(75, 57);
            txtnueve.TabIndex = 7;
            txtnueve.Text = "9";
            txtnueve.UseVisualStyleBackColor = true;
            txtnueve.Click += txtnueve_Click;
            // 
            // txtsiete
            // 
            txtsiete.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtsiete.Location = new Point(12, 276);
            txtsiete.Name = "txtsiete";
            txtsiete.Size = new Size(75, 57);
            txtsiete.TabIndex = 8;
            txtsiete.Text = "7";
            txtsiete.UseVisualStyleBackColor = true;
            txtsiete.Click += txtsiete_Click;
            // 
            // txtcinco
            // 
            txtcinco.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtcinco.Location = new Point(93, 214);
            txtcinco.Name = "txtcinco";
            txtcinco.Size = new Size(75, 57);
            txtcinco.TabIndex = 9;
            txtcinco.Text = "5";
            txtcinco.UseVisualStyleBackColor = true;
            txtcinco.Click += txtcinco_Click;
            // 
            // txtcuatro
            // 
            txtcuatro.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtcuatro.Location = new Point(12, 213);
            txtcuatro.Name = "txtcuatro";
            txtcuatro.Size = new Size(75, 57);
            txtcuatro.TabIndex = 10;
            txtcuatro.Text = "4";
            txtcuatro.UseVisualStyleBackColor = true;
            txtcuatro.Click += txtcuatro_Click;
            // 
            // txttres
            // 
            txttres.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txttres.Location = new Point(174, 151);
            txttres.Name = "txttres";
            txttres.Size = new Size(75, 57);
            txttres.TabIndex = 11;
            txttres.Text = "3";
            txttres.UseVisualStyleBackColor = true;
            txttres.Click += txttres_Click;
            // 
            // txtdos
            // 
            txtdos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtdos.Location = new Point(93, 150);
            txtdos.Name = "txtdos";
            txtdos.Size = new Size(75, 57);
            txtdos.TabIndex = 12;
            txtdos.Text = "2";
            txtdos.UseVisualStyleBackColor = true;
            txtdos.Click += txtdos_Click;
            // 
            // txtuno
            // 
            txtuno.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtuno.Location = new Point(12, 150);
            txtuno.Name = "txtuno";
            txtuno.Size = new Size(75, 57);
            txtuno.TabIndex = 13;
            txtuno.Text = "1";
            txtuno.UseVisualStyleBackColor = true;
            txtuno.Click += txtuno_Click;
            // 
            // t
            // 
            t.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            t.Location = new Point(12, 339);
            t.Name = "t";
            t.Size = new Size(156, 57);
            t.TabIndex = 14;
            t.Text = "0";
            t.UseVisualStyleBackColor = true;
            t.Click += t_Click;
            // 
            // txtpunto
            // 
            txtpunto.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtpunto.Location = new Point(174, 339);
            txtpunto.Name = "txtpunto";
            txtpunto.Size = new Size(75, 57);
            txtpunto.TabIndex = 15;
            txtpunto.Text = ".";
            txtpunto.UseVisualStyleBackColor = true;
            txtpunto.Click += txtpunto_Click;
            // 
            // txtigual
            // 
            txtigual.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtigual.Location = new Point(251, 277);
            txtigual.Name = "txtigual";
            txtigual.Size = new Size(75, 119);
            txtigual.TabIndex = 16;
            txtigual.Text = "=";
            txtigual.UseVisualStyleBackColor = true;
            txtigual.Click += txtigual_Click;
            // 
            // txtborrar
            // 
            txtborrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtborrar.Location = new Point(251, 214);
            txtborrar.Name = "txtborrar";
            txtborrar.Size = new Size(75, 57);
            txtborrar.TabIndex = 17;
            txtborrar.Text = "CE";
            txtborrar.UseVisualStyleBackColor = true;
            txtborrar.Click += txtborrar_Click;
            // 
            // txteliminar
            // 
            txteliminar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txteliminar.Location = new Point(251, 151);
            txteliminar.Name = "txteliminar";
            txteliminar.Size = new Size(75, 57);
            txteliminar.TabIndex = 18;
            txteliminar.Text = "BA";
            txteliminar.UseVisualStyleBackColor = true;
            txteliminar.Click += txteliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 399);
            Controls.Add(txteliminar);
            Controls.Add(txtborrar);
            Controls.Add(txtigual);
            Controls.Add(txtpunto);
            Controls.Add(t);
            Controls.Add(txtuno);
            Controls.Add(txtdos);
            Controls.Add(txttres);
            Controls.Add(txtcuatro);
            Controls.Add(txtcinco);
            Controls.Add(txtsiete);
            Controls.Add(txtnueve);
            Controls.Add(txtocho);
            Controls.Add(txtseis);
            Controls.Add(txtentre);
            Controls.Add(txtpor);
            Controls.Add(txtmenos);
            Controls.Add(txtmas);
            Controls.Add(txtscreen);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtscreen;
        private Button txtmas;
        private Button txtmenos;
        private Button txtpor;
        private Button txtentre;
        private Button txtseis;
        private Button txtocho;
        private Button txtnueve;
        private Button txtsiete;
        private Button txtcinco;
        private Button txtcuatro;
        private Button txttres;
        private Button txtdos;
        private Button txtuno;
        private Button t;
        private Button txtpunto;
        private Button txtigual;
        private Button txtborrar;
        private Button txteliminar;
    }
}
