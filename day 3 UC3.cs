using System;



class string_comparison_demo

{

    static void Main()

    {

        string str_equ1 = "C# compare";

        string str_equ2 = "C Sharp compare";



        if (String.Equals(str_equ1, str_equ2))

        {

            Console.WriteLine("Both Strings are same!");

        }

        else

        {

            Console.WriteLine("Strings are different!");

        }



        Console.ReadLine();

    }

}