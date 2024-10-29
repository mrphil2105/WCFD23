using System;

var players = ReadNumber();
var cards = ReadNumber();

if (cards == 0)
{
    Console.WriteLine("NO");

    return;
}

if (players == 2 || cards == 1)
{
    Console.WriteLine("YES");

    return;
}

if (cards == 2)
{
    Console.WriteLine("NO");

    return;
}

if (int.IsEvenInteger(cards))
{
    Console.WriteLine((players - 1) * 2 <= cards ? "MAYBE" : "NO");

    return;
}

Console.WriteLine("MAYBE");

static int ReadNumber()
{
    int num = 0, b;

    while ((b = Console.Read()) != '\n' && b != '\r' && b != ' ' && b != -1)
    {
        num = num * 10 + b - '0';
    }

    return num;
}
