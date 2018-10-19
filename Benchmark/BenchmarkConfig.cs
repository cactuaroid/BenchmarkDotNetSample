using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;

namespace Benchmark
{
    public class BenchmarkConfig : ManualConfig
    {
        // https://benchmarkdotnet.org/articles/configs/configs.html

        public BenchmarkConfig()
        {
            // 実行方法
            // ShortRunを使うとサクッと終わらせられる、デフォルトだと本気で長いので短めにしとく。
            // ShortRunは LaunchCount=1  TargetCount=3 WarmupCount = 3 のショートカット
            Add(Job.ShortRun);

            // ベンチマーク結果
            Add(MarkdownExporter.GitHub); // GitHub対応のMarkdown形式で出力する
            Add(MemoryDiagnoser.Default); // メモリアロケーションの情報も出力する
        }
    }
}
