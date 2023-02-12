# dotnet-up

[![Build-CSharp](https://github.com/winkingzhang/dotnet-up/actions/workflows/build-csharp.yml/badge.svg)](https://github.com/winkingzhang/dotnet-up/actions/workflows/build-csharp.yml)

dotnet utilities and practices all in one

# Requirements

To build `dotnet-up` you'll a [latest `dotnet` SDK](https://dotnet.microsoft.com/en-us/download) and a well-known IDE like [`Jetbrains Rider`](https://www.jetbrains.com/rider/download/) or [`Visual Studio Code`](https://code.visualstudio.com/) 


# Installation

```bash
$ dotnet tool install dotnet-up --global
```

# Usage

### lint
```bash
$ dotnet up lint init  # To initialize EditorConfig, create .editorconfig into current folder
$ dotnet up lint [options] [<PROJECT | SOLUTION>] # run `dotnet format`
```

### hook
```bash
$ dotnet up hook init # setup basic hooks for current repo

```



