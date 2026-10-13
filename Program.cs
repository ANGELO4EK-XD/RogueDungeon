using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int playerHealth = 100, maxHealth = 100, gold = 0, PosX = 0, posY = 0;
            Console.WriteLine("###");
            Console.WriteLine("###");
            Console.WriteLine("###");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(PosX, posY);
            Console.Write("H");
            Console.ResetColor();
            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"♥️[{playerHealth}/{maxHealth}] ${gold,5}");

            int enemyDamage;;
            Console.Write("Введите урон противника: ");
            int.TryParse(Console.ReadLine(), out enemyDamage);
            playerHealth -= enemyDamage;
            if (playerHealth < 0) 
            {
                playerHealth = 0;
            }
            Console.WriteLine($"♥️[{playerHealth}/{maxHealth}] ${gold,5}");

            Console.Write("Двинуться: ");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.D)
            {
                //вправо
                Console.SetCursorPosition(PosX, posY);
                Console.WriteLine("#");
                PosX += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(PosX, posY);
                Console.Write("H");
                Console.ResetColor();
                Console.SetCursorPosition(0, 4);
            }
            else if (key.Key == ConsoleKey.S)
            {
                //вниз            
            }
        }
    }
}
