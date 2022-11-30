// //Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// и выводит его н аэкран
// в нашем примере отрезок от 0 до 100 
void FillArray (int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,100);
        Console.WriteLine($"{array[i]}");
    }
}
FillArray(8);
