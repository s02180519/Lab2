using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Numerics;
using Lab1_2;

namespace Lab1
{
    class Program
    {

        static void Main(string[] args)
        {

            V1MainCollection element_collection = new V1MainCollection();
            element_collection.AddDefaults();
            Console.WriteLine("\n\n*********************\nLab_2*");
            Console.WriteLine("Exercise 1");
            V1DataCollection V1DataCollection_element = new V1DataCollection("init.txt");
            Console.WriteLine(V1DataCollection_element.ToLongString("{0,3:00.00}"));
            Console.WriteLine("\n\n*********************\nExercise 2");
            Console.WriteLine("max measurement`s count: " + element_collection.max_count + "\n\nelements in descending order\n");
            foreach (var elem in element_collection.V1Data_ordered_by_coordinates_length)
            {
                // Console.WriteLine("OK");
                Console.WriteLine(elem.ToString("{0,3:00.00}"));
            }
            Console.WriteLine("\n***********************\none time t");
            foreach (var elem in element_collection.time_one_time)
            {
                Console.WriteLine(/*elem.ToString("{0,3:00.00}")*/String.Format("{0,3:00.00}", elem));
            }
            Console.ReadLine();
        }
    }
}