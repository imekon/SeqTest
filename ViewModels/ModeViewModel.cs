using Sequencer.Models;

namespace Sequencer.ViewModels
{
    public class ModeViewModel : ViewModelBase
    {
        private Mode _mode;

        public ModeViewModel(Mode mode)
        {
            _mode = mode;
        }

        public string Name
        {
            get { return _mode.Name; }
            set
            {
                string name = string.Empty;
                if (SetProperty(ref name, value))
                {
                    _mode.Name = name;
                }
            }
        }

        public override string ToString()
        {
            return _mode.Name;
        }
    }
}
