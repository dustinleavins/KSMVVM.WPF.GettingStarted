using SampleApplication.Models;
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
        private InventoryItem _model;

        public FormPage(InventoryItem model)
        {
            InitializeComponent();
            _model = model;
            DataContext = _model;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string boxMessage = string.Format(CultureInfo.InvariantCulture,
                "Data submitted:\n{0} - {1}",
                _model.Name,
                _model.Amount);

            MessageBox.Show(boxMessage);

            NavigationService.GoBack();
        }
    }
}
