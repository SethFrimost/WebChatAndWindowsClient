using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ACMVT.SignlR.WebChatServer
{
    public class RoomManager : IGroupManager
    {
        private Dictionary<string, List<string>> Rooms;

        public RoomManager()
        {
            Rooms = new Dictionary<string, List<string>>();
            Rooms.Add("General", new List<string>());
        }

        public Task Add(string connectionId, string groupName)
        {
            if(!Rooms.ContainsKey(groupName))
            {
                Rooms.Add(groupName, new List<string>());
            }
            Rooms[groupName].Add(connectionId);
            return null;
        }

        public Task Remove(string connectionId, string groupName)
        {
            if (Rooms.ContainsKey(groupName))
            {
                Rooms.Remove(groupName);
            }
            return null;
        }

        public List<string> GetAllConnectionsId(string room)
        {
            if (Rooms.ContainsKey(room)) return Rooms[room];
            else return new List<string>();
        }
    }
}