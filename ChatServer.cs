using System.Collections.Generic;
using System.Linq;

namespace ChapAppMediator
{
    public class ChatServer:IChatServer
    {
        private List<IUser> _users = new List<IUser>();

        public void RegisterUser(IUser user)
        {
            //register user and notify each user that a new one joined the club
            if (!_users.Contains(user))
            {
                _users.ForEach(x => x.ReceiveMessage(x.Name, $"User {user.Name} is online"));
                _users.Add(user);
            }

        }

        public void Unregister(IUser user)
        {
            //unregister user and notify each user that one leaved the club
            if (_users.Contains(user))
            {
                _users.Remove(user);
                _users.ForEach(x => x.ReceiveMessage(x.Name, $"User {user.Name} is offline"));
            }
        }

        public void SendMessage(string senderName, string receiverName, string message)
        {
            //send message to specific user
            var receiver = _users.FirstOrDefault(x => x.Name == receiverName);
            receiver.ReceiveMessage(senderName, message);
        }
    }
}
