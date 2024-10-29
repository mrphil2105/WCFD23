using System;

var alice = 0;
var bob = 0;

var bottles = ReadNumber();
var aliceSeconds = ReadNumber();
var alicePenalty = ReadNumber();
var bobSeconds = ReadNumber();
var bobPenalty = ReadNumber();

for (var i = 0; i < bottles; i++)
{
    alice += aliceSeconds + alicePenalty * i;
    bob += bobSeconds + bobPenalty * i;
}

if (alice == bob)
{
    Console.WriteLine("=");

    return;
}

Console.WriteLine(alice > bob ? "Bob" : "Alice");

static int ReadNumber()
{
    int num = 0, b;

    while ((b = Console.Read()) != '\n' && b != '\r' && b != ' ' && b != -1)
    {
        num = num * 10 + b - '0';
    }

    return num;
}
