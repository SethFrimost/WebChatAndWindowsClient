using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACMVT.SignlR.WinFormClient
{
    public partial class InputDialog : Form
    {
        public string Texto { get; set; }
        public InputDialog()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            Texto = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancl_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
