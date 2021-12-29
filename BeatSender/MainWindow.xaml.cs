using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BeatSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>p
    public partial class MainWindow : Window
    {
        public static Frame MainFrameInstance;

        public string mails = "";
        public string selecteddFile = "";
        public string[] files;
        public string[] result;
        List<string> list = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            MainFrameInstance = MainFrame;
            MainFrame.Navigate(new LoginPage());
        }

       
    }
}
