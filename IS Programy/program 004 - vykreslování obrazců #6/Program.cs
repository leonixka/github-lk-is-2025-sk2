using System.Numerics;

//Šířka obdelníku
int width;

//Výška obdelníku
int height;

Console.Clear();

Console.WriteLine("Zadejte šířku obdelníku:");
width = int.Parse(Console.ReadLine());

Console.WriteLine("Zadejte výšku obdelníku:");
height = int.Parse(Console.ReadLine());


for (int i = 0; i < height; i++)   {
    for (int j = 0; j < width; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}