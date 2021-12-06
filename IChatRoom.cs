namespace ChapAppMediator
{
    public interface IChatRoom
    {
        void RegisterUser(IUser user);
        void Unregister(IUser user);
        void SendMessage(int userIdSender, int userIdReceiver, string message);
    }
}
