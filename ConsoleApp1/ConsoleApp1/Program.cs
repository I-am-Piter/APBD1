// See https://aka.ms/new-console-template for more information




Console.WriteLine("Hello, World!");

int[] integers = {1, 2, 3, 4, 5};

Console.WriteLine(CalculateSmth(integers));
Console.WriteLine(CalculateMax(integers));

static double CalculateSmth(int[] arr)
{
    return arr.Average();
}

static double CalculateMax(int[] arr)
{
    return arr.Max();
}