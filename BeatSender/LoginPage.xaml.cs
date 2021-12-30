using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net.Sockets;
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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        //public static bool TestConnection(Configuration config)
        //{
        //    MailSettingsSectionGroup mailSettings = config.GetSectionGroup("system.net/mailSettings") as MailSettingsSectionGroup;
        //    if (mailSettings == null)
        //    {
        //        throw new ConfigurationErrorsException("The system.net/mailSettings configuration section group could not be read.");
        //    }
        //    return TestConnection(mailSettings.Smtp.Network.Host, mailSettings.Smtp.Network.Port);
        //}

        //public static bool TestConnection(string smtpServerAddress, int port)
        //{
        //    IPHostEntry hostEntry = Dns.GetHostEntry(smtpServerAddress);
        //    IPEndPoint endPoint = new IPEndPoint(hostEntry.AddressList[0], port);
        //    using (Socket tcpSocket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
        //    {
        //        //try to connect and test the rsponse for code 220 = success
        //        tcpSocket.Connect(endPoint);
        //        if (!CheckResponse(tcpSocket, 220))
        //        {
        //            return false;
        //        }

        //        // send HELO and test the response for code 250 = proper response
        //        SendData(tcpSocket, string.Format("HELO {0}\r\n", Dns.GetHostName()));
        //        if (!CheckResponse(tcpSocket, 250))
        //        {
        //            return false;
        //        }

        //        // if we got here it's that we can connect to the smtp server
        //        return true;
        //    }
        //}

        //private static void SendData(Socket socket, string data)
        //{
        //    byte[] dataArray = Encoding.ASCII.GetBytes(data);
        //    socket.Send(dataArray, 0, dataArray.Length, SocketFlags.None);
        //}

        //private static bool CheckResponse(Socket socket, int expectedCode)
        //{
        //    while (socket.Available == 0)
        //    {
        //        System.Threading.Thread.Sleep(100);
        //    }
        //    byte[] responseArray = new byte[1024];
        //    socket.Receive(responseArray, 0, socket.Available, SocketFlags.None);
        //    string responseData = Encoding.ASCII.GetString(responseArray);
        //    int responseCode = Convert.ToInt32(responseData.Substring(0, 3));
        //    if (responseCode == expectedCode)
        //    {
        //        return true;
        //    }
        //    return false;
        //}


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(mailBox.Text, passwordBox.Password);
                smtp.EnableSsl = true;
                
                MainWindow.MainFrameInstance.Navigate(new Sender(mailBox.Text, passwordBox.Password));

            }
            catch
            {

            }
        }
    }
}
