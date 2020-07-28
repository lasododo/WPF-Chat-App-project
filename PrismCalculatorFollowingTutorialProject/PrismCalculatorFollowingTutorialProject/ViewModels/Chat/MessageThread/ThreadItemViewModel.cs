using System;
using System.Collections.Generic;
using System.Text;

namespace PrismCalculatorFollowingTutorialProject
{
    public class ThreadItemViewModel : ViewModuleBase
    {
        public string SendersName { get; set; }

        public string Message { get; set; }

        public string TwoLetters { get; set; }

        public string ProfilePicColorRGB { get; set; }

        public bool SentByMe { get; set; }

        public DateTimeOffset TimeWhenWasSent { get; set; }

    }
}
