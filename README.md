# ScriptCS Lightning Talk

[ScriptCS project page](http://scriptcs.net/)
[ScriptCS on github](https://github.com/scriptcs/scriptcs)

## Installation

1. run powershell as admin
2. install chocolatey
3. install scriptcs chocolatey package

## Getting help

1. run `$ scriptcs -help`

## ScriptCS REPL

1. run `$ scriptcs` or `$ scriptcs -repl`

Scripts run in a "roslyn" scripting session.

`Console.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod());`

## Basic script

c.f. /basic/httpd.csx

### Passing args to a script

Pass args to a script during invocation, in order, after a double-hyphen.

e.g.: `foo.csx -- bar baz bin`

c.f. /args/args.csx

### Referencing other scripts

1. include `#load` directives at the top of your script

c.f. /ref-script/main.csx

### Referencing assemblies

1. include `#r` directives at the top of your script

c.f. /ref-assembly/random.csx

### Referencing nuget packages

1. install the package with scriptcs: `$ scriptcs -install [package]`
2. OR specify a particlar package version: `$ scriptcs -install [package] -packageversion [version]`
3. nuget packages are implicitly referenced (just add "using" statements)

c.f. /nuget/main.csx

## Installing script packs

List of available script packs: https://github.com/scriptcs/scriptcs/wiki/Script-Packs-master-list

Script packs implement a standard interface that allows them to be imported with `Require<>`.

1. install the script pack: `$ scriptcs -install [script-package]`
2. import the script pack with `Require<TScriptPack>()`

c.f. /script-packs/zippo.csx