﻿static int CalcRectArea(int width, int height)
{
    return width * height;
}

int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int area = CalcRectArea(width, height);
Console.WriteLine(area);