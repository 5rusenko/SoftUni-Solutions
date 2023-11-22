using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        var result = CharacterRange.GetRange('a', 'b');
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        var result = CharacterRange.GetRange('b', 'a');
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        var result = CharacterRange.GetRange('a', 'c');
        Assert.AreEqual("b", result);
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        var result = CharacterRange.GetRange('d', 'g');
        Assert.AreEqual("e f", result);
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        var result = CharacterRange.GetRange('x', 'z');
        Assert.AreEqual("y", result);
    }
}
