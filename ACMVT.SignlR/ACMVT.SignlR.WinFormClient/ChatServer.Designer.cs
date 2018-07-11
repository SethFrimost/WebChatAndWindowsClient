namespace ACMVT.SignlR.WinFormClient
{
    partial class ChatServer
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabRooms = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabRooms
            // 
            this.tabRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRooms.Location = new System.Drawing.Point(0, 0);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.SelectedIndex = 0;
            this.tabRooms.Size = new System.Drawing.Size(552, 395);
            this.tabRooms.TabIndex = 4;
            // 
            // ChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabRooms);
            this.Name = "ChatServer";
            this.Size = new System.Drawing.Size(552, 395);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRooms;
    }
}
