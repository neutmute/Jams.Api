# Assumes nuget is in path. Execute from a Visual Studio Developer Prompt

Write-Host "-=Build all nuget packagess=-"

$nuspecs = Get-ChildItem -Path "$PSScriptRoot\src\jams.core" -Filter *.nuspec -Recurse

Foreach($nuspec in $nuspecs){
    nuget pack $nuspec.FullName
}

$artifactsFolder = "./.artifacts"

remove-item -path $artifactsFolder -Force -Recurse -ErrorAction SilentlyContinue
New-Item $artifactsFolder -Force -Type Directory | Out-Null
Move-Item *.nupkg $artifactsFolder