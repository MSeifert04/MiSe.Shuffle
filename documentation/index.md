# Shuffling ILists and IEnumerables

This package contains methods for shuffling `System.Collections.Generic.IList<T>` and also
for shuffling copies of `System.Collections.Generic.IEnumerable<T>`.

## Getting started

```csharp
using System;
using System.Collections.Generic;
using MiSe.Shuffle;

var rng = new Random(Seed: 5);
var a = new List<int> { 1, 2, 3, 4, 5, 6 };
ShuffleOps.ShuffleInPlace(a, rng);
Console.WriteLine(string.Join(", ", a));
```