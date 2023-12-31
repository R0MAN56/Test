// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// int num = 322;
// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine($"a={num}\t=> да");
// }
// else
// {
//     Console.WriteLine($"a={num}\t=> нет");
// }


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// int x = 4;
// int y = -2;
// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"{x},\t{y}\t=>\t1");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine($"{x},\t{y}\t=>\t2");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine($"{x},\t{y}\t=>\t3");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine($"{x},\t{y}\t=>\t4");
// }


// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int num = new Random().Next(10, 100);
// int digit1 = num / 10;
// int digit2 = num % 10;
// if (digit1 > digit2)
// {
//     Console.WriteLine($"{num}\t=> {digit1}");
// }
// else
// {
//     Console.WriteLine($"{num}\t=> {digit2}");
// }


// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// int num = 9542;
// int i = 1;
// int digit;
// while (num / i >= 10)
// {
//     i *= 10;
// }
// Console.Write($"{num}\t=> ");
// Console.Write(num / i);
// num %= i;
// i /= 10;
// while (i > 0)
// {
//     digit = num / i;
//     Console.Write("," + digit);
//     num %= i;
//     i /= 10;
// }