<Query Kind="Program">
  <NuGetReference>MiSe.Shuffle</NuGetReference>
  <Namespace>System</Namespace>
  <Namespace>System.Linq</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>MiSe.Shuffle.Extensions</Namespace>
</Query>

void Main()
{
    var rng = new Random(Seed: 5);
    var a = new List<int> { 1, 2, 3, 4, 5, 6 };
    rng.Shuffle(a);
    a.Dump();
}
