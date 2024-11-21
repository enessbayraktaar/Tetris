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

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {

        private MediaPlayer mediaPlayer;
       
        public MainMenu()
        {
            InitializeMusic();
        }

        private void InitializeMusic()
        {
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri("Tetris/03.Promise of the Forgotten.wav", UriKind.Relative));
            mediaPlayer.Volume = 1.0; 
            mediaPlayer.MediaEnded += (s, e) => mediaPlayer.Position = TimeSpan.Zero;
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        public void Score_Click (object sender, RoutedEventArgs e)
        {

        }

        public void Exit_Click (object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
