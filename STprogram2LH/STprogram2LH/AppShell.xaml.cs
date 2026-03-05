namespace STprogram2LH
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewPage2), typeof(NewPage2));
            Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}
