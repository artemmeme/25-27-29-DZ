//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Напишите само число");
int num0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите степень возведения");
int num1 = Convert.ToInt32(Console.ReadLine());
int i = 0;
int num2 = 1;
Vosvedenie(num2);
void Vosvedenie(int num2)
{
    while (i < num1)
    {
        num2 = num2 * num0;
        i++;
    }
    Console.WriteLine($"Число {num0} возвели в степень {num1}, получили {num2}");
}



