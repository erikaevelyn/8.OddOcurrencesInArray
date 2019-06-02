using System;

namespace _8.OddOcurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] array = new[]{9,7,9,3,9,3,9};
            
            if(sol.solution(array) == 0){
                Console.WriteLine($"Array incorrecto");
            }else{
                Console.WriteLine($"Result: {sol.solution(array)}");
            }
            
        }
    }
}
