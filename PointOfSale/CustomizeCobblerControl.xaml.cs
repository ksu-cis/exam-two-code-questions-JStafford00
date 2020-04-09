using System;
using System.Collections.Generic;
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
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Radio button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RadioButtonClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Cobbler cobbler)
            {
                if(sender is RadioButton button)
                {
                    switch(button.Tag)
                    {
                        case "BlueBerry":
                            cobbler.Fruit = FruitFilling.Blueberry;
                            break;
                        case "Cherry":
                            cobbler.Fruit = FruitFilling.Cherry;
                            break;
                        case "Peach":
                            cobbler.Fruit = FruitFilling.Peach;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }
    }
}
