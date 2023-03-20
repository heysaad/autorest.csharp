param(
    [Parameter(Mandatory)]
    [string]$VersionSuffix,

    [string]$NetRepoRoot = "",
    
    [string[]]$ServiceDirectoryFilters = @("*"),
    
    [switch]$ShowSummary
)

$repoRoot = Resolve-Path "$PSScriptRoot/.."

if($NetRepoRoot) {
    $netRepoRoot = Resolve-Path $NetRepoRoot
} else {
    $netRepoRoot = Resolve-Path "$repoRoot/../azure-sdk-for-net"
}

Push-Location $repoRoot

npm install

dotnet pack /p:OfficialBuildId="$(Get-Date -Format 'yyyyMMdd').$VersionSuffix"
| Tee-Object -Variable packOutput

$autorestCSharpVersion = $packOutput | Where-Object { $_ -match 'task\.setvariable variable=AutorestCSharpVersion.*?\](.*)$' } | ForEach-Object { $Matches[1] }

$nugetContent = Get-Content -Path "$netRepoRoot/NuGet.Config" -Raw

if($nugetContent -notcontains " key=`"local`" ") {
    $nugetContent = $nugetContent -replace '(\r?\n *)</packageSources>', "`$1  <add key=`"local`" value=`"$repoRoot\artifacts\packages\Debug`" />`$0"
    Set-Content -Path "$netRepoRoot/NuGet.Config" -Value $nugetContent -NoNewline
}

Push-Location "$repoRoot/src/CADL.Extension/Emitter.Csharp"

$packageJsonContent = Get-Content -Path "./package.json" -Raw

$packageJson = $packageJsonContent | ConvertFrom-Json -Depth 100
$packageJson.version = $autorestCSharpVersion
$packageJson | ConvertTo-Json | Set-Content -Path "./package.json"

npm pack

$packageJsonContent | Set-Content -Path "./package.json" -NoNewline

Pop-Location

.\eng\UpdateAzureSdkForNet.ps1 `
-AutorestCSharpVersion $autorestCSharpVersion `
-CadlEmitterVersion "$repoRoot/src/CADL.Extension/Emitter.Csharp/azure-tools-typespec-csharp-$autorestCSharpVersion".Replace('\', '/') `
-SdkRepoRoot $netRepoRoot `
-ServiceDirectoryFilters $ServiceDirectoryFilters `
-ShowSummary:$ShowSummary

Pop-Location
