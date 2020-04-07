chcp 65001
cls
@echo off
set ConfigFolderName=Conf\
set RootFolderPath=C:\EfemSystem\Source\
set ConfigFolderPath="%RootFolderPath%\%ConfigFolderName%"
set CurrentFolderPath=%~dp0

REM  Add Registration and add RootFolder value
reg ADD HKLM\Software\EfemSystem /v RootFolder /t REG_SZ /d %RootFolderPath% /f 	

if '%errorlevel%' NEQ '0' (
	echo PLEASE: Run as administrator.
	pause
	exit
)

REM  Delete config folder if it is exist and create new folder
if exist %ConfigFolderPath% (
	rmdir /S /Q %ConfigFolderPath%
)
mkdir %ConfigFolderPath%
echo.
echo Config folder created successfully.

REM  Copy config file from temp folder to Efem config folder
for %%a in ("%CurrentFolderPath%*.xml") do (
	xcopy  "%%a" %ConfigFolderPath% >nul
)

echo.
echo Config file created successfully.
echo.

pause