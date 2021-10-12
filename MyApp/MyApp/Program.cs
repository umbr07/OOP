using System;
using System.Reflection;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int ip = -10;
            int j = 20;
            Console.WriteLine("int = {0}+{1}={2}", ip, j, ip + j);
            bool check = true;
            Console.WriteLine($"bool:{check}");
            byte s = 255;
            Console.WriteLine($"byte{s}");
            sbyte a = 127;
            char b = 'p';
            float fl = 5;
            double db = 2.3;
            uint ui = 100;
            decimal dc = 200;
            long ln = -5555;
            ulong uln = 5000;
            short sh = -30;
            ushort ush = 30;
            object ob = 's';
            Console.WriteLine($"\nsbyte: {a}\nchar - {b}\nfloat {fl}\ndouble {db}\nuint {ui}\ndecimal {dc}\nlong {ln}\nulong {uln}\nshort {sh}\nushort {ush}\n");

            //Работа с методом Convert
            Console.Write("Введите bit1: ");
            byte bit1 = Convert.ToByte(Console.ReadLine());

            Console.Write("Введите sbit1: ");
            sbyte bit2 = Convert.ToSByte(Console.ReadLine());

            Console.Write("Введите i1: ");
            int i1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите d1: ");
            double d1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n Тип данных byte: {bit1} \n" +  
                              $"Тип данных sbyte: {bit2}\n" + 
                              $"Тип данных int: {i1}\n" +
                              $"Тип данных double: {d1}\n");

            //Неявное и явное преобразование
            byte aa = 4;
            ushort bb = aa;
            sbyte a1 = 4;
            short b1 = a1;
            int g = 34;
            float f = g;

            int a2 = 4;
            int b2 = 6;
            byte c = (byte)(a2 + b2);
            double a3 = 4.0;
            decimal b3 = (decimal)a3;
            double d4 = 34.5;
            int i4 = (int)d4;
            float f3 = (float)d4;

            Console.WriteLine(
                $"\n -----------Неявное преобразование-----------\n" +
                $"Преобразование в unshort: {b} \n" +
                $"Преобразование в short: {b1} \n" +
                $"Преобразование в float: {f} \n" +
                $"\n -----------Явное преобразование-----------\n" +
                $"Преобразование в byte: {c} \n" +
                $"Преобразование в decimal: {b3} \n" +
                $"Преобразование в int: {i4} \n" +
                $"Преобразование в float: {f3} \n");

            //Упаковка и распаковка значимых типов
            int i5 = 54;
            object o = i5;

            int i6 = 234;
            object o1 = i6;
            int jj = (int)o1;

            //Работа с неявно типизированной переменной
            var untp = "vot eto da";
            dynamic untps = 90;
            untps = "a teper stroka";

            //Работа с Nullable переменной
            int? z1 = 5;
            bool? enabled1 = null;
            Double? d7 = 3.3;

            Nullable<int> z2 = 5;
            Nullable<bool> enabled2 = null;
            Nullable<System.Double> d3 = 3.3;

            //Строки
            //Объявление строковых литералов и сравнение их
            string str1 = "Hello World";
            string str2 = "Hi";
            string str3 = "Word";
            string str4 = str3;

            Console.WriteLine(str1 == str2 + "/n");
            Console.WriteLine(str1 + str3 + "/n");
            Console.WriteLine($"Копирование строк: {str4} \n");

            int startIndex = 5;
            int length = 6;
            string substring = str1.Substring(startIndex, length);
            Console.WriteLine($"Извлекаем подстроку из строки: {substring} \n");

            string str6 = "You win, it's good";
            string[] subs = str6.Split(' ');
            foreach (var sub in subs)
            {
                Console.WriteLine($"Разделение строки на слова: {sub} \n");
            }

            string str7 = "Hello World,it's good";
            string str8 = " day";
            string str9 = str7.Insert(21, str8);
            Console.WriteLine($"Вставка подстроки в заданную позицию: {str9} \n");

            //Удаление подстроки из строки ДОДЕЛАТЬ через remove!!!!!!!!!!!

            //Создайте пустую и null строку.Работа с методом string.IsNullOrEnpty ДОДЕЛАТЬ!!!!!!!!!!!!
            string str11 = "";
            string str12 = null;

            Console.WriteLine(string.IsNullOrEmpty(str11));
            Console.WriteLine(string.IsNullOrEmpty(str12));

            string op = str11 ?? str12;


            //Создание строки с помощью StringBuilder
            StringBuilder sb = new StringBuilder("Привет всем!");
            sb.Remove(0, 2);
            sb.Insert(0, "Ии");
            sb.Insert((sb.Length), " Пока всем");
            Console.WriteLine($"Работа со StringBuilder: {sb} \n");

            //Создание и вывод отформатированного двумерного массива
            int[,] Array = { { 3, 2, 1 }, { 6, 5, 4 } };
            Console.WriteLine("\nМатрица:");
            for (int v = 0; v < 2; v++)
            {
                for (int w = 0; w < 3; w++)
                {
                    Console.Write(Array[v, w] + " ");
                }
                Console.WriteLine();
            }

            //Работа с одномерным массивом
            string[] newArray = new string[3];
            newArray[0] = "раз";
            newArray[1] = "два";
            newArray[2] = "три";

            for (int iw = 0; iw < 3; iw++)
            {
                Console.Write($"\n{newArray[iw]}");
            }
            Console.WriteLine($"\nДлинна массива:{newArray.Length}");

            int en;
            while (true)
            {
                Console.WriteLine("Введите позицию для замены");
                en = int.Parse(Console.ReadLine());
                if (en == 1 || en == 2 || en == 3)
                {
                    break;
                }
            }
            Console.WriteLine("Введите строку ");
            string st = Console.ReadLine();
            newArray[en - 1] = st;
            for (int we = 0; we < 3; we++)
            {
                Console.WriteLine(newArray[we]);
            }

            //Создайте ступечатый (не выровненный) массив вещественных чисел с 3 - мя строками
            //В каждой из которых 2, 3 и 4 столбцов соответственно.Значения массива введите с консоли
            int[][] myArray = new int[3][];
            myArray[0] = new int[2];
            myArray[1] = new int[3];
            myArray[2] = new int[4];

            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < myArray[m].Length; n++)
                {
                    Console.WriteLine($"Введите значение {m}");
                    myArray[m][n] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Значения массива");
            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < myArray[m].Length; n++)
                {
                    Console.Write(myArray[m][n] + " ");
                }
                Console.WriteLine();
            }

            //Создайте неявно типизированные переменные для хранения массива и строки.
            var Arr = myArray;
            var strokaArr = newArray;

            //Работа с Кортежами
            var cort = (good: 11, yes: "Tom", going: 'S', slaime: "Jerry", year: 19433);
            Console.WriteLine($"Кортеж весь целиком: {cort} \n");
            Console.WriteLine($"Выборочно первый элемент: {cort.Item1} \n");
            Console.WriteLine($"Выборочно пятый элемент: {cort.Item5} \n");
            var good = cort.good;
            var yes = cort.yes;
            var going = cort.going;
            var slaime = cort.slaime;
            var year = cort.year;
            var corti = (good: 11, yes: "Tom", going: 'S', slaime: "Jerry", year: 19433);
            Console.WriteLine($"Сравниваем:{Tuple.Equals(cort,corti)} \n");
        }
    }
}
