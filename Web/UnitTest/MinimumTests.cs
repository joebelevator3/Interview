using LearningStarter;
using NUnit.Framework;

namespace UnitTest;

public class MinimumTests
{
    [Test]
    public void Test1()
    {
        var minumum = MinimumFinder.FindMinimum(Enumerable.Range(1,1));
        Assert.That(1, Is.EqualTo(minumum));
    }
    
    [Test]
    public void Test2()
    {
        var minumum = MinimumFinder.FindMinimum(Enumerable.Range(1,2));
        Assert.That(1, Is.EqualTo(minumum));
    }
    
    [Test]
    public void Test3()
    {
        var minumum = MinimumFinder.FindMinimum(Enumerable.Range(1, 10).Reverse().Select(x => 100 * x));
        Assert.That(100, Is.EqualTo(minumum));
    }
    
    [Test]
    public void Test4()
    {
        var minumum = MinimumFinder.FindMinimum(Enumerable.Range(-10,10));
        Assert.That(-10, Is.EqualTo(minumum));
    }
    
    [Test]
    public void Test5()
    {
        var minumum = MinimumFinder.FindMinimum(Enumerable.Range(1,1));
        Assert.That(1, Is.EqualTo(minumum));
    }
}