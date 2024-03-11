using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03
{
    public class Program
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int[] data = { 1, 5, 3, 2, 4 };
            Array2 array = new Array2(data);

            Console.WriteLine("Максимальне значення: " + array.Max());
            Console.WriteLine("Мінімальне значення: " + array.Min());
            Console.WriteLine("Середнє значення: " + array.Avg());
            Console.WriteLine("Значення 3 знайдено: " + array.Search(3));
            Console.WriteLine("Значення 7 знайдено: " + array.Search(7));
        }
    }
}
