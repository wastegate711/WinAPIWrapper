using Prism.Commands;
using Prism.Mvvm;
using WinApi.User32;

namespace TestWinApi_003.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel()
        {

        }

        private DelegateCommand _setCursor;
        public DelegateCommand SetCursor =>
            _setCursor ?? (_setCursor = new DelegateCommand(ExecuteSetCursor));

        void ExecuteSetCursor()
        {
            User32.SetCursorPos(11, 11);
        }
    }
}
