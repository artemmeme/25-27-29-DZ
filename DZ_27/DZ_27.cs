//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
Console.WriteLine("Напишите целое число");
int num0 = Convert.ToInt32(Console.ReadLine());
int numi = 1;
int num = 0;
int sum = 0;
int count = 0;
int i = 0;
int j = 10;
int k = 1;
int h = 10;
Count(count); //Вызываем функцию подсчета количества чисел, чтобы понимать когда остановить цикл
void Count(int i)
{
    while (numi > 0)
    {
        numi = num0 / h;
        count = count + 1;
        h = h * 10;
    }
    Console.WriteLine($"количество чисел = {count}");
}
Sum(sum); //Вызываем функцию для суммирования цифр в числе
void Sum(int sum)
{
    while (i < count + 1)
    {
        sum = sum + num;
        num = num0 % j / k;
        k = k * 10;
        j = j * 10;
        i++;
    }
    Console.WriteLine($"Сумма этих чисел = {sum}");
}

