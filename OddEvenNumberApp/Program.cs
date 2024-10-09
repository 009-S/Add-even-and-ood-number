


int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

printnumber("All Number", number);
printnumber("All Number Is Even", number.Where(x=>Iseven(x)));
printnumber("All Number Is odd", number.Where(x => Isodd(x)));



void printnumber( string title , IEnumerable<int> number)
{
	Console.WriteLine();
    Console.Write($"{ title} [ ");

	foreach (var item in number)
	{
		Console.Write($"{item}  ");
	}
    Console.WriteLine(" ] ");

    Console.WriteLine();

}

bool Iseven (int number)
{
	if (number % 2 == 0)
	{
		return true;
	}
	else
	{
        return false;

    }
}

bool Isodd(int number)
{
    if (number % 2 != 0)
    {
        return true;
    }
    else
    {
        return false;

    }
}

Console.ReadKey();
