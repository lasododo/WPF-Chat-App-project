using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrismCalculatorFollowingTutorialProject
{
    /// <summary>
    /// Interaction logic for MessageSender.xaml
    /// </summary>
    public partial class MessageSender : UserControl
    {
        public MessageSender()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // TextBoxer.Text
            if (TupleDataClass.OMightyDict.TryGetValue(TupleDataClass.CurrentlySelected.ID, out var x))
            {
                x.Add(new ThreadItemViewModel
                {
                    SendersName = "ME",
                    TwoLetters = "ME",
                    ProfilePicColorRGB = "green",
                    Message = TextBoxer.Text,
                    SentByMe = true
                });
                TupleDataClass.OMightyDict[TupleDataClass.CurrentlySelected.ID] = x;
            }
            else
                MessageBox.Show("Oh no");
            TupleDataClass.Refresher();
        }
    }
}
