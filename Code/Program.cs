﻿string[] Array = new string[8] {"control", "work", "world", "08", ":)", "lesson", "up", "down"};
int count = 0;
for (int i = 0; i < Array.Length; i ++)
{
    Console.Write($"{Array[i]},");
    if (Array[i].Length < 4)
    {
        count ++;
    }
}
Console.WriteLine();

string[] Array2 = new string[count];
int j = 0;
for (int i = 0; i < Array.Length; i ++)
{
    if (Array[i].Length < 4)
    {
        Array2[j] = Array[i];
        Console.Write($"{Array2[j]},");
        j ++;
    }
}