using System;

namespace P1_T1
{
    class Program
    {
        static void wordFreq(string sentence, out string[] uniqueWords, out int[] frequencies)
        {


            // Remove punctuation marks
            sentence = sentence.Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "").Replace(":", "");

            // Split the sentence into words
            string[] words = sentence.Split(' ');


            uniqueWords = new string[words.Length];
            frequencies = new int[words.Length];

            int count = 0;

            foreach (string word in words)
            {
                bool found = false;

                // Check if the word is already in the uniqueWords array
                for (int j = 0; j < count; j++)
                {
                    if (uniqueWords[j] == word)
                    {
                        // Word already exists, increment its frequency
                        frequencies[j]++;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    // Add the new word to the lists
                    uniqueWords[count] = word;
                    frequencies[count] = 1;
                    count++;

                }


            }


            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{uniqueWords[i]}: {frequencies[i]}");
            }

            Array.Resize(ref uniqueWords, count);
            Array.Resize(ref frequencies, count);
        }



        static string[] randomGenerator(string[] sentence, int[] frequencies, int N)
        {
            Random random = new Random();
            string[] randomsentences = new string[N];
            for (int i = 0; i < N; i++)
            {
                string[] newwords = new string[5];

                for (int j = 0; j < 5; j++)
                {

                    int ranomIndex = random.Next(sentence.Length);
                    newwords[j] = sentence[ranomIndex];

                }

                string sentences = string.Join(" ", newwords);
                
                randomsentences[i] = sentences;
            }

            return randomsentences;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence:");
            string input = Console.ReadLine();
            // Call the WordFrequency method

            string[] words;
            int[] frequencies;
            wordFreq(input, out words, out frequencies);



            Console.Write("Enter a Number: ");
            int N = int.Parse(Console.ReadLine());
            string[] sentences = randomGenerator(words, frequencies, N);
           
            
            foreach (string generatedSentence in sentences)
            {
                Console.WriteLine(generatedSentence);
            }
        }

    }
}