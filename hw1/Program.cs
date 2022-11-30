//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int CountSumDigit (int num)
{
    int sum = 0;
    while (num >= 1)
    {
        sum = sum + num % 10;
        num = num / 10;
        
    }

     return sum;

}
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CountSumDigit(number));
