using System;

var beer = ReadNumber();
var lemonade = ReadNumber();

var min = Math.Min(beer, lemonade);
Console.WriteLine(min * 2);

static int ReadNumber()
{
    int num = 0, b;

    while ((b = Console.Read()) != '\n' && b != '\r' && b != ' ' && b != -1)
    {
        num = num * 10 + b - '0';
    }

    return num;
}
