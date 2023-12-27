// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// // тип_данных имяПеременной = значение;
// // camelCase: firstNumber, secondNumber, thirdNumber
// Convert.ToInt32("123") => 123(int)
// Console.ReadLine() - получение информации из консоли

// Console.Write("Введите 1 число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите 2 число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// // "==" - проверка на равенство: 5 == 5 (true), 4 == 5 (false)
// if (firstNumber == secondNumber * secondNumber)
// // firstNumber = 25, secondNumber = 5
// // Является ли первое число квадратом второго?
// {
// // "Привет" + "мир" = "Приветмир" (конкатенация)
// Console.WriteLine("Да, " + firstNumber + " является квадратом от " + secondNumber);
// }
// else // Первое число не является квадратом от второго
// {
// Console.WriteLine("НЕТ, " + firstNumber + " НЕ является квадратом от " + secondNumber);
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int negativeN = -N; // negativeN = -N

// while (negativeN <= N)
// {
// Console.Write(negativeN + "\t");
// // "\t" = 4 пробела или Таб между элементами
// negativeN++;
// // "negativeN++": negativeN = negativeN + 1 (инкремент)
// // "negativeN--": negativeN = negativeN - 1 (декремент)
// }

// е от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N < 0)
// {
// N *= -1; // N = N * -1
// // a = a * 500; a *= 500
// }

// int negativeN = -N; // negativeN = -N

// while (negativeN <= N)
// {
// Console.Write(negativeN + "\t");
// // "\t" = 4 пробела или Таб между элементами
// negativeN++;
// // "negativeN++": negativeN = negativeN + 1 (инкремент)
// // "negativeN--": negativeN = negativeN - 1 (декремент)
// }

// // Получить 3 цифру с левого края
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100)
// {
// while (number > 999)
// {
// number /= 10;
// }
// // 123 => 3
// Console.WriteLine(number % 10);
// }
// else
// {
// Console.WriteLine("Вы ввели не трехзнач. число");
// }



// Комментарий 

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных имяПеременной = значение;
// camelCase: firstNumber, secondNumber, thirdNumber
// Convert.ToInt32("123") => 123(int)
// Console.ReadLine() -  получение информации из консоли
// Console.Write("Введите 1 число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите 2 число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// // "==" - проверка на равенство: 5 == 5 (true), 4 == 5 (false)
// if (firstNumber == secondNumber * secondNumber)
// // firstNumber = 25, secondNumber = 5
// // Является ли первое число квадратом второго?
// {
//     // "Привет" + "мир" = "Приветмир" (конкатенация)
//     Console.WriteLine("Да, " + firstNumber + " является квадратом от " + secondNumber);
// }
// else // Первое число не является квадратом от второго 
// {
//     Console.WriteLine("НЕТ, " + firstNumber + " НЕ является квадратом от " + secondNumber);
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N < 0)
// {
//     N *= -1; // N = N * -1
//     // a = a * 500; a *= 500
// }

// int negativeN = -N; // negativeN = -N

// while (negativeN <= N)
// {
//     Console.Write(negativeN + "\t");
//     // "\t" = 4 пробела или Таб между элементами
//     negativeN++;
//     // "negativeN++": negativeN = negativeN + 1 (инкремент)
//     // "negativeN--": negativeN = negativeN - 1 (декремент)
// }

// Получить 3 цифру с левого края
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100) 
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     // 123 => 3
//     Console.WriteLine(number % 10);
// }
// else
// {
//    Console.WriteLine("Вы ввели некорректное значение");
// }

// Введенные числа равны `3`
// int a = 3;
// // // Буква ё на англ. раскладке
// Console.WriteLine("Введенные числа равны " + "`" + a + "`");

// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// // "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)
// if (number >= 100 && number <= 999)
// {
//     int firstDigit = number / 100; // 275 / 100 = 2
//     int thirdDigit = number % 10; // 275 % 10 = 5
//     int result = firstDigit * 10 + thirdDigit;// 2 * 10+ 5 = 25
//     //$"Текст {firstDigit} текст {firstDigit * 10 + thirdDigit}"
//     Console.WriteLine($"Результат: {number} => {result}");
// }
// else
// {
//     Console.WriteLine("Число не трехзначное ИЛИ отрц.");
// }

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// // "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)
// if (number >= 100 && number <= 999)
// {
//     int secondDigit = number / 10 % 10;
//     // 275 / 10 % 10 = 27 % 10 = 7
//     int thirdDigit = number % 10; // 275 % 10 = 5
//     // Возвести число 7 в 5 степень
//     // Math.Pow(2, 3) => 2 в 3 степени: 2 * 2 * 2 = 8
//     int result = (int)Math.Pow(secondDigit, thirdDigit);
//     Console.WriteLine($"{number} : {secondDigit} ^ {thirdDigit} = {result}");
// }
// else
// {
//     Console.WriteLine("Число не трехзначное ИЛИ отрц.");
// }

