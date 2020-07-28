
using System;

namespace PrismCalculatorFollowingTutorialProject
{

    // just for deisgner ... does nothing in production
    public class ThreadItemDesignModel : ThreadItemViewModel
    {

        // { get { return new ChatMessageDesignModule(); } }
        public static ThreadItemDesignModel Instance => new ThreadItemDesignModel();

        #region Constructor
        public ThreadItemDesignModel()
        {
            TwoLetters = "LK";
            SendersName = "Luke";
            Message = "I am really huge text, m8 ... is can your app not break on this message ?";
            ProfilePicColorRGB = "green";
            SentByMe = true;
            TimeWhenWasSent = DateTimeOffset.UtcNow;
        }

        #endregion
    }
}
