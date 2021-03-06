using System;

namespace P1_ReverseString
{
    class CovertStringToReverseOrder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string line");
            string word = Console.ReadLine();
            string reverseword = ReverseWithSequentialManner(word);
            Console.WriteLine(reverseword.ToLower());
        }
        public static string ReverseWithSequentialManner(string word)
        {
          
            string reverse = "";
            string reversedsequence = "";
            int length = word.Length;
            int countspace = 0;
            int[] arr;
            int count=0;
            char space = ' ';
            int i = 0;
            while (length - 1 >= 0)
            {
                if (word[length - 1] == ' ')
                {
                    
                    countspace = countspace + 1;
                    length = length - 1;

                }
                length = length - 1;
            }
            countspace = countspace + 2;
            arr = new int[countspace];
            length = word.Length;
            while (length>0)
            {
                if(word[length-1]==' ')
                {
                    i = i + 1;
                    length = length - 1;
                    arr[i] = count;
                    count = 0;
                    
                }
                else
                {
                    reverse = reverse + word[length - 1];
                    count = count + 1;
                    length = length - 1;
                    
                }
            }
            i = i + 1;
            arr[i] = count;
            i = 0;
            countspace = 0;
            int num = arr.Length;
            
            foreach (char c in reverse)
            {
                
                if(countspace==arr[num-1])
                {
                    reversedsequence = reversedsequence + space;
                    countspace = 0;
                    i = i + 1;
                    num = num -1;
                }
                reversedsequence = reversedsequence + c;
                countspace = countspace + 1;
                
            }
            return reversedsequence;
        }
    }
}
