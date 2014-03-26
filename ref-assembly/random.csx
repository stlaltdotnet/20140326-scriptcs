#r "Randomizer.dll";
using Randomizer;

RandomCollection randColl = new RandomCollection();
randColl.Add("Nick");
randColl.Add("Tim");
randColl.Add("Brad");

while (randColl.HasMore()) {
  String result = randColl.GetRandom();
  Console.WriteLine("Chose {0}", result);
}

Console.WriteLine("done");