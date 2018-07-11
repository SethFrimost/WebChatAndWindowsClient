using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACMVT.SignlR.WinFormClient
{
    public partial class ChatServer : UserControl
    {
        ChatWindowsClient.ChatClient chatClient;
        List<ChatRoom> rooms = new List<ChatRoom>();

        public ChatServer(string url, string name)
        {
            InitializeComponent();

            chatClient = new ChatWindowsClient.ChatClient(url, name);
            AddRoom(ChatWindowsClient.ChatClient.GlobalRoom);
        }

        public void AddRoom(string roomName)
        {
            var r = new ChatRoom(chatClient.rooms[roomName]);
            r.Dock = DockStyle.Fill;
            rooms.Add(r);

            tabRooms.TabPages.Add(roomName,roomName);
            tabRooms.TabPages[roomName].Controls.Add(r);
        }
    }
}
