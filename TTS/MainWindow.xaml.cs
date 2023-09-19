using System;
using System.Speech.Synthesis;
using System.Windows;
using System.Windows.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;

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
            
            if (FileLocationBox.Text != "")
            {
                var synthesizer = new SpeechSynthesizer();
                synthesizer.SetOutputToWaveFile(FileLocationBox.Text);
                synthesizer.Speak(userInput.Text);
                synthesizer.SetOutputToNull();    
            }
            else
            {
                MessageBox.Show("Please select a file to save.", "No File Selected", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FileLocationBtn_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog folderPicker = new CommonOpenFileDialog();
            folderPicker.IsFolderPicker = false;
            folderPicker.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (folderPicker.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FileLocationBox.Text = folderPicker.FileName;
            };

            
        }
    }
}
