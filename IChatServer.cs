namespace ChapAppMediator
{
    public interface IChatServer
    {
        void RegisterUser(IUser user);
        void Unregister(IUser user);
        void SendMessage(int userIdSender, int userIdReceiver, string message);
    }
}
