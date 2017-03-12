using System.Collections.Generic;

namespace Sequencer.Models
{
    public class ModeManager
    {
        private List<Mode> _modes;

        public ModeManager()
        {
            _modes = new List<Mode>();

            AddMode(new Mode { Name = "Major " });
            AddMode(new Mode { Name = "Minor" });
        }

        public List<Mode> Modes => _modes;

        public void AddMode(Mode mode)
        {
            _modes.Add(mode);
        }

        public void RemoveMode(Mode mode)
        {
            _modes.Remove(mode);
        }
    }
}
