using KSMVVM.WPF;
using SampleApplication.Models;
using SampleApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleApplication
{
    /// <summary>
    /// Interaction logic for FormPage.xaml
    /// </summary>
    public partial class FormPage : Page
    {
        private FormViewModel _viewModel;

        public FormPage(InventoryItem model)
        {
            InitializeComponent();
            _viewModel = new FormViewModel(model, new PageNavigationService(this));
            DataContext = _viewModel;
        }
    }
}
