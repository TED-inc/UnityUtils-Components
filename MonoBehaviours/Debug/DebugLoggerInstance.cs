#pragma warning disable 0649 //dissable unnusign warnings
using UnityEngine;
using UnityEngine.UI;

namespace TEDinc.Utils.Components.Debug
{
    public class DebugLoggerInstance : DebugBase, IInitable
    {
        [SerializeField]
        private Text _label;
        public static Text label;

        public void Init()
        {
            label = _label;
            DebugLogger.Init();
        }
    }

    public static class DebugLogger
    {
        private static string prevCondition = "";
        private static string prevStackTrace = "";
        private static LogType prevLogType = LogType.Assert;
        private static string text = "";
        private static bool initilized;


        public static void Init()
        {
            if (!initilized)
                Application.logMessageReceived += LogCallback;
            initilized = true;
        }



        private static void LogCallback(string condition, string stackTrace, LogType type)
        {
            if (condition == prevCondition && type == prevLogType
                && (type == LogType.Log || stackTrace == prevStackTrace))
            {
                if (text.EndsWith("\n") || text.EndsWith("+"))
                    text += "+";
                else
                    text += "\n+";
            }
            else
            {
                if (!text.EndsWith("\n"))
                    text += "\n\n";
                else if (!text.EndsWith("\n\n"))
                    text += "\n";

                prevCondition = condition;
                prevStackTrace = stackTrace;
                prevLogType = type;

                switch (type)
                {
                    case LogType.Error:
                        text += "<color=red>";
                        break;
                    case LogType.Assert:
                        text += "<color=blue>";
                        break;
                    case LogType.Warning:
                        text += "<color=yellow>";
                        break;
                    case LogType.Log:
                        text += "<color=white>";
                        break;
                    case LogType.Exception:
                        text += "<color=brown>";
                        break;
                    default:
                        text += "<color=white>";
                        break;
                }
                text += condition + "</color>";

                if (type != LogType.Log)
                {
                    text += "\n<color=white>";
                    foreach (string item in stackTrace.Split('\n'))
                        text += $"   {item}\n";
                    text += "</color>";
                }
            }

            if (DebugLoggerInstance.label != null)
                DebugLoggerInstance.label.text = text;
        }
    }
}