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
using Newtonsoft.Json;
using System.IO;

namespace KeyStrVis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int Mode_Select_Index;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Setting();
            this.Opacity = Properties.Settings.Default.WindowOpacity;

        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }



        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Setting();
        }



        private void MouseButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Mouse();

        }

        private void KeyboardButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Keyboard();
        }


        private void KeyStrokeVis(object sender, RoutedEventArgs e)
        {
            StrokeVisualizer strokeVisualizer = new StrokeVisualizer();
            this.Hide();
            strokeVisualizer.Show();

        }

        private void DragMove_Handler(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) 
            {
                DragMove();
            }
        }

        private void GamePadButton_Click(object sender, RoutedEventArgs e)
        {
            // Burayi ekleme yap 
        }


    }
}
