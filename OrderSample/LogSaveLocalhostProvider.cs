using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class LogSaveLocalhostProvider : LogSaveBaseProvider
    {
        protected override bool ValidatorLogEntity(LogEntity logEntity)
        {
            if ( base.ValidatorLogEntity(logEntity))
            {
                if (string.IsNullOrEmpty(logEntity.Content.LogTrackInfo))
                    return false;
            }
            return true;
        }

        protected override void FormatLogContect(LogEntity logEntity)
        {
            logEntity.Content.Message = logEntity.Content.Message.Replace("\\", "--");
        }

        protected override bool DoSaveLog(LogEntity logEntity)
        {
            //开始保存
            return true;
        }
    }
}
