# JAMS Scheduler API
JAMS Scheduler has assemblies that can be used for an API.
As an API the assemblies and documentation are somewhat lacking.

This is an official wrapper around their API.

## Jams.Core
Contains `JAMSShr.dll`

## Jams.Api
Wrapper services with interfaces to make interfacing to JAMS somewhat easier.
JAMS conveniently haven't obfuscated their assemblies so use `ILSpy` or similar to deduce how to interact with the entities.
