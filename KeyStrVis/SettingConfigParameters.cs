using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace KeyStrVis
{
    internal class SettingConfigParameters
    {
        public class ColorsParameters
        {
            public string Background_1_color { get; set; } = "#6C757D";
            public string Background_2_color { get; set; } = "#DEE2E6";
            public string Foreground_1_Color { get; set; } ="#6C757D";

            public string Foreground_2_Color { get; set; }= "#6C757D";
            public string Icon_color { get; set; } = "#6C757D";
            public string Font_1_color { get; set; } = "#6C757D";
            public string Font_2_color { get; set; } = "#ffff";
        }

        public class OpacityParameters
        {
            public double MainWindow { get; set; }
            public double KeyStrVisualizer { get; set; }
        }

        public class TypographyParamaters
        {
            public string FontFamily { get; set; }
            public int FonstSize { get; set; }
        }

        public class KeyboardParameters
        {
            public string KeyboardType { get; set; }
            public string KeyboardStyle { get; set; }
            public string KeyboardStrokeSound { get; set; }
        }

        public class MouseParameters
        {
            public string MouseStrokeSound { get; set; }
        }

        public class Configuration
        {
            public ColorsParameters ColorsParameters { get; set; }
            public OpacityParameters OpacityParameters { get; set; }
            public TypographyParamaters TypographyParamaters { get; set; }
            public KeyboardParameters KeyboardParameters { get; set; }
            public MouseParameters MouseParameters { get; set; }
        }

        private string jsonFilePath = "SettingConfigParamaters.json";

        public SettingConfigParameters.Configuration LoadConfiguration()
        {
            string json = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<SettingConfigParameters.Configuration>(json);  // read to json and convert to c# objects
        }

        public void UpdateConfiguration(SettingConfigParameters.Configuration config)
        {
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);  // c# convert to json objects and set the format
            File.WriteAllText(jsonFilePath, json); 
        }


    }
}
