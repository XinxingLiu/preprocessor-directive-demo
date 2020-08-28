This repo is to demo the use of a C# preprocessor directive "HOSTED" to build different binaries out of one code branch.

To run it:
```
dotnet build
dotnet run --no-build
```
There are no output. In the build output folder we don't introduce the lib dependency "MyLib.dll".

If we turn the flag on:

```
dotnet build /p:HostingMode=cloud
dotnet run --no-build
```
We can see the following output. And the dependency lib is included.
```
MyMethod1 called.
```