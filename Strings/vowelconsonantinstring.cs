// 9. Write a program in C# Sharp to count a total number of vowel or consonant in a string. Go to the editor
// Test Data :
// Input the string : Welcome to w3resource.com
// Expected Output :

// The total number of vowel in the string is : 9 
// The total number of consonant in the string is : 12 

using System;

namespace vowelconsonentinstring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, ln, vowel, consonant;
            string str;

            Console.WriteLine("\n\nCount a total number of vowel or consonant in a sring");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("\n=> Input the string : ");
            str = Console.ReadLine();

            Console.WriteLine("\n\nExpected Output :");
            Console.WriteLine("--------------------\n");

            vowel = 0;
            consonant = 0;
            ln = str.Length;

            for (i = 0; i < ln; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }

                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'a' && str[i] <= 'z'))
                {
                    consonant++;
                }
            }

            Console.WriteLine("=> The total number of vowel in the string is : {0}\n", vowel);
            Console.WriteLine("=> The total number of consonant in the string is : {0}\n\n", consonant);
        }
    }
}