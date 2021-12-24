using System;
using System.Threading.Tasks;
using AdventOfCode.Days;
using NUnit.Framework;

namespace AdventOfCode.Tests;

public class Tests
{   
    private const string TestFilesDir = "AdventOfCode.Tests/Inputs";
    
    [TestCase(typeof(Day01), "7")]
    [TestCase(typeof(Day02), "150")]
    [TestCase(typeof(Day03), "198")]
    public async Task TestPart1(Type type, string solution)
    {
        if (Activator.CreateInstance(type) is CustomDirBaseDay instance)
        {
            instance.TestInputFileDirPath = TestFilesDir;
            
            Assert.AreEqual(solution, await instance.Solve_1());
        }
        else
        {
            Assert.Fail($"{type} is not a CustomDirBaseDay");
        }
    }
    
    [TestCase(typeof(Day01), "5")]
    [TestCase(typeof(Day02), "900")]
    [TestCase(typeof(Day03), "230")]
    public async Task TestPart2(Type type, string solution)
    {
        if (Activator.CreateInstance(type) is CustomDirBaseDay instance)
        {
            instance.TestInputFileDirPath = TestFilesDir;
            
            Assert.AreEqual(solution, await instance.Solve_2());
        }
        else
        {
            Assert.Fail($"{type} is not a CustomDirBaseDay");
        }
    }
}