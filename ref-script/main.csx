#load "insult.csx"
using System.Collections.Generic;

IList<Insult> insults = new List<Insult>();

var i1 = new Insult("Every enemy I have met, I've annihilated!");
i1.ComeBack = "With your breath, I'm sure they all suffocated.";
insults.Add(i1);

var i2 = new Insult("You're as repulsive as a monkey in a negligee!");
i2.ComeBack = "I look that much like your fiancée?";
insults.Add(i2);

var i3 = new Insult("Killing you would be justifiable homicide!");
i3.ComeBack = "Then killing you must be justifiable fungicide.";
insults.Add(i3);

foreach (Insult i in insults) {
  Console.WriteLine(i.ToString());
}