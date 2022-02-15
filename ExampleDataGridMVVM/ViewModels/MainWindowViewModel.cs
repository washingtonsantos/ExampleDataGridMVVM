using ExampleDataGridMVVM.Views;
using Prism.Commands;
using Prism.Mvvm;

namespace ExampleDataGridMVVM.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private DelegateCommand dataGridExample1Command;
        public DelegateCommand DataGridExample1Command
            => dataGridExample1Command ?? (dataGridExample1Command = new DelegateCommand(OpenDataGridExample1));

        private void OpenDataGridExample1() =>
            new DataGridExample1View().Show();
    }
}
