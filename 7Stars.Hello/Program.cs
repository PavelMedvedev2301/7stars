using System;
using System.Threading;

namespace _7Stars.Hello
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the 7Stars application.");
            
            var playerName = "Pavel";
            var server = new Server();
            server.Start();


            var client = new Client(playerName);

            var username = "pmedvedev";
            var password = "pmedvedev";
            client.Login(username, password, server.Id);

            var game = new HorseRacing();
            client.StartGame(game);
            while (game.IsPlaying { Thread.Sleep(100); }


            Console.WriteLine("Hello World!");
        }
    }

    internal class Server
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public int Id { get; set; }
    }

    public class Client
    {
        public Client(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public bool IsActive { get; set; }
        public void Login(string username, string password, int serverId)
        {
            IsActive = true;
        }

        public void StartGame(HorseRacing horseRacing)
        {
            throw new NotImplementedException();
        }
    }

    public class HorseRacing : IGame
    {
        public bool IsPlaying { get; set; }
    }

    public interface IGame
    {
    }
}
