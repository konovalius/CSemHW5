//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] Array  (int size, int min, int max)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}
int[] Massiv = Array  (20, 100, 999);

int NumbersOfMassive (int[] Massiv)
{
    int count = 0;
    for (int i = 0; i < Massiv.Length; i++)
{
    if (Massiv[i] % 2 == 0)
    count++;
}
    return count;
}

Console.WriteLine(String.Join(",", Massiv));
Console.Write($"-> {NumbersOfMassive(Massiv)} ");