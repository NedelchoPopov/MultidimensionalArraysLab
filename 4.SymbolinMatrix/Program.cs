/*
3
ABC
DEF
X!@
!

4
asdd
xczc
qwee
qefw
4

*/


int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] input = Console.ReadLine().ToCharArray();
    

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

char charToFind = char.Parse(Console.ReadLine());

bool isFind = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    


    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == charToFind)
        {
            Console.WriteLine($"({row}, {col})");
            isFind = true;
            break;
        }
    }
    if (isFind)
    {
        return;
    }
}
Console.WriteLine($"{charToFind} does not occur in the matrix");




