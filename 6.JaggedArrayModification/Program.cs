/*
3
1 2 3
4 5 6 7
8 9 10
Add 0 0 5
Subtract 1 2 2
Subtract 1 4 7
END

4
1 2 3 4
5
8 7 6 5
4 3 2 1
Add 4 4 100
Add 3 3 100
Subtract -1 -1 42
Subtract 0 0 42
END

*/

int rows = int.Parse(Console.ReadLine());
int[][] jaggedArr = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] value = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    jaggedArr[row] = value;
}

string command;

while ((command = Console.ReadLine().ToLower()) != "end")
{
    string[] tokkens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string action = tokkens[0];

    int row = int.Parse(tokkens[1]);
    int col = int.Parse(tokkens[2]);
    int value = int.Parse(tokkens[3]);

    if (row < 0 || row >= rows || col < 0 || col >= jaggedArr[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }
    switch (action) 
    {
        case "add":
            jaggedArr[row][col] += value;
            break;
        case "subtract":
            jaggedArr[row][col] -= value;
            break;
        default:
            break;
    }

}

foreach (var row in jaggedArr)
{
    Console.WriteLine(string.Join(" ", row));
}
