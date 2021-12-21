namespace AdventOfCode.Days;

public sealed class Day01 : CustomDirBaseDay
{
    private readonly int[] _input;
    
    private static int DepthCheck(int[] input) => (
        from it in input.Zip(input.Skip(1))
        where it.First < it.Second
        select 1
    ).Sum();
    
    private static int DepthCheckWindowed(int[] input) => DepthCheck((
        from it in input.Zip(input.Skip(1), input.Skip(2))
        select it.First + it.Second + it.Third
    ).ToArray());

    public Day01()
    {
        var textInput = File.ReadAllLines(InputFilePath);
        _input = (from text in textInput select Convert.ToInt32(text)).ToArray();
    }

    public override ValueTask<string> Solve_1() => new(
        DepthCheck(_input).ToString()
        );

    public override ValueTask<string> Solve_2() => new(
        DepthCheckWindowed(_input).ToString()
    );
}
