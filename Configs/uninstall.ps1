Stop-Service -Name "TDNSService" -PassThru
sc.exe delete "TDNSService"