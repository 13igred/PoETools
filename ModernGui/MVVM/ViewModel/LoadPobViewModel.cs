using ModernGui.Core;
using System.IO;
using System.Windows.Input;
using ModernGui.Commands;
using GalaSoft.MvvmLight.Messaging;

namespace ModernGui.MVVM.ViewModel
{
    class LoadPobViewModel : ViewModelBase
    {
        public RelayCommand OpenFile { get; set; }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                OnPropertyChanged();
            }
        }

        public string FilePath;


        public LoadPobViewModel()
        {
            

            OpenFile = new RelayCommand(o =>
            {                
                FilePath = openFile("Select a valid .xml file");
                FileName = "File Name: " + Path.GetFileName(FilePath);
                // Send a message to the service bus
                Messenger.Default.Send(new FilePathMessage(FilePath));
            }
            );
        }

        private string openFile(string title)
        {
            Microsoft.Win32.OpenFileDialog fileOpen = new Microsoft.Win32.OpenFileDialog();
            fileOpen.Title = title;
            fileOpen.ShowDialog();
            return fileOpen.FileName;
        }
    }
}
