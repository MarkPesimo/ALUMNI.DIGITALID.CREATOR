using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniDigitalIDTool
{
    public class AlumniConstant
    {
        public static string QRLocation  = ConfigurationManager.AppSettings["QRLocation"];
        public static string IDLocation = ConfigurationManager.AppSettings["IDLocation"];
        public static string ImageLocation = ConfigurationManager.AppSettings["ImageLocation"];
    }
}
