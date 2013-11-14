using KSMVVM.WPF;
using KSMVVM.WPF.ViewModel;
using SampleApplication.Models;
using System.Globalization;
using System.Windows;
using System.Windows.Input;

namespace SampleApplication.ViewModels
{
    public sealed class FormViewModel : ViewModelBase
    {
        public FormViewModel(InventoryItem model, IAppNavigationService nav)
        {
            Model = model;
            _nav = nav;

            Submit = new BasicCommand(
                //Execute
                () =>
                {
                    string boxMessage = string.Format(CultureInfo.InvariantCulture,
                        "Data submitted:\n{0} - {1}",
                        Model.Name,
                        Model.Amount);

                    MessageBox.Show(boxMessage);
                    _nav.GoBack();
                });
        }

        public ICommand Submit { get; private set; }

        public InventoryItem Model { get; private set; }

        private IAppNavigationService _nav;
    }
}