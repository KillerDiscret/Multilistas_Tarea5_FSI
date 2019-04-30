namespace Tarea5_FSI
{
    partial class ListarCajasDeCliente
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
            this.listBoxDNI = new System.Windows.Forms.ListBox();
            this.listBoxCodigo = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes(DNI)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cajas(Codigo)";
            // 
            // listBoxDNI
            // 
            this.listBoxDNI.FormattingEnabled = true;
            this.listBoxDNI.Location = new System.Drawing.Point(23, 47);
            this.listBoxDNI.Name = "listBoxDNI";
            this.listBoxDNI.Size = new System.Drawing.Size(120, 186);
            this.listBoxDNI.TabIndex = 2;
            this.listBoxDNI.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxCodigo
            // 
            this.listBoxCodigo.FormattingEnabled = true;
            this.listBoxCodigo.Location = new System.Drawing.Point(272, 47);
            this.listBoxCodigo.Name = "listBoxCodigo";
            this.listBoxCodigo.Size = new System.Drawing.Size(120, 186);
            this.listBoxCodigo.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(164, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListarCajasDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 298);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listBoxCodigo);
            this.Controls.Add(this.listBoxDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListarCajasDeCliente";
            this.Text = "ListarCajasDeCliente";
            this.Load += new System.EventHandler(this.ListarCajasDeCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDNI;
        private System.Windows.Forms.ListBox listBoxCodigo;
        private System.Windows.Forms.Button btnSalir;
    }
}