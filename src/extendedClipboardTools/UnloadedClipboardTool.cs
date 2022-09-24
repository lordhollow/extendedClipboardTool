using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendedClipboardTools
{
    /// <summary>
    /// subclass of clipboard tool. use this if tool is not loaded.
    /// </summary>
    class UnloadedClipboardTool : ClipboardTool
    {
        /// <summary>
        /// false: disabled, true: can't load
        /// </summary>
        public bool Error { get; set; }
    }
}
