using System.Windows;
using Rosemary.Exercise.Wpf.ViewModel;

namespace Rosemary.Exercise.Wpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel MainWindowVm { get; set; }=new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
