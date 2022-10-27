/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();
int[,] generateTwodimensionalArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twodimensionalArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twodimensionalArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twodimensionalArray;
}

void print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write((arrayToPrint[i, j]) + "\t");
        }
        Console.WriteLine();
    }
}

int findMinSumInArray(int[,] inputArray)
{
    int minSum = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            minSum += inputArray[i, j];

        }
    }
    int result = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum += inputArray[i, j];
        }
        Console.WriteLine($"Сумма строки {i+1} = {sum} ");
        if (sum < minSum)
        {
            minSum = sum;
            result = i + 1;
        }
    }
    return result;
}


int[,] generateArray = generateTwodimensionalArray(5, 5, 1, 9);
print2DArray(generateArray);
int result = findMinSumInArray(generateArray);
Console.WriteLine($"Строка с наименьшей суммой элементов это - {result} ");