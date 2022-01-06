# Highlight
A relatively simple and extensible syntax highlighter written in C#.

**Note**: this is a fork of [krdmllr/highlight](https://github.com/krdmllr/highlight), which is itself a fork adding .NET Standard 2.0 support to [thomasjo/highlight](https://github.com/thomasjo/highlight). Here I removed the HTML, XML and RTF output format engines and all references to System.Drawing. I removed the reference to SixLabors.Fonts by creating a lightweight placeholder and I am now using [arklumpus/VectSharp](https://github.com/arklumpus/VectSharp) to parse colour strings.

I also did some minor changes to the configuration (namely, allowing arbitrary regexes for block patterns) and modified the C# definition by changing some colours and adding a pattern to match method/constructor calls.

To use this version of the library, you need to create your own `Engine` implementation. I have no plans to provide documentation for this.

This package is released under a MIT licence, but beware of the dependency on VectSharp (which is released under LGPLv3)!

The NuGet package for this release is called [Highlight.NoEngine](https://www.nuget.org/packages/Highlight.NoEngine/).