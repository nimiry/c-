//Процюк

/*
1.	Написать метод, возвращающий минимальное из трёх чисел.
2.	Написать метод подсчета количества цифр числа.
3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.
4.	Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь,
    если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, 
    написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    С помощью цикла do while ограничить ввод пароля тремя попытками.
5.	а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
    набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
6.	*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
    «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы,
    используя структуру DateTime.
7.	a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.


*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void WW (string text, int x, int y)
        {
            Console.SetCursorPosition(x,y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static bool Login()               //задание 4
        {
            string log = ""; 
            string pas = "";
            for (int i = 0; i < 3; i++)
            {
                Console.Write("ВВедите логин:\n> ");
                log = Console.ReadLine();
                Console.Write("ВВедите пароль:\n> ");
                pas = Console.ReadLine();
                Console.Clear();
                if (log == "root")
                    if (pas == "GeekBrains")
                        return true;
            }
            return false;
        }

        static double Minimal3 (double a1, double a2, double a3) //задание 1
        {
            if (a1 > a2)
                if (a2 > a3)
                    return a3;
                else return a2;
            else
                if (a1 > a3)
                return a3;
            return a1;
        }

        static int KolC (int a)                             // задание 2
        {
            int kol = 0;
            if (a == 0) return 1;
            while (a != 0)
            {
                kol += 1;
                a = a / 10;
            }
            return kol;
        }

        static int SumC(int a)                              //для задания 6
        {
            int sum = 0;
            while (a != 0)
            {
                sum = sum + a % 10;
                a = a / 10;
            }
            return sum;
        }

        static int GoodCh()                                 //для задания 6
        {
            int kol = 0;
            double dop = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                dop = (double)i / SumC(i);
                if (dop % 1 == 0)
                {
                    kol += 1;
                }
            }
            Console.WriteLine(kol);
            return kol;
        }


        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;                                          //задание 6
            GoodCh();
            DateTime finish = DateTime.Now;

            Console.WriteLine(finish - start);

            if (Login())                                                             //задание 4
            {
                Console.Write("Введите а\n>");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b\n>");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c\n>");
                double c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Minimal3(a, b, c));                   // вывод задание 1

                Console.Write("Введите число\n>");
                int ch = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(KolC(ch));                            // вывод задание 2

                int dop = 1;                                //задание 3
                ch = 0;
                while (dop != 0)
                {
                    Console.Write("Введите чило\n>");
                    dop = Convert.ToInt32(Console.ReadLine());
                    if (dop % 2 == 0)
                        ch = ch + dop;
                }

                Console.WriteLine(ch);                                   // вывод задания 3
            }
            Console.WriteLine("Для выхода нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
