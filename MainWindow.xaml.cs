using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Messagebox1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int MAX_TIME = 5;
        static private int time = MAX_TIME;
        static DispatcherTimer timer = new DispatcherTimer();
        static MessageBoxes messageConnect = new MessageBoxes();
        EventHandler handler = new EventHandler(Timer_Tick);
        public MainWindow()
        {
            InitializeComponent();
        }
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {

        }
        private void ConnectClick(object sender, RoutedEventArgs e)
        {
            messageConnect = new MessageBoxes();
            messageConnect.Owner = this;
            messageConnect.Show();
            messageConnect.Title = "Подключение к стенду";
            if (timer.IsEnabled)
            {
                timer.Stop();
                timer = new DispatcherTimer();
            }
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(Timer_Tick);
            time = MAX_TIME + 1;
            Timer_Tick(null, null);
            timer.Start();
        }
        static void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                messageConnect.messageLabel.Text = "Идет подключение...\nОсталось " + time + " секунд.\nОтменить?";
            }
            else
            {
                timer.Stop();
                messageConnect.Close();
            }
        }
        private void DisconnectClick(object sender, RoutedEventArgs e)
        {
            MessageBoxes messageDisconnect = new MessageBoxes();
            messageDisconnect.Owner = this;
            messageDisconnect.Show();
            messageDisconnect.Title = "Отключение от стенда";
            messageDisconnect.messageLabel.Text = "Идет отключение.\nОтменить?";
            //while (time > 0)
            //{
            //    MessageBox.Show("Идет подключение!\nПодождите!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            //}
        }
        private void StartScanClick(object sender, RoutedEventArgs e)
        {
            MessageBoxes messageStartScan = new MessageBoxes();
            messageStartScan.Owner = this;
            messageStartScan.Show();
            messageStartScan.Title = "Сканирование";
            messageStartScan.messageLabel.Text = "Идет сканирование.\nОтменить?";
        }
        private void StartCentrClick(object sender, RoutedEventArgs e)
        {
            MessageBoxes messageStartCentr = new MessageBoxes();
            messageStartCentr.Owner = this;
            messageStartCentr.Show();
            messageStartCentr.Title = "Центрирование";
            messageStartCentr.messageLabel.Text = "Идет центрирование.\nОтменить?";
        }
    }
}
