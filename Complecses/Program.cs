using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complecses
{
    internal class Program
    {
        static void Main()
        { 
            bool f = true;

            while (f)
            {
                Console.WriteLine("Мои задачи");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Сложение комплексных чисел");
                Console.WriteLine("2 -> Вычитание комплексных чисел");
                Console.WriteLine("3 -> Умножение комплексных чисел");
                Console.WriteLine("4 -> Деление комплексных чисел");
                Console.WriteLine("5 -> Второе задание из домашней работы");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                var complex1 = new ComplexClass(5, 6);
                var complex2 = new ComplexClass(15, 87);

                switch (number)
                {
                    case 0:
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        break;
                    case 1:
                        ComplexClass plus = complex1.Plus(complex2); ;                        
                        Console.WriteLine($"Сумма сложения комплексных чисел 5,6i и 15,87i = {plus}") ;
                        break;

                    case 2:
                        ComplexClass subtract = complex1.Subtract(complex2); ;
                        Console.WriteLine($"Сумма сложения комплексных чисел 5,6i и 15,87i = {subtract}");
                        break;

                    case 3:
                        
                        ComplexClass multi = complex1.Multi(complex2); ;
                        Console.WriteLine($"Сумма сложения комплексных чисел 5,6i и 15,87i = {multi}");
                        break;

                    case 4:
                        ComplexClass divide = complex1.Divide(complex2); ;
                        Console.WriteLine($"Сумма сложения комплексных чисел 5,6i и 15,87i = {divide}");
                        break;

                    case 5:
                        Task3();
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.");
                        break;
                }
            }
        }
        static void Task3()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Выполнение задачи 3 ...");
            Console.WriteLine("=======================");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("СУММА НЕЧЕТНЫХ ПОЛОЖИТЕЛЬНЫХ ЧИСЕЛ");
                         
            Console.Write("Введите числа, кроме 0 Если будет введен 0,\nпрограмма начнет считать сумму:\n");
            int counter = 0;            
            while (true)
            { 
                bool result = int.TryParse(Console.ReadLine(), out int number);

                if (result)
                {

                    if (number % 2 == 1 && number > 0)
                    {
                        counter += number;                       
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число, попробуйте снова");
                    continue;
                }

                if (number == 0)
                {
                    
                    Console.WriteLine($"Сумма чисел = {counter}.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }    
}
