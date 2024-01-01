using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStrVis
{
    public class ColorConfig
    {
        public ColorSet colors { get; set; }
    }

    public class ColorSet
    {
        public string backgroundColor { get; set; }
        public string foregroundColor { get; set; }
        public string titleColor { get; set; }
    }
}