using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PrismCalculatorFollowingTutorialProject
{
    /// <summary>
    /// Interaction logic for MessageList.xaml
    /// </summary>
    public partial class MessageList : UserControl
    {
        public MessageList()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] txtList = Directory.GetFiles(TupleDataClass.MessagesDataPath, "*.csv");
            string[] txtList2 = Directory.GetFiles(TupleDataClass.ListDataPath, "*.csv");

            foreach (var x in txtList)
                File.Delete(x);

            foreach (var x in txtList2)
                File.Delete(x);

            foreach (var item in TupleDataClass.OMightyDict.Keys)
            {
                var t = Task.Run(() => OnePersonSaver(item));
                SaveCurrentChatInfo(item);
                t.Wait();
            }

        }

        public bool OnePersonSaver(int item)
        {
            foreach (var content in TupleDataClass.OMightyDict[item])
            {
                using StreamWriter sw = File.AppendText(TupleDataClass.MessagesDataPath + $"{item}.csv");
                if (content.SentByMe)
                    sw.WriteLine($"{content.TwoLetters},{content.SendersName},{content.Message},{content.ProfilePicColorRGB},1");
                else
                    sw.WriteLine($"{content.TwoLetters},{content.SendersName},{content.Message},{content.ProfilePicColorRGB},0");
            }


            return true;
        }

        public void SaveCurrentChatInfo(int currID)
        {
            foreach (var content in TupleDataClass.ChatsAviable)
            {
                if (content.ID == currID)
                {
                    using StreamWriter sw = File.AppendText(TupleDataClass.ListDataPath + $"list.csv");
                    sw.WriteLine($"{content.Name},{content.Message},{content.TwoLetters},{content.ProfilePicColorRGB},{content.ID}.csv");
                }
            }
        }
    }
}
