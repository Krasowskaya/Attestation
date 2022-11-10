

void SortMassive(string[] FirstMassive)
{
    int j = 0;
    string[] ResultMassive = new string[j];
    {
        for(int i = 0; i < FirstMassive.Length; i++)
        {
            if(FirstMassive[i].Length < 4)
            Console.WriteLine(FirstMassive[i]);
        }
    }
}

Console.Clear();
string[] FirstMassive = { "Moscow", "sun", "1703" };
Console.Write($"Исходный массив: [{string.Join(",",FirstMassive)}]");
Console.WriteLine();
Console.WriteLine("Результат: ");
SortMassive(FirstMassive);
