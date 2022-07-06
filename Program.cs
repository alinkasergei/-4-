/*Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

/*Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum(int n)
{
    int count = Convert.ToString(n).Length;
    int result = 0;
  
    for (int i = 0; i < count; i++)
    {
        result = result + (n - (n - (n % 10)));
        n = n / 10;
    }
    return result;
}
int result = Sum(n);
System.Console.WriteLine("Sum of numbers " + result);*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]  */

/*
void FillArray(int[] Elements)
{
    int length = Elements.Length;
    int index = 0;

    while (index < length)
    {
        Elements[index] = new Random().Next(1, 8);
        index++;
    }
}
void PrintArray(int[] Elmnts)
{
    int count = Elmnts.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write(Elmnts [position] );
        position++;
    }
}
int[] array = new int [8];

FillArray(array);
PrintArray (array);
*/

