Console.Write("What's your name? ");
var name = Console.ReadLine();

var reversed = ReversedName(name);

Console.WriteLine("Reversed name: " + reversed);

string ReversedName(string? s)
{
    var array = new char[s.Length];
    for (var i = s.Length; i > 0; i--)
        array[s.Length - i] = s[i - 1];
    return new string(array);
}
