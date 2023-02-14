// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] Array (int size, int min,int max)
{
    Random rnd= new Random();
    double []res = new double [size];
    for (int i=0 ; i< size; i++)
    {
        res[i]=rnd.NextDouble();

    }
    return res;
}
double []Massiv = Array(5,-100,100);
double Diff (double[] Massiv)
{
    double max=Massiv[0];
    double min=Massiv[0];
    double diff=0;
    for (int i=0;i<Massiv.Length;i++)
    {
        if (Massiv[i]<min)
        {
            min=Massiv[i];
        }
        if (Massiv[i]>max)
        {
            max=Massiv[i];
        }
        
    }
    diff=max-min;
    return diff;
}

Console.WriteLine(String.Join(",", Massiv));
Console.WriteLine($" разница ->{Diff(Massiv)}");
