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


        List<string> LanguagesChoose = new List<string> {"TR: QWERTY", "EN: QWERTY", "DE: QWERTZ", "FR: AZERTY"};
        public Setting()
        {
            InitializeComponent();

            AddItemsComboBox(LanguagesChoose);


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

        private void LanguagesOptions_Button_Click(object sender, RoutedEventArgs e)
        {
            Change_Visibility("LanguagesOptionsGrid");
        }

        private void AddItemsComboBox(List<string> items)
        {
            foreach (string item in items)
            {
                LanguagesChoose_ComboBox.Items.Add(item);
            }
        }
        private void LanguagesChoose_SelectChange(object sender, SelectionChangedEventArgs e)
        {
            /// burayi kullanicam 
        }

        // ADD process 

        private void TC_Backgroud_1_Color(object sender, TextChangedEventArgs e)
        {
            Setting_Save_Button.IsEnabled = true;
            SettigParametersSave();
        }

        private void SettigParametersSave()
        {

        }

        private void ScrollViewer_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
