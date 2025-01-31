# Your Library

***An awesome template for your awesome library***

[![Azure Pipelines status](https://dev.azure.com/fosterjakea/oss/_apis/build/status/fosterjakea.Library.Template?branchName=master)](https://dev.azure.com/fosterjakea/oss/_build/latest?definitionId=14&branchName=master)
[![GitHub Actions status](https://github.com/fosterjakea/Library.Template/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/fosterjakea/Library.Template/actions/workflows/build.yml)
[![codecov](https://codecov.io/gh/fosterjakea/Library.Template/branch/master/graph/badge.svg?token=KMXAJ5MEVS)](https://codecov.io/gh/fosterjakea/Library.Template)
[![license](https://img.shields.io/github/license/fosterjakea/Library.Template)](https://github.com/fosterjakea/Library.Template/blob/master/LICENSE.md)

## Features

* Follow the best and simplest patterns of build, pack and test with dotnet CLI.
* Init script that installs prerequisites and auth helpers, supporting both non-elevation and elevation modes.
* Static analyzers: [FxCop](https://docs.microsoft.com/en-us/visualstudio/code-quality/fxcop-analyzers?view=vs-2019) and [StyleCop](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)
* Read-only source tree (builds to top-level bin/obj folders)
* Auto-versioning (via [Nerdbank.GitVersioning](https://github.com/dotnet/nerdbank.gitversioning))
* Builds with a "pinned" .NET Core SDK to ensure reproducible builds across machines and across time.
* Automatically pack the library and publish it as an artifact, and even push it to some NuGet feed for consumption.
* Testing
  * Testing on .NET Framework, multiple .NET Core versions
  * Testing on Windows, Linux and OSX
  * Tests that crash or hang in Azure Pipelines automatically collect dumps and publish as a pipeline artifact for later investigation.
* Cloud build support
  * YAML based build for long-term serviceability, and PR review opportunities for any changes.
  * Azure Pipelines and GitHub Action support
  * Emphasis on PowerShell scripts over reliance on tasks for a more locally reproducible build.
  * Code coverage published to Azure Pipelines
  * Code coverage published to codecov.io so GitHub PRs get code coverage results added as a PR comment

## Consumption

Once you've expanded this template for your own use, you should **run the `Expand-Template.ps1` script** to customize the template for your own project.

Further customize your repo by:

1. Verify the license is suitable for your goal as it appears in the LICENSE.md and stylecop.json files and the Directory.Build.props file's `PackageLicenseExpression` property.
1. Reset or replace the badges at the top of this file.

# README template for future projects
Use headings as required.

## Overview

## Purpose

## Installation

## Usage

## Limitations

## Building

## Disclaimers

## Code of Conduct
