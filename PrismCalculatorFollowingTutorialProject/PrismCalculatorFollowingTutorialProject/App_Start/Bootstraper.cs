using System;
using System.Collections.Generic;
using System.Text;
using Prism.Unity;
using Microsoft.Practices.Unity;
using System.Windows;
using Unity;

namespace PrismCalculatorFollowingTutorialProject.App_Start
{
    public class Bootstraper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
