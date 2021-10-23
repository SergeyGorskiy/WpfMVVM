using System.Windows;
using WpfMVVM.ViewModels;

namespace WpfMVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindowViewModel ViewModel { get; set; } = new MainWindowViewModel();
    }
}
