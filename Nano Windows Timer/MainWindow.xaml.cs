using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace Nano_Windows_Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void PlusTimerButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void StartOrPauseButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SecondsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            PartOfTimer partOfTimer = new PartOfTimer(PartOfTimer.TimerPart.Seconds);
        }

        private void MinutesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            PartOfTimer partOfTimer = new PartOfTimer(PartOfTimer.TimerPart.Minutes);
        }

        private void HoursTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            PartOfTimer partOfTimer = new PartOfTimer(PartOfTimer.TimerPart.Hours);
        }
    }
}