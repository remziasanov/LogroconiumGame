using LogroconiumGame.Models;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace LogroconiumGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Добро пожаловать в игру Logroconium!");
			Console.WriteLine("Вы ведущий или игрок? Выберите Ведущий - Игрок");
            var choose = Console.ReadLine();

            if (string.IsNullOrEmpty(choose) && choose == "Ведущий")
            {
				Console.WriteLine("Назовите свое имя Ведущий");
				var name  = Console.ReadLine();

                var player = new Player()
                {
                    Name = name, 
                    TelegramId = 1, // to do подключить апи телеграм
					IsLeading = true
				};
            }
            else
            {

            }
        }
    }
}
