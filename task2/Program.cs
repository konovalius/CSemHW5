// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] Array (int size, int min,int max)
{
    int []res = new int [size];
    for (int i=0 ; i< size; i++)
    {
        res[i]=new Random().Next(min,max+1);
    }
    return res;
}

int []Massiv = Array(5,-100,100);

int sumOfNumb (int[] Massiv)
{
    int sum = 0;
    for (int i = 0; i < Massiv.Length; i++)
{
    if (i % 2 != 0)
    {
        sum+=Massiv[i];
    }
    
}
    return sum;
}

Console.Write(String.Join(",", Massiv));
Console.WriteLine($"->{sumOfNumb(Massiv)}");