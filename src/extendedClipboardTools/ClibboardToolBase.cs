using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace extendedClipboardTools
{
    /// <summary>
    /// common base class of clipboard tool
    /// </summary>
    /// <remarks>
    /// this class has 1 of Regex(regex) and 1 of object(value).
    /// </remarks>
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

        /// <summary>
        /// Regex object syntax suger for subclass
        /// </summary>
        protected Regex regex;

        /// <summary>
        /// Variant object syntax suger for subclass
        /// </summary>
        protected object value;

        /// <summary>
        /// get clipboard string (if data is not text, return null)
        /// </summary>
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

        /// <summary>
        /// Syntax suger for Environment.NewLine
        /// </summary>
        protected string NL { get { return Environment.NewLine; } }


        /// <summary>
        /// Write value.ToString() to clipboard as text
        /// </summary>
        protected void Write()
        {
            Clipboard.SetText(value.ToString());
        }

        /// <summary>
        /// write s to clipboard as text
        /// </summary>
        /// <param name="s"></param>
        protected void Write(string s)
        {
            Clipboard.SetText(s);
        }
    }
}
