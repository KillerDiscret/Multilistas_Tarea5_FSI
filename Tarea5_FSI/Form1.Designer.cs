namespace Tarea5_FSI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarComprasDeUnaCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerCajaConMásComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCajasDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerClientesConMenorCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerMontoTotalDeTodasLasCajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCajaToolStripMenuItem,
            this.registrarCompraToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // crearCajaToolStripMenuItem
            // 
            this.crearCajaToolStripMenuItem.Name = "crearCajaToolStripMenuItem";
            this.crearCajaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.crearCajaToolStripMenuItem.Text = "Crear Caja";
            this.crearCajaToolStripMenuItem.Click += new System.EventHandler(this.crearCajaToolStripMenuItem_Click);
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            this.registrarCompraToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarComprasDeUnaCajaToolStripMenuItem,
            this.obtenerCajaConMásComprasToolStripMenuItem,
            this.listarCajasDeUnClienteToolStripMenuItem,
            this.obtenerClientesConMenorCompraToolStripMenuItem,
            this.obtenerMontoTotalDeTodasLasCajasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listarComprasDeUnaCajaToolStripMenuItem
            // 
            this.listarComprasDeUnaCajaToolStripMenuItem.Name = "listarComprasDeUnaCajaToolStripMenuItem";
            this.listarComprasDeUnaCajaToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.listarComprasDeUnaCajaToolStripMenuItem.Text = "Listar Compras de una Caja";
            this.listarComprasDeUnaCajaToolStripMenuItem.Click += new System.EventHandler(this.listarComprasDeUnaCajaToolStripMenuItem_Click);
            // 
            // obtenerCajaConMásComprasToolStripMenuItem
            // 
            this.obtenerCajaConMásComprasToolStripMenuItem.Name = "obtenerCajaConMásComprasToolStripMenuItem";
            this.obtenerCajaConMásComprasToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.obtenerCajaConMásComprasToolStripMenuItem.Text = "Obtener Caja con más compras";
            this.obtenerCajaConMásComprasToolStripMenuItem.Click += new System.EventHandler(this.obtenerCajaConMásComprasToolStripMenuItem_Click);
            // 
            // listarCajasDeUnClienteToolStripMenuItem
            // 
            this.listarCajasDeUnClienteToolStripMenuItem.Name = "listarCajasDeUnClienteToolStripMenuItem";
            this.listarCajasDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.listarCajasDeUnClienteToolStripMenuItem.Text = "Listar Cajas de un Cliente";
            this.listarCajasDeUnClienteToolStripMenuItem.Click += new System.EventHandler(this.listarCajasDeUnClienteToolStripMenuItem_Click);
            // 
            // obtenerClientesConMenorCompraToolStripMenuItem
            // 
            this.obtenerClientesConMenorCompraToolStripMenuItem.Name = "obtenerClientesConMenorCompraToolStripMenuItem";
            this.obtenerClientesConMenorCompraToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.obtenerClientesConMenorCompraToolStripMenuItem.Text = "Obtener Clientes con menor compra";
            // 
            // obtenerMontoTotalDeTodasLasCajasToolStripMenuItem
            // 
            this.obtenerMontoTotalDeTodasLasCajasToolStripMenuItem.Name = "obtenerMontoTotalDeTodasLasCajasToolStripMenuItem";
            this.obtenerMontoTotalDeTodasLasCajasToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.obtenerMontoTotalDeTodasLasCajasToolStripMenuItem.Text = "Obtener monto total de todas las Cajas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarComprasDeUnaCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerCajaConMásComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCajasDeUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerClientesConMenorCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerMontoTotalDeTodasLasCajasToolStripMenuItem;
    }
}

