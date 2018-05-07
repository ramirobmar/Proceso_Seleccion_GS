namespace WindowsExplorerForms
{
    partial class xDSL_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xDSL_Tools));
            this.SuspendLayout();
            // 
            // xDSL_Tools
            // 
            this.ClientSize = new System.Drawing.Size(947, 381);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xDSL_Tools";
            this.Text = "xDSL Tools";
            this.Load += new System.EventHandler(this.xDSL_Tools_Load);
            this.ResumeLayout(false);

        }

        #endregion


    }
}

