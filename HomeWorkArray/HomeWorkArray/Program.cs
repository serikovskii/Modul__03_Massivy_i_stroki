using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1
            ConsoleKeyInfo Symbol;
            int spaceCount = 0;
            Console.WriteLine("Введите текст и точку чтобы выйти");
            do
            {
                Symbol = Console.ReadKey();

                if (Symbol.KeyChar == '.')
                {
                    break;
                }
                if (Symbol.KeyChar == ' ')
                {
                    spaceCount++;
                }
            }
            while (true);
            Console.WriteLine("\nПробелов: " + spaceCount);
            // 2
            int numBilet;
            numBilet = Int32.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;

            

            // 3
            string str;
            string tmp;
            Console.WriteLine("Введите текст:");
            str = Console.ReadLine();
            tmp = str;
            if (str.Equals(tmp.ToLower()))
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.ToLower());
            }
            Console.ReadLine();
            // 4

            // 5
            string number = "987654321";
            char[] numOne = number.ToCharArray();

            for (int i = 0; i < numOne.Length; i++)
            {
                Console.Write(numOne[numOne.Length - 1 - i]);
            }
            Console.ReadLine();
        }
    }
}
