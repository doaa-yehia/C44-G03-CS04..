namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01 
            ///Write a program that allows the user to insert an integer then print all numbers 
            ///between 1 to that number.

            //Console.Write("Please Enter Number : ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            //if (isParsed)
            //{
            //    for(int i = 0; i <= number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("you didn't Enter Number");
            //}

            #endregion

            #region Q02
            ///Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("Please Enter Number : ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            //if (isParsed)
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        int multiple = i * number;
            //        Console.WriteLine(multiple);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("you didn't Enter Number");
            //}

            #endregion

            #region Q03
            ///Write a program that allows to user to insert number then 
            ///print all even numbers between 1 to this number

            //Console.Write("Please Enter Number : ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            //if (isParsed)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }

            //}
            //else
            //{
            //    Console.WriteLine("you didn't Enter Number");
            //}

            #endregion

            #region Q04
            ///Write a program that takes two integers then prints the power.

            //Console.Write("Please Enter Number : ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            //Console.Write("Please Enter Power : ");
            //bool isnumber = int.TryParse(Console.ReadLine(), out int power);
            //int num = 1;

            //if (isParsed && isnumber)
            //{
            //    for (int i = 1; i <= power; i++)
            //    {
            //        num *= number;

            //    }
            //    Console.WriteLine($"The Number {number} Power {power} = {num} ");

            //}
            //else
            //{
            //    Console.WriteLine("you didn't Enter Numbers");
            //}

            #endregion

            #region Q05
            ///- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //double sum = 0;

            //bool flag = true;
            //for (int i = 1; i <= 5; i++) //95 76 58 90 89
            //{
            //    Console.Write($"Please Enter The  marke of subject {i} : ");
            //    bool isPared = double.TryParse(Console.ReadLine(), out double sub);

            //    if (isPared)
            //    {
            //        sum += sub;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You Must Enter Number");
            //        flag = false;
            //        break;

            //    }

            //}
            //if (flag)
            //{
            //    double avg = sum / 5;
            //    Console.WriteLine($"The Avarage = {avg}");

            //    double perc = (sum / 500) * 100;
            //    Console.WriteLine($"The Percentage = {perc}");

            //}


            #endregion

            #region Q06
            /// Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Please Enter Worlds : ");
            //string message = Console.ReadLine() ?? "";
            //string revMessage = "";
            //for (int i = (message.Length) - 1 ; i >= 0 ; i--)
            //{
            //    revMessage += message[i];
            //}
            //Console.WriteLine(revMessage);

            #endregion

            #region Q07
            ///Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Please Enter Number : ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //int temp = number;
            //int revNum=0;
            //if (isParsed)
            //{
            //    while( temp > 0)
            //    {
            //        int digit = temp % 10;
            //        revNum = revNum * 10 + digit;
            //        temp /= 10;
            //    }
            //}
            //Console.WriteLine(revNum);

            #endregion

            #region Q08
            ///Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("Please Enter Starting Number : ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int start);

            //Console.Write("Please Enter Ending Number : ");
            //bool isnumber = int.TryParse(Console.ReadLine(), out int end);

            //int first = start < end ? start : end;
            //int last = end > start ? end : start;

            //bool index = false;

            //if (isParsed && isnumber)
            //{

            //    for( int i=first; i<=last;i++)
            //    {
            //        bool flag = true;
            //        for (int j=2;j<=i/2; j++)
            //        {
            //            if (i % j == 0 )
            //            {

            //                flag = false;
            //            }
            //        }
            //        if (!index)
            //        {
            //            Console.WriteLine($"The prime number between {start} and {end} are");
            //            index = true;
            //            continue;
            //        }

            //        if (flag && i != 1)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine( "You Must Enter Numbers" );
            //}

            #endregion

            #region Q9
            ///Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Please Enter  Number : ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //int binary = 0, power = 1;
            //if (isParsed)
            //{
            //    while (number > 0)
            //    {
            //        int reminder = number % 2;
            //        binary += reminder * power;
            //        power *= 10;
            //        number /= 2;
            //    }
            //    Console.WriteLine(binary);
            //}
            //else
            //{
            //    Console.WriteLine("You Must Enter Number");
            //}


            #endregion





        }
    }
}
