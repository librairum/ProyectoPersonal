﻿namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenera = new System.Windows.Forms.Button();
            this.txtclave1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtclave2 = new System.Windows.Forms.TextBox();
            this.btnGuardarClave1 = new System.Windows.Forms.Button();
            this.btnGuardarClave2 = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.rbUno = new System.Windows.Forms.RadioButton();
            this.rbDos = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(30, 70);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(75, 23);
            this.btnGenera.TabIndex = 0;
            this.btnGenera.Text = "Generar";
            this.btnGenera.UseVisualStyleBackColor = true;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // txtclave1
            // 
            this.txtclave1.Location = new System.Drawing.Point(116, 12);
            this.txtclave1.Name = "txtclave1";
            this.txtclave1.Size = new System.Drawing.Size(128, 20);
            this.txtclave1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "knightlibra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "libraa";
            // 
            // txtclave2
            // 
            this.txtclave2.Location = new System.Drawing.Point(116, 38);
            this.txtclave2.Name = "txtclave2";
            this.txtclave2.Size = new System.Drawing.Size(126, 20);
            this.txtclave2.TabIndex = 3;
            // 
            // btnGuardarClave1
            // 
            this.btnGuardarClave1.Location = new System.Drawing.Point(197, 70);
            this.btnGuardarClave1.Name = "btnGuardarClave1";
            this.btnGuardarClave1.Size = new System.Drawing.Size(73, 22);
            this.btnGuardarClave1.TabIndex = 5;
            this.btnGuardarClave1.Text = "Guardar";
            this.btnGuardarClave1.UseVisualStyleBackColor = true;
            this.btnGuardarClave1.Click += new System.EventHandler(this.btnGuardarClave1_Click);
            // 
            // btnGuardarClave2
            // 
            this.btnGuardarClave2.Location = new System.Drawing.Point(418, 36);
            this.btnGuardarClave2.Name = "btnGuardarClave2";
            this.btnGuardarClave2.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarClave2.TabIndex = 6;
            this.btnGuardarClave2.Text = "Guardar";
            this.btnGuardarClave2.UseVisualStyleBackColor = true;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(116, 70);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 7;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // rbUno
            // 
            this.rbUno.AutoSize = true;
            this.rbUno.Location = new System.Drawing.Point(263, 13);
            this.rbUno.Name = "rbUno";
            this.rbUno.Size = new System.Drawing.Size(38, 17);
            this.rbUno.TabIndex = 8;
            this.rbUno.TabStop = true;
            this.rbUno.Text = "V1";
            this.rbUno.UseVisualStyleBackColor = true;
            // 
            // rbDos
            // 
            this.rbDos.AutoSize = true;
            this.rbDos.Location = new System.Drawing.Point(263, 42);
            this.rbDos.Name = "rbDos";
            this.rbDos.Size = new System.Drawing.Size(38, 17);
            this.rbDos.TabIndex = 9;
            this.rbDos.TabStop = true;
            this.rbDos.Text = "V2";
            this.rbDos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 111);
            this.Controls.Add(this.rbDos);
            this.Controls.Add(this.rbUno);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnGuardarClave2);
            this.Controls.Add(this.btnGuardarClave1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtclave2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtclave1);
            this.Controls.Add(this.btnGenera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenera;
        private System.Windows.Forms.TextBox txtclave1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtclave2;
        private System.Windows.Forms.Button btnGuardarClave1;
        private System.Windows.Forms.Button btnGuardarClave2;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.RadioButton rbUno;
        private System.Windows.Forms.RadioButton rbDos;
    }
}

