using System;

namespace ChapAppMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatServer = new ChatServer();

            var john = new ChatUser("John", chatServer);
            var doe = new ChatUser("Doe", chatServer);
            var andrew = new ChatUser("Andrew", chatServer);

            chatServer.RegisterUser(john);
            chatServer.RegisterUser(doe);

            chatServer.RegisterUser(andrew);

            chatServer.Unregister(john);

            john.SendMessage("Doe", "Test message");


            Console.ReadLine();
        }
    }
}
