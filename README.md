# Atesh.Metalama

Atesh.Metalama library is a collection of custom made Metalama Aspects (a.k.a Attributes).

# Prerequisites

* **Metalama:** The purpose of Atesh.Metalama library is to add additional features to Metalama by providing new aspects. Metalama is a commercial product which is a modern replacement for PostSharp: https://www.postsharp.net/metalama. \
\
Metalama offers a free license so you can use community aspects such as the ones in Atesh.Metalama free of charge. \
\
From their website: Metalama is a modern Roslyn-based meta-programming framework for C# to reduce boilerplate and architecture erosion by offloading repeating work from humans to machines. [Metalama Documentation](https://www.postsharp.net/metalama/documentation). \
\
Please see Distribution section below for more info.

# Team Members

* Project Lead: Onur "Xtro" Er, Atesh Entertainment Inc. onurer@gmail.com

# Download and Install

You can directly install the library via [NuGet](https://www.nuget.org/packages/Atesh.Metalama).

**OR**

Download it via "manual download" link in [NuGet](https://www.nuget.org/packages/Atesh.Metalama) web page and extract the assembly into your project manually if you don't want to use a NuGet client.

"nupkg" file you downloaded from NuGet web page is a regular zip file. You can change its extension to "zip" and extract it easily.

# Distribution

Atesh.Metalama library references Metalama.Framework library therefore, referencing Atesh.Metalama in your own project will automatically make your project to use the Metalama system.

By using Metalama system in your project, you will be able to implement your own Metalama aspects. If that's what you want, you can keep the package reference in your `.csproj` file unmodified:

```
  <ItemGroup>
    <PackageReference Include="Atesh.Metalama" Version="CHANGE ME" />
  </ItemGroup>
```

If you just want to use the existing aspects from Atesh.Metalama and don't want to implement your own aspects, then you should modify the package reference by adding a PrivateAssets value:

```
<ItemGroup>
    <PackageReference Include="Atesh.Metalama" Version="CHANGE ME" PrivateAssets="all" />
</ItemGroup>
```

You can see the distribution section of [Metalama Documentation](https://doc.metalama.net/deployment/distributing) for more info.

# Contribution

You can easily contribute to the project by just reporting issues to [here](https://bitbucket.org/XtroTheArctic/Atesh.Metalama/issues)

If you want to get involved and actively contribute to the project, you can simply do so by sending pull requests to the project lead via bitbucket.com.

Project page on [Bitbucket](https://bitbucket.org/XtroTheArctic/Atesh.Metalama)

Git Repo URL: git@bitbucket.org:XtroTheArctic/atesh.metalama.git

Please feel free to contact the team members via email at any time.

# The Unlicense

This is free and unencumbered software released into the public domain.

Anyone is free to copy, modify, publish, use, compile, sell, or distribute this software, either in source code form or as a compiled binary, for any purpose, commercial or non-commercial, and by any means.

In jurisdictions that recognize copyright laws, the author or authors of this software dedicate any and all copyright interest in the software to the public domain. We make this dedication for the benefit of the public at large and to the detriment of our heirs and successors. We intend this dedication to be an overt act of relinquishment in perpetuity of all present and future rights to this software under copyright law.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

For more information, please refer to <http://unlicense.org>