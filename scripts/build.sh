#!/usr/bin/env bash
dotnet restore
dotnet publish -c release -r ubuntu.16.04-x64
dotnet test /test/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj
dotnet test /test/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj