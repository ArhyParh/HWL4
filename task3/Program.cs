// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Main();
void Main(){
    Console.WriteLine("Введите 3 числа: 1 - размер массива, 2 - нижний предел, 3 - верхний предел...");
    int size = int.Parse(Console.ReadLine()!);
    int a = int.Parse(Console.ReadLine()!);
    int b = int.Parse(Console.ReadLine()!);
    double [] c = FillMass(size,a,b);
    double d = DiffMinMax(c);
    Console.WriteLine(d);


}
double [] FillMass(int size, int a, int b){
    Random rnd = new Random();
    double [] back = new double[size];
    for(int i = 0;i< size ; i++){
        back[i] = rnd.Next(a,b);
        Console.Write(back[i]+" ");
    }
    Console.WriteLine(" ");
    return back;
}
double DiffMinMax(double[] array){
    double a = array.Max()- array.Min();
    return a;
}