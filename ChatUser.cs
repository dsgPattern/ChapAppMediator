using System;

namespace ChapAppMediator
{
    public class ChatUser:IUser
    {
        private IChatServer _chatServer;

        public int Id { get; }
        public string Name { get; }
        public bool IsBusy { get; }

        public ChatUser(string name, IChatServer chatServer)
        {
            Id = new Random().Next();
            Name = name;
            _chatServer = chatServer;
        }


        public void SendMessage(string userName, string message)
        {
            
        }

        public void ReceiveMessage(string userName, string message)
        {
            
        }


    }
}
