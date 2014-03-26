using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Randomizer {
  public class RandomCollection : KeyedCollection<String, String> {

    private Random _rand = new Random();
    private ISet<String> _used = new HashSet<String>();

    public RandomCollection() {}

    public Boolean HasMore() {
      return _used.Count < this.Count;
    }

    public String GetRandom() {
      Int32 count = this.Count;

      if (_used.Count == count) {
        throw new Exception("all random values used up!");
      }

      Int32 index = _rand.Next(0, count);
      String result = this[index];
      while (_used.Contains(result)) {
        Console.WriteLine("testing again {0} {1}", index, count);
        index = _rand.Next(0, count - 1);
        result = this[index];
      }
      _used.Add(result);
      return result;
    }

    protected override string GetKeyForItem(String item) {
      return item;
    }
  }
}