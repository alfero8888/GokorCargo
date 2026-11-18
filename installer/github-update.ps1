param([string]$Installed, [string]$Current)
$ErrorActionPreference = 'Stop'
$ProgressPreference = 'SilentlyContinue'
try {
  $headers = @{ 'User-Agent' = 'GokorCargo-Setup'; 'Accept' = 'application/vnd.github+json' }
  $rel = Invoke-RestMethod -Uri 'https://api.github.com/repos/alfero8888/GokorCargo/releases/latest' -Headers $headers
  $tag = ([string]$rel.tag_name).Trim().TrimStart('v').TrimStart('V')
  $remote = [version](($tag -split '\.' | Select-Object -First 3) -join '.')
  $local = [version](($Current -split '\.' | Select-Object -First 3) -join '.')
  if ($remote -le $local) { exit 10 }
  $asset = $rel.assets | Where-Object name -eq 'GokorCargo.exe' | Select-Object -First 1
  if (-not $asset) { exit 11 }
  $dest = Join-Path $env:TEMP 'GokorCargo-github.exe'
  Invoke-WebRequest -Uri $asset.browser_download_url -OutFile $dest -Headers @{ 'User-Agent' = 'GokorCargo-Setup' } -UseBasicParsing
  if ((Get-Item -LiteralPath $dest).Length -lt 1000000) { exit 12 }
  Copy-Item -LiteralPath $dest -Destination $Installed -Force
  exit 0
} catch {
  exit 13
}
