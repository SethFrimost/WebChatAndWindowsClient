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
    public partial class frmMain : Form
    {
        List<ChatServer> servers = new List<ChatServer>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiConnectTo_Click(object sender, EventArgs e)
        {
            try
            {
                var inp = new InputDialog();
                if (inp.ShowDialog() == DialogResult.OK)
                {
                    var s = new ChatServer(inp.Texto, Environment.UserName);
                    s.Dock = DockStyle.Fill;
                    tabServers.TabPages.Add(inp.Texto, inp.Texto);
                    tabServers.TabPages[inp.Texto].Controls.Add(s);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
