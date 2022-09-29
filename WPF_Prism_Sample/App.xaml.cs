using Prism.Ioc;
using System.Windows;
using WPF_Prism_Sample.ViewModels;
using WPF_Prism_Sample.Views;

namespace WPF_Prism_Sample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SampleWindow, SampleWindowViewModel>();
        }
    }
}
