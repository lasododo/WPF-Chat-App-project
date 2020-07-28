
using System;
using System.Collections.Generic;

namespace PrismCalculatorFollowingTutorialProject
{

    // just for deisgner ... does nothing in production
    public class ThreadChatAllDesignModel : ThreadChatAllViewModel
    {

        // { get { return new ChatMessageDesignModule(); } }
        public static ThreadChatAllDesignModel Instance => new ThreadChatAllDesignModel();

        #region Constructor
        public ThreadChatAllDesignModel()
        {
            Items = new List<ThreadItemViewModel>
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
        }

        #endregion
    }
}
