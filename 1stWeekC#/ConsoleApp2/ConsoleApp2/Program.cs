using System;
namespace ConsoleApp2
{
    class Program
    {
static void Main(String[] args)
        {
            int a, fact,i;
            Console.WriteLine("saisir une valeur non null ");
            a= int.Parse( Console.ReadLine());

            while(a == 0)
            {

                Console.WriteLine("resaisir la valeur ");
                a = int.Parse(Console.ReadLine());


            }
            fact = 1;
            for (i = 1; i <= a; i++)
            {
                fact = fact * i;

            }


            Console.WriteLine("le factoriel de {0} est {1} ",a,fact);




        }


    }
}

