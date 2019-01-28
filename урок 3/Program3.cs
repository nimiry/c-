using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 1.	а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.
2.	а) С клавиатуры вводятся числа, пока не будет введён 0 (кадое число в новой строке). 
       Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя.
*/




namespace ConsoleApplication4
{

    class Complex
    {

        double im;
        double re;

        // Конструктор без параметров.
        public Complex()
        {
            im = 0;
            re = 0;
        }

        // Конструктор, в котором задаем поля.    
        public Complex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public Complex Mines(Complex x)
        {
            Complex y = new Complex();
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y = new Complex();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public double Im
        {
            get { return im; }
            set
            {
                im = value;
            }
        }
        public double Re
        {
            get { return re; }
            set
            {
                re = value;
            }
        }
        // Специальный метод, который возвращает строковое представление данных.
        public string TString()
        {
            if (im >= 0)
            {
                return re + "+" + im + "i";
            }
            else
            {
                return re + "" + im + "i";
            }
        }
    }


    class Program
    {


        /*                      структура комплексных чисел
        struct Complex
        {
            public double im;
            public double re;

            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }

            public Complex Mines(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public string TString()
            {
                // return Convert.ToString(re) + "+" + Convert.ToString(im) + "i";
                if (im >= 0)
                {
                    return re + "+" + im + "i";
                }
                else {
                    return re +""+ im + "i";
                }
            }
        }
        */

static double GetValue()
        {
            double x = 0;
            bool flag = false;

            do
            {
                Console.WriteLine("Введите число");
                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    flag = true;
                }
                catch
                {
                    //сюда действия если конверт не удался
                }
            }
            while (!flag);
            return x;
        }
        static int GetValueI()
        {
            int x = 0;
            bool flag = false;

            do
            {
                Console.WriteLine("Введите число");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    flag = true;
                }
                catch
                {
                    //сюда действия если конверт не удался
                }
            }
            while (!flag);
            return x;
        }

        static int recur()            // задание 2
        {
            int r = GetValueI();
            int dop = 0;
            if (r==0)
            {
                return r;
            }
            else
            {
                dop = recur();
                if ((r > 0) && (r % 2 == 1))
                {
                    Console.Write("{0} ", r);
                    return dop + r;
                }
                else
                {
                    return dop;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ввод чисел");
            Complex a1 = new Complex(GetValue(), GetValue()); 
            Complex a2 = new Complex(GetValue(), GetValue());
            Complex res;

            Console.WriteLine("Выберете операцию над числами:\n1 - сложение\n2 - вычетание\n3 - умножение.");

            int a = 0;
            while (!((a > 0) && (a < 4)))
            {
                a = GetValueI();
            }
            Console.WriteLine("тут");

            switch (a)
            {
                case 1:
                    res = a1.Plus(a2);
                    Console.WriteLine(res.TString());
                    break;
                    
                case 2:
                    res = a1.Mines(a2);
                    Console.WriteLine(res.TString());
                    break;
                    
                case 3:
                    res = a1.Multi(a2);
                    Console.WriteLine(res.TString());
                    break;
                    
                default:
                    //   что- то можно сделатьб но сейчас не нужно
                    break;
            }

            /*
                     реализация для структуры комплексных чисел
                     Complex a1;
                     Complex a2;
                     Complex res;

                     a1.re = GetValue();
                     a1.im = GetValue();

                     a2.re = GetValue();
                     a2.im = GetValue();

                     res = a1.Mines(a2);
                     Console.WriteLine(res.TString());
                     
                     */

            Console.WriteLine("Задание 2\nВводите числа. Для остановки введите 0");
            int sum = recur();
            Console.WriteLine();   //  для отделения суммы от чисел
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}

