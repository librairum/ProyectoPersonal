namespace Presentacion
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRucEmpresa = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblcorrelativo = new System.Windows.Forms.Label();
            this.lblnombrempresa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.txtnumeroruc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaEmision = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfechapago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.lblmontoenletras = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtimportegravada = new System.Windows.Forms.TextBox();
            this.txtimporteigv = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtimporteinafecta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtimportexonerada = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtimporteexportacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtimportetotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbldireccionemisor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(830, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "RUC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblRucEmpresa
            // 
            this.lblRucEmpresa.AutoSize = true;
            this.lblRucEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRucEmpresa.Location = new System.Drawing.Point(928, 22);
            this.lblRucEmpresa.Name = "lblRucEmpresa";
            this.lblRucEmpresa.Size = new System.Drawing.Size(142, 36);
            this.lblRucEmpresa.TabIndex = 3;
            this.lblRucEmpresa.Text = "N° 00000";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(814, 57);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(260, 36);
            this.lblTipoDocumento.TabIndex = 4;
            this.lblTipoDocumento.Text = "tipo de documento";
            // 
            // lblcorrelativo
            // 
            this.lblcorrelativo.AutoSize = true;
            this.lblcorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorrelativo.Location = new System.Drawing.Point(875, 93);
            this.lblcorrelativo.Name = "lblcorrelativo";
            this.lblcorrelativo.Size = new System.Drawing.Size(168, 36);
            this.lblcorrelativo.TabIndex = 6;
            this.lblcorrelativo.Text = "123456789";
            // 
            // lblnombrempresa
            // 
            this.lblnombrempresa.AutoSize = true;
            this.lblnombrempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrempresa.Location = new System.Drawing.Point(12, 156);
            this.lblnombrempresa.Name = "lblnombrempresa";
            this.lblnombrempresa.Size = new System.Drawing.Size(241, 36);
            this.lblnombrempresa.TabIndex = 8;
            this.lblnombrempresa.Text = "Nombre empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre/Razon Social:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(165, 288);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(248, 20);
            this.txtNombreCliente.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(165, 317);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(248, 53);
            this.txtdireccion.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Moneda";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(167, 376);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(248, 20);
            this.txtMoneda.TabIndex = 14;
            // 
            // txtnumeroruc
            // 
            this.txtnumeroruc.Location = new System.Drawing.Point(881, 289);
            this.txtnumeroruc.Name = "txtnumeroruc";
            this.txtnumeroruc.Size = new System.Drawing.Size(248, 20);
            this.txtnumeroruc.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(842, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ruc";
            // 
            // txtFechaEmision
            // 
            this.txtFechaEmision.Location = new System.Drawing.Point(881, 315);
            this.txtFechaEmision.Name = "txtFechaEmision";
            this.txtFechaEmision.Size = new System.Drawing.Size(248, 20);
            this.txtFechaEmision.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(776, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha emision";
            // 
            // txtfechapago
            // 
            this.txtfechapago.Location = new System.Drawing.Point(881, 376);
            this.txtfechapago.Name = "txtfechapago";
            this.txtfechapago.Size = new System.Drawing.Size(248, 20);
            this.txtfechapago.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(776, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de pago:";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Location = new System.Drawing.Point(15, 450);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.Size = new System.Drawing.Size(1128, 128);
            this.dgvdetalle.TabIndex = 21;
            // 
            // lblmontoenletras
            // 
            this.lblmontoenletras.AutoSize = true;
            this.lblmontoenletras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmontoenletras.Location = new System.Drawing.Point(15, 581);
            this.lblmontoenletras.Name = "lblmontoenletras";
            this.lblmontoenletras.Size = new System.Drawing.Size(165, 17);
            this.lblmontoenletras.TabIndex = 22;
            this.lblmontoenletras.Text = "Texto de monto en letras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(629, 582);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Op.Gravada";
            // 
            // txtimportegravada
            // 
            this.txtimportegravada.Location = new System.Drawing.Point(742, 581);
            this.txtimportegravada.Name = "txtimportegravada";
            this.txtimportegravada.Size = new System.Drawing.Size(78, 20);
            this.txtimportegravada.TabIndex = 24;
            // 
            // txtimporteigv
            // 
            this.txtimporteigv.Location = new System.Drawing.Point(742, 607);
            this.txtimporteigv.Name = "txtimporteigv";
            this.txtimporteigv.Size = new System.Drawing.Size(78, 20);
            this.txtimporteigv.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(629, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "IGV";
            // 
            // txtimporteinafecta
            // 
            this.txtimporteinafecta.Location = new System.Drawing.Point(742, 633);
            this.txtimporteinafecta.Name = "txtimporteinafecta";
            this.txtimporteinafecta.Size = new System.Drawing.Size(78, 20);
            this.txtimporteinafecta.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(629, 634);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Op.Inafecta";
            // 
            // txtimportexonerada
            // 
            this.txtimportexonerada.Location = new System.Drawing.Point(742, 659);
            this.txtimportexonerada.Name = "txtimportexonerada";
            this.txtimportexonerada.Size = new System.Drawing.Size(78, 20);
            this.txtimportexonerada.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(629, 660);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Op.Exonerada";
            // 
            // txtimporteexportacion
            // 
            this.txtimporteexportacion.Location = new System.Drawing.Point(742, 685);
            this.txtimporteexportacion.Name = "txtimporteexportacion";
            this.txtimporteexportacion.Size = new System.Drawing.Size(78, 20);
            this.txtimporteexportacion.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(629, 686);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Op.Exportacion";
            // 
            // txtimportetotal
            // 
            this.txtimportetotal.Location = new System.Drawing.Point(742, 711);
            this.txtimportetotal.Name = "txtimportetotal";
            this.txtimportetotal.Size = new System.Drawing.Size(78, 20);
            this.txtimportetotal.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(629, 712);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Importe total";
            // 
            // lbldireccionemisor
            // 
            this.lbldireccionemisor.AutoSize = true;
            this.lbldireccionemisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccionemisor.Location = new System.Drawing.Point(12, 205);
            this.lbldireccionemisor.Name = "lbldireccionemisor";
            this.lbldireccionemisor.Size = new System.Drawing.Size(298, 36);
            this.lbldireccionemisor.TabIndex = 35;
            this.lbldireccionemisor.Text = "direccion de empresa";
            this.lbldireccionemisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(536, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 749);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbldireccionemisor);
            this.Controls.Add(this.txtimportetotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtimporteexportacion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtimportexonerada);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtimporteinafecta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtimporteigv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtimportegravada);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblmontoenletras);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.txtfechapago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFechaEmision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnumeroruc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblnombrempresa);
            this.Controls.Add(this.lblcorrelativo);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblRucEmpresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRucEmpresa;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblcorrelativo;
        private System.Windows.Forms.Label lblnombrempresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.TextBox txtnumeroruc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaEmision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfechapago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.Label lblmontoenletras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtimportegravada;
        private System.Windows.Forms.TextBox txtimporteigv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtimporteinafecta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtimportexonerada;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtimporteexportacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtimportetotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbldireccionemisor;
        private System.Windows.Forms.Button btnGuardar;
    }
}