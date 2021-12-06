namespace ChapAppMediator
{
    public interface IUser
    {
        void SendMessage(string userName, string message);
        void ReceiveMessage(string userName, string message);
        int Id { get; }
        string Name { get; }
        bool IsBusy { get; }
    }
}
