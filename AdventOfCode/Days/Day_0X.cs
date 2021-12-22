namespace AdventOfCode.Days;

public sealed class Day0X : CustomDirBaseDay
{
    private readonly int[] _input;
    
    public Day0X()
    {   
        var textInput = File.ReadAllLines(InputFilePath);
        _input = null;
    }

    public override ValueTask<string> Solve_1() => new("Solution 1");

    public override ValueTask<string> Solve_2() => new("Solution 2");
}
