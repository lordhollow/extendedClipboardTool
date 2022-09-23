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

        private List<IClipboardTool> tools;

        public ClipboardExtender()
        {
            tools = new List<IClipboardTool>
            {
                new SampleNormalTool { Enable = true },
                new SampleContinuousTool { Enable = true }
            };

            foreach(var tool in tools)
            {
                tool.Prepare();
            }
        }

        public IEnumerable<IClipboardTool> Tools { get { return tools; } }

    }
}
