using System;

namespace Le_nombre_magique
{
    class Program
    {
        static void Main(string[] args)
        { 
            Random rand = new Random();
            const int NUMBER_MIN = 1;
            const int NUMBER_MAX = 10;
            int NUMBER_FIND = rand.Next(NUMBER_MIN,NUMBER_MAX+1);

            
            
            int nombre = NUMBER_FIND +1;

          //  int nbVies = 4; 
       //     while (nbVies > 0)
            for(int nbVies = 4; nbVies > 0; nbVies -=1)
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : "+ nbVies);
                     nombre = DemanderNombres(NUMBER_MIN,NUMBER_MAX);

                if(nombre < NUMBER_FIND)
                {
                Console.WriteLine("C'est plus.");
                 //   nbVies -= 1;
                    
                }
                else if(nombre > NUMBER_FIND)
                {
                Console.WriteLine("C'est moins.");
                 //   nbVies -= 1;
                }
                else
                {
                    Console.WriteLine("Bravo vous avez trouvé");
                    break;
                }
           //     nbVies -= 1;

            }
            

            if (nombre != NUMBER_FIND)
            {
                Console.WriteLine("Vous avez perdu, le nombre était " + NUMBER_FIND);
            }
           
           

/*
            Random randNum = new Random();
            for(int i = 0; i<10; i++)
            {
            int valeursRandom = randNum.Next(1, 11);
            Console.WriteLine("Nombre aleatoire : " + valeursRandom);
            }
*/
        }


        static int DemanderNombres(int min, int max)
        {
           
            int numberUsers = min - 1;

            while((numberUsers < min) || (numberUsers > max))
            {


                Console.WriteLine("Rentrez un nombre entre " + min + " et " + max +".");
                string reponse = Console.ReadLine();
                try
                {
                    numberUsers = int.Parse(reponse);

                    if((numberUsers < min) || (numberUsers > max))
                    {
                        Console.WriteLine("Il faut choisir un nombre compris entre "+ min +" et "+ max + ".");
                      
                    }
                }
                catch
                {
                    Console.WriteLine("ERROR : Entrez un nombre correct: ");
                }

            }
            return numberUsers;

        }
    
    }
}
