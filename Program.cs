using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctci_6_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var arr = new int[3]{ 0,1,2 };
            reverse(arr);
        }

        private static void reverse(int[] array){
            Console.WriteLine(String.Join("", array));
            for(int i = 0; i < array.Length / 2; i++){
                int other = array.Length -i - 1;
                int temp = array[i];
                array[i] = array [other];
                array[other] = temp;
            }
            Console.WriteLine(String.Join("", array));
        }
    }
}
