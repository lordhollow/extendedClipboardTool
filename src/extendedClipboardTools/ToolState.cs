using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendedClipboardTools
{
    /// <summary>
    /// State of clipboard tool.
    /// </summary>
    public enum ToolState
    {
        /// <summary>
        /// tool is enable
        /// </summary>
        Enable,

        /// <summary>
        /// tool is disable
        /// </summary>
        Disable,


        /// <summary>
        /// tool can not load
        /// </summary>
        Error,
    }
}
