using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace extendedClipboardTools
{
    /// <summary>
    /// Clipboard Tool Trigger Panel
    /// </summary>
    public partial class CustomTriggerButton : UserControl
    {
        /// <summary>
        /// regex for create options from name
        /// </summary>
        static Regex regexOpts = new Regex(@"\$");

        public CustomTriggerButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// attached clipboard tool
        /// </summary>
        public IClipboardTool Tool { get; private set; }

        /// <summary>
        /// attach clipboard tool to this
        /// </summary>
        /// <param name="tool"></param>
        public void Attach(IClipboardTool tool)
        {
            Tool = null;    //for skip checked_changed event
            Control visible = null;
            if (tool.Continuous)
            {
                visible = chkContAct;
                btnAct.Visible = false;
                chkContAct.Checked = false;
            }
            else
            {
                visible = btnAct;
                chkContAct.Visible = false;
            }
            visible.Visible = true;

            //check option
            if (regexOpts.IsMatch(tool.Name))
            {
                var opts = regexOpts.Split(tool.Name);
                visible.Text = opts[0];
                cmbOption.Items.AddRange(opts.Skip(1).ToArray());
                cmbOption.SelectedIndex = 0;

                cmbOption.Visible = true;
                visible.Width = this.ClientSize.Width - cmbOption.Width - 4;
            }
            else
            {
                visible.Text = tool.Name;
                cmbOption.Visible = false;
                visible.Width = this.ClientSize.Width;
            }

            Tool = tool;
        }

        /// <summary>
        /// action for non-continuous tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOption_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// action for continuous tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkContAct_CheckedChanged(object sender, EventArgs e)
        {
        }

    }
}
