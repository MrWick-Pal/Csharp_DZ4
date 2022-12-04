// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void FillArray(int [] array)
{
    int i = 0;
    while (i < 8)
    {
        array[i] = new Random().Next(0, 101);
        i++;
    }
}
void PrintArray(int [] col)
{
    int pos = 0;
    while(pos < 8)
    {
        Console.Write($"{col[pos]}, ");
        pos++;
    }
}
int [] array = new int[8];
FillArray(array);
PrintArray(array);