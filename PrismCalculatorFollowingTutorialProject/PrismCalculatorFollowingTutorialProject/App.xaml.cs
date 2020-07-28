using PrismCalculatorFollowingTutorialProject.App_Start;
using System.Windows;

namespace PrismCalculatorFollowingTutorialProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IoCContainer.Setup();
            TupleDataClass.Instance = new TupleDataClass("plz");

            new Bootstraper().Run();
        }
    }
}
