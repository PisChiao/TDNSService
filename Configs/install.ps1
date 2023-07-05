## New-Service -Name "TDNSService" -BinaryPathName (Get-Location).Path+"TDNSService.exe"
$path = (Split-Path -Parent $psISE.CurrentFile.FullPath)+"\TDNSService.exe"
New-Service -Name "TDNSService" -BinaryPathName $path
Start-Service TDNSService