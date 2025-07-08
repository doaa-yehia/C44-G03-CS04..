namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region video 01 Evalution of Switch in C#
            #region C# 7.0 [ Pattern Matching - Case Guards (when)]
            //object num = 5.3;  //Boxing
            #region Example 01 [Pattern Matching on Types]
            //switch (num)
            //{
            //    case int value:  //UnBoxing
            //        Console.WriteLine("Integer");
            //        break;
            //    case decimal value:
            //        Console.WriteLine("decimal");
            //        break;
            //    case double value:
            //        Console.WriteLine("double");
            //        break;
            //    default:
            //        Console.WriteLine("No Match");
            //        break;
            //}
            #endregion

            #region Example 02 [case Guards (when)
            //switch (num)
            //{
            //    case int value when value > 10:  //UnBoxing
            //        Console.WriteLine("integer is less than 10");
            //        break;
            //    case int value when value > 10:
            //        Console.WriteLine("integer is greater than 10");
            //        break;
            //    case decimal value:
            //        Console.WriteLine("decimal");
            //        break;
            //    case double value when value > 3.5 && value < 10.5:
            //        Console.WriteLine("double is more than 3.5 and less Than 10.5 ");
            //        break;
            //    default:
            //        Console.WriteLine("No Match");
            //        break;
            //}

            #endregion

            #region Example 03 [user Defind Data Type]

            //object input = 5;
            //input = new Person { Id = 1, Name = "Doaa", Age = 32 };
            //switch (input)
            //{
            //    case int value when value > 10:  //UnBoxing
            //        Console.WriteLine("integer is less than 10");
            //        break;
            //    case int value when value > 10:
            //        Console.WriteLine("integer is greater than 10");
            //        break;
            //    case string value:
            //        Console.WriteLine("string");
            //        break;
            //    case Person value  when value.Id==1 && value.Name=="Doaa":
            //        Console.WriteLine("Person");
            //        break;
            //    default:
            //        Console.WriteLine("No Match");
            //        break;
            //}

            #endregion

            #endregion

            #region C# 8.0 

            #region Example 01 pattern Matching Without alias name

            //object num = 5.3;
            //switch (num)
            //{
            //    case int :  //UnBoxing
            //        Console.WriteLine("Integer");
            //        break;
            //    case decimal :
            //        Console.WriteLine("decimal");
            //        break;
            //    case double when (double) num > 3.5 && (double) num < 15.5:
            //        Console.WriteLine("double");
            //        break;

            //}

            #endregion

            #region Example 02 Switch Expressions [ Constant Pattern - Discard Pattern ]

            //Console.Write("Enter Your number : ");

            //int.TryParse(Console.ReadLine(), out int option);

            //string message = option switch
            //{
            //    1 => "Option 01",
            //    2 => "Optrion 02",
            //    3 => "Optrion 02",
            //    _ => "Invalid Option"

            //};
            //Console.WriteLine(message);

            #endregion

            #region Example 03 [property Pattern]

            //Person person = new Person { Id = 2, Name = "Mostafa", Age = 30 };
            //string message = person switch
            //{
            //    { Name: "Mohamed", Age: 10 } => "Hello Mohamed",
            //    { Name: "Mostafa" } => "Hello Mostafa",
            //    _ =>"Sorry We Don't Know you"
            //};
            //Console.WriteLine(message);

            #endregion

            #region Example 04 [ Nullable type - Relational Pattern (Partially) ]

            //int? num = 10;
            //string massage = num switch
            //{
            //    null => "Nullable type",
            //    int X when X > 0 => "Positive number",
            //    int X when X < 0 => "Negative number",
            //    0 => "Zero number",

            //};
            //Console.WriteLine(massage);
            #endregion

            #endregion



            #endregion
        }
    }
}
