using Hobby;

SortingAlgorithms sa = new();
sa.RandomizeArray();
sa.PrintArray();

Console.WriteLine("sorting");
sa.SelectionSort();
sa.PrintArray();

Console.ReadLine();