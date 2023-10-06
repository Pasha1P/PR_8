using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PR_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, previousNumber, i = 0, exit = 1;
            Console.Title = "Практическая работа №8";
            Console.WriteLine("\tЗдраствуйте!");
            Console.Write("Введите первое число: ");

            while (exit == 1)
            {
                try
                {
                    while (true)
                    {
                        Console.Write("Введите первое число: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        previousNumber = number;
                        while (true)
                        {
                            Console.Write("Введите следующее число: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            if (number == 0)
                            {
                                break;
                            }
                            else
                            {
                                if (number > previousNumber)
                                {
                                    i++;
                                }
                                previousNumber = number;
                            }
                        }
                        Console.WriteLine("\t . . . ");
                        Console.WriteLine($"счетчик показал: {i}");
                        i = 0;
                        Console.WriteLine(" ");
                        Console.WriteLine("если нет еще последовательности введите 0, иначе другую цифру");
                        exit = Convert.ToInt32(Console.ReadLine());
                        if (exit == 0) break;
                        Console.Clear();
                    }
                }
                catch (InvalidCastException ice)                  //Исключение, которое выдается в случае недопустимого приведения или явного преобразования.
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Недопустимое исключение приведения. Ошибка: " + ice.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (ArgumentOutOfRangeException aoore)        //Исключение, которое выдается, если значение аргумента не соответствует допустимому диапазону значений, установленному вызванным методом.
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Исключение аргумента вне диапазона. Ошибка: " + aoore.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException fe)                       //Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно.
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Исключение формата. Ошибка: " + fe.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e)                              //все исключения
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Что то пошло не так. Ошибка: " + e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }               
            }
            Console.WriteLine("\tДо свидания!");
            Console.ReadKey();
        }
    }
}
