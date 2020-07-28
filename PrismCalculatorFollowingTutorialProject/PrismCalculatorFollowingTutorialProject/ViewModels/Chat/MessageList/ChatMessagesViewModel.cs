using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace PrismCalculatorFollowingTutorialProject
{
    public class ChatMessagesViewModel : ViewModuleBase
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ChatMessagesViewModel TagMyself;

        public string Message { get; set; }

        public string TwoLetters { get; set; }

        public string ProfilePicColorRGB { get; set; }

        public bool IsSelected { get; set; }


        public ICommand OpenMessageCommand { get; set; }

        public ChatMessagesViewModel()
        {
            ID = TupleDataClass.ID;
            TupleDataClass.ID += 1;
            OpenMessageCommand = new RelayCommand(OpenMessage);
        }

        public delegate void DataChangedEventHandler(object sender, EventArgs e);

        public event DataChangedEventHandler DataChanged;

        public void OpenMessage()
        {
            TupleDataClass.CurrentlySelectedChanger(this);
            TupleDataClass.Refresher();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
