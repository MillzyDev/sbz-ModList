using System;
using QModLogger = QModManager.Utility.Logger;

namespace ModList
{

    /// <summary>
    /// This is a wrapper around QMod's logger because I dont like the level param
    /// </summary>
    public class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

        private Logger() {}

        public static Logger Instance
        {
            get => _instance.Value;
        }

        public static void LogDebug(string msg = null, Exception ex = null, bool showOnScreen = false)
            => QModLogger.Log(QModLogger.Level.Debug, msg, ex, showOnScreen);

        public static void LogInfo(string msg = null, Exception ex = null, bool showOnScreen = false)
            => QModLogger.Log(QModLogger.Level.Debug, msg, ex, showOnScreen);

        public static void LogWarn(string msg = null, Exception ex = null, bool showOnScreen = false)
            => QModLogger.Log(QModLogger.Level.Debug, msg, ex, showOnScreen);

        public static void LogError(string msg = null, Exception ex = null, bool showOnScreen = false)
            => QModLogger.Log(QModLogger.Level.Debug, msg, ex, showOnScreen);

        public static void Logatal(string msg = null, Exception ex = null, bool showOnScreen = false)
            => QModLogger.Log(QModLogger.Level.Debug, msg, ex, showOnScreen);
    }
}