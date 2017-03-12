using Sequencer.Models;
using System.Collections.ObjectModel;
using System;

namespace Sequencer.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ModeManager _modeManager;

        private int _currentScale;
        private ModeViewModel _currentMode;
        private int _tempo;
        private ObservableCollection<ModeViewModel> _modes;

        public MainViewModel(ModeManager modeManager)
        {
            _modeManager = modeManager;

            _currentScale = 0;
            _currentMode = null;
            _tempo = 120;
            _modes = new ObservableCollection<ModeViewModel>();

            BuildModes();
        }

        private void BuildModes()
        {
            foreach(var mode in _modeManager.Modes)
            {
                var modeViewModel = new ModeViewModel(mode);
                _modes.Add(modeViewModel);
            }

            _currentMode = _modes[0];
        }

        public int CurrentScale
        {
            get { return _currentScale; }
            set
            {
                SetProperty(ref _currentScale, value);
            }
        }

        public ModeViewModel CurrentMode
        {
            get { return _currentMode; }
            set
            {
                SetProperty(ref _currentMode, value);
            }
        }

        public int Tempo
        {
            get { return _tempo; }
            set
            {
                SetProperty(ref _tempo, value);
            }
        }

        public ObservableCollection<ModeViewModel> Modes => _modes;
    }
}
