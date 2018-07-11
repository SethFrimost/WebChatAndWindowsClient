namespace ACMVT.SignlR.WinFormClient
{
    partial class InputDialog
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
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnCancl = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcc
            // 
            this.btnAcc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAcc.Location = new System.Drawing.Point(12, 38);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(75, 23);
            this.btnAcc.TabIndex = 0;
            this.btnAcc.Text = "Aceptar";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnCancl
            // 
            this.btnCancl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancl.Location = new System.Drawing.Point(93, 38);
            this.btnCancl.Name = "btnCancl";
            this.btnCancl.Size = new System.Drawing.Size(75, 23);
            this.btnCancl.TabIndex = 1;
            this.btnCancl.Text = "Cancelar";
            this.btnCancl.UseVisualStyleBackColor = true;
            this.btnCancl.Click += new System.EventHandler(this.btnCancl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 2;
            // 
            // InputDialog
            // 
            this.AcceptButton = this.btnAcc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancl;
            this.ClientSize = new System.Drawing.Size(309, 70);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancl);
            this.Controls.Add(this.btnAcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnCancl;
        private System.Windows.Forms.TextBox textBox1;
    }
}