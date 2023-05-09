To run tests follow next steps:
1. Codex test application from the root folder is unzipped
2. Latest release of WinAppDriver is downloaded and installed from https://github.com/microsoft/WinAppDriver/releases/tag/v1.2.1
3. Developer mode is enabled in Settings -> Developer settings -> Developer mode  
4. Paths to Codex.exe and WinAppDriver.exe are added to the corresponding fields in the appsetings.json file


To find selectors for windows desktop applications inspect.exe can be used:
1. Windows 10 SDK is installed via Visual Studio Installer
2. App can be found at "C:\Program Files (x86)\Windows Kits\10\bin\<version>\x64\inspect.exe"


To work with gherkin feature files, install the Specflow for Visual Studio 2022 extension.


For more info: 
https://appium.io/docs/en/drivers/windows/