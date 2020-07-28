using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismCalculatorFollowingTutorialProject
{
    public static class IoCContainer
    {
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        public static ApplicationViewModel Application => Get<ApplicationViewModel>();

        public static void Setup()
        {
            BindViewMoels();
        }

        public static void BindViewMoels()
        {
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
