# ScriptCS Lightning Talk

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

### Referencing other scripts

1. include `#load` directives at the top of your script

### Referencing assemblies

1. include `#r` directives at the top of your script

## Installing nuget packages

1. install the package with scriptcs: `$ scriptcs -install [package]`
2. specify a particlar package version: `$ scriptcs -install [package] -packageversion [version]`

## Installing script packs

List of available script packs: https://github.com/scriptcs/scriptcs/wiki/Script-Packs-master-list

Script packs implement a standard interface that allows them to be imported with `Require<>`.

1. install the script pack: `$ scriptcs -install [script-package]`
2. import the script pack with `Require<TScriptPack>()`

c.f. /script-packs/zippo.csx