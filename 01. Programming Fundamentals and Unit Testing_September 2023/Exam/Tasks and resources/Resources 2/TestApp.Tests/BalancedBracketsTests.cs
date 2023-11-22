using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        var result = BalancedBrackets.IsBalanced(new string[] { });
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        var result = BalancedBrackets.IsBalanced(new string[] { "(", ")", "(", ")" });
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        var result = BalancedBrackets.IsBalanced(new string[] { "(", ")", "(" });
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        var result = BalancedBrackets.IsBalanced(new string[] { ")", "(", ")" });
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        var result = BalancedBrackets.IsBalanced(new string[] { "(" });
        Assert.IsFalse(result);
    }
}
