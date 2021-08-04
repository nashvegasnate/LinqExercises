using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 8, 3, 3, 11, 23, 9, 9, 9, 2, 7, 300, 300 };

            //SORTING OPERATIONS: OrderBy, OrderByDescending, and Reverse
            
            Console.WriteLine("Begin the sorting operations");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            var orderedNumbers = numbers.OrderBy(num => num);

            foreach (int num in orderedNumbers)
            {
                Console.WriteLine(num);
            }

            var descendingOrderNumbers = numbers.OrderByDescending(num => num);

            Console.WriteLine($"descendingOrderNumbers: { String.Join(',', descendingOrderNumbers)}");
            
            foreach (int num in orderedNumbers)
            {
               Console.WriteLine(num);
            }


            //the return type of reverse is void, so you can't store anything
            //numbers.Reverse();
            //Console.WriteLine("Ordered:", numbers);


            //AGGREGATION OPERATIONS
            // Max, Sum, Min, Average, Count
            Console.WriteLine("Begin the aggregation operations");

            var maxNumber = numbers.Max();
            Console.WriteLine(maxNumber);

            var sumOfNumbers = numbers.Sum();
            Console.WriteLine(sumOfNumbers);

            var averageNumber = numbers.Average();
            Console.WriteLine(averageNumber);

            var count = numbers.Count();
            Console.WriteLine(count);

            //Where is like array.filter - returns a new collection
            //filtering data
            //num below is taco. Can be anything
            var biggerNumbers = numbers.Where(num => num > 9);
            Console.WriteLine($"biggerNumbers: { String.Join(',', biggerNumbers)}");

            //Select is like array.map - returns a new collection of IEnumerable<T>
            //Transforming data- projecting operation
            var biggerNumbers2 = numbers.Select(num => num * 12);
            Console.WriteLine($"biggerNumbers2: { String.Join(',', biggerNumbers2)}");

            //List<int> newNewNumbers = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };

            var firstNumber = numbers.First();
            Console.WriteLine(firstNumber);

            var lastNumber = numbers.Last();
            Console.WriteLine(lastNumber);

            //First matching item
            //this one shows the first matching number that is greater than 9
            var firstMatchingNumber = numbers.Where(num => num > 9).First();
            var firstMatchingNumber2 = numbers.First(num => num > 9);

            Console.WriteLine(firstMatchingNumber);
            Console.WriteLine(firstMatchingNumber2);

            //QUANTIFIER OPERATIONS
            //returns a boolean
            //all, any, and contains

            Console.WriteLine("Begin the quantifier operations");

            var allNumbers = numbers.All(c => c > 5);
            Console.WriteLine(allNumbers);

            var anyNumbers = numbers.Any(c => c < 5);
            Console.WriteLine(anyNumbers);

            var containsNumber = numbers.Contains(7) || numbers.Contains(3);
            Console.WriteLine(containsNumber);

            //SET OPERATIONS
            Console.WriteLine("Begin the set operations");

            List<int> badNumbers = new List<int>() { 19, 11, 3, 9 };

            var onlyGoodNumbers = numbers.Except(badNumbers);
            Console.WriteLine($"onlyGoodNumbers: {String.Join(',', onlyGoodNumbers)}");

            var uniqueNumbers = numbers.Distinct();
            Console.WriteLine($"uniqueNumbers: {String.Join(',', uniqueNumbers)}");

            //take the first 3 numbers from the list, skip the first 5 numbers on the list, then append the next 2 numbers after that

            var firstThreeNumbersAndTheSixth = numbers.Take(3).Concat(numbers.Skip(5).Take(2));
            Console.WriteLine($"firstThreeNumbersAndTheSixth: {String.Join(',', firstThreeNumbersAndTheSixth)}");

            var animals = new List<Animal> {
            new Animal { Type = "Pikachu", HeightIninches = 24, WeightInPounds = 10 },
            new Animal { Type = "Charzard", HeightIninches = 72, WeightInPounds = 250},
            new Animal { Type = "Bulbasaur", HeightIninches = 12, WeightInPounds = 450},
            new Animal { Type = "JigglyPuff", HeightIninches = 9, WeightInPounds = 5},
            new Animal {Type = "Cthulhu", HeightIninches = 96, WeightInPounds = 375},
            };

            var animalsThatStartWithC = animals.Where(animal => animal.Type.ToLower().StartsWith('c'));
           
            foreach (var animal in animalsThatStartWithC)
            {
                Console.WriteLine(animal.Type);
            }

            //Group a collection by a given key (based on a function)

            //this one groups the animals by the first character in the Type, then loops them and prints out each animal
            var groupAnimals = animals.GroupBy(animal => animal.Type.First());

            foreach (var animalGroup in groupAnimals)
            {
                //GroupBy() above creates the Key below to keep track of items in the group
                Console.WriteLine($"Animals that start with {animalGroup.Key}");

                foreach (var animal in animalGroup)
                {
                    Console.WriteLine(animal.Type);
                }
            }
        }
    }
}
