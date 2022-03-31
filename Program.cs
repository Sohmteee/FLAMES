using System;
using System.Text;

namespace SoulMate
{
    class SoulMate
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first name: ");
            String a = Console.ReadLine().ToLower(); //converts the input to lower case for easier use

            Console.Write("Enter the second name: ");
            String b = Console.ReadLine().ToLower();

            StringBuilder plus = new StringBuilder(); 
            char[] aa, bb;

            aa = a.ToCharArray(); //the names are converted to char arrays so that we can easily work with their letters
            bb = b.ToCharArray();

            int plusLength = 0;

            for (int i = 0; i < aa.Length; i++)
            { //this picks out a single letter from the first name

                for (int j = 0; j < bb.Length; j++)
                {//then it checks each letter of the second name
                    if (aa[i] == bb[j])
                    {/*if the selected letter of the first name is the same as the current letter of the second one,
					it stores that letter and 'deletes' both letters. More like canceling them out*/
                        plus.Append(aa[i]);
                        plusLength++;
                        aa[i] = ' ';
                        bb[j] = ' ';
                    }
                }
            }

            /*since the .length() method can't be accurately used with a StringBuilder variable
		    we'll have to use a naive way to find out it's length*/
            int count = 0;
            String pp = plus.ToString();
            char[] p = pp.ToCharArray();

            for (int i = 0; i < plusLength; i++)
            {
                if (p[i] != ' ')
                {
                    count++;
                }
            }

            Console.WriteLine();

            //we find out the remaining letters after cancelling out the common corresponding letters from each name
            int length = (a.Length + b.Length) - (count * 2);
            Console.WriteLine("Result: " + length);
            int rem = length % 6; 

            Console.Write("Using the FLAMES analysis, ");

            switch (rem)
            {
                case 1:
                    Console.WriteLine("You two should be just friends");
                    break;

                case 2:
                    Console.WriteLine("You two should be lovers");
                    break;

                case 3:
                    Console.WriteLine("You two should be admirers");
                    break;

                case 4:
                    Console.WriteLine("You two should get married");
                    break;

                case 5:
                    Console.WriteLine("You two should be enemies");
                    break;

                case 0:
                    Console.WriteLine("You two should be secret admirers");
                    break;

            }

        }
    }
}