
/// Chat GPT
/// 

/*Assignment:

* If user selected to generate random number, ask him to enter minimum & maximum values

If user selected to generate random string, ask him to enter the string length * If user selected to generate random string, ask him to select buffer options as follows:

[1] Include capital letters? (yes/no) [2] Include small letters? (yes/no)

[3] Include numbers? (yes/no)

[4] Include symbols? (yes/no)Assignment:

* If user selected to generate random number, ask him to enter minimum & maximum values

If user selected to generate random string, ask him to enter the string length * If user selected to generate random string, ask him to select buffer options as follows:


[1] Include capital letters? (yes/no) [2] Include small letters? (yes/no)

[3] Include numbers? (yes/no)

[4] Include symbols? (yes/no)*/
using System;
using System.Text;

namespace CSharpFundamental_Basics3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("[1] Generate Random Number  [2] Generate Random String");
                var selectedOption = Console.ReadLine();

                if (selectedOption == "1")
                {
                    Console.WriteLine("Enter a minimum value:");
                    if (int.TryParse(Console.ReadLine(), out int min))
                    {
                        Console.WriteLine("Enter a maximum value:");
                        if (int.TryParse(Console.ReadLine(), out int max))
                        {
                            GenerateRandomNumber(min, max);
                        }
                        else
                        {
                            Console.WriteLine("Invalid maximum value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid minimum value.");
                    }
                }
                else if (selectedOption == "2")
                {
                    Console.WriteLine("Enter the length of the string:");
                    if (int.TryParse(Console.ReadLine(), out int len))
                    {
                        GenerateRandomString(len);
                    }
                    else
                    {
                        Console.WriteLine("Invalid length.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
        }

        static void GenerateRandomNumber(int min, int max)
        {
            var rnd = new Random();
            var value = rnd.Next(min, max);
            Console.WriteLine($"Random Number = {value}");
        }

        private static void GenerateRandomString(int len)
        {
            var sb = new StringBuilder();
            var container = new StringBuilder();
            const string Container1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string Container2 = "abcdefghijklmnopqrstuvwxyz";
            const string Container3 = "0123456789";
            const string Container4 = "~!@#$%^&*()";

            Console.WriteLine("Do you want Capital Letters (yes/no)?");
            string cap = Console.ReadLine()?.Trim().ToLower();
            Console.WriteLine("Do you want Small Letters (yes/no)?");
            string small = Console.ReadLine()?.Trim().ToLower();
            Console.WriteLine("Do you want Numbers (yes/no)?");
            string numbers = Console.ReadLine()?.Trim().ToLower();
            Console.WriteLine("Do you want Symbols (yes/no)?");
            string symbols = Console.ReadLine()?.Trim().ToLower();

            if (cap == "yes")
                container.Append(Container1);
            if (small == "yes")
                container.Append(Container2);
            if (numbers == "yes")
                container.Append(Container3);
            if (symbols == "yes")
                container.Append(Container4);

            if (container.Length == 0)
            {
                Console.WriteLine("No valid character sets selected.");
                return;
            }

            var random = new Random();
            while (sb.Length < len)
            {
                var randomIndex = random.Next(0, container.Length);
                sb.Append(container[randomIndex]);
            }
            Console.WriteLine($"Random String = {sb.ToString()}");
        }
    }
}

  
// me       
/*
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpFundamental_Basics3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please Selected an Option ?");

                Console.WriteLine("[1] Generate Random Number  [2] Generate Random String  ");
                var Selected_Option = Console.ReadLine();

                if (Selected_Option == "1")
                {
                    Console.WriteLine("Enter a Minmum Value : ");
                    var min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a Maxmum Value : ");
                    var max = int.Parse(Console.ReadLine());
                    GenerateRandomNumber(min, max);
                }
                else if (Selected_Option == "2")
                {
                    Console.WriteLine("Enter The Lenght of String :");
                    var len = int.Parse(Console.ReadLine());
                    GenerateRandomString(len);

                }
            }


        }


        static void GenerateRandomNumber(int min, int max)
        {
            var rnd = new Random();
            var value = rnd.Next(min, max);
            Console.WriteLine($"Random Number ={value}");

        }

        private static void GenerateRandomString(int len)
        {
            var sb = new StringBuilder();
            var Container = new StringBuilder();
            const string Container1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string Container2 = "abcdefghijklmnopqrstuvwxyz";
            const string Container3 = "0123456789";
            const string Container4 = "~!@#$%^&*()";


            Console.WriteLine(" Do you want Capita Letters");
            string Cap = Console.ReadLine();
            Console.WriteLine("Do you want Small Letters ");
            string small = Console.ReadLine();
            Console.WriteLine("Do you want a Number ");
            string Numbers = Console.ReadLine();
            Console.WriteLine("Do you want a Sympols ");
            string Sympols = Console.ReadLine();


            if (Cap == "yes / no ")
                Container.Append(Container1);
            if (small == "yes / no")
                Container.Append(Container2);
            if (Numbers == "yes/ no")
                Container.Append(Container3);
            if (Sympols == "yes / no")
                Container.Append(Container4);

            var random = new Random();
            while (sb.Length < len)
            {
                var randomindex = random.Next(0, Container.Length);
                sb.Append(Container[randomindex]);

            }
            Console.WriteLine($"Random String {sb} ={sb.Length}");

        }

    }

}

*/



//static void Main(string[] args)
//{
//    while (true)
//    {
//        Console.WriteLine("Please Select an Option ?");
//        Console.WriteLine("[1] Generate Random Number  [2] Generate Random String ");
//        var Select_Optipn = Console.ReadLine();
//        if (Select_Optipn == "1")
//            GenerateRandomNumber();
//        else if (Select_Optipn == "2")
//            GenerateRandomString();
//    }

//}


//static void GenerateRandomNumber()
//{
//    var rnd = new Random();
//    var value = rnd.Next(1000, 9999);

//    Console.WriteLine($"Random Number = {value}");
//}

//private const string Buffer = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~!@#$%^&*()";
//private static void GenerateRandomString()
//{
//    var sb = new StringBuilder();
//    var rnd = new Random();
//    while (sb.Length < 16)
//    {
//        var RandomIndex = rnd.Next(0, Buffer.Length);
//        sb.Append(Buffer[RandomIndex]);
//    }
//    Console.WriteLine($"Random String ={sb}");


//}

