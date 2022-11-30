//  Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

int FindDegree (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result*a;
    }
    return result;
}
Console.WriteLine("введите число a");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int number2 = Convert.ToInt32(Console.ReadLine());
int fin = FindDegree(number1, number2);
Console.WriteLine(fin);
