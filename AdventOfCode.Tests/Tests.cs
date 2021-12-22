using System;
using System.Threading.Tasks;
using AdventOfCode.Days;
using NUnit.Framework;

namespace AdventOfCode.Tests;

public class Tests
{   
    private const string TestFilesDir = "AdventOfCode.Tests/Inputs";
    
    [TestCase(typeof(Day01), "7", "5")]
    [TestCase(typeof(Day02), "150", "900")]
    public async Task Test(Type type, string sol1, string sol2)
    {
        if (Activator.CreateInstance(type) is CustomDirBaseDay instance)
        {
            instance.TestInputFileDirPath = TestFilesDir;
            
            Assert.AreEqual(sol1, await instance.Solve_1());
            Assert.AreEqual(sol2, await instance.Solve_2());
        }
        else
        {
            Assert.Fail($"{type} is not a CustomDirBaseDay");
        }
    }
}