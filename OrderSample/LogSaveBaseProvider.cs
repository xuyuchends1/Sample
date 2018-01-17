using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public abstract class LogSaveBaseProvider : ILogSaveProvider
    {
        public bool SaveLog(LogEntity logEntity)
        {
            if (!this.IsSaveLogWithConfiguration(logEntity))
                return false;
            if (!this.ValidatorLogEntity(logEntity))
                return false;
            this.FormatLogContect(logEntity);
            return this.DoSaveLog(logEntity);
        }
        /// <summary>
        /// log是否是配置文件中需要保存的类型
        /// </summary>
        /// <param name="logEntity"></param>
        /// <returns></returns>
        protected virtual bool IsSaveLogWithConfiguration(LogEntity logEntity)
        {
            string logType = ConfigurationManager.AppSettings["LogType"];
            if (logEntity.Type.Equals(logType))
                return true;
            return false;
        }

        /// <summary>
        /// 验证log是否有效
        /// </summary>
        /// <param name="logEntity"></param>
        /// <returns></returns>
        protected virtual bool ValidatorLogEntity(LogEntity logEntity)
        {
            if (logEntity == null || logEntity.Content == null)
                return false;
            return true;
        }

        /// <summary>
        /// 格式化log实体中的信息内容
        /// </summary>
        /// <param name="logEntity"></param>
        protected virtual void FormatLogContect(LogEntity logEntity)
        {
            // 提供程序可以根据自己的需要对日志进行格式化
        }

        /// <summary>
        /// 最终的保存方法
        /// </summary>
        /// <param name="logEntity"></param>
        /// <returns></returns>
        protected abstract bool DoSaveLog(LogEntity logEntity);
    }
}
