using System;

namespace ILikeTrainsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I Like Trains!");

            int aNumber = 0;
            int numberOfLikes = 0;
            string readALine;

            do
            {
                Console.WriteLine("Press 1 to add like to train!");
                Console.WriteLine("Press 3 to Exit!");
                readALine = Console.ReadLine();

                if(readALine=="1")
                {
                    numberOfLikes++;
                }
                if(readALine=="3")
                {
                    break;
                }
            }
            while (aNumber == 5);


        }
    }
}
