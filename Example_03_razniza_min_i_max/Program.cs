void InputArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Math.Round ((new Random().NextDouble () * 100), 2);
    }
}

double ReleaseArray (double [] array)
{
    int i = 0;
    double max = array[i];
    double min = array[i];


    for (i = 0; i < array.Length; i++)
    {
        if (array [i] > max)
        max = array [i];
    }
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array [i];
    }
    double def = max - min;
    return def;

}




Console.Clear();
Console.WriteLine ("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double [n];

InputArray(array);
Console.WriteLine ($"[{string.Join(", ", array)}]");
Console.Write ($"Разница между максимальным и минимальным числом равна {ReleaseArray (array)}");