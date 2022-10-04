using System;

namespace W4_Lecture1_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3_a();
            //Q3();
        }
        #region Q1
        static void Q1()
        {
            string word1 = "abcd";
            string word2 = "a";
            string word3 = "3456";
            word1 = Invert(word1);
            word2 = Invert(word2);
            word3 = Invert(word3);
            Console.Write(word1 + "\n" + word2 + "\n" + word3);
        }
        
        static string Invert(string word)
        {
            char a;
            a = word[0];
            int length = word.Length;
            string newWord = "" + word[length-1];
            for(int i =1;i<length;i++)
            {
                if(i==length-1)
                {
                    newWord = newWord + word[0];

                }
                else
                {
                    newWord = newWord + word[i];
                }
            }
            return newWord;


        }
        #endregion
        #region Q2
        static void Q2()
        {
            int[] array1 = { 7, 5, 2, 3, 4, 5, 0, 9, 9 };
            int[] sequence1 = { 3, 4, 5 };
            int[] array2 = { 5, 3, 4, 8, 9 };
            bool presence1 = Test(array1, sequence1);
            bool presence2 = Test(array2, sequence1);
            int[] array3 = { 8, 1, 2, 1, 3, 4, 5, 21, 45 };
            bool presence3 = Test(array3, sequence1);
            Console.WriteLine(presence1 + "\n" + presence2+ "\n" + presence3);
        }
        static bool Test(int[] array, int[] sequence)
        {
            bool present = false;
            int number = 0;
            int i = 0;

                do
                {
                    if (array[i] == sequence[0])
                    {
                        present = true;

                    }
                    i++;
                } while (present == false);


                for (int j = i; j < i + sequence.Length - 1; j++)

                {

                    if (array[j] != sequence[j - i + 1])
                    {
                        present = false;

                        break;
                    }
                    else
                    {
                        present = true;
                    }
                }
            return present;
        }

        #endregion
        #region Q3
        static void Q3_a()
        {
            Console.WriteLine("give me a character");
            char c = Convert.ToChar(Console.ReadLine());
            int ASCII = Convert.ToInt32(c);
            Console.WriteLine(ASCII);
        }
        static void Q3()
        {
            Console.Write("give me a string \n");
            string word = Console.ReadLine();
            int[] array = ConvertCharToASCII(word);
            array = Sort(array);
            string finalWord = ConvertASCIIToChar(array);
            Console.WriteLine(finalWord);

        }
        static int[] ConvertCharToASCII(string word)
        {
            int[] array = new int[word.Length];
            for(int i =0;i<array.Length; i ++)
            {
                array[i] = Convert.ToInt32(word[i]);
            }
            return array;
        }
        static string ConvertASCIIToChar(int[] array)
        {
            string finalWord = "";
            for(int i = 0;i<array.Length; i ++)
            {
                finalWord = finalWord + Convert.ToChar(array[i]);
            }
            return finalWord;
        }
        static int[] Sort(int[] array)
        {
            for(int i =0;i<array.Length;i++)
            {
                for(int j =0;j<array.Length-i-1;j++)
                {
                    if(array[j]<array[j+1])
                    {
                        int a = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = a;
                    }
                }
            }
            Print(array);
            return array;
        }
        #endregion
        #region Q4

        #endregion
        static void Print(int[] array)
        {
           for(int i =0;i<array.Length;i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
