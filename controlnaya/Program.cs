
void SortMassive(string[] FirstMassive)

    {
        for(int i = 0; i < FirstMassive.Length; i++)
        {
            if(FirstMassive[i].Length < 4)
            Console.WriteLine(FirstMassive[i]);
        }
    }



Console.Clear();
string[] FirstMassive = { "Moscow", "sun", "1703", "<33", "NY" };
Console.Write($"Исходный массив: [{string.Join(",",FirstMassive)}]");
Console.WriteLine();
Console.Write("Результат: ");
SortMassive(FirstMassive);
