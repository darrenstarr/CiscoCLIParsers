# Cisco CLI Parsers

## Introduction

This is a library for parsing the output of Cisco CLI commands on IOS and IOS XE devices.

The library is based almost entirely on [Pegasus by John Gietzen](https://github.com/otac0n/Pegasus)
which is an excellent Packrat style parser generator for C# that I've [ported to .NET Standard 2](https://github.com/darrenstarr/Pegasus).

## Status
Currently, this is a refactoring of an earlier library I wrote [CiscoTerminalServer](https://github.com/darrenstarr/CiscoTerminalServer)
which is to become a dead project. 

Since the purpose of this library is to produce high quality C# data models that serialize cleanly to JSON
and XML, instead of simply employing a hackish technique of running simple regular expressions against
command line output... the quality is limited to the unit tests run against the parser library.

At this time, it is expected that the data model should be considered mildly unstable as there are constantly new
cases being found in the way that IOS devices produce output.

### Call for help

Updated unit tests (via unit test) or simply command line output (via GitHub issues) are very welcome.
As more data is pushed through the library, the higher the quality of the output produced.
