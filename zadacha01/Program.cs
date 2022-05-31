//Показать двумерный массив размером m×n заполненный вещественными числами
Console.Clear();
Console.Write("Введите кол-во строк двумерного массива:");
int m = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите кол-во столбцов двухмерного массива:");
int n = int.Parse(Console.ReadLine()?? "0");
int[,]array = new int[m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(-10,10);
        Console.Write($" {array[i, j] }");
    }
    Console.WriteLine();
}