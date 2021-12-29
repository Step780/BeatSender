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
    /// Логика взаимодействия для Sender.xaml
    /// </summary>
    public partial class Sender : Page
    {
        public string mails = "";
        public string selecteddFile = "";
        public string selecteddFileName = "";
        public string[] files;
        public string[] result;
        List<FileUpload> list = new List<FileUpload>();

        public class FileUpload
        {
            public string Name { get; set; }
            public string FilePath { get; set; }
        }


        public Sender(string mail, string password)
        {
            InitializeComponent();

            mailBox.Text = mail;
            passwordBox.Password = password;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string phrase = File.ReadAllText(openFileDialog.FileName);
                allMails.Text = phrase;
                


            }
        }


        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mails = allMails.Text;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(mailBox.Text, passwordBox.Password);
                smtp.EnableSsl = true;

                string[] words = mails.Split(';');

                foreach (var word in words)
                {

                    MailAddress from = new MailAddress(mailBox.Text, "rxsemary");
                    MailAddress to = new MailAddress(word);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = mailTheme.Text;
                    m.Body = mailText.Text;


                    foreach (var file in list)
                    {
                        m.Attachments.Add(new Attachment(file.FilePath));

                    }

                    smtp.Send(m);

                }
            }
            catch
            {

            }
        }

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                selecteddFile = openFileDialog.FileName;
                selecteddFileName = System.IO.Path.GetFileName(openFileDialog.FileName);

                FileUpload fileUpload = new FileUpload
                {
                    Name = selecteddFileName,
                    FilePath = selecteddFile

                };

                list.Add(fileUpload);
                filesGrid.ItemsSource = null;
                filesGrid.ItemsSource = list;
                selecteddFile = "";
                selecteddFileName = "";
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            FileUpload upload = (FileUpload)filesGrid.SelectedItem;
            list.Remove(upload);
            filesGrid.ItemsSource = null;
            filesGrid.ItemsSource = list;
        }
    }
}
