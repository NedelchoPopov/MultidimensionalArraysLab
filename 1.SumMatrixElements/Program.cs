/*
3, 6
7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0

*/


int[] dimentionSize = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimentionSize[0];
int columns = dimentionSize[1];

int[,] matrix = new int[rows, columns];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine()
        .Split(", ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        matrix[row, column] = numbers[column]; 
    }
}

int sum = 0;
foreach (var item in matrix)
{
    sum += item;
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);
