using log4net;
using log4net.Config;
using System.Reflection;

ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
BasicConfigurator.Configure();

log.Info("this is a log message");
log.Debug("another log message");
log.Warn("Oh noes, a warning!");
log.Error("Ack! An error!");