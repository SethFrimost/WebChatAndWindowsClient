namespace ACMVT.SignlR.WinFormClient
{
    partial class ChatRoom
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbSala = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbSala);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtSend);
            this.splitContainer1.Panel2.Controls.Add(this.btnSend);
            this.splitContainer1.Size = new System.Drawing.Size(459, 339);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 3;
            // 
            // txtSend
            // 
            this.txtSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSend.Location = new System.Drawing.Point(0, 0);
            this.txtSend.MinimumSize = new System.Drawing.Size(4, 44);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(406, 57);
            this.txtSend.TabIndex = 2;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            this.txtSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyUp);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Image = global::ACMVT.SignlR.WinFormClient.Properties.Resources.export1;
            this.btnSend.Location = new System.Drawing.Point(406, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(53, 57);
            this.btnSend.TabIndex = 3;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbSala
            // 
            this.rtbSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSala.Location = new System.Drawing.Point(0, 0);
            this.rtbSala.Name = "rtbSala";
            this.rtbSala.ReadOnly = true;
            this.rtbSala.Size = new System.Drawing.Size(459, 278);
            this.rtbSala.TabIndex = 6;
            this.rtbSala.Text = "";
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ChatRoom";
            this.Size = new System.Drawing.Size(459, 339);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbSala;
    }
}
