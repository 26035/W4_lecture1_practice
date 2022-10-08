using System;
using System.Linq;
using System.Collections.Generic;

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
            //Q4();
            //Q5();
            //Q6();
            //Q7();
            //Q8();
            Q9();
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
        static void Q4()
        {
            Console.Write("  write a string \n");
            string word = Console.ReadLine();
            string compressor = Compressor(word);
            Console.Write(compressor);
        }
        static string Compressor(string word)
        {
            int number=0;
            char c = word[0];
            string compressor = "";
            for(int i =0;i<word.Length;i++)
            {
                if(word[i]==c)
                {
                    number = number + 1;
                }
                else
                {
                    compressor = compressor + c + number;
                    number = 1;
                    c = word[i];

                }
            }
            compressor = compressor + c + number;
            return compressor;
        }
        #endregion
        #region Q5
        static void Q5()
        {
            List<int> Amstrong = FindAmstrongNumber();
            foreach(int a in Amstrong)
            {
                Console.Write(a + " ");
            }
            
        }
        static List<int> FindAmstrongNumber()
        {
            
            List<int> Amstrong = new List<int>();
            double sum = 0;
            int division = 100;
            int result = 0;
            for(int i=0;i<=999;i++)
            {
                string number = Convert.ToString(i);
                result = i;
                for (int j = 2; j>=0;j--)
                {
                    
                    sum =Math.Pow(result/ division,3) + sum;
                    result = result % division;
                    division = division / 10;

                }
                if(sum == i)
                {
                    Amstrong.Add(i);
                   
                }
                sum = 0;
                division = 100;
            }
            return Amstrong;
        }

        #endregion
        #region Q6
        static void Q6()
        {

            Console.WriteLine("How much number would you like to give?");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            for(int i =0;i<number;i++)
            {
                Console.Write("write the number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int numberOfDifferentNumbers = 0;
            
            int[,] matrice = new int[2, array.Length];
            for(int i =0;i<999;i++)
            {
                int n = Counter(i, array);
                if(n!=0)
                {

                    matrice[0, numberOfDifferentNumbers] = i;
                    matrice[1, numberOfDifferentNumbers] = n;
                    numberOfDifferentNumbers++;

                }
            }
            PrintM(matrice);
            

        }
        static int Counter(int number, int[] array)
        {
            int counter = 0;
            
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == number)
                    {
                        counter++;
                    }
                }
            
            return counter;
        }
        #endregion
        #region Q7
        static void Q7()
        {
            Console.WriteLine("give a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number ==0)
            {
                Console.WriteLine("the factorial is 1");

            }
            else
            {
                int factorial = Factorial(number);
                Console.WriteLine("the factorial is " + factorial);
            }
        }
        static int Factorial(int number)
        {
            int factorial = 1;
            for(int i=number; i>0;i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        #endregion
        #region Q8
        static void Q8()
        {
            Console.Write("what's the phrase?\n");
            string phrase = Console.ReadLine();
            int nbOfSpaces =CounterOfSpace(phrase);
            Console.WriteLine(nbOfSpaces);
        }
        static int CounterOfSpace(string phrase)
        {
            int nbOfSpaces = 0;
            for(int i =0;i<phrase.Length; i ++)
            {
                if(phrase[i]==' ')
                {
                    nbOfSpaces++;
                }
            }
            return nbOfSpaces;
        }
        #endregion
        #region Q9
        static void Q9()
        {
            Console.Write("write 3 names\n");
            Person n1 = new Person(Console.ReadLine());
            Person n2 = new Person(Console.ReadLine());
            Person n3 = new Person(Console.ReadLine());
            Console.Write("n1 = " + n1 + " n2=" + n2 + " n3=" + n3);
            n1.Name = n1.Destructor();
            Console.WriteLine(n1.ToString());

        }
        #endregion
        // print array
        static void Print(int[] array)
        {
           for(int i =0;i<array.Length;i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        // print matrice
        static void PrintM(int[,] mat)
        {
            for(int i =0;i<mat.GetLength(0);i++)
            {
                for(int j=0;j<mat.GetLength(1);j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
