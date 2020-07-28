using System;
using System.Collections.Generic;
using System.Text;

namespace PrismCalculatorFollowingTutorialProject
{
    public class ViewModelLocator
    {
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();
        public static ApplicationViewModel ApplicationViewModel => IoCContainer.Get<ApplicationViewModel>();
    }
}
