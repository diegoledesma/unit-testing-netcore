# Unit Testing Workshop

## Install instructions

### Windows
Install Visual Studio Community 2017
https://visualstudio.microsoft.com/downloads/
<br/>Be sure to select the "Web Development" option in the "Workloads" section.


### macOS
Install Visual Studio for Mac or Visual Studio Code
https://visualstudio.microsoft.com/downloads/
https://code.visualstudio.com/

Install ASP.Net Core framework v2.1
https://dotnet.microsoft.com/download/dotnet-core/2.1


## Running projects

### API
Run as a regular project from Visual Studio. Will startup on localhost:5000
From console run `dotnet run -p netcore/AlbumsAPI/AlbumsAPI.csproj`

### UnitTests
Run as a regular project from Visual Studio.
From console run `dotnet test -v n netcore/UnitTests/UnitTests.csproj`

