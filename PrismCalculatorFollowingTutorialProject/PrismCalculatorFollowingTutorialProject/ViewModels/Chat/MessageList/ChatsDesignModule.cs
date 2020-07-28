
using System.Collections.Generic;

namespace PrismCalculatorFollowingTutorialProject
{

    // just for deisgner ... does nothing in production
    public class ChatsDesignModule : ChatsViewModel
    {

        // { get { return new ChatMessageDesignModule(); } }
        public static ChatsDesignModule Instance => new ChatsDesignModule();

        #region Constructor
        public ChatsDesignModule()
        {
            Items = new List<ChatMessagesViewModel>
            {
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow",
                    IsSelected = true
                },




                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "LK",
                    Name = "Luke",
                    Message = "I am really huge text, m8 ... is can your app not break on this message ?",
                    ProfilePicColorRGB = "#0c6991"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "YM",
                    Name = "Yoloman",
                    Message = "Goes Yolo every day?",
                    ProfilePicColorRGB = "green"
                },
                new ChatMessagesViewModel
                {
                    TwoLetters = "RK",
                    Name = "Radek",
                    Message = "Dummy text here ?",
                    ProfilePicColorRGB = "yellow"
                },
            };
        }

        #endregion
    }
}
