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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Fortnait_Kanone
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PlayClip("wwwroots\\Fortnite 2026.11.13 - 00.36.57.19.Eliminierung.DVR.mp4");
        }

        private void PlayFirstClip(object sender, RoutedEventArgs e)
        {
            PlayClip("wwwroots\\Fortnite 2026.11.13 - 00.36.57.19.Eliminierung.DVR.mp4");
        }

        private void PlaySecondClip(object sender, RoutedEventArgs e)
        {
            PlayClip("wwwroots\\Fortnite 2026.11.13 - 00.37.28.20.Eliminierung.DVR.mp4");
        }

        private void ResumeVideo(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Play();
        }

        private void PauseVideo(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Pause();
        }

        private void PlayClip(string relativePath)
        {
            string videoPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            VideoPlayer.Stop();
            VideoPlayer.Source = new Uri(videoPath, UriKind.Absolute);
            VideoPlayer.Play();
        }
    }
}
