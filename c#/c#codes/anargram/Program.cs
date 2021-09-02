using System;
// two string to check anagram
namespace anargram
{
    class Program
    {
        public static int countOccurances(string s, char c){
            int count =0;
            for(int i=0;i<s.Length;i++){
                if(s[i]==c)
                count+=1;
            }
            return count;
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine().ToLower();
            string b = Console.ReadLine().ToLower();
            bool flag = true;
            if(a.Length==b.Length){
                for(int i =0; i<a.Length;i++){
                    if(b.Contains(a[i])){
                        int aCount = countOccurances(a,a[i]);
                        int bCount = countOccurances(b,a[i]);
                        if(aCount==bCount){
                            flag=true;
                        }
                        else{
                            flag = false;
                            break;
                        }
                        
                    }
                    else{
                        flag=false;
                        break;
                    }
                }
            }
            else{
                flag=false;
            }

            if(flag==true){
                Console.WriteLine("Angram!");
                
            }
            else{
                Console.WriteLine("Not Angram!");
            }
        }
    }
}
