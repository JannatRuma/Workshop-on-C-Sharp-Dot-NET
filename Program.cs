using System;

namespace Array_2nd_batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            /*
            int[] a = new int[5] {1,2,3,4,5};
            int[] b = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //.WriteLine(a[0]);
            int[,] c = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(c[1,0]);
            int[,] d = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            

            //string

            string firstName = "Mushfiqur";
            string lastName = "Rahman";
            string fullName = firstName +" "+ lastName;
            string name = String.Concat(firstName, " ", lastName);
            // Console.WriteLine(name);
            //Console.WriteLine("hello {0} {1}",firstName,lastName);
            Console.WriteLine("hello "+ firstName +" "+lastName);
             

            char[] letters = { 'M', 'u', 's', 'h', 'f', 'i', 'q', 'u', 'r' };
            string name = new string(letters);
            Console.WriteLine(letters);
            
            string name = "Mushfiqur";
            char[] arr = name.ToCharArray();
            foreach (char vari in arr)
            {
                Console.WriteLine(vari);
            }
            
            string[] names = { "how", "Are", "You","All","?" };
            string sentence = String.Join("_",names);
            Console.WriteLine(sentence);
            */
            string name = "MuShFiQur";
            string upper = name.ToUpper();
            string lower = name.ToLower();
            Console.WriteLine("Upper - "+upper);
            Console.WriteLine("Lower - "+lower);





            Console.ReadKey();
        }
    }
}
