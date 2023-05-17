The purpose of this repository is to compare testing of the same Electron application using Selenium and Appium automation tools.

An Electron application is a desktop app created using web technologies, rendered using the Chromium browser engine, and using the Node.js backend runtime environment (e.g. Slack, VS Code).


To run Appium tests follow next steps:
1. Codex test application from the root folder is unzipped
2. Latest release of WinAppDriver is downloaded and installed from https://github.com/microsoft/WinAppDriver/releases/tag/v1.2.1
3. Developer mode is enabled in Settings -> Developer settings -> Developer mode  
4. Paths to Codex.exe and WinAppDriver.exe are added to the corresponding fields in the appsettings.json file


To find selectors for windows desktop applications inspect.exe can be used:
1. Windows 10 SDK is installed via Visual Studio Installer
2. App can be found at "C:\Program Files (x86)\Windows Kits\10\bin\\\<version>\x64\inspect.exe"


For more info: 
https://appium.io/docs/en/drivers/windows/


To run Selenium tests you only need to add path to the Codex.exe file in the appsettings.json file.

To work with gherkin feature files, install the Specflow for Visual Studio 2022 extension.