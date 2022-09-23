using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendedClipboardTools
{
    public interface IClipboardTool
    {
        string Name { get;  }

        string Description { get; }

        bool Continuous { get; }

        bool Enable { get; set; }

        void Prepare();

        bool Checker(string opt);

        void Action(string opt);

        void FinishAction(string opt);
    }
}
