﻿// Copyright (c) {companyName}.  All rights reserved.
// Licensed under the {licenseName} license.  See {licenseFile} file in the project root for
// full license information.

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
        // This tests aggregation of code coverage across test runs.
#if NETCOREAPP2_1
        Assert.Equal(3, Calculator.Add(1, 2));
#else
        Assert.Equal(-1, Calculator.Subtract(1, 2));
#endif
    }
}
