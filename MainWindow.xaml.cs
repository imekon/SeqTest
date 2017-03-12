using Sequencer.Models;
using Sequencer.ViewModels;
using System.Windows;

namespace Sequencer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ModeManager _modeManager;
        private MainViewModel _mainViewModel;

        public MainWindow()
        {
            InitializeComponent();

            _modeManager = new ModeManager();
            _mainViewModel = new MainViewModel(_modeManager);

            DataContext = _mainViewModel;
        }
    }
}
