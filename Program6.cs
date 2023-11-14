

Console.WriteLine("\n--- 1 ---");

for (int i = 1; i <= 5; i++)
{
	for (int j = 1; j <= 5; j++)
	{
        Console.Write(j);
    }
    Console.WriteLine("");
}

Console.WriteLine("\n--- 2 ---");

for (int i = 1; i <= 5; i++)
{
    for (int j = i; j <= i+4; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine("");
}

Console.WriteLine("\n--- x ---");

for (int i = 1; i <= 5; i++)
{
    for (int j = i; j <= 5; j++)
    {
        Console.Write(0);
    }

    Console.WriteLine("");
}
Console.WriteLine("\n--- x ---");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(0);
    }

    Console.WriteLine("");
}

Console.WriteLine("\n--- 3 ---");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write(".");
    }
    for (int j = 5; j >= i; j--)
    {
        Console.Write(0);
    }
    Console.WriteLine("");
}

Console.WriteLine("\n--- 4 ---");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine("");
}

Console.WriteLine("\n--- 5 ---");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine("");
}

Console.WriteLine("\n--- 6 ---");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1, h = 5; j <= i; j++, h--)
    {
        Console.Write(h);
    }
    Console.WriteLine("");
}
Console.WriteLine("\n--- 7 ---");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1, h = i; j <= i; j++, h--)
    {
        Console.Write(h);
    }
    Console.WriteLine("");
}

Console.WriteLine("\n--- 8 ---");

int c = 1;
for (int i = 1; i <= 5; i++)
{
    
    for (int j = 1, h = i; j <= i; j++, h--, c++)
    {
        Console.Write(c);
        if (c <= 10)
        {
            Console.Write("  ");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine("");
}

Console.WriteLine("\n--- 9 ---");

for (int i = 1; i <= 5; i++)
{
    for (int j = i; j < 5; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i; j++)
    {
        Console.Write("x");
    }
    Console.WriteLine("");
}