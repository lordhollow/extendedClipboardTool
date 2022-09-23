using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendedClipboardTools
{
    /// <summary>
    /// [Singleton]
    /// Extender manager
    /// </summary>
    class ClipboardExtender
    {
        public static readonly ClipboardExtender Instance = new ClipboardExtender();

        public void NotifyClipboardChanged()
        {

        }
    }
}
