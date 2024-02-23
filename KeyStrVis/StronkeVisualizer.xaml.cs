using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KeyStrVis
{
    /// <summary>
    /// Interaction logic for StronkeVisualizer.xaml
    /// </summary>
    public partial class StronkeVisualizer : Window
    {
        public StronkeVisualizer()
        {
            InitializeComponent();
        }

        static private bool IsDragging = false;
        static private Point StartPoint;

        private void backToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }


        private void KSV_Move_ClickDown(object sender, MouseButtonEventArgs e)
        {
            IsDragging = true;
            StartPoint = e.GetPosition(this);
        }

        private void KSV_Move_ClickUp(object sender, MouseButtonEventArgs e)
        {
            IsDragging= false;
        }

        private void KSV_Move(object sender, MouseEventArgs e)
        {

            if (IsDragging)
            {
                Point MousePosition = e.GetPosition(this);
                double offsetX = MousePosition.X - StartPoint.X;
                double offsetY = MousePosition.Y - StartPoint.Y;

                Left += offsetX;
                Top += offsetY;

            }

        }

        private void Push_KeyDown(object sender, KeyEventArgs e)
        {
            string KeyStronke = GetKey(e.Key);
            KSV_textBlock.Text = KeyStronke +" " + e.Key.ToString() ;
        }

        // tr 
        private string GetKey(Key key)
        {
            switch(key){
                case Key.OemQuotes: return "Ö"; 
                case Key.Oem6: return "Ü"; 
               // case Key.Oem7: return "Ğ"; 
                case Key.Oem1: return "Ş"; 
                case Key.OemComma: return "Ç"; 
                case Key.OemPeriod: return "İ"; 
                default:
                    return key.ToString();

            }
        }
    }
}
