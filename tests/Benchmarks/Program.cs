using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;

namespace Benchmarks;

public class Program
{
    public static void Main(string[] args)
    {
        var config = ManualConfig.Create(DefaultConfig.Instance).WithArtifactsPath("artifacts").WithOptions(ConfigOptions.JoinSummary);
        // var reviewValidationSummary = BenchmarkRunner.Run<ReviewValidationBenchmark>(config);
        var stringValidationBenchmark = BenchmarkRunner.Run<StringValidationBenchmark>(config);

    }
}
