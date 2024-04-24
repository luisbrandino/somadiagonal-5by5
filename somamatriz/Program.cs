int rows = 3;
int columns = 3;

int[,] matrixA = new int[rows, columns];

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        matrixA[i, j] = new Random().Next(0, 10);

Console.WriteLine("Matriz A:\n");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write($"{matrixA[i, j]} ");

    Console.WriteLine();
}

Console.WriteLine("\nLINHAS:\n");

int sum;

for (int i = 0; i < rows; i++)
{
    sum = 0;

    for (int j = 0; j < columns; j++)
        sum += matrixA[i, j];

    Console.WriteLine($"Soma na {i + 1}ª linha: {sum}\n");
}

Console.WriteLine("COLUNAS:\n");

for (int i = 0; i < columns; i++)
{
    sum = 0;

    for (int j = 0; j < rows; j++)
        sum += matrixA[j, i];

    Console.WriteLine($"Soma na {i + 1}ª coluna: {sum}\n");
}

if (rows != columns)
    Environment.Exit(0);

sum = 0;

for (int i = 0; i < rows; i++)
    sum += matrixA[i, i];

Console.WriteLine($"DIAGONAL (esquerda para direita): {sum}\n");

sum = 0;

for (int i = 0; i < rows; i++)
    sum += matrixA[i, (rows - 1) - i];

Console.WriteLine($"DIAGONAL (direita para esquerda): {sum}\n");