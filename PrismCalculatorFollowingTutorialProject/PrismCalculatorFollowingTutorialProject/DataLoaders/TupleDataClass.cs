using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace PrismCalculatorFollowingTutorialProject
{
    public class TupleDataClass : ViewModuleBase
    {
        public static TupleDataClass Instance;

        public static string ListDataPath = Directory.GetCurrentDirectory() + @"\..\..\..\DataFile\ListOfChats\";
        public static string MessagesDataPath = Directory.GetCurrentDirectory() + @"\..\..\..\DataFile\ChatMessages\";

        public static int ID = 1;

        public static ChatMessagesViewModel CurrentlySelected { get; set; }

        public static List<ChatMessagesViewModel> ChatsAviable { get; set; }

        public static List<ThreadItemViewModel> CurrentMessageList { get; set; } = new List<ThreadItemViewModel>()
        {
            new ThreadItemViewModel
                {
                    TwoLetters = "LK",
                    SendersName = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "LK",
                    SendersName = "Luke",
                    Message = "How about pizza ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "JM",
                    SendersName = "James",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "red",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = true
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "LK",
                    SendersName = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
        };

        public static Dictionary<int, List<ThreadItemViewModel>> OMightyDict { get; set; }

        public TupleDataClass()
        {
        }

        public TupleDataClass(string x)
        {
            OMightyDict = new Dictionary<int, List<ThreadItemViewModel>>();
            FileLoader("list.csv");
            // FillOutDict();
        }

        /*
         var first = new ChatMessagesViewModel
            {
                TwoLetters = "LK",
                Name = "Luke",
                Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                ProfilePicColorRGB = "#0c6991"
            };

            // MessageBox.Show(first.ID.ToString());

            var second = new ChatMessagesViewModel
            {
                TwoLetters = "YM",
                Name = "Yoloman",
                Message = "Goes Yolo every day?",
                ProfilePicColorRGB = "green"
            };
            var third = new ChatMessagesViewModel
            {
                TwoLetters = "RK",
                Name = "Radek",
                Message = "Dummy text here ?",
                ProfilePicColorRGB = "yellow",
            };

            var Items = new List<ThreadItemViewModel>
            {
                new ThreadItemViewModel
                {
                    TwoLetters = "LK",
                    SendersName = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "LK",
                    SendersName = "Luke",
                    Message = "How about pizza ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "JM",
                    SendersName = "James",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "red",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = true
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "LK",
                    SendersName = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },

            };

            var Items2 = new List<ThreadItemViewModel>
            {
                new ThreadItemViewModel
                {
                    TwoLetters = "YM",
                    SendersName = "LuUUUUke",
                    Message = "Lets see if I can get the right message ....",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "YM",
                    SendersName = "LuUUUUUke",
                    Message = "How about pizza ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "JM",
                    SendersName = "James",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "red",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = true
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "YM",
                    SendersName = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },

            };

            var Items3 = new List<ThreadItemViewModel>
            {
                new ThreadItemViewModel
                {
                    TwoLetters = "MM",
                    SendersName = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "MM",
                    SendersName = "Luke",
                    Message = "How about pizza ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "MM",
                    SendersName = "James",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "red",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = true
                },
                new ThreadItemViewModel
                {
                    TwoLetters = "MM",
                    SendersName = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991",
                    TimeWhenWasSent = DateTimeOffset.UtcNow,
                    SentByMe = false
                },

            };

            OMightyDict = new Dictionary<int, List<ThreadItemViewModel>>
            {
                {first.ID, Items },
                {second.ID, Items2 },
                {third.ID, Items3 },
            };

            ChatsAviable = new List<ChatMessagesViewModel>
            {
                first,
                second,
                third
            };
         */

        public static void FillOutDict()
        {
            OMightyDict = new Dictionary<int, List<ThreadItemViewModel>>();
            ChatsAviable = new List<ChatMessagesViewModel>();

            try
            {
                CurrentlySelectedChanger(ChatsAviable.First());
            }
            catch (Exception x)
            {
                MessageBox.Show("Could not load the data ... sorry but u broke the app ... now please leave and go to the shame corder ... thx in advance");
                MessageBox.Show(x.ToString());
            }

        }

        public static void CurrentlySelectedChanger(ChatMessagesViewModel next)
        {
            if (CurrentlySelected != null)
                CurrentlySelected.IsSelected = false;
            CurrentlySelected = next;
            CurrentlySelected.IsSelected = true;
            UpdateCurrentMessageList(next);
        }

        public static void UpdateCurrentMessageList(ChatMessagesViewModel next)
        {
            try
            {
                CurrentMessageList = OMightyDict[next.ID];
            }
            catch (Exception X)
            {
                Debug.Fail("WTF ARE U DOIN ?");
            }

        }

        public static void Refresher()
        {
            IoCContainer.Application.GoToPage(ApplicationPage.Chat, new ThreadChatAllViewModel
            {
                Items = CurrentMessageList
            });
        }

        public static void FileLoader(string filepath)
        {
            string line;
            MessageBox.Show(ListDataPath);

            ChatsAviable = new List<ChatMessagesViewModel>();
            using var file = new StreamReader(ListDataPath + filepath);
            while ((line = file.ReadLine()) != null)
            {
                var lister = line.Split(',');
                var obj = new ChatMessagesViewModel
                {
                    Name = lister[0],
                    Message = lister[1],
                    TwoLetters = lister[2],
                    ProfilePicColorRGB = lister[3]
                };
                ChatsAviable.Add(obj);
                OMightyDict[obj.ID] = ThreadReader(lister[4], lister);
            }
            MessageBox.Show(ChatsAviable.Count.ToString());
        }

        public static List<ThreadItemViewModel> ThreadReader(string filepath, string[] lister)
        {
            string line;
            var list = new List<ThreadItemViewModel>();

            using var file2 = new StreamReader(MessagesDataPath + filepath);
            while ((line = file2.ReadLine()) != null)
                list.Add(ThreadReaderOneLine(line.Split(','), lister));

            return list;
        }

        public static ThreadItemViewModel ThreadReaderOneLine(string[] arrayOfSingleMessageParameters, string[] lister)
        {
            return new ThreadItemViewModel
            {
                TwoLetters = lister[2],
                SendersName = lister[0],
                Message = arrayOfSingleMessageParameters[2],
                ProfilePicColorRGB = lister[3],
                TimeWhenWasSent = DateTimeOffset.UtcNow,
                SentByMe = arrayOfSingleMessageParameters[4] == "1",
            };
        }
    }
}
