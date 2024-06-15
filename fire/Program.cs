using System;
class beng
{
    static void Main()
    {
        Console.Write("Введите количество бенгальских огней у Игоря: ");
        int c1 = int.Parse(Console.ReadLine());

        int b1 = 2;

        int time = 2, allFire = 0;

        if (c1 > 0)
        {
            allFire = (c1 + b1) * time;
        }

        Console.WriteLine($"Огни будут гореть в часах: {allFire}");
        Console.ReadKey();
    }
}