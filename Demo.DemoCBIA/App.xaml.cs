using Microsoft.Maui.ApplicationModel;

namespace Demo.DemoCBIA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Syncfusionkey");
            //Current.RequestedTheme = OSAppTheme.Light;
            MainPage = new AppShell();
        }

    }
}