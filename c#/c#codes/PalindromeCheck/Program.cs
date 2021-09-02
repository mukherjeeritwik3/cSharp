using System;
// Write code to check a String is palindrome or not?

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            string reverseInp = "";
            for(int i= inp.Length-1;i!=-1;i--){
                reverseInp+=inp[i];
            }
            if(inp.Equals(reverseInp)){
                Console.WriteLine("Palindrome!");
            }
            else{
                Console.WriteLine("Not Palindrome!");
            }
        }
    }
}
