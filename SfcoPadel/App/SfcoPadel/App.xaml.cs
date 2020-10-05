using System;
using Prism;
using Prism.Ioc;
using SfcoPadel.Data.Courts;
using SfcoPadel.Framework.DataSources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SfcoPadel.UI.Main.Views;
using SfcoPadel.UI.Map.ViewModels;
using SfcoPadel.UI.Map.Views;
using SfcoPadel.UI.ViewModels.Main.ViewModels;
using SfcoPadel.UseCases.Courts;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SfcoPadel
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainTabbedPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //Views
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainTabbedPage, MainTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<CourtsMapPage, CourtsMapPageViewModel>();
            containerRegistry.RegisterForNavigation<CourtDetailsPage, CourtDetailsPageViewModel>();

            //Repositories & Data sources
            containerRegistry.Register<CourtsRepository>();
            containerRegistry.Register<ICourtsSource, InMemoryCourtsSource>();


            //Use cases
            containerRegistry.Register<GetAllCourts>();
        }
    }
}
