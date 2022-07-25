// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


namespace Task
{
    class Program
    {
        static void Main(string[]args)
        {
Console.Clear();
Console.WriteLine($"Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
int n = InputNumbers("Введите M: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
        }
    }
}