ECHO OFF
ECHO DEMO Automation

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"
vsTest.Console.exe C:\Users\hp2022\source\repos\ST_ProjectusingSelenium\ST_ProjectusingSelenium\bin\Debug\ST_ProjectusingSelenium.dll

PAUSE