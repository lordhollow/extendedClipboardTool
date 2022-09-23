using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace extendedClipboardTools
{
    public static class PathExtension
    {
        public static string ApplicationPath { get { return Application.StartupPath; } }

        public static string ApplicationPathFile(string name)
        {
            return Path.Combine(Application.StartupPath, name);
        }

        public static string ApplicationPathFile(string rel, string name)
        {
            return Path.Combine(Application.StartupPath, rel, name);
        }
    }
}
