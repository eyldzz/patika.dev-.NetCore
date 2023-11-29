using System.Collections;

namespace collectionQuestion3
{
    //Write a program that stores the vowels in the sentence entered from the keyboard in an array and sorts the elements of the array.

    internal class Program
    {
        public static void Vowels(string param)
        {
            ArrayList arr = new ArrayList();
            string vowelwords = "aeıioöuüAEIİOÖUÜ";
            for (int i = 0;i<param.Length;i++)
            {
                if (vowelwords.Contains(param[i]))
                    arr.Add(param[i]);
            }

            arr.Sort();
            Console.Write("sorted vowel words: ");
            foreach (var i in arr)
                Console.Write(i + " ");
        }
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Vowels(sentence);
        }
    }
}