using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Windows.Threading;

namespace Nano_Windows_Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool isRunning = false;

        private DispatcherTimer timer;
        private int seconds = 0;
        public MainWindow()
        {
            InitializeComponent();

            TrayApp.Inizialize();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if(isRunning)
            {
                return;
            }

            isRunning = true;
            timer.Start();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            if(!isRunning)
            {
                return;
            }
            isRunning = false;
            timer.Stop();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            isRunning = false;
            seconds = 0;
            TimerTextBlock.Text = "00:00:00";
            timer.Stop();
        }



        private void Timer_Tick(object? sender, EventArgs e)
        {
            seconds++;
            TimerTextBlock.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }

        private void MainTimerWindow_Closed(object sender, EventArgs e)
        {
            if(!isRunning)
                Application.Current.Shutdown();


        }
    }
}