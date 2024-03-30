using System;

namespace Strings
{
    class String
    {
        //Input:
        public void Input()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();
            Console.Write("The string you entered is : " + str);
        }
        //Length:
        public void Length()
        {
            string str = "Hello World!";
            int l = 0;
            foreach (char c in str) 
            {
                l++;
            }
            Console.WriteLine("Length of string:"+l);   
        }
        //Seperate:
        public void Seperate()
        {
            string str = "Hello";
            foreach (char c in str)
            {
                Console.Write(c + " ");
            }
        }
        //Reverse:
        public void Reverse()
        {
            string str = "Hello";
            string rev = " ";
            for (int i=str.Length-1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine("Reverse string:" + rev);
        }
        //Words:
        public void Words()
        {
            string sentence = "This is a sample sentence";
            int word = 0;
            foreach(char c in sentence)
            {
                if (c == ' ')
                {
                    word++;
                }
            }
            word++;
            Console.WriteLine("Number of words in sentence : " + word);
        }
        //Count:
        public void Count()
        {
            Console.Write("Input the string: ");
            string str = Console.ReadLine();
            int a = 0;
            int d = 0;
            int s = 0;
            foreach (char c in str)
            {
                if(char.IsLetter(c))
                {
                    a++;
                }
                else if (char.IsDigit(c))
                {
                    d++;
                }
                else
                {
                    s++;
                }
            }
            Console.WriteLine("Number of alphabets in sting:" + a);
            Console.WriteLine("Number of digits in sting:" + d);
            Console.WriteLine("Number of special characters in sting:" + s);
        }
        //Copy:
        public void Copy()
        {
            string str1 = "Hello World!";
            int length = str1.Length;
            string str2 = str1;
            int c = 0;
            foreach (char i in str2)
            {
                c++;
            }
            Console.WriteLine("Length of str1: " + length);
            Console.WriteLine("Number of words copied:" + c);
        }
        //Vowels & Consonants:
        public void Count1()
        {
            string str = "Hello World!";
            int v = 0;
            int c = 0;
            foreach (char i in str)
            {
                if(i >= 'a' && i <='z' || i >= 'A' && i <= 'Z')
                {
                    if(i == 'a' || i == 'e'||i == 'i' || i == 'o' || i == 'u' || i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')
                    {
                        v++;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine("Number of Vowels:"+ v);
            Console.WriteLine("Number of Consonatns:" + c);
        }
        //Sort:
        public void Sort()
        {
            string str = "Hello World";
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string sort = new string(arr);
            Console.WriteLine("Sorted string:" + sort);
        }
        //LowerCase-UpperCase:
        public void Swap()
        {
            string str = "Hello World";
            string cstr = " ";
            foreach (char i in str)
            {
                if(char.IsLower(i))
                {
                    cstr += char.ToUpper(i);
                }
                else
                {
                    cstr += char.ToLower(i);
                }
            }
            Console.WriteLine("Converted string:"+cstr);
        }
        //Compare
        public void Compare() 
        {
            string a = Console.ReadLine();
            Console.WriteLine("stirng 1:"+a);
            string b = Console.ReadLine();
            Console.WriteLine("stirng 2:" + b);
            if (a.Length > b.Length)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }  
    }
}
