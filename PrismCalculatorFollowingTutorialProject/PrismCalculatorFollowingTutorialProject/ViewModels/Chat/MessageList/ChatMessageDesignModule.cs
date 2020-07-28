
namespace PrismCalculatorFollowingTutorialProject
{

    // just for deisgner ... does nothing in production
    public class ChatMessageDesignModule : ChatMessagesViewModel
    {

        // { get { return new ChatMessageDesignModule(); } }
        public static ChatMessageDesignModule Instance => new ChatMessageDesignModule();

        #region Constructor
        public ChatMessageDesignModule()
        {
            TwoLetters = "LK";
            Name = "Luke";
            Message = "I am really huge text, m8 ... is can your app not break on this message ?";
            ProfilePicColorRGB = "#0c6991";
        }

        #endregion
    }
}
