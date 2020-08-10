using System.Windows.Input;
using RosemaryThemes.Wpf.BaseClass;

namespace Rosemary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public ICommand TestCommand=> new RelayCommand(DO);

        private void DO(object obj)
        {
            throw new System.NotImplementedException();
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}