using System;

namespace FUNDAMENTALSI
{
    class Program
    {
        static void Main(string[] args)
        {
        //Create a Loop that prints all values from 1-255
           for(int i =1 ; i<=255 ; i++){
                Console.WriteLine(i);
           }
        //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int y =1;y<=100;y++){
                if (y%3==0||y%5==0){
                Console.WriteLine(y);
                }
            }
        //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
                for (int y =1;y<=100;y++){
                 if (y%3==0&&y%5==0){
                Console.WriteLine("FizzBuzz");
                }
                 else if (y%3==0){
                Console.WriteLine("Fizz");
                }else if (y%5==0){
                     Console.WriteLine("Buzz");
                }
            
            }
        }
    }
}
