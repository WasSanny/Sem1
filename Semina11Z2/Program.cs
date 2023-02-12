// Написать программу, которая на вход принимает 2 числа, и проверяет, является ли первое число квадратом второго?

// int numberA = 25;
// int numberB = 5; // определяем переменные
// Console.WriteLine("numberA, numberB");
// Console.WriteLine(numberB * numberB);

// if (numberB * numberB == numberA)
// {
//   Console.WriteLine("Да!");
// }
// else
// {
//   Console.WriteLine("Нет!");
//}
// Конец решения зачдачи 1

//////////////////////////////////////////////////

// //Первый вариант решения задачи 2 поиска дня недели по номеру

// string[] days = new String[]{"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
// Console.Write("Введите номер дня недели:");
// int day = int.Parse(Console.ReadLine());
// Console.WriteLine(days[day - 1]);


//Второй вариант решения задачи 2 поиска дня недели по номеру

// internal class Program
// {
//   private static void Main(string[] args)
//   {
//     int.TryParse(Console.ReadLine(), out int a);

//     if (a == 1) Console.WriteLine("Понедельник");
//     else if (a == 2) Console.WriteLine("Вторник");
//     else if (a == 3) Console.WriteLine("Среда");
//     else if (a == 4) Console.WriteLine("Четверг");
//     else if (a == 5) Console.WriteLine("Патница");
//     else if (a == 6) Console.WriteLine("Суббота");
//     else if (a == 7) Console.WriteLine("Воскресенье");

//     else
//     {
//       Console.WriteLine("Невеный ввод числа!!!");
//     }
//   }
// }
/////////////////////////////////////////////////////////////////////

//Третий вариант решения задачи 2 поиска дня недели по номеру
// с использованием конструкции Switch case

// Console.WriteLine("Введите номер дня недели: ");
// if (int.TryParse(Console.ReadLine(), out int a))
// {
//   switch(a)
//   {
//     case 1:
//       Console.WriteLine("Понедельник");
//       break;
//     case 2:
//       Console.WriteLine("Вторник");
//       break;
//     case 3:
//       Console.WriteLine("Среда");
//       break;
//     case 4:
//       Console.WriteLine("Четверг");
//       break;
//     case 5:
//       Console.WriteLine("Пятница");
//       break;
//     case 6:
//       Console.WriteLine("Суббота");
//       break;
//     case 7:
//       Console.WriteLine("Воскресенье");
//       break;
//     default:
//       Console.WriteLine("Нет такого дня недели!");
//       break;
//   }
// }


// Вариант решения задачи 1 и 2 с возможностью выбора задачи для решения

// bool isWork = true;

// while(isWork)
// {
//   Console.Write("Введите номер задачи: ");
//   if (int.TryParse(Console.ReadLine(), out int i))

//   switch(i)
//   {
//     case 1:
//     {
//       // Пишем код программы(задачи 1)
//     }
//     case 2:
//     {
//       // Пишем код программы(задачи 2)
//     }
//     case - 1: isWork = false; break;
//   }

// }