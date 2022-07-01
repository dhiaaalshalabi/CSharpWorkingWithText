var numbers = new List<int>();
while (true)
{
    Console.WriteLine("Enter a number (or 'Quite' to exit): ");
    var input = Console.ReadLine();
    
    if (input?.ToLower() == "quit")
        break;

    numbers.Add(Convert.ToInt32(input));
}

Console.WriteLine("Unique numbers:");
foreach(var number in GetUniqueNumbers(numbers))
    Console.WriteLine(number);

List<int> GetUniqueNumbers(List<int> ints)
{
    var list = new List<int>();
    foreach (var number in ints)
    {
        if (!list.Contains(number))
            list.Add(number);
    }

    return list;
}