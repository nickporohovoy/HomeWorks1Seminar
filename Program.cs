// ДОМАШНЯЯ РАБОТАДОМАШНЯЯ РАБОТАДОМАШНЯЯ РАБОТАДОМАШНЯЯ РАБОТАДОМАШНЯЯ РАБОТА

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.WriteLine($"{num1} Большее, {num2} Меньшее.");
// }
// else
// {
//     Console.WriteLine($"{num2} Большее, {num1} Меньшее.");
// }
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Задача выполняет условия!

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input therty number");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
//     if(num1 > num3)
//     {
//         Console.WriteLine($"{num1}"); 
//     }
//     else
//     {
//         Console.WriteLine($"{num3}");
//     }
// else
//     if(num2 > num3)
//     {
//         Console.WriteLine($"{num2}");
//     }
//     else
//     {
//         Console.WriteLine($"{num3}");
//     }
    // 2, 3, 7 -> 7
    // 44 5 78 -> 78
    // 22 3 9 -> 22
    // Задача выполняет условия!

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("input number");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if((num1%2)==0)
// {
//     Console.WriteLine($"{num1} Чётное");
// }
// else
// {
//     Console.WriteLine($"{num1} Нечётное");
// }
    // 4 -> да
    // -3 -> нет
    // 7 -> нет
    // Задача выполняет условия!

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("input number");
int n = Convert.ToInt32(Console.ReadLine());
if(n<0) Console.WriteLine("inval");
int count = (n*0)+1;
while(count <= n)
{
    Console.Write(count+" ");
    count++;
}
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Задача вывыодит все положительные числа от 1 до N.

// Не знаю куда вставить "%2 == 0" ???!!! Чтобы выводила только четные числа.
// while(count <= n)        //Если тут то бесконечно ставит двойки через пробел
//     if(count%2==0)       //Если тут то зависает
//     {
//         Console.Write(count+" ");
//         count++;
//     }

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Задача вывыодит все положительные числа от 1 до N.