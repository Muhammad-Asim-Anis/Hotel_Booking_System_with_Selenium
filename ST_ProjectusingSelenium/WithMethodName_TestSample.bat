@ECHO OFF
ECHO Demo Automation Executed Started.

set summaryPath=C:\Users\hp2022\source\repos\ST_ProjectusingSelenium\TestSummaryReport\

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"

VSTest.Console.exe C:\Users\hp2022\source\repos\ST_ProjectusingSelenium\ST_ProjectusingSelenium\bin\Debug\ST_ProjectusingSelenium.dll /Tests:Loginwithvaildcredentials_001 /Logger:"trx;LogFileName=C:\Users\hp2022\source\repos\ST_ProjectusingSelenium\TestSummaryReport\ir001.trx"

cd C:\Users\hp2022\source\repos\ST_ProjectusingSelenium\ST_ProjectusingSelenium\bin\Debug\

TrxToHTML.exe %summaryPath%

PAUSE

