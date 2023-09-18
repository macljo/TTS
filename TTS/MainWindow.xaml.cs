using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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

namespace TTS
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

        public void OnClick1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(userInput.Text, "What you entered", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.Yes);
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToWaveFile("output.wav");
            //synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak(userInput.Text);
        }
    }
}
