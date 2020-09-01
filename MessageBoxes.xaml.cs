using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Messagebox1
{
    public partial class MessageBoxes : Window
    {
        public MessageBoxes()
        {
            InitializeComponent();
        }
        //public enum MessageImage
        //{
        //    information = MessageBoxImage.Information,
        //    warning = MessageBoxImage.Warning,
        //    error = MessageBoxImage.Error,
        //    question = MessageBoxImage.Question,
        //    none = MessageBoxImage.None
        //}
        private void ButtonYesClick(object sender, RoutedEventArgs e)
        {
            Close();
            //DispatcherTimer timer = new DispatcherTimer();

        }
        private void ButtonNoClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
