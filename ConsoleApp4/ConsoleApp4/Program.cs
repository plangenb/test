using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string json = @"{'A': 'Test1', 'B': 'Test2', 'People' : [{
                'Omschrijving': 'Department1',
                'Aantal': 1
            },{
                'Omschrijving': 'Department2',
                'Bedrag': 99.9
            }]}";

            var persons = JsonConvert.DeserializeObject<Container>(json, new PersonConverter());

            Console.WriteLine("Hello World!");
        }
    }
}
