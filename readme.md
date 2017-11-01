# JAMS Scheduler API
[![Build status](https://ci.appveyor.com/api/projects/status/0u6fh1vh1ux3mj88/branch/master?svg=true)](https://ci.appveyor.com/project/neutmute/jams-api/branch/master)
![nuget](https://img.shields.io/nuget/v/jams.api.svg)

JAMS Scheduler has assemblies that can be used for an API.
As an API the JAMS assemblies and documentation are somewhat lacking.

This is an unofficial wrapper around their API that provides a more typical API service, implementing interfaces and built to support IoC and unit testing.

## Jams.Core
The real JAMS assembly - `JAMSShr.dll`. Packaged here since JAMS haven't placed it on nuget themselves.

## Jams.Api
Wrapper services with interfaces to make interfacing to JAMS somewhat easier.

JAMS conveniently haven't obfuscated their assemblies so use `ILSpy` or similar to deduce how to interact with the entities.
