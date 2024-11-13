using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Globalization;
using Store.Reviews;

namespace Benchmarks;

[JsonExporterAttribute.Full]
[MemoryDiagnoser]
public class ReviewValidationBenchmark
{
    private const string SampleData = "This is a sample review text with some disallowed words.";
    private const char ReplacementChar = '*';
    private static readonly CultureInfo SampleCulture = CultureInfo.InvariantCulture;

    [Benchmark]
    public void BenchmarkStringValidation()
    {
        ReviewValidation.StringValidation(SampleData, ReplacementChar, SampleCulture);
    }

    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<ReviewValidationBenchmark>();
    }
}
