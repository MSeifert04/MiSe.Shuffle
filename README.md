[![GitHub release](https://img.shields.io/github/release/MSeifert04/MiSe.Shuffle)](https://github.com/MSeifert04/MiSe.Shuffle/releases) [![Nuget](https://img.shields.io/nuget/v/MiSe.Shuffle)](https://www.nuget.org/packages/MiSe.Shuffle/)

# Shuffling ILists and IEnumerables

This package contains methods for shuffling `System.Collections.Generic.IList<T>` and also
for shuffling copies of `System.Collections.Generic.IEnumerable<T>`.

```csharp
using System;
using System.Collections.Generic;
using MiSe.Shuffle;

var rng = new Random(Seed: 5);
var a = new List<int> { 1, 2, 3, 4, 5, 6 };
ShuffleOps.ShuffleInPlace(a, rng);
Console.WriteLine(string.Join(", ", a));
```