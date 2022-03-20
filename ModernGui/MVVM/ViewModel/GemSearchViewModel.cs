using ModernGui.Core;
using GalaSoft.MvvmLight.Messaging;
using ModernGui.Helpers;

namespace ModernGui.MVVM.ViewModel
{
    class GemSearchViewModel
    {
        private string xmlStr;
        public GemSearchViewModel()
        {
            Messenger.Default.Register<FilePathMessage>(this,
                msg =>
                {
                    xmlStr = msg.FileName;
                });
        }
    }
}
