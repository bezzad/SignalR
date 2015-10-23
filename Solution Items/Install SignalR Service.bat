cd /d %~dp0

"..\Bin\SignalR Library\SignalRServer\SignalRServer.exe" /i

netsh http add urlacl http://127.0.0.1:50023/ user=EveryOne    

pause