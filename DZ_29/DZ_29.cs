//Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
int[] massive(int length)
{
    int[] massive = new int[length];
    Console.WriteLine("Напишите числа массива через Enter");
    for (int i = 0; i < length; i++)
    {
        massive[i] = Convert.ToInt32(Console.ReadLine()); ;
    }
    return massive;
}
int length = 8;
int[] array = massive(length);
for (int i = 0; i < length; i++)
{
    Console.Write($"{array[i]} ");
}