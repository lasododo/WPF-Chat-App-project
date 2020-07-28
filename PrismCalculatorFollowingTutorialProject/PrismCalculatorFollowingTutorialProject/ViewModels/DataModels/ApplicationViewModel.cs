using System;
using System.Collections.Generic;
using System.Text;

namespace PrismCalculatorFollowingTutorialProject
{
    public class ApplicationViewModel : ViewModuleBase
    {
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Chat;

        public ViewModuleBase CurrentPageModule { get; set; }

        public void GoToPage(ApplicationPage page, ViewModuleBase viewModel = null)
        {
            CurrentPage = page;

            CurrentPageModule = viewModel;

            OnPropertyChanged(nameof(CurrentPage));
        }
    }
}
