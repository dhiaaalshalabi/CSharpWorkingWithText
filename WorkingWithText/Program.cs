namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really long text.";
            Console.WriteLine(StringUtils.summerizeText(sentence,40));
        }
    }
}
