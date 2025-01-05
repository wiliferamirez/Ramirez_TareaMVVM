namespace Ramirez_TareaMVVM
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.WRNotePage), typeof(Views.WRNotePage));
        }
    }
}
