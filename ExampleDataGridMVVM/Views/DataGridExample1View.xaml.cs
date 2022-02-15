using ExampleDataGridMVVM.ViewModels;
using System.Windows;

namespace ExampleDataGridMVVM.Views
{
    /// <summary>
    /// Interaction logic for DataGridExample1View.xaml
    /// </summary>
    public partial class DataGridExample1View : Window
    {
        public DataGridExample1View()
        {
            InitializeComponent();
            DataContext = new DataGridExample1ViewModel();
        }
    }
}
