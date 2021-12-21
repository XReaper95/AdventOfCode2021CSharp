using System;
using System.Threading.Tasks;
using AdventOfCode.Days;
using NUnit.Framework;

namespace AdventOfCode.Tests;

public class Tests
{
    [TestCase(typeof(Day01), "AdventOfCode.Tests/Inputs", "7", "5")]
    public async Task Test(Type type, string inputFileDirPath, string sol1, string sol2)
    {
        // Can't use BaseDay since some of them aren't days, but you probably can
        if (Activator.CreateInstance(type) is CustomDirBaseDay instance)
        {
            instance.TestInputFileDirPath = inputFileDirPath;
            
            Assert.AreEqual(sol1, await instance.Solve_1());
            Assert.AreEqual(sol2, await instance.Solve_2());
        }
        else
        {
            Assert.Fail($"{type} is not a BaseProblem");
        }
    }
}