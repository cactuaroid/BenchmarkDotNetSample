using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    public class MyClass
    {
        private static class Cache<T>
        {
            public static int Value { get; set; }
        }

        private IDictionary<Type, int> Values { get; set; } = new Dictionary<Type, int>();

        public void Initialize()
        {
            Values.Add(typeof(int), 1);
            Values.Add(typeof(uint), 2);
            Values.Add(typeof(short), 3);
            Values.Add(typeof(string), 4);
            Values.Add(typeof(List<int>), 5);
            Values.Add(typeof(List<uint>), 6);
            Values.Add(typeof(List<short>), 7);
            Values.Add(typeof(List<string>), 8);

            Cache<int>.Value = 1;
            Cache<uint>.Value = 2;
            Cache<short>.Value = 3;
            Cache<string>.Value = 4;
            Cache<List<int>>.Value = 5;
            Cache<List<uint>>.Value = 6;
            Cache<List<short>>.Value = 7;
            Cache<List<string>>.Value = 8;
        }

        public int GetFromDictionary()
        {
            return Values[typeof(int)] + Values[typeof(uint)] + Values[typeof(short)] + Values[typeof(string)] +
                Values[typeof(List<int>)] + Values[typeof(List<uint>)] + Values[typeof(List<short>)] + Values[typeof(List<string>)];
        }

        public int GetFromCache()
        {
            return Cache<int>.Value + Cache<uint>.Value + Cache<short>.Value + Cache<string>.Value +
                Cache<List<int>>.Value + Cache<List<uint>>.Value + Cache<List<short>>.Value + Cache<List<string>>.Value;
        }
    }
}
