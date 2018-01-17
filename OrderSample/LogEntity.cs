using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class LogEntity
    {
        public string  Type { get; set; }
        public string Level { get; set; }
        public LogContent Content { get; set; }
    }

    public class LogType
    {
        public const string Exception = "Error";
        public const string ApplicationTrack = "Track";
    }
    public class LogLevel
    {
        public const string Warning = "Warning";
        public const string Error = "Error";
    }
    public class LogContent
    {
        public string LogTrackInfo { get; set; }
        public string Message { get; set; }
    }
}
