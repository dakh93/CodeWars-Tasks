using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars_Tasks
{
    public class StartUp
    {
        public static void Main()
        {
            var intervals = new (int, int)[]
            {
                (1, 4),
                (7, 10),
                (3, 5)
            };

            ////THIS IS THE BEST SOLUTION FROM CodeWars
            //var bestSolution = intervals
            //    .SelectMany(i => Enumerable.Range(i.Item1, i.Item2 - i.Item1))
            //    .Distinct()
            //    .Count();

            var sumOfIntervalResult = SumIntervals(intervals);

            Console.WriteLine(sumOfIntervalResult);
        }
            static int SumIntervals((int, int)[] intervals)
            {


                ////  X | Y - EXPECTED ANSWER : 7
                //(1, 4),
                //(7, 10),
                //(3, 5)



                if (intervals.Length == 0)
                {
                    return 0;
                }

                List<Interval> listOfIntervals = CreateIntervals(intervals);

                var orderedIntervals = listOfIntervals
                    .OrderBy(x => x.X)
                    .ThenBy(x => x.Y)
                    .ToList();



                var list = new List<Interval>();
                list.Add(orderedIntervals[0]);
                var listIndex = 0;
                for (int i = 1; i < orderedIntervals.Count(); i++)
                {
                    var currInt = list[listIndex];
                    var nextInt = orderedIntervals[i];

                    if (currInt.Y >= nextInt.X)
                    {
                        int yValue = currInt.Y;
                        if (currInt.Y < nextInt.Y)
                        {
                            yValue = nextInt.Y;
                        }
                        var newInt = new Interval(currInt.X, yValue);
                        list[listIndex] = newInt;
                    }
                    else
                    {
                        list.Add(nextInt);
                        listIndex++;
                    }

                }

                var result = list.Sum(x => x.Y - x.X);

                return result;

            }

            static List<Interval> CreateIntervals((int, int)[] intervals)
            {
                var listOfIntervals = new List<Interval>();

                foreach (var interval in intervals)
                {
                    var currInterval = new Interval(interval.Item1, interval.Item2);

                    listOfIntervals.Add(currInterval);

                }

                return listOfIntervals;
            }
        
    }
}
