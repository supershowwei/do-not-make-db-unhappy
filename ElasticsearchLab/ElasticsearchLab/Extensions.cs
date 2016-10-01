using System;
using System.Windows.Forms;

namespace ElasticsearchLab
{
    internal static class Extensions
    {
        public static void SafeInvoke(this Control me, Action action)
        {
            if (me.InvokeRequired)
            {
                me.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}