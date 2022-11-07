//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] GenArray(int a)
{
    int[] x = new int[a];
    Random rd = new Random();
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = rd.Next(-500, 500);
    };
    return x;
}
void PrintArray(int[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length; i++)
    {
        if (i == a.Length - 1)
        {
            Console.Write(a[i]);
        }
        else
        {
            Console.Write(a[i] + ", ");
        }
    }
    Console.Write("]");

}
Console.Write("Введите количество элеметов массива ");
int x = Convert.ToInt32(Console.ReadLine());
PrintArray(GenArray(x));

