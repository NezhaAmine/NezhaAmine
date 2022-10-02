


using System;


namespace suiteEntier
{

    class Program
    {
        static void Main (String[] args)
        {
            int a, i, fact, abso, occ, v, np, si, max, min, moy, sum;
            i = 1;
            Console.WriteLine("sasir la valeur recherchee :");
            v = int.Parse(Console.ReadLine());
            Console.WriteLine("veuillez saisir unse suite de valeurs strictement negatives :");
            Console.WriteLine("saisir la valeur {0} :",i);

            a = int.Parse(Console.ReadLine());

            while (a >= 0)
            {
                Console.WriteLine(" veuillez resaisir la valeur {0}:", i);
                a = int.Parse(Console.ReadLine());



            }
            occ = 0;
            max = a;
            min = a;
            sum = a;
            np = 0;

            si = 0;


            while (a < 0)
            {
               

                if (a > max)
                {

                    max = a;
                }

                if (a < min)
                {

                    min = a;
                }

               

                if (a % 2 == 0)
                {
                    np=np+1;


                }
                else
                {

                    si = si + a;
                }

                sum =sum+a;
 if (a == v)
            {
                occ=occ+1;
            } 
                    Console.WriteLine("saisir la valeur {0}:",i=i+1) ;
                a = int.Parse(Console.ReadLine());
            }
            //  max min moyenne  nombre de v.paire somme v.impaire nombre d occ de v saisie clavier v absolue du max et son fact
            Console.WriteLine(" le max est : {0} \n", max);
            abso = -max;
            Console.WriteLine(" la valeur absolue du max  est : {0} \n", abso);
            fact = 1;
            for (i = 1; i <= abso; i = i + 1) 
            {
                fact = fact * i;


            }
            Console.WriteLine(" le factoriel de la valeur absolue du Max est : {0} \n", fact);

            Console.WriteLine(" le min est : {0} \n", min);

            moy = sum / i;
            Console.WriteLine(" la moyenne est : {0} \n", moy);
            Console.WriteLine(" le nombre de valeurs paires: {0} \n", np);
            Console.WriteLine(" la somme  de valeurs impaires: {0} \n", si);
            Console.WriteLine(" l occurence de la valeur recherchee est : {0} \n", occ);
           



        }
    }


}