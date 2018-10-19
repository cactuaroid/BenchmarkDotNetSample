using BenchmarkDotNet.Attributes;
using MyLibrary;

namespace Benchmark
{
    // ベンチマーク本体
    [Config(typeof(BenchmarkConfig))]
    public class DictionaryBenchmark
    {
        private MyClass m_instance = new MyClass();

        // https://benchmarkdotnet.org/articles/features/setup-and-cleanup.html
        [GlobalSetup]
        public void Initialize()
        {
            m_instance.Initialize();
        }

        [Benchmark]
        public int Dictionary()
        {
            return m_instance.GetFromDictionary();
        }

        [Benchmark]
        public int Cache()
        {
            return m_instance.GetFromCache();
        }
    }
}
