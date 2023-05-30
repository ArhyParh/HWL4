// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Main();
void Main()
{
    int[] a = FillMass(8, -10, 25);
    int b = SumOfOdd(a);
    Console.WriteLine(b);
}
int[] FillMass(int size, int a, int b)
{
    int[] back = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        back[i] = rnd.Next(a, b);
        Console.Write(back[i] + " ");
    }
    Console.WriteLine(" ");
    return back;
}
int SumOfOdd(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count = count + array[i];
    }
    return count;
}