namespace Presentacion
{
    partial class frmConsultas
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtnodo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeer.Location = new System.Drawing.Point(0, 20);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(512, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(512, 367);
            this.textBox1.TabIndex = 1;
            // 
            // txtnodo
            // 
            this.txtnodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtnodo.Location = new System.Drawing.Point(0, 0);
            this.txtnodo.Name = "txtnodo";
            this.txtnodo.Size = new System.Drawing.Size(512, 20);
            this.txtnodo.TabIndex = 2;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 410);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtnodo);
            this.Name = "frmConsultas";
            this.Text = "leer Xml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtnodo;
    }
}