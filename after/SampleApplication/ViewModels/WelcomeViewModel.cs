using KSMVVM.WPF;
using KSMVVM.WPF.ViewModel;
using SampleApplication.Models;
using System.Windows.Input;

namespace SampleApplication.ViewModels
{
    public sealed class WelcomeViewModel : ViewModelBase
    {
        public WelcomeViewModel(IAppNavigationService nav)
        {
            _nav = nav;

            Submit = new BasicCommand(
                //Execute
                () =>
                {
                    InventoryItem newItem = new InventoryItem()
                    {
                        Name = "Test Item",
                        Amount = 5
                    };

                    _nav.Navigate(() =>
                        new FormPage(newItem));
                });
        }

        public ICommand Submit { get; private set; }
        private IAppNavigationService _nav;
    }
}