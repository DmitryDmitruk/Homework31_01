/*Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит
число A в натуральную степень B.
Нельзя использовать библиотеку Math!
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Clear();


int naturalsqrt(int a,int b)
{
    int count =1;
    int y =1;
      while (count<b+1)
      {
        y=y*a;
        count++;
      }
    return y;
}
Console.WriteLine("Введите число a");
int a=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b");
int b= int.Parse(Console.ReadLine()!);
int x=naturalsqrt( a,b);

Console.WriteLine($"ответ {x}");