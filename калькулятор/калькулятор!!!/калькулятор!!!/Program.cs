using System.ComponentModel;

namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            while (number1 < 1)
            {
                Console.WriteLine("1. Сложить 2 числа\r\n" +
                    "2. Вычесть первое из второго\r\n" +
                    "3. Перемножить два числа\r\n" +
                    "4. Разделить первое на второе\r\n" +
                    "5. Возвести в степень N первое число\r\n" +
                    "6. Найти квадратный корень из числа\r\n" +
                    "7. Найти 1 процент от числа\r\n" +
                    "8. Найти факториал из числа\r\n" +
                    "9. Выйти из программы");
                Console.WriteLine("Выберите действие над числами");
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number2 == 9)
                {
                    number1 = 2;
                    break;
                }
                int b = 0;
                Console.WriteLine("Введите первое число");
                int a = Convert.ToInt32(Console.ReadLine());
                if (number2 <= 5)
                {
                    Console.WriteLine("Введите второе число(степень)");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                double d = 0;
                if (number2 == 1)
                {

                    d = a + b;

                }
                if (number2 == 2)
                {

                    d = b - a;

                }
                if (number2 == 3)
                {

                    d = b * a;

                }
                if (number2 == 4)
                {

                    d = a / b;

                }
                if (number2 == 5)
                {

                    d = (Math.Pow(a, b));

                }
                if (number2 == 6)
                {
                    d = (Math.Sqrt(a));
                }
                if (number2 == 7)
                {
                    d = a / 100;
                }
                if (number2 == 8)
                    
                {
                    int i = 1;
                    int l = 1;

                    for (; i <= a; ++i)
                    {
                        l = l * i;

                        d = l;
                    }
                }
                Console.WriteLine(d);
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}