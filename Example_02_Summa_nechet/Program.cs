void InputArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (1, 101);
    }
}

int ReleaseArray (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        count+= array[i];
    }
    return count;

}




Console.Clear();
Console.WriteLine ("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];

InputArray(array);
Console.WriteLine ($"[{string.Join(", ", array)}]");

Console.WriteLine ($"Сумма чисел, стоящих на нечетных местах массива, равна {ReleaseArray (array)}");