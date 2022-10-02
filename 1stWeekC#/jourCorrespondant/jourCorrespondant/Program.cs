

using System;
namespace jourCorrespondant
{

    class Program
    {
        static void Main(String[] args)
        {

            int choix;



            Console.WriteLine("saisir un chiffre entre 1 et 7");
            choix= int.Parse(Console.ReadLine());

            while((choix<1)|| (choix > 7))
            {

                Console.WriteLine("Veuillez resaisir la valeur");
                choix = int.Parse(Console.ReadLine());


            }
            switch (choix)
            {

                case 1:
                    Console.WriteLine("Lundi");
                    break;

                case 2:
                    Console.WriteLine("Mardi");
                    break;

                case 3: Console.WriteLine("Mercredi");
                    break;

                case 4:
                    Console.WriteLine("Jeudi");
                    break;

                case 5:
                    Console.WriteLine("Vendredi");
                    break;

                case 6: Console.WriteLine("Samedi");
                    break;

                case 7:
                    Console.WriteLine("Dimanche");
                    break;

              



            }




        }


    }



}
