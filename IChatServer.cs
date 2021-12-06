namespace ChapAppMediator
{
    public interface IChatServer
    {
        void RegisterUser(IUser user);
        void Unregister(IUser user);
        void SendMessage(string senderName, string receiverName, string message);
    }
}
