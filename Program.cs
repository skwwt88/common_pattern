using System;
using System.Linq;
using System.Collections.Generic;

namespace CommonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySample();
            ListSample();
            MapSample();
            SetSample();
        }

        static void ArraySample()
        {
            int[] inputs = new int[5];
            int[,] inputs1 = new int[5, 5];
            Console.Out.WriteLine(string.Join(",", inputs1[2,3]));

            Console.Out.WriteLine(inputs.Length);
            inputs[3] = 6;
            inputs = inputs.OrderBy(i => -i).ToArray();
            Array.Sort(inputs, (a, b) => a.CompareTo(b));
            
            Console.Out.WriteLine(string.Join(",", inputs));
            List<int> output = inputs.Select(i => i).ToList();
            Console.Out.WriteLine(string.Join(",", output));
        }

        static void ListSample() {
            List<int> inputs = new List<int>() {1, 2};
            Console.Out.WriteLine(string.Join(",", inputs));
            inputs[1] = 9;
            Console.Out.WriteLine(string.Join(",", inputs));
            Console.Out.WriteLine(inputs.Count());
            inputs.Sort((a, b) => -a.CompareTo(b));
            Console.Out.WriteLine(string.Join(",", inputs));
            inputs.Sort();
            Console.Out.WriteLine(string.Join(",", inputs));
            Console.Out.WriteLine(string.Join(",", inputs.ToArray()));
            inputs.Add(100);
            inputs.AddRange(new int[]{200, 300});
            inputs.Insert(1, 2);
            inputs.Insert(1, 3);
            Console.Out.WriteLine(string.Join(",", inputs));
            inputs.RemoveAt(0);
            inputs.RemoveRange(3,2);
            Console.Out.WriteLine(string.Join(",", inputs));
            Console.Out.WriteLine(inputs.Find(i => i == 300));
            inputs = inputs.OrderBy(_ => Guid.NewGuid()).ToList();
            Console.Out.WriteLine(string.Join(",", inputs));
        }

        static void MapSample(){
            Dictionary<int, int> inputs = new Dictionary<int, int>() { { 1, 2 } };
            Console.Out.WriteLine(inputs.Count());
            inputs[2] = 5;

            var keys = inputs.Keys.ToArray();
            var values = inputs.Values.ToArray();
            var items = inputs.ToList();

            inputs.Remove(3);

            Console.Out.WriteLine(inputs.ContainsKey(2));
            foreach (var item in inputs) {
                Console.Out.WriteLine(item.Key + "," + item.Value);
            }
        }

        static void SetSample() {
            HashSet<int> inputs = new HashSet<int>() {4, 5};

            inputs.Add(7);
            inputs.Remove(4);
            Console.Out.WriteLine(string.Join(",", inputs));
            inputs.UnionWith(new int[]{2, 3, 4});
            inputs.IntersectWith(new int[] {2, 4});
            inputs.ExceptWith(new int[] {4});
            Console.Out.WriteLine(string.Join(",", inputs));

            var list = inputs.Where(i => i > 3).ToList();
            Console.Out.WriteLine(string.Join(",", list));
        }
    }
}
