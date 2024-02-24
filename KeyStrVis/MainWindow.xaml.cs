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


        private bool IsDragging = false;
        private Point StartPoint;
        public int Mode_Select_Index;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Setting();
        }



        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }



        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Setting();
        }

        private void WindowMove(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                Point mousePos = e.GetPosition(this);
                double offsetX = mousePos.X - StartPoint.X;
                double offsetY = mousePos.Y - StartPoint.Y;

                Left += offsetX;
                Top += offsetY;

            }

        }

        private void WindowsMoveClickUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                IsDragging = false;
            }
        }

        private void WindowsMoveClickDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                IsDragging = true;
                StartPoint = e.GetPosition(this);
            }

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
    }
}
