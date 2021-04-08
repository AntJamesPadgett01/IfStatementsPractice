using System;

namespace IfStatementsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;  // repsonds to this variable
            bool isTall = true;




            if (isMale && isTall)       // condition  && - both have to be true... || only one has to be true.
            {
                Console.WriteLine("You are a tall male");
            }


            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }


            else if (!isMale &&  isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }

            else 

            {
                Console.WriteLine("You are not male or not tall");
            }









        }
    }
}
