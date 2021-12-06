namespace ChapAppMediator
{
    public class ChatServer:IChatServer
    {
        public void RegisterUser(IUser user)
        {
            //register user and notify each user that a new one joined the club
        }

        public void Unregister(IUser user)
        {
            //unregister user and notify each user that one leaved the club
        }

        public void SendMessage(int userIdSender, int userIdReceiver, string message)
        {
            //send message to specific user
        }
    }
}
