using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public interface ILogSaveProvider
    {
        bool SaveLog(LogEntity logEntity);
    }
}
