using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_string
{
    class Program
    {
        static void Main(string[] args)
        {

            stringt();
            //arr()
            Console.ReadKey();
        }
        public static void arr()
        {
            //array is a reference type data
            //dicliar a aray
            int[] arr1 = new int[5];//1st way
            //Array a = new Array[5];
            int[] arr2 = new int[5] { 0, 1, 3, 4, 5 };//2nd way
            int[] arr3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };//3rd way

            foreach (int a in arr2)
            {
                Console.WriteLine(a);
            }

            //multidimentional array
            int[,] mular1 = new int[2, 3];//1st way
            int[,] mular2 = new int[,] { { 10, 29 }, { 30, 40 } };
            mular1[0, 1] = 10;


            //variable[ row , column ] = values
            //jagged arrayes- also called arrayes of array

            int[][] array2 = new int[3][];
            array2[0] = new int[3] { 1, 2, 3 };
            array2[1] = new int[] { 4, 5, 6, 7, 8, 9 };
            array2[2] = new int[10];
            // Console.WriteLine(array2[0][1]);//2



            //Console.WriteLine(mular1[0, 1]);
            Console.ReadKey();


        }
        public static void stringt()
        {
            //string cancating
            string firstname, lastname;
            firstname = "Mushfiqur";
            lastname = "Rahman";
            string name = firstname +" "+ lastname;//
            Console.WriteLine(name);
            string fulname =  String.Concat(firstname,"+", lastname);
            Console.WriteLine(fulname);
            Console.WriteLine("Hello {0}", firstname + " " + lastname);
            Console.WriteLine("how are you " + firstname + " " + lastname +" ? ");

            // by using string constractor
            char[] letters = { 'H', 'E', 'L', 'L', 'O' };
            string st = new string(letters);
            Console.WriteLine("Hello " + st);

            //for convert string to arr
            char[] let = st.ToCharArray();
            foreach (char a in let)
            {
                Console.WriteLine(a);
            }

            //methods returning string

            string[] words = { "how", "are", "you", "?" };
            string sentence = String.Join(" ", words);
            Console.WriteLine(sentence);



            //upper lower case in string
            string sentences = "heLlo WoRld";
            string lower = sentences.ToLower();
            string upper = sentences.ToUpper();
            Console.WriteLine("Upper " + upper + " Lower " + lower);

            //perticular scarch
            string bd = "I love my country very much";
            Console.WriteLine(bd.StartsWith("I"));//if start with I it will return true either false
            Console.WriteLine(bd.EndsWith("h"));//if ends with with h it willl return true eiher false
            Console.WriteLine(bd.Contains("very"));






        }
    }
}
