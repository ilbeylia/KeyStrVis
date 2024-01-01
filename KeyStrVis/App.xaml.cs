using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.IO;

namespace KeyStrVis
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            LoadColors();
        }

        private void LoadColors()
        {

            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ColorConfig.json");
            string json = File.ReadAllText(jsonFilePath);

            var colorConfig = JsonConvert.DeserializeObject<ColorConfig>(json);

            if (colorConfig != null && colorConfig.colors != null)
            {
                Current.Resources["backgroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorConfig.colors.backgroundColor));
                Current.Resources["foregroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorConfig.colors.foregroundColor));
                Current.Resources["titlegroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorConfig.colors.titleColor));
            }

        }
    }
}