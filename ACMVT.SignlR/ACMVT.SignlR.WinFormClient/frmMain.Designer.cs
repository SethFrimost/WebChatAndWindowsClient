namespace ACMVT.SignlR.WinFormClient
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConnectTo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisconectFrom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiChangeName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJoin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabServers = new System.Windows.Forms.TabControl();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiServer,
            this.tsmiRoom});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiExit.Text = "Exit";
            // 
            // tsmiServer
            // 
            this.tsmiServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnectTo,
            this.tsmiDisconectFrom,
            this.toolStripSeparator1,
            this.tsmiChangeName});
            this.tsmiServer.Name = "tsmiServer";
            this.tsmiServer.Size = new System.Drawing.Size(51, 20);
            this.tsmiServer.Text = "Server";
            // 
            // tsmiConnectTo
            // 
            this.tsmiConnectTo.Name = "tsmiConnectTo";
            this.tsmiConnectTo.Size = new System.Drawing.Size(180, 22);
            this.tsmiConnectTo.Text = "Connect to";
            this.tsmiConnectTo.Click += new System.EventHandler(this.tsmiConnectTo_Click);
            // 
            // tsmiDisconectFrom
            // 
            this.tsmiDisconectFrom.Name = "tsmiDisconectFrom";
            this.tsmiDisconectFrom.Size = new System.Drawing.Size(180, 22);
            this.tsmiDisconectFrom.Text = "Disconect from";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiChangeName
            // 
            this.tsmiChangeName.Name = "tsmiChangeName";
            this.tsmiChangeName.Size = new System.Drawing.Size(180, 22);
            this.tsmiChangeName.Text = "Change name";
            // 
            // tsmiRoom
            // 
            this.tsmiRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiJoin,
            this.tsmiLeave});
            this.tsmiRoom.Name = "tsmiRoom";
            this.tsmiRoom.Size = new System.Drawing.Size(51, 20);
            this.tsmiRoom.Text = "Room";
            // 
            // tsmiJoin
            // 
            this.tsmiJoin.Name = "tsmiJoin";
            this.tsmiJoin.Size = new System.Drawing.Size(104, 22);
            this.tsmiJoin.Text = "Join";
            // 
            // tsmiLeave
            // 
            this.tsmiLeave.Name = "tsmiLeave";
            this.tsmiLeave.Size = new System.Drawing.Size(104, 22);
            this.tsmiLeave.Text = "Leave";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabServers
            // 
            this.tabServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabServers.Location = new System.Drawing.Point(0, 24);
            this.tabServers.Name = "tabServers";
            this.tabServers.SelectedIndex = 0;
            this.tabServers.Size = new System.Drawing.Size(800, 426);
            this.tabServers.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabServers);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Chat";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiServer;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnectTo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisconectFrom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeName;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiJoin;
        private System.Windows.Forms.ToolStripMenuItem tsmiLeave;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabServers;
    }
}

