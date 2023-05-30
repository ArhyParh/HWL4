// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Main();
void Main()
{
    int[] a = FeelMass(10);
    int b = HowMuchNumberIsEven(a);
    Console.WriteLine(b);

}
int[] FeelMass(int size)
{
    int[] back = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        back[i] = rnd.Next(100, 1000);
        Console.Write(back[i] + " ");
    }
    return back;
}
int HowMuchNumberIsEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}