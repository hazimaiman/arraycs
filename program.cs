using System.Runtime.CompilerServices;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            //array = a variable that can store multiple value. fixed size
            //foreach loop =  a simpler way to iterate over an array but its an less flexible

            String[] cars = new string[3];


            //String[] cars = {"BWM" , "Mustang", "Myvi" };

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            
            
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }



            Console.ReadKey();
            }
        }
    }





   
