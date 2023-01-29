/*Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();
int[] ReadArray()
{
  Console.WriteLine("Введите длинну массива");
  int n = int.Parse(Console.ReadLine()!);
  int[] massiv = new int [n];
  
    for (int i = 0; i < n; i++)
      {
    massiv[i]=int.Parse(Console.ReadLine()!);
      }
      return massiv;

}
int[]array=ReadArray();
void PrintArray(int[] col)
{
    int position =col.Length;
    int count = 0;
    while (count<position)
    {
      Console.WriteLine(col[position]);
      count++;
    }
}
PrintArray(array);