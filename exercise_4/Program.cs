using System;

namespace exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 0 или 1");
            int num = int.Parse(Console.ReadLine());
            string a = num == 1 ? "Хорошо" : num == 0 ? "Плохо" : "Введёное число не является 1 или 0";
            Console.WriteLine(a);
            Console.ReadLine();
        }
                      
                
            
        
    }
}
