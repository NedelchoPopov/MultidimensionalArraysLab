/* 
3
11 2 4
4 5 6
10 8 -12 

3
1 2 3
4 5 6
7 8 9

*/

int sizeSquare = int.Parse(Console.ReadLine());

int[,] matrix = new int[sizeSquare, sizeSquare];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
    }
}

int sum = 0;
int rows = 0;
    for (int col = 0;col < matrix.GetLength(0); col++)
    {
        sum += matrix[col, rows];
        rows++;
    }
    Console.WriteLine(sum);
    

