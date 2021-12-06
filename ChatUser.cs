using System;

namespace ChapAppMediator
{
    public class ChatUser:IUser
    {
        private IChatServer _chatRoom;

        public int Id { get; }
        public string Name { get; }
        public bool IsBusy { get; }

        public ChatUser(string name, IChatServer chatRoom)
        {
            Id = new Random(100).Next();
            Name = name;
            _chatRoom = chatRoom;
        }


        public void SendMessage(int userId, string message)
        {
            
        }

        public void ReceiveMessage(string userName, string message)
        {
            
        }


    }
}
