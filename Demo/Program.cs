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



            #endregion
        }
    }
}
