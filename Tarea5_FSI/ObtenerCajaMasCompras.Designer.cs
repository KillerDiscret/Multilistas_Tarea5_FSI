namespace Tarea5_FSI
{
    partial class ObtenerCajaMasCompras
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
            this.listBoxCaja = new System.Windows.Forms.ListBox();
            this.listBoxCompras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCaja
            // 
            this.listBoxCaja.FormattingEnabled = true;
            this.listBoxCaja.Location = new System.Drawing.Point(12, 40);
            this.listBoxCaja.Name = "listBoxCaja";
            this.listBoxCaja.Size = new System.Drawing.Size(120, 134);
            this.listBoxCaja.TabIndex = 0;
            // 
            // listBoxCompras
            // 
            this.listBoxCompras.FormattingEnabled = true;
            this.listBoxCompras.Location = new System.Drawing.Point(258, 40);
            this.listBoxCompras.Name = "listBoxCompras";
            this.listBoxCompras.Size = new System.Drawing.Size(120, 134);
            this.listBoxCompras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compras";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(159, 204);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ObtenerCajaMasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 262);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCompras);
            this.Controls.Add(this.listBoxCaja);
            this.Name = "ObtenerCajaMasCompras";
            this.Text = "ObtenerCajaMasCompras";
            this.Load += new System.EventHandler(this.ObtenerCajaMasCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCaja;
        private System.Windows.Forms.ListBox listBoxCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}