namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        { 
            var fullName = "Dhia'a Shalabi";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUppor: '{0}'", fullName.Trim().ToUpper());
            
            // Splitting a text
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0,index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: '{0}'", firstName);
            Console.WriteLine("LastName: '{0}'", lastName);
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: '{0}'", names[0]);
            Console.WriteLine("LastName: '{0}'", names[1]);
            
            // Replacing text
            Console.WriteLine(fullName.Replace("Dhia'a", "Dhia'a Alhaq"));
            
            // Validating a text
            if(String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");
            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");
            
            // Converting text
            var str = "25";
            var age = Convert.ToByte(str);

            var price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
