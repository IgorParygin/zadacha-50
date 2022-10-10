// Задача 50: Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArray(array);

WriteArray(array);

Console.WriteLine();

void CreateArray(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double Number = Math.Round(array[i, j], 1);
        Console.Write(Number + " ");
      }
      Console.WriteLine();
  }
}
Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

string? coordinates = Console.ReadLine();
int[] position = CoordinateNumbers(coordinates);

if(position[0] <= m && position[1] <= n && position[0] >= 0 && position[1] >= 0) 
{
  double result = array[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write($"такого элемента в массиве нет.");

int[] CoordinateNumbers(string input)
{
  int count = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          count++;
  }

  int[] numbers = new int[count];

  int index = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[index] = Convert.ToInt32(subString);
    index++;
  }

  return numbers;
}

