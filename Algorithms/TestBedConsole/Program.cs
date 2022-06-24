// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using TestBedConsole;

public static class Program
{
    public static void Main()
    {
        var summary = BenchmarkRunner.Run<RansomNotePerformance>();
    }
}

// |                        Method |      Mean |    Error |   StdDev |
//     |------------------------------ |----------:|---------:|---------:|
//     |     BenchmarkCanSpellWordSlow |  56.65 ns | 1.149 ns | 1.074 ns |
//     |     BenchmarkCanSpellWordHash | 125.22 ns | 2.538 ns | 5.882 ns |
//     | BenchmarkCanSpellWordTechLead | 195.52 ns | 3.854 ns | 4.874 ns |
//

public class RansomNotePerformance
{
    [Benchmark]
    public bool BenchmarkCanSpellWordSlow() => RansomNote.CanSpellWordBruteForce(new char[] {'a', 'b', 'c', 'd', 'e', 'f'}, "deaf");
    
    [Benchmark]
    public bool BenchmarkCanSpellWordHash() => RansomNote.CanSpellWordHashed(new char[] {'a', 'b', 'c', 'd', 'e', 'f'}, "deaf");
    
    [Benchmark]
    public bool BenchmarkCanSpellWordTechLead() => RansomNote.CanSpellWordTechlead(new char[] {'a', 'b', 'c', 'd', 'e', 'f'}, "deaf");
    
    
}