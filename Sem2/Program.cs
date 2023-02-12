// Задача. Программа, которая на вход принимает число N, а выводит множество от -N до N
int.TryParse(Console.ReadLine(), out int number); // вводим число

var negativN = number * (-1); // умножаем на (-1)

while (negativN <= number)
{
  Console.Write(negativN + " ");
  negativN++;
}

