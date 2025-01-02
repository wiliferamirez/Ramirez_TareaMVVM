using Foundation;

namespace Ramirez_TareaMVVM
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => WRMauiProgram.CreateMauiApp();
    }
}
