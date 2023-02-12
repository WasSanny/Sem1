bool isWork = true;

while(isWork)
{
  // Console.Write("Введите номер задачи: ");
  // if (int.TryParse(Console.ReadLine(), out int i))
  
  //   switch(i)
  //   {
  //     case 1:
  //     {
        // Задача. Программа, которая на вход принимает число N, а выводит множество от -N до N
        int.TryParse(Console.ReadLine(), out int number); // вводим число

        var negativN = number * (-1); // умножаем на (-1)

        while (negativN <= number)
        {
          Console.Write(negativN + " ");
          negativN++;
        }
      // }
      // case 2:
      // {
          ///////////////////
          // Задача 2

        int.TryParse(Console.ReadLine(), out int N);

        Console.WriteLine(N % 10);
//       }
//     }
// }
 
