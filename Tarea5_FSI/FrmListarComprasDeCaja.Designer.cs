namespace Tarea5_FSI
{
    partial class FrmListarComprasDeCaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxCajas = new System.Windows.Forms.ListBox();
            this.lBoxCompras = new System.Windows.Forms.ListBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lBoxMonto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cajas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compras";
            // 
            // lBoxCajas
            // 
            this.lBoxCajas.FormattingEnabled = true;
            this.lBoxCajas.Location = new System.Drawing.Point(24, 40);
            this.lBoxCajas.Name = "lBoxCajas";
            this.lBoxCajas.Size = new System.Drawing.Size(120, 186);
            this.lBoxCajas.TabIndex = 2;
            this.lBoxCajas.SelectedIndexChanged += new System.EventHandler(this.lBoxCajas_SelectedIndexChanged);
            // 
            // lBoxCompras
            // 
            this.lBoxCompras.FormattingEnabled = true;
            this.lBoxCompras.Location = new System.Drawing.Point(186, 40);
            this.lBoxCompras.Name = "lBoxCompras";
            this.lBoxCompras.Size = new System.Drawing.Size(136, 186);
            this.lBoxCompras.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(221, 247);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto";
            // 
            // lBoxMonto
            // 
            this.lBoxMonto.FormattingEnabled = true;
            this.lBoxMonto.Location = new System.Drawing.Point(345, 40);
            this.lBoxMonto.Name = "lBoxMonto";
            this.lBoxMonto.Size = new System.Drawing.Size(136, 186);
            this.lBoxMonto.TabIndex = 6;
            // 
            // FrmListarComprasDeCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 282);
            this.Controls.Add(this.lBoxMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lBoxCompras);
            this.Controls.Add(this.lBoxCajas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmListarComprasDeCaja";
            this.Text = "FrmListarComprasDeCaja";
            this.Load += new System.EventHandler(this.FrmListarComprasDeCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBoxCajas;
        private System.Windows.Forms.ListBox lBoxCompras;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBoxMonto;
    }
}