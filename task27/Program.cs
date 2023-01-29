/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();
int numbersum (int number)
{
    int sum=0;
    
    
    for (int i = number/10; i >0; i++)
    {
       sum+=number%10; 
    }
       
     return sum;
}
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine()!);

int b =numbersum(a);
Console.WriteLine(b);