Console.WriteLine("┌---------------------------------------┐");
Console.WriteLine($"|        x          |         y         |");
Console.WriteLine("|---------------------------------------|");
for (double x = 1; x <= 2; x += 0.1)
{
    double y = 0;
    if (x <= 2)
    {
        for (double u = (x*x-7*x+3)/x-Math.Exp(x) ; u <= 5; u++) y += Math.Acos(0.5*Math.Abs(Math.Sin(u-3)))+3*x;
    }
    else y = Math.Acos(0.5 * Math.Abs(Math.Sin(Math.Pow(Math.Atan(x),2) - 3))) + 3 * x;
    Console.WriteLine($"|       {x,-5:F2}       |       {y,5:F2}       |");
}
Console.WriteLine("└---------------------------------------┘");
Console.WriteLine();
