using BenchmarkDotNet.Attributes;
using System;
using Store.Reviews;

namespace Benchmarks
{
    public class StringValidationBenchmark
    {
        [Benchmark]
        public void BenchmarkStringValidation()
        {
            var testString = "Sample string to validate";
            ReviewValidation.StringValidation(testString, '*', System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}