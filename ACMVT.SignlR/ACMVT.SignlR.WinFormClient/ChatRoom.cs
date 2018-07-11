using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace ACMVT.SignlR.WinFormClient
{
    public partial class ChatRoom : UserControl
    {
        ChatWindowsClient.ChatRoom Room;
        string html = string.Empty;

        public ChatRoom(ChatWindowsClient.ChatRoom room)
        {
            InitializeComponent();

            Room = room;
            /*this.lblName.Text = Room.room;

            webSala.Navigate("about:blank");
            webSala.Document.OpenNew(false);
            webSala.Document.Write(string.Empty);*/

            room.MessageRecived += Room_MessageRecived;
            room.PrivateMessageRecived += Room_PrivateMessageRecived;
        }

        private void Room_PrivateMessageRecived(string name, string msg)
        {
            name = HttpUtility.HtmlEncode(name);
            msg = HttpUtility.HtmlEncode(msg);

            //webSala.DocumentText += $"<li><strong style='color:red'>{name}</strong>: {msg}</li>"+Environment.NewLine;
        }

        private void Room_MessageRecived(string name, string msg)
        {
            if (rtbSala.InvokeRequired)
            {

                rtbSala.Invoke(new Action(() => {
                    rtbSala.SelectionColor = Color.DarkGreen;
                    rtbSala.AppendText(name);
                    rtbSala.SelectionColor = Color.Empty;
                    rtbSala.AppendText(": " + msg +Environment.NewLine);
                    
                    //rtbSala.Rtf += $"{{\\rtf1\\ansi \\b {name} \\b0 : {msg} \\line }}" + Environment.NewLine;
                    rtbSala.Refresh();
                }));
            }
            else
            {
                rtbSala.SelectionColor = Color.DarkGreen;
                rtbSala.AppendText(name);
                rtbSala.SelectionColor = Color.Empty;
                rtbSala.AppendText(": " + msg + Environment.NewLine);

                //rtbSala.Rtf += $"{{\\rtf1\\ansi \\b {name} \\b0 : {msg} \\line }}" + Environment.NewLine;
                rtbSala.Refresh();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Room.Send(txtSend.Text);
            txtSend.Text = string.Empty;
            txtSend.Focus();
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (e.Shift)
                {
                    e.Handled = true;
                    txtSend.AppendText(Environment.NewLine);
                }
                else
                {
                    btnSend_Click(this, EventArgs.Empty);
                    e.Handled = true;
                }
            }
        }

        private void txtSend_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
