using Android.App;
using Android.Runtime;

namespace Ramirez_TareaMVVM
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => WRMauiProgram.CreateMauiApp();
    }
}
