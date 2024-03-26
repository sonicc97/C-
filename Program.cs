using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = { "Honda", "Mazda", "Toyota" };

            //cars[1] = "Audi";

            //for (int i = 0; i < cars.Length; i++) { 
            // Console.WriteLine(cars[i]);
            //}

            String[] honda = { "Civic", "Accord", "Jazz" };
            String[] audi = { "rsaudi", "Audi a", "Audi" };
            String[] usa = { "San Francisko", "Seattle", "Kansas" };


            String[,] cars = { { "Civic", "Accord", "Jazz" },
                { "rsaudi", "Audi a", "Audi" },
                { "San Francisko", "Seattle", "Kansas" } };

            cars[1, 0] = "Germany";
            cars[2, 1] = "Dallas";

            //foreach ( String car in cars)
            //{
                //Console.WriteLine(car);
            //}

            for ( int i = 0; i <cars.GetLength(0); i++)
            {
                for (int j = 0; j < cars.GetLength(1); j++)
                {
                    Console.Write(cars[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}