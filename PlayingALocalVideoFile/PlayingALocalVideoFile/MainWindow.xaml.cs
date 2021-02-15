using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

namespace PlayingALocalVideoFile
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


        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (txtMediaPathTextBox.Text.Length <= 0)

            {

                MessageBox.Show("Enter a valid media file");

                return;

            }

            VideoControl.Source = new System.Uri(txtMediaPathTextBox.Text);

            VideoControl.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            VideoControl.Pause();
        }

        public class uri : System.Runtime.Serialization.ISerializable
        {
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            VideoControl.Stop();
        }

        private void btnBrowseClick_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();

            openDlg.InitialDirectory = @"c:\";

            openDlg.ShowDialog();

            txtMediaPathTextBox.Text = openDlg.FileName;
        }
    }
}
