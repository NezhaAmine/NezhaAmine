// See https://aka.ms/new-console-template for more information


using System;
namespace consoleApp1
{
class Program
    {

public static void Main (String[] args)
        {

           int a;
            Console.WriteLine("Saisir un entier");
            a = int.Parse(Console.ReadLine());

            if ((a >= 0) && (a % 2 == 0))
            {

                Console.WriteLine("{0} est postif et pair", a);
            }

            if ((a >=0) && (a % 2 != 0))
            {

                Console.WriteLine("{0} n est pas pair",a);
            }
            if ((a < 0) && (a % 2 == 0))
            {

                Console.WriteLine("{0} n est pas positif",a);
            }



        }


    }



}








