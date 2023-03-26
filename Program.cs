//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
int[] elementsToMatrix = ArreyElements();
int[,] createMatrix = CreateMatrix(elementsToMatrix);
PrintMatrix(createMatrix);
int[,] CreateMatrix(int[] array)
{
    int[,] matrix = new int[4, 4];
    {
        var x = 0;
        var constI = 0;
        var constJ = 0;
        var maxI = matrix.GetLength(0);
        var maxJ = matrix.GetLength(1);
        var minI = 0;
        var minJ = 0;
        for (int m = 0; m < array.Length; m++)
        {
            for (int j = constJ; j < maxJ - 1; j++)
            {
                if (matrix[constI, j] == 0)
                {
                    matrix[constI, j] = array[x];
                    x++;
                    constJ++;
                }
            }
            maxJ--;
            for (int i = constI; i < maxI - 1; i++)
            {
                if (matrix[i, constJ] == 0)
                {
                matrix[i, constJ] = array[x];
                x++;
                constI++;
                }
                    
            }
            maxI--;
            for (int k = maxJ; k > minJ; k--)
            {
                if (matrix[constI, k] == 0)
                {
                    matrix[constI, k] = array[x];
                    x++;
                    constJ--;
                }
            }
            minJ++;
            for (int l = maxI; l > minI; l--)
            {
                if (matrix[l, constJ] == 0)
                {
                    matrix[l, constJ] = array[x];
                    x++;
                    constI--;
                }
            }
            minI++;
            constI++;
            constJ++;
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write($"0{matrix[i, j]}, ");
            }
            else
            {
                Console.Write($"{matrix[i, j]}, ");
            }
        }
        if (matrix[i, matrix.GetLength(1) - 1] < 10)
        {
            Console.WriteLine($"0{matrix[i, matrix.GetLength(1) - 1]} |");
        }
        else
        {
            Console.WriteLine($"{matrix[i, matrix.GetLength(1) - 1]} |");
        }
    }
}
int[] ArreyElements()
{
    int[] arrey = new int[16];
    for (int i = 0; i < 16; i++)
    {
        arrey[i] = i + 1;
    }
    return arrey;
}