param(
    [Parameter(Mandatory)]
    [string]$AutorestCSharpVersion,

    [Parameter(Mandatory)]
    [string]$CadlEmitterVersion,

    [Parameter(Mandatory)]
    [string]$SdkRepoRoot,

    [bool]$UseInternalFeed = $false)

$ErrorActionPreference = 'Stop'

$SdkRepoRoot = Resolve-Path $SdkRepoRoot

Write-Host "Updating Autorest.CSharp($AutorestCSharpVersion) and Cadl Emitter($CadlEmitterVersion) under $SdkRepoRoot"

$PackagesProps = "$SdkRepoRoot\eng\Packages.Data.props"
(Get-Content -Raw $PackagesProps) -replace `
    '<PackageReference Update="Microsoft.Azure.AutoRest.CSharp" Version=".*?" />',
"<PackageReference Update=`"Microsoft.Azure.AutoRest.CSharp`" Version=`"$AutorestCSharpVersion`" PrivateAssets=`"All`" />" | `
    Set-Content $PackagesProps -NoNewline

$CadlEmitterProps = "$SdkRepoRoot\eng\emitter-package.json"
(Get-Content -Raw $CadlEmitterProps) -replace `
    '"@azure-tools/cadl-csharp": ".*?"',
"`"@azure-tools/cadl-csharp`": `"$CadlEmitterVersion`"" | `
    Set-Content $CadlEmitterProps -NoNewline

if ($UseInternalFeed) {
    $nugetConfigPath = "$SdkRepoRoot\NuGet.Config"
    $nuGetConfig = [xml](Get-Content -Path $nugetConfigPath)
    $xmlAdd = $nuGetConfig.configuration.packageSources.LastChild.clone()
    if ($xmlAdd.key -ne "azure-sdk-for-net-private") {
        $xmlAdd.key = "azure-sdk-for-net-private"
        $xmlAdd.value = "https://pkgs.dev.azure.com/azure-sdk/_packaging/azure-sdk-for-net-private/nuget/v3/index.json"
        $nuGetConfig.configuration.packageSources.AppendChild($xmlAdd)
        $nuGetConfig.Save($nugetConfigPath)
        Write-Host "Updating Nuget.Config"
        Write-Host $nuGetConfig
    }

    & (Join-Path $PSScriptRoot 'GenerateInternalNpmrc.ps1') -ContainingFolder $SdkRepoRoot

    $npmrcFile = Resolve-Path (Join-Path $SdkRepoRoot ".npmrc")
    $projectGeneratePath = "$SdkRepoRoot\eng\common\scripts\Cadl-Project-Generate.ps1"
    (Get-Content -Raw $projectGeneratePath) -replace `
    'npm install --no-lock-file',
"Copy-Item -Path $npmrcFile -Destination `".npmrc`" -Force`nnpm install --no-lock-file" | `
    Set-Content $projectGeneratePath -NoNewline
}
