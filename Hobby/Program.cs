using Hobby;

SortingAlgorithms sa = new();
sa.RandomizeArray();
sa.PrintArray();

Console.WriteLine("sorting");
sa.InsertionSort();
sa.PrintArray();

Console.ReadLine();