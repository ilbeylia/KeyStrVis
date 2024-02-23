using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace KeyStrVis
{
    /// <summary>
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : Page
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void ColorOptions_Click(object sender, RoutedEventArgs e)
        {
            Change_Visibility("ColorOptionsGrid");
        }

        private void Change_Visibility(String Name)
        {
            UIElement targetElement = FindName(Name) as UIElement;

            if (targetElement != null)
            {
                
                if (targetElement.Visibility == Visibility.Collapsed)
                {
                    targetElement.Visibility = Visibility.Visible;

                }
                else
                {
                    targetElement.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                
                MessageBox.Show($"UIElement '{Name}' not found.");
            }

        }

        private void OpacityOptions_Button_Click(object sender, RoutedEventArgs e)
        {
            Change_Visibility("OpacityOptionsGrid");
        }

        private void Setting_Save(object sender, RoutedEventArgs e)
        {

        }

        private void TypographyOptions_Button_Click(object sender, RoutedEventArgs e)
        {
            Change_Visibility("TypographyOptionsGrid");
        }


        // ADD process 
        private void AlignRight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AlignCenter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AlignLeft_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
