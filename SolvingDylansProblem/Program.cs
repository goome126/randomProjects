using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingDylansProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program by Goome126 or Nathan Tymofichuk
            //That's me! :D

            /*Variable Declaration*/
            int numberCeiling;
            int isPrime = 0;
            int numberTimesDivided = 0;
            double dBO;

            /*Prompt the user to input to how many prime numbers should the program go.*/
            Console.Write("Please input a number to go to: ");
            numberCeiling = Convert.ToInt32(Console.ReadLine());


            /*Main Program Loop*/
                for (int n = 1; n <= numberCeiling; n++) //Run through all the numbers the user input
                {

                    numberTimesDivided = 0; //Reset this variable for the next for loop

                    for (int k = 1; k <= n; k++) //Divide the current number by every number before it and see if it divides evenly 
                    {

                        dBO = n % k;

                        if (dBO == 0) //If it does divide evenly, keep track of it
                        {

                            numberTimesDivided++;
                            
                        }

                    if (numberTimesDivided > 2) { //This if exists to see that if the number has already been evenly divided more than twice it can stop checking for that number
                        k = n; 
                    }

                    }

                    if (numberTimesDivided <= 2) { //If the number was only divisble two times, that means it's prime

                        isPrime = 1; 

                    }


                    if (isPrime == 1) //And if it's prime, print it out to the console.
                    {

                        Console.WriteLine(n);

                    }

                    isPrime = 0; //Reset the isPrime variable for the next value of n

                    }


            Console.ReadKey(); //Pause the program


        }
    }
}
