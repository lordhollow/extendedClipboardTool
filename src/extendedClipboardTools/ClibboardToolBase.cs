using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace extendedClipboardTools
{
    public abstract class ClipboardTool : IClipboardTool
    {
        #region IClipboardTool
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public bool Continuous { get; protected set; }
        public bool Enable { get; set; }
        public virtual void Prepare() { }
        public virtual bool Checker(string opt) { return false; }
        public virtual void Action(string opt) { }
        public virtual void FinishAction(string opt) { }
        #endregion

        protected Regex regex;

        protected object value;

        protected string StringData
        {
            get
            {
                if (Clipboard.ContainsText())
                {
                    return Clipboard.GetText();
                }
                return null;
            }
        }

        protected string NL { get { return Environment.NewLine; } }

        protected void Write(string s)
        {
            Clipboard.SetText(s);
        }
    }

    public class SampleNormalTool : ClipboardTool
    {
        public SampleNormalTool()
        {
            Name = "StripQuote";
            Description = "get quoted string list without quote.";
            Continuous = false;
        }

        public override void Prepare()
        {
            regex = new Regex(@"""([^""]+)""");
        }

        public override bool Checker(string opt)
        {
            var s = StringData;
            var ret = false;
            if (!string.IsNullOrEmpty(s))
            {
                value = "";
                foreach(Match m in regex.Matches(s))
                {
                    value += m.Groups[1].ToString() + NL;
                    ret = true;
                }
            }
            return ret;
        }

        public override void Action(string opt)
        {
            Write(value as string);
        }
    }

    public class SampleContinuousTool : ClipboardTool
    {
        public SampleContinuousTool()
        {
            Name = "ConcatStrings$NewLine$Tab";
            Description = "Concatenate with linebreak or tab";
            Continuous = true;
        }

        public override bool Checker(string opt)
        {
            return !string.IsNullOrEmpty(StringData);
        }

        public override void Action(string opt)
        {
            if (value == null)
            {
                value = StringData;
            }
            else
            {
                string sep = "";
                if (opt == "NewLine")
                {
                    sep = Environment.NewLine;
                }
                else if (opt == "Tab")
                {
                    sep = "\t";
                }
                value += sep + StringData;
            }
        }

        public override void FinishAction(string opt)
        {
            Write(value as string);
            value = null;
        }
    }

}
