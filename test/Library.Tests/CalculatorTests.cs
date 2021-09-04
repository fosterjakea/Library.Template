// Copyright (c) COMPANY-PLACEHOLDER. All rights reserved. Licensed under the MIT
// license. See LICENSE.md in the project root for full license information.

using Library;
using Xunit;

public class CalculatorTests
{
    public CalculatorTests()
    {
    }

    [Fact]
    public void AddOrSubtract()
    {
        Assert.Equal(3, Calculator.Add(1, 2));
        Assert.Equal(-1, Calculator.Subtract(1, 2));
    }
}
