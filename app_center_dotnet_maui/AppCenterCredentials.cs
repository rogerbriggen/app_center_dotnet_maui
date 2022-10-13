namespace app_center_dotnet_maui;

internal static class AppCenterCredentials
{
    public static string GetAppCenterCredentials()
    {
        return "android=ADD_YOUR_CREDS_HERE;" +
                "windowsdesktop=ADD_YOUR_CREDS_HERE;" +
                "ios=ADD_YOUR_CREDS_HERE;" +
                "macos={Your macOS App secret here};";
    }
}
