using Prism.Mvvm;
using Prism.Regions;

namespace WPF_Prism_Sample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "WPF_Prism_Sample";
        private readonly IRegionManager _regionManager;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            this._regionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.SampleWindow));
        }
    }
}
