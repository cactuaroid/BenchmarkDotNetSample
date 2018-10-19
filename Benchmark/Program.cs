using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Benchmark
{
    // こちらの記事を参考にしています
    // http://engineering.grani.jp/entry/2017/07/28/145035
    // http://neue.cc/2017/08/20_557.html

    // Releaseビルドに設定し、デバッグなし実行（Ctrl+F5）で起動して計測します

    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DictionaryBenchmark>();
        }
    }
}
