using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class Algorithm
    {
        public static List<int> CreateList(bool isSeq, int size, int start, List<int> input)
        {
            RemoveInvalid(size, input);
            
            List<int> finalInput = RemoveConsecutive(input); ;
            if (isSeq == false)
                finalInput = RemoveDuplicates(input);

            List<int> workQue = new List<int>();
            workQue.Add(start);
            foreach (int item in finalInput)
            {
                workQue.Add(item);
            }

            //workQue.ForEach(el => Debug.Print(el.ToString() + " "));

            return workQue;
        }
        
        public static List<int> RemoveDuplicates(List<int> input)
        {
            List<int> q = input.Distinct().ToList();
            return q;
        }

        public static void RemoveInvalid(int max, List<int> input)
        {
            List<int> removeItems = new List<int>();

            foreach(int item in input)
            {
                if(item >= max || item < 0)
                {
                    removeItems.Add(item);
                }
            }

            foreach (int item in removeItems)
                input.Remove(item);
        }

        public static List<int> RemoveConsecutive(List<int> input)
        {
            List<int> results = new List<int>();
            foreach (var element in input)
            {
                if (results.Count == 0 || results.Last() != element)
                    results.Add(element);
            }

            return results;
        }

        public static int CalculateTHM(List<int> input)
        {
            List<int> differences = (input.Zip(input.Skip(1), (x, y) => Math.Abs(y - x))).ToList();

            //differences.ForEach(el => Debug.Print(el.ToString() + " "));

            int THM = differences.Sum(x => Convert.ToInt32(x));

            return THM;
        }

        public static string Differences(List<int> input)
        {
            List<int> differences = (input.Zip(input.Skip(1), (x, y) => Math.Abs(y - x))).ToList();

            string results = "= " + string.Join(" + ", differences);

            return results;
        }

        public static string Solution(List<int> input)
        {
            string[] nums = input.Select(i => i.ToString()).ToArray();
            List<string> block = new List<string>();

            for(int i = 0; i < nums.Length - 1; i++)
            {
                block.Add(" | " + nums[i] + " - " + nums[i + 1] + " | ");
            }

            string results = "= " + string.Join(" + ", block);

            return results;

            //block.ForEach(el => Debug.Print(el.ToString() + " "));
            
        }

        public static List<int> SortSSTF(List<int> input)
        {
            int[] array = input.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int currentValue = array[i];
                int distance = int.MaxValue;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[j] - currentValue) < distance)
                    {
                        distance = Math.Abs(array[j] - currentValue);
                        int temp = array[i + 1];
                        array[i + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            List<int> sorted = new List<int>(array);

            //sorted.ForEach(el => Debug.Print(el.ToString() + " "));

            return sorted;
        }

        public static List<int> SortCLook(int start, List<int> input)
        {
            List<int> descending = input.OrderByDescending(x => x).ToList();
            List<int> sorted = new List<int>(); ;

            foreach(int item in descending)
            {
                if (item <= start)
                {
                    sorted.Add(item);
                }
            }

            foreach (int item in sorted)
                descending.Remove(item);

            foreach (int item in descending)
            {
                sorted.Add(item);
            }

            //sorted.ForEach(el => Debug.Print(el.ToString() + " "));

            return sorted;
        }

        public static List<int> SortLook(int start, List<int> input)
        {
            List<int> descending = input.OrderByDescending(x => x).ToList();
            List<int> sorted = new List<int>(); ;

            foreach (int item in descending)
            {
                if (item <= start)
                {
                    sorted.Add(item);
                }
            }

            foreach (int item in sorted)
                descending.Remove(item);

            descending = descending.OrderBy(x => x).ToList();

            foreach (int item in descending)
            {
                sorted.Add(item);
            }

            sorted.ForEach(el => Debug.Print(el.ToString() + " "));

            return sorted;
        }

        public static List<int> SortScan(int start, List<int> input)
        {
            List<int> descending = input.OrderByDescending(x => x).ToList();
            List<int> sorted = new List<int>(); ;

            foreach (int item in descending)
            {
                if (item <= start)
                {
                    sorted.Add(item);
                }
            }

            foreach (int item in sorted)
                descending.Remove(item);

            sorted.Add(0);

            descending = descending.OrderBy(x => x).ToList();

            foreach (int item in descending)
            {
                sorted.Add(item);
            }

            sorted = RemoveDuplicates(sorted);

            sorted.ForEach(el => Debug.Print(el.ToString() + " "));

            return sorted;
        }

        public static List<int> SortCScan(int start, int size, List<int> input)
        {
            List<int> descending = input.OrderByDescending(x => x).ToList();
            List<int> sorted = new List<int>(); ;

            foreach (int item in descending)
            {
                if (item <= start)
                {
                    sorted.Add(item);
                }
            }

            foreach (int item in sorted)
                descending.Remove(item);

            sorted.Add(0);
            sorted.Add(size - 1);

            foreach (int item in descending)
            {
                sorted.Add(item);
            }

            sorted = RemoveDuplicates(sorted);

            sorted.ForEach(el => Debug.Print(el.ToString() + " "));

            return sorted;
        }
    }
}
