# app_center_dotnet_maui

Shows the problems with appcenter with dotnet maui

## Usage
Start on Windows as packaged app
press the "Click me" button -> the app crashes

Restart the app so the app center reports are sent

As long as OnCounterClicked in MainPage.xaml.cs is async, nothing is sent to app center.
If you remove the async part, it is sent to appcenter, but no callstack is available.