// double a = Math.Round(2.1234, 2);
// System.Console.WriteLine(a);

// Получить 3 цифру с начала (слева) введенного числа
// 12345678 -> 3
// 78671 -> 6
// 12 - 3 цифры нет
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;

// if (number < 100)
// {
//     Console.WriteLine("Число не трехзначное ИЛИ отрц.");
// }

// else // В числе >= 3 знака
// {   
//     while (number > 999) // В числе 4 знака
//     {
//         number /= 10; // number = number / 10
//         // a = a + 500 (a += 500)
//         // a = a * 30 (a *= 30)
//     }
//     Console.WriteLine($"Третья цифра от числа {copyNumber} = {number % 10}");
// }

// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;

// if (number < 100)
// {
//     Console.WriteLine("Число не трехзначное ИЛИ отрц.");
// }

// else // В числе >= 3 знака
// {   
//     Console.WriteLine($"Третья цифра от {copyNumber} (справа) =  {number / 100 % 10}");
// }
// int a = 100;
// int b = 30;
// if (a % b == 0) // Число а делится БЕЗ остатка
// {
//     Console.WriteLine("Число а делится БЕЗ остатка");
// }
// else // Число делится с остатком 
// {
//     Console.WriteLine($"{a} / {b} = {a % b}");
// }



// Домашнее задание

// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Ввод числа с клавиатуры
//         Console.Write("Введите число: ");
//         int inputNumber = int.Parse(Console.ReadLine());

//         // Проверка кратности 7 и 23
//         if (IsMultipleOf7And23(inputNumber))
//         {
//             Console.WriteLine($"{inputNumber} кратно и 7, и 23.");
//         }
//         else
//         {
//             Console.WriteLine($"{inputNumber} не кратно одновременно 7 и 23.");
//         }
//     }

//     static bool IsMultipleOf7And23(int number)
//     {
//         return number % 7 == 0 && number % 23 == 0;
//     }
// }

// // Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Ввод координат точки
//         Console.Write("Введите координату X: ");
//         double x = double.Parse(Console.ReadLine());

//         Console.Write("Введите координату Y: ");
//         double y = double.Parse(Console.ReadLine());

//         // Определение номера координатной четверти
//         int quadrant = GetQuadrant(x, y);

//         // Вывод результата
//         Console.WriteLine($"Точка с координатами ({x}, {y}) находится в {quadrant} четверти.");
//     }

//     static int GetQuadrant(double x, double y)
//     {
//         if (x > 0 && y > 0)
//         {
//             return 1;
//         }
//         else if (x < 0 && y > 0)
//         {
//             return 2;
//         }
//         else if (x < 0 && y < 0)
//         {
//             return 3;
//         }
//         else if (x > 0 && y < 0)
//         {
//             return 4;
//         }
//         else
//         {
//             // Если точка лежит на осях координат
//             Console.WriteLine("Точка лежит на координатных осях.");
//             return 0;
//         }
//     }
// }


// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Ввод целого числа из отрезка [10, 99]
//         Console.Write("Введите целое число от 10 до 99: ");
//         int number = int.Parse(Console.ReadLine());

//         // Проверка, что число находится в допустимом диапазоне
//         if (number >= 10 && number <= 99)
//         {
//             // Нахождение наибольшей цифры
//             int maxDigit = GetMaxDigit(number);

//             // Вывод результата
//             Console.WriteLine($"Наибольшая цифра числа {number} : {maxDigit}");
//         }
//         else
//         {
//             Console.WriteLine("Число не находится в допустимом диапазоне.");
//         }
//     }

//     static int GetMaxDigit(int number)
//     {
//         // Получение десятков и единиц
//         int tens = number / 10;
//         int units = number % 10;

//         // Возвращение наибольшей цифры
//         return Math.Max(tens, units);
//     }
// }


// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

using System;

class Program
{
    static void Main()
    {
        // Ввод натурального числа N
        Console.Write("Введите натуральное число N: ");
        int n = int.Parse(Console.ReadLine());

        // Проверка, что число является натуральным
        if (n > 0)
        {
            // Вывод цифр числа через запятую
            Console.WriteLine($"Цифры числа {n} через запятую: {GetDigitsSeparatedByComma(n)}");
        }
        else
        {
            Console.WriteLine("Введите корректное натуральное число.");
        }
    }

    static string GetDigitsSeparatedByComma(int number)
    {
        // Преобразование числа в строку
        string numberString = number.ToString();

        // Проход по каждой цифре числа и формирование строки с запятой
        string result = string.Join(", ", numberString.ToCharArray());

        return result;
    }
}
