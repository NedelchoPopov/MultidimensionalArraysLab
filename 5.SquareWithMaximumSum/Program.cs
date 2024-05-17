/*
3, 6
7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0

2, 4
10, 11, 12, 13
14, 15, 16, 17

 */

int[] size = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


int[,] matrix = new int[size[0], size[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        matrix[row, column] = numbers[column];
    }
}
int maxSum = int.MinValue;
int numA = 0;
int numB = 0;
int numC = 0;
int numD = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        var newSquareSum = matrix[row, col] +
        matrix[row + 1, col] +
       matrix[row, col + 1] +
       matrix[row + 1, col + 1];
        if (newSquareSum > maxSum)
        {
            maxSum = newSquareSum;
            numA = matrix[row, col];
            numB = matrix[row + 1, col];
            numC = matrix[row, col + 1];
            numD = matrix[row + 1, col + 1];
        }
    }
}
Console.WriteLine($"{numA} {numC}");
Console.WriteLine($"{numB} {numD}");
Console.WriteLine(maxSum);