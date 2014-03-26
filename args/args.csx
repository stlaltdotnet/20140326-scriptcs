Int32 i = 0;
Int32 length = Env.ScriptArgs.Count;
while (i < length) {
  Console.WriteLine("Argument {0}: {1}", i, Env.ScriptArgs[i]);
  i++;
}