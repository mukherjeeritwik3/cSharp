using System;
//Write a method which will remove any given character from a String?

//Read more: https://javarevisited.blogspot.com/2011/06/top-programming-interview-questions.html#ixzz75JRYy0UX
namespace RemoveString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "BobTheBuilder";
            char[] arr = s.ToCharArray();
            char k = Convert.ToChar(Console.ReadLine());
            string temp = "";
            foreach(char c in arr){
                if(c!=k){
                    temp+=c;
                }
            }
            Console.WriteLine(temp);
        }
    }
}
