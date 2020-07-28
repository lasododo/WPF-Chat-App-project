using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Controls;

namespace PrismCalculatorFollowingTutorialProject.ViewModels
{
    public class ShellViewModel : ViewModuleBase
    {
        public ShellViewModel()
        { 

        }

        public string Title { get; } = "Cool Calculator";
    }
}
