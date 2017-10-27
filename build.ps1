param(
    [string]$packageVersion = $null,
    [string]$configuration = "Release"
)

. ".\common.ps1"

$solutionName = "Jams.Api"
$sourceUrl = "https://github.com/neutmute/jams.api"

function init {
    # Initialization
    $global:rootFolder = Split-Path -parent $script:MyInvocation.MyCommand.Path
    $global:rootFolder = Join-Path $rootFolder .
    $global:outputFolder = Join-Path $rootFolder _artifacts

    
    # Read App
    if(!(Test-Path Env:\PackageVersion )){
        $env:PackageVersion = $env:APPVEYOR_BUILD_VERSION
    }
    
    # Default when no env vars
    if(!(Test-Path Env:\PackageVersion )){
        $env:PackageVersion = "1.0.0.0"
    }
    
    _WriteOut -ForegroundColor $ColorScheme.Banner "-= $solutionName Build =-"
    _WriteConfig "rootFolder" $rootFolder
    _WriteConfig "version" $env:PackageVersion
}

function restorePackages{
    _WriteOut -ForegroundColor $ColorScheme.Banner "dotnet restore"
    
    dotnet restore
}

function nugetPack{
    _WriteOut -ForegroundColor $ColorScheme.Banner "Nuget pack"
    
    New-Item -Force -ItemType directory -Path $outputFolder  | Out-Null
    Remove-Item $outputFolder\*.nupkg -Force # so teamcity builds don't accumulate artifacts

    dotnet pack --include-symbols .\src\Jams.Api -o $outputFolder /p:PackageVersion=$env:PackageVersion
}


function buildSolution{

    _WriteOut -ForegroundColor $ColorScheme.Banner "Build Solution"
    
    & dotnet build /p:AssemblyVersion=$env:PackageVersion /p:FileVersion=$env:PackageVersion
}

function executeTests{

    Write-Host "Execute Tests"

    & dotnet test .\test\Jams.Api.Tests\Jams.Api.Tests.csproj
		        
	checkExitCode
}

init
restorePackages
buildSolution
#executeTests
nugetPack
#nugetPublish

Write-Host "Build $env:PackageVersion complete"