namespace AdventOfCode;

public abstract class CustomDirBaseDay : BaseDay
{
    public string TestInputFileDirPath { get; set; }
    protected override string InputFileDirPath => TestInputFileDirPath;

    protected CustomDirBaseDay()
    {
        TestInputFileDirPath = base.InputFileDirPath;
    }
}