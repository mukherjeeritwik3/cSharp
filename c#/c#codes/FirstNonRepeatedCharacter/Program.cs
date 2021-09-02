using System;
// Program to Find first Non Repeated Character
namespace FirstNonRepeatedCharacter
{
    class Program
    {
        public static bool check(string s , char c){
            int count =0;
            for(int i =0; i<s.Length;i++){
                if(s[i]==c){
                    count++;
                }
            }
            if(count==1){
                return true;
            }
            else{
                return false;
            }
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            char ans =' ';
            
            for(int i =0; i<a.Length;i++){
                if(check(a,a[i])){
                    ans=a[i];
                    break;
                }    
            }
            if(ans==' '){
                Console.WriteLine("No first repeated character!");
            }
            else{
                Console.WriteLine(ans);
            }
        }
    }
}
