using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Sequencer
{
    /// <summary>
    /// Interaction logic for PianoRollControl.xaml
    /// </summary>
    public partial class PianoRollControl : UserControl
    {
        private const int LeftMargin = 10;
        private const int TopMargin = 10;
        private const int LineHeight = 14;
        private const int CellWidth = 24;

        public PianoRollControl()
        {
            InitializeComponent();

            BuildGrid();
        }

        private void BuildGrid()
        {
            for (int y = 0; y < 35; y++)
            {
                var line = new Line() { X1 = LeftMargin, Y1 = TopMargin + y * LineHeight, X2 = 1000, Y2 = TopMargin + y * LineHeight, Stroke = Brushes.LightGray };
                PianoRollCanvas.Children.Add(line);
            }

            for (int x = 0; x < 32; x++)
            {
                var line = new Line() { X1 = LeftMargin + x * CellWidth, X2 = LeftMargin + x * CellWidth, Y1 = TopMargin, Y2 = TopMargin + 36 * LineHeight, Stroke = Brushes.LightGray };
                PianoRollCanvas.Children.Add(line);
            }
        }
    }
}
