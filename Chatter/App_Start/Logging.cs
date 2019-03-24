using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace Chatter.App_Start
{
    public interface ILoggging
    {
        void Error(Exception ex);
        void Info(string message);
    }


    class Logging : ILoggging
    {
        private readonly ILog Log = LogManager.GetLogger(nameof(Logging));
        public void Error(Exception ex)
        {
            Log.Error(ex);
        }

        public void Info(string message)
        {
            Log.Info(message);
        }
    }
}