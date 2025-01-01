using System;
namespace SkillFactoryLessons_Part3
{
    public enum FavoriteDay
    {
        понедельник = 1,
        вторник,
        среда,
        четверг,
        пятница,
        суббота,
        воскресенье
    }
    public class Program
    {
        public static void Main()
        {
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.Write("Введите номер вашего любимого дня недели: ");
            byte day = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("Ваше имя {0}, Ваш возраст {1}, Ваш любимый день: {2}", name, age, (FavoriteDay)day);
            Console.ReadKey();
        }
    }
}