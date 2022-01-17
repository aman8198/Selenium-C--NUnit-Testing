using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NUnit.Framework;

[assembly: AssemblyTitle("UnitTestProject1")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("HP")]
[assembly: AssemblyProduct("UnitTestProject1")]
[assembly: AssemblyCopyright("Copyright © HP 2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("0e7a9261-a395-4d1e-9211-2835e7ff5d0f")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

//To define Test Attribute 4th part parallel Testing
[assembly: Parallelizable(ParallelScope.Children)]

//Number of Browsers 4th part parallel testing
//[assembly: LevelOfParallelism(10)]4th parallel testing