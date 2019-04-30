namespace Tarea5_FSI
{
    partial class FrmIngresoCaja
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
            this.txtBoxCodCaja = new System.Windows.Forms.TextBox();
            this.txtBoxNombreCaja = new System.Windows.Forms.TextBox();
            this.btnSalirCaja = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Cajero";
            // 
            // txtBoxCodCaja
            // 
            this.txtBoxCodCaja.Location = new System.Drawing.Point(129, 22);
            this.txtBoxCodCaja.MaxLength = 8;
            this.txtBoxCodCaja.Name = "txtBoxCodCaja";
            this.txtBoxCodCaja.Size = new System.Drawing.Size(114, 20);
            this.txtBoxCodCaja.TabIndex = 2;
            // 
            // txtBoxNombreCaja
            // 
            this.txtBoxNombreCaja.Location = new System.Drawing.Point(129, 66);
            this.txtBoxNombreCaja.MaxLength = 40;
            this.txtBoxNombreCaja.Name = "txtBoxNombreCaja";
            this.txtBoxNombreCaja.Size = new System.Drawing.Size(211, 20);
            this.txtBoxNombreCaja.TabIndex = 3;
            // 
            // btnSalirCaja
            // 
            this.btnSalirCaja.Location = new System.Drawing.Point(273, 131);
            this.btnSalirCaja.Name = "btnSalirCaja";
            this.btnSalirCaja.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCaja.TabIndex = 4;
            this.btnSalirCaja.Text = "Salir";
            this.btnSalirCaja.UseVisualStyleBackColor = true;
            this.btnSalirCaja.Click += new System.EventHandler(this.btnSalirCaja_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(30, 131);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(116, 23);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar Caja";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmIngresoCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 166);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalirCaja);
            this.Controls.Add(this.txtBoxNombreCaja);
            this.Controls.Add(this.txtBoxCodCaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngresoCaja";
            this.Text = "FrmIngresoCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCodCaja;
        private System.Windows.Forms.TextBox txtBoxNombreCaja;
        private System.Windows.Forms.Button btnSalirCaja;
        private System.Windows.Forms.Button btnIngresar;
    }
}