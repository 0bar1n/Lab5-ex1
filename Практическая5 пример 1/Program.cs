using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom"; int age = 33; //задание переменной строкового типа ; целочисленного типа
            bool isEmployed = false; double weight = 78.65; //задание переменной логического типа; вещественного типа
            Console.WriteLine($"Имя: {name}"); Console.WriteLine($"Возраст: {age}");   //вывод переменной; вывод переменной
            Console.WriteLine($"Вес: {weight}"); Console.WriteLine($"Работает: {isEmployed}"); //вывод переменной; вывод переменной
        }
    }
}