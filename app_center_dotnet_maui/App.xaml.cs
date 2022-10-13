using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace app_center_dotnet_maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            SetupMsAppCenter();
        }

        // ReD BROG: 24.04.2022 analytic and macos are given words
        [SuppressMessage("ReSharper", "CommentTypo")]
        protected void SetupMsAppCenter()
        {
            
            //Initialize Visual Studio App Center for analytic and crash dumps
            AppCenter.LogLevel = LogLevel.Verbose;
            Distribute.UpdateTrack = UpdateTrack.Private;   //We currently have only private distribution, so we enable it
#if ANDROID
            Distribute.SetEnabledForDebuggableBuild(false); //Disable the distribute check for Debug since it is annyoing.. only for Android available
#endif
            AppCenter.Start(AppCenterCredentials.GetAppCenterCredentials(),
                typeof(Analytics), typeof(Crashes));
            
        }
    }

    


}